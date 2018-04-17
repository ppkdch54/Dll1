#pragma once
extern "C"
{
	struct MyStruct
	{
	public:
		int num;
		int id;
	};
	__declspec(dllexport) int testDll(MyStruct para);
	__declspec(dllexport) int testIplimage(MyStruct *paraArray,int size);
}
