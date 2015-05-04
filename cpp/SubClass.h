#pragma once
#include "SuperClass.h"
class SubClass: public SuperClass 
{
public:
  SubClass();
  // destructor
  ~SubClass();

  SubClass(std::string str);
};

