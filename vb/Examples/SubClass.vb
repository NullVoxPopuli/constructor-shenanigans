' 3. When no constructor is defined:
'    Class 'vb.SubClass' must declare a 'Sub New' because its base class 
'    'vb.SuperClass' does not have an accessible 'Sub New' that can be 
'    called with no arguments.
Public Class SubClass : Inherits SuperClass

  ' 3.5 right off the bat, the compiler makes us implement a constructor
  Sub New(parameter)
    MyBase.New(parameter)
  End Sub

End Class
