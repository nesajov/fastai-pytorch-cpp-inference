
#pragma once


namespace DogOrCatLib
{
	class CDogOrCat
	{
		std::string _label;
		float _probability;

	public:
		CDogOrCat();
		virtual ~CDogOrCat();
	
	private:
		bool LoadImage(char* file_name, cv::Mat& image);
		void ConvertToFloatImage(cv::Mat& image);
		bool LoadLabels(char* file_name, std::vector<std::string>& labels);

	public:
		std::string& GetLabel()
		{
			return _label;
		}
		float GetProbability()
		{
			return _probability;
		}

		bool Process(IplImage* iplImage);

	};
}
