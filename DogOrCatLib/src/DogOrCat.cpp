#include <torch/script.h> // One-stop header.

#include <iostream>
#include <memory> //Better memory management


// headers for opencv
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <opencv2/opencv.hpp>

#include "DogOrCatLib.h"

#define IMAGESIZE 224
#define NUMCHANNELS 3
#define TOPK 3

namespace DogOrCatLib
{
	CDogOrCat::CDogOrCat()
	{
	}
	CDogOrCat::~CDogOrCat()
	{
	}

	bool CDogOrCat::Process(IplImage* iplImage)
	{
		_label = "";
		_probability = 0;

		std::string model_name = "../models/model_traced.pt";		// dog-cat model

		std::ifstream in(model_name, std::ios_base::binary);

		if (in.fail()) 
		{
			std::cout << "failed to open model" << std::endl;
			return false;
		}

		torch::jit::script::Module module = torch::jit::load(in);
		
		// Create a vector of inputs.
		std::vector<torch::jit::IValue> inputs;
		inputs.push_back(torch::ones({ 1, 3, 224, 224 }));

		// Execute the model and turn its output into a tensor.
		at::Tensor output = module.forward(inputs).toTensor();
		
		std::cout << output.slice(/*dim=*/1, /*start=*/0, /*end=*/5) << '\n';

		inputs.pop_back();
	
		// class labels
		std::vector<std::string> labels;
		if (LoadLabels("../models/_dog-cat-classes.txt", labels))
		{
			std::cout << "== Label loaded! Let's try it\n";
		}
		else 
		{
			std::cerr << "Please check your label file path." << std::endl;
			return false;
		}

		cv::Mat image = cv::cvarrToMat(iplImage);
		ConvertToFloatImage(image);

		auto input_tensor = torch::from_blob(image.data, { 1, IMAGESIZE, IMAGESIZE, NUMCHANNELS });
		input_tensor = input_tensor.permute({ 0, 3, 1, 2 });
		input_tensor[0][0] = input_tensor[0][0].sub_(0.485).div_(0.229);
		input_tensor[0][1] = input_tensor[0][1].sub_(0.456).div_(0.224);
		input_tensor[0][2] = input_tensor[0][2].sub_(0.406).div_(0.225);

		torch::Tensor out_tensor = module.forward({ input_tensor }).toTensor();
		auto results = out_tensor.sort(-1, true);
		auto softmaxs = std::get<0>(results)[0].softmax(0);
		auto indexs = std::get<1>(results)[0];

		for (int i = 0; i < TOPK; ++i)
		{
			auto idx = indexs[i].item<int>();
			if (idx < (int)labels.size())
			{
				if (i == 0)
				{
					_label = labels[idx];
					_probability = softmaxs[i].item<float>();
				}
				std::cout << "Top:" << i + 1 << std::endl;
				std::cout << "Label:  " << labels[idx] << std::endl;
				std::cout << "With probability:  " << softmaxs[i].item<float>() * 100.0f << "%" << std::endl;
			}
		}



		return true;
	}

	bool CDogOrCat::LoadImage(char* file_name, cv::Mat& image)
	{
		image = cv::imread(file_name);  // CV_8UC3
		if (image.empty() || !image.data) 
		{
			return false;
		}

		return true;
	}
	void CDogOrCat::ConvertToFloatImage(cv::Mat& image)
	{
		cv::cvtColor(image, image, CV_BGR2RGB);
		std::cout << "== image size: " << image.size() << " ==" << std::endl;

		// scale image to fit
		cv::Size scale(IMAGESIZE, IMAGESIZE);
		cv::resize(image, image, scale);
		std::cout << "== simply resize: " << image.size() << " ==" << std::endl;

		// convert [unsigned int] to [float]
		image.convertTo(image, CV_32FC3, 1.0f / 255.0f);
	}
	bool CDogOrCat::LoadLabels(char* file_name, std::vector<std::string>& labels)
	{
		std::ifstream ifs(file_name);
		if (!ifs) 
		{
			return false;
		}
		std::string line;
		while (std::getline(ifs, line)) 
		{
			labels.push_back(line);
		}
		return true;
	}
}
