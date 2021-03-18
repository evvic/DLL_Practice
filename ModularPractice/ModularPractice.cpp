// ModularPractice.cpp : Defines the exported functions for the DLL.
#include "pch.h" // use stdafx.h in Visual Studio 2017 and earlier
#include <utility>
#include <limits.h>
#include "ModularPractice.h"

// you cannot apply __declspec(dllimport) keyword to implement a function
// ONLY in the declaration (header file)

int HelloWorld() {
	return 69;
}