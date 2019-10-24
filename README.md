
# PyTorch 1.0 inference in C++  using Microsoft Visual Studio 2019



## Description

The repository provides an example how to go from an existing Pytorch model to a serialized representation that can be _loaded_ and _executed_ purely from C++ in Windows.

It converts a pretrained fastai/PyTorch model to Torch Script.  
Then, a C++ application loads serialized PyTorch model.
Finally, an image is presented to the model and classification results are displayed.   

Run git clone https://github.com/nesajov/fastai-pytorch-cpp-inference.git in order to clone this repository. 

## Requrements

 - ### libtorch
	  Use pre-built libtorch from ‘ https://pytorch.org/ ’ (ver. 1.2, Windows, LibTorch, C++, cuda-none)

 - ### MS Visual Studio 2019

 - ### OpenCV ver. 3.4.7


## Pretrained Weights

The model is trained in fastai using the [Oxford-IIIT Pet Dataset](http://www.robots.ox.ac.uk/~vgg/data/pets/) by [O. M. Parkhi et al., 2012](http://www.robots.ox.ac.uk/~vgg/publications/2012/parkhi12a/parkhi12a.pdf) which features 12 cat breeds and 25 dogs breeds.

## Jupyter Notebook

The repository contains a Jupyter notebook (fastai-to-torch-script.ipynb) to export a fastai/pytorch model to torch script file. 
The tracing, a mechanism in which the structure of the model is captured by evaluating it once using example inputs, is used to convert  PyTorch model to Torch Script. 

## Inference

A VisualStudio application loads serialized PyTorch model using the PyTorch C++ API – also known as _LibTorch.
After the model is loaded the OpenCV function is used to load a test image.
In order to perform inference the test image is converted to a normalized float tensor and passed as an input to the model.
The obtained results (a class label and probability) are displayed.

![enter image description here](https://drive.google.com/uc?export=download&id=1WrSXYrw26sOYPbO4WQ6q0DSIcWtlHHpY)
## Contact
Issues should be raised directly in the repository. For additional questions or comments please email Nebojsa Jovanovic at njovanovic.nesa@gmail.com.
