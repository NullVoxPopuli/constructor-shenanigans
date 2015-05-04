Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()>
Public Class VBTests

  <TestMethod()>
  Public Sub SubClass_New_CallsSuperNew()
    Dim target As SubClass
    target = New SubClass("value")
    Assert.AreEqual("value", target.field)
  End Sub


  <TestMethod()>
  Public Sub SubClass_New_WithoutArgsRaisesException()
    Dim target As SubClassWithNoConstructors
    ' 5. Shows that the parameterless constructor
    '    is inherited. 
    target = New SubClassWithNoConstructors
    Assert.AreEqual("default", target.field)
  End Sub

  <TestMethod()>
  Public Sub SubClass_New_WithArgSetsField()
    Dim target As SubClassWithParameterConstructor


    ' 6. When a sub class doesn't define any constructors, this line
    '    gives a compiler error.
    '    the super class's constructors with parameters are not inherited.
    '
    '    This is apparently 'by design' or some made up cover up for a
    '    design mistake. Copying constructors all over the place is a pain.
    ' 
    '    New SubClassWithNoConstructors("value")


    ' 8. The compiler error goes away when our sub class implements a
    '    constructor, and calls MyBase.new(parameter)
    target = New SubClassWithParameterConstructor("value")
    
    Assert.AreEqual("value", target.field)
  End Sub

  <TestMethod()>
  Public Sub SubClass_New_WithoutArgs_NowErrors()
    Dim target As SubClassWithBothConstructors
    ' 9. Now this gives us a compiler error:
    '    Argument not specified for parameter.
    '    This was previously inherited from SuperClass, but
    '    now that there is a constructor defined in SubClass,
    '    we suddenly need to define all constructors, and 
    '    inheritance isn't a thing anymore.
    '
    '    New SubClassWithParameterConstructor()

    ' 11. All is well, once we have duplicated our constructors
    target = New SubClassWithBothConstructors

    Assert.AreEqual("default", target.field)
  End Sub

  <TestMethod()>
  Public Sub SubClass_New_WithArgs_ShouldStillWork()
    Dim target As SubClassWithBothConstructors

    target = New SubClassWithBothConstructors("value")

    Assert.AreEqual("value", target.field)
  End Sub

  <TestMethod()>
  Public Sub SubClassFinal_HasBothSuperClassConstructors()
    Dim target As SubClassFinal

    target = New SubClassFinal
    Assert.AreEqual("default", target.field)

    target = New SubClassFinal("value")
    Assert.AreEqual("value", target.field)
  End Sub

End Class