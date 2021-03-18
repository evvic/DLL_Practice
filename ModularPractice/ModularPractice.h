#pragma once

// MODULARPRACTICE_EXPORTS & MODULARPRACTICE_API are predefined macros based on the header file name

#ifdef MODULARPRACTICE_EXPORTS
#define MODULARPRACTICE_API __declspec(dllexport)
#else
#define MODULARPRACTICE_API __declspec(dllimport)
#endif

extern "C" MODULARPRACTICE_API int HelloWorld();