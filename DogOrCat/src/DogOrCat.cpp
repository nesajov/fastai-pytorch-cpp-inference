// 

#include "DogOrCat.h"

namespace DogOrCat {


	bool DogOrCat::StringDotNetToNative(String^ s, wchar_t** output)
	{
		wchar_t* chars = (wchar_t*)(Marshal::StringToHGlobalUni(s)).ToPointer();
		if (*output != 0)
			delete* output;

		if (!String::IsNullOrEmpty(s))
		{
			int size = s->Length + 1;

			*output = new wchar_t[size];
			memcpy(*output, chars, size * sizeof(wchar_t));
			wchar_t* p = *output;
			p[size - 1] = '\0';
			Marshal::FreeHGlobal(IntPtr((void*)chars));

			return true;
		}
		else
		{
			return false;
		}
	}
	bool DogOrCat::StringDotNetToNative(String^ s, char** output)
	{
		char* chars = (char*)(void*)Marshal::StringToHGlobalAnsi(s);
		if (*output != 0)
			delete* output;

		if (!String::IsNullOrEmpty(s))
		{
			int size = s->Length + 1;

			*output = new char[size];
			memcpy(*output, chars, size * sizeof(char));
			char* p = *output;
			p[size - 1] = '\0';
			Marshal::FreeHGlobal(IntPtr((void*)chars));

			return true;
		}
		else
		{
			return false;
		}
	}



}



