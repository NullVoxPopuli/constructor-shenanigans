Public Class SubClassWithParameterConstructor
  Inherits SuperClassWithDefaultConstructor

  ' 7. Define a constructor that takes a parameter, and call the 
  '    superclass' corresponding constructor.
  '    This is less work than having to copy the whole constructor,
  '    but if there are a lot of different kinds of subclasses, 
  '    this gets cumbersome.
  Sub New(p1 As String)
    MyBase.New(p1)
  End Sub

End Class
