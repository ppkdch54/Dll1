// Dll1.cpp: 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "dll1.h"
#include <io.h>

int testDll(MyStruct para)
{
	return para.id+para.num;
}

int testIplimage(MyStruct *paraArray, int size)
{
	int sum = 0;
	for (int i = 0; i < size; i++)
	{
		sum += (paraArray[i].id+paraArray[i].num);
	}
	
	return sum;
}