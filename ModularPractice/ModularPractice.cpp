// ModularPractice.cpp : Defines the exported functions for the DLL.
#include "pch.h" // use stdafx.h in Visual Studio 2017 and earlier
#include <utility>
#include <limits.h>
#include "ModularPractice.h"

#include <iostream>

// you cannot apply __declspec(dllimport) keyword to implement a function
// ONLY in the declaration (header file)


void HelloWorld() {
	std::cout << "Hello!\n";
}

int Calculate(int one, int two) {
	return one * two;
}

//The .NET runtime uses unicode (wchar_t) strings, not ascii (char) so this require some changes.
//.NET has no way to free a string that has been allocated by a C/C++
void GetString(char* str, int strlen) {
	std::string result = "this is a c++ string in a .dll";

	result = result.substr(0, strlen);

	std::copy(result.begin(), result.end(), str);
	str[(int)result.size()] = 0;
}

