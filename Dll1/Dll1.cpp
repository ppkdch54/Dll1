// Dll1.cpp: 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "dll1.h"
#include <iostream>

int testInputStruct(MyStruct para)
{
	return para.id+para.num;
}

int testOutPutStructArray(Results *results,int size)
{
	results[0].a = 123;
	results[0].b = 234;
	return 0;
}
