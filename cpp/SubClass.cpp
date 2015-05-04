#include "stdafx.h"
#include "SubClass.h"

#include <string>

// Constructors with no parameters are inherited
// automatically.
// Until a constructor with parameters is implemented.
// This is just like in VB.NET and C#
SubClass::SubClass(std::string str) : SuperClass(str)
{

}

SubClass::SubClass() : SuperClass()
{

}