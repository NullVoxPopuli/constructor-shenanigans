using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp
{
  // Assume that the SuperClass has two constructors:
  // - one with 0 parameters
  // - one with 1 parameter
  // Both constructors set the 'field' field.
  //
  // At every stage (#), the tests should pass as long as 
  // there isn't a compiler error in one of them.
  // If a test has a compiler error, then it can be commented 
  // out and the other test should pass.
  [TestClass]
  public class CSharpTests
  {
    [TestMethod]
    public void SubClass_Constructor_WithNoParameters()
    {
      // 1. SubClass has 0 constructors: Works
      // 3. Once the constructor is implemented in SubClass,
      //    this no longer works, as SubClass is seen as now
      //    not having any constructors.
      // 4. Add a parameterless constructor.
      //    Now, we have no errors, but we also have two redundant
      //    constructors.
      Examples.SubClass target = new Examples.SubClass();

      Assert.AreEqual("default", target.field);
    }

    [TestMethod]
    public void SubClass_Constructor_WithParameters()
    {
      // 1. SubClass has 0 constructors: Does not work
      //    without explicitly defining a constructor, the compiler tells us
      //    that SubClass doesn't have a constructor that takes 1 argument
      // 2. Add a constructor to SubClass that takes one parameter
      Examples.SubClass target = new Examples.SubClass("value");

      Assert.AreEqual("value", target.field);
    }
  }
}
