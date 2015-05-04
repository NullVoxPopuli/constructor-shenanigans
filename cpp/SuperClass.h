#pragma once

#include <string>

class SuperClass
{
public:
  // default constructor
 SuperClass();
 // destructor
 ~SuperClass();
 // sets field
 SuperClass(std::string str);

 // arbitrary field
 std::string field;
};

