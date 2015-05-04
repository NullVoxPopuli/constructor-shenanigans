' 3. When no constructor is defined:
'    Class 'vb.SubClassFinal' must declare a 'Sub New' because its base class 
'    'vb.SuperClassFinal' does not have an accessible 'Sub New' that can be 
'    called with no arguments.
Public Class SubClassFinal
  Inherits SuperClassFinal

  ' 5. SuperClassFinal's constructor is not inherited when 
  '    a parameterized constructor is defined. If we had no
  '    constructors defined in the sub class, and the super 
  '    class has a parameterless new, then it is inherited.
  Sub New()
    MyBase.New()
  End Sub

  ' 6. Define a constructor that takes a parameter, and call the 
  '    superclass' corresponding constructor.
  '    This is less work than having to copy the whole constructor,
  '    but if there are a lot of different kinds of subclasses, 
  '    this gets cumbersome.
  Sub New(parameter)
    MyBase.New(parameter)
  End Sub
End Class
