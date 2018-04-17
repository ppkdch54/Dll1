#pragma once

#define MAXResults 50
extern "C"
{
	struct MyStruct
	{
	public:
		int num;
		int id;
	};
	struct StructIplimage
	{
		int id;
	};

	struct AlarmInfo
	{
		int framNo;         //’Ï∫≈
		bool result;
	};

	struct Results {
		int a;
		int b;
	};


	__declspec(dllexport) int testInputStruct(MyStruct para);
	__declspec(dllexport) int testOutPutStructArray(Results *results,int size);

}
