// Dll1.cpp: 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "dll1.h"

int testDll(MyStruct para)
{
	return para.id+para.num;
}
