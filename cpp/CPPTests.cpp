#include "stdafx.h"
#include "CppUnitTest.h"
#include "SubClass.h"
#include "SuperClass.h"


using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace cpp
{		
	TEST_CLASS(CPPTests)
	{
	public:
		
    TEST_METHOD(SuperClass_Constructor_SetsDefault)
    {
      SuperClass *target = new SuperClass();
      std::string expected = "default";

      Assert::AreEqual(expected, target->field);
    }


    TEST_METHOD(SuperClass_Constructor_SetsField)
    {
      std::string expected = "value";
      SuperClass *target = new SuperClass(expected);

      Assert::AreEqual(expected, target->field);
    }

		TEST_METHOD(SubClass_Constructor_SetsDefault)
		{
      SubClass *target = new SubClass();
      std::string expected = "default";

      Assert::AreEqual(expected, target->field);
		}

    TEST_METHOD(SubClass_Constructor_SetsField)
    {
      std::string expected = "value";
      SubClass *target = new SubClass(expected);

      Assert::AreEqual(expected, target->field);
    }

	};
}