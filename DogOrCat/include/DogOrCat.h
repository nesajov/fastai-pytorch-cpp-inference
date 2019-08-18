#pragma once

#using <System.Drawing.dll>

#pragma unmanaged
#include <string.h> // memcpy

#include "DogOrCatLib.h"
#pragma managed

using namespace System;
using namespace System::Drawing;
using namespace System::Runtime::InteropServices;
using namespace System::Drawing;
using namespace System::Drawing::Imaging;

namespace DogOrCat 
{
	using namespace DogOrCatLib;

	public ref class DogOrCat
	{
		CDogOrCat* _dogOrCat;

		String^ _label;
		float _probability;

	public:
		DogOrCat()
		{
			_label = gcnew String("");
			_probability = 0;

			_dogOrCat = new CDogOrCat();
		}
		~DogOrCat()
		{
			delete _dogOrCat;
		}
	protected:

		bool StringDotNetToNative(String^ s, wchar_t** output);
		bool StringDotNetToNative(String^ s, char** output);
	public:

		Bitmap^ Process(Bitmap^ inImage)
		{
			PixelFormat pixelFormat = inImage->PixelFormat;
			if (pixelFormat != PixelFormat::Format24bppRgb)
			{
				return inImage;
			}

			BitmapData^ bmpData = inImage->LockBits(System::Drawing::Rectangle(0, 0, inImage->Width, inImage->Height), ImageLockMode::ReadWrite, inImage->PixelFormat);

			IntPtr data = bmpData->Scan0;		
			int widthStep = (inImage->Width * 3 * 8 + 31) / 32 * 4;

			IplImage* iplImage = new IplImage();

			iplImage->nSize = sizeof(IplImage);				
			iplImage->ID = 0;								
			iplImage->nChannels = 3;			
			iplImage->alphaChannel = 0;						
			iplImage->depth = 8;					 
			iplImage->dataOrder = 0;						
			iplImage->origin = 0;							
			iplImage->align = 4;							
			iplImage->width = inImage->Width;
			iplImage->height = inImage->Height;
			iplImage->roi = NULL;							
			iplImage->maskROI = NULL;						
			iplImage->imageId = "";							
			iplImage->tileInfo = NULL;						
			iplImage->imageSize = widthStep * inImage->Height;
			iplImage->imageData = reinterpret_cast<char*>(data.ToPointer());
			iplImage->widthStep = widthStep;			


			bool status = _dogOrCat->Process(iplImage);
			if (status == true)
			{
				std::string& label = _dogOrCat->GetLabel();
				_label = gcnew String(label.c_str());
				_probability = _dogOrCat->GetProbability();
			}
			else
			{
				_label = gcnew String("");
				_probability = 0;
			}

			delete iplImage;

			inImage->UnlockBits(bmpData);


			return inImage;
		}

		property float Probability
		{
			virtual float get()
			{
				return _probability;
			}
		}
		property String^ Label
		{
			virtual String^ get()
			{
				return _label;
			}
		}

	};
}
