' 1. A standard SuperClass that has a constructor.
'    It is intuitive to think that if a subclass inherits 
'    from this SuperClass, that the constructors would also
'    be inherited.
Public Class SuperClass

  Public field As Object

  ' 2. A constructor with a parameter is created, this is
  '    what we want our SubClass to inherit. 
  Sub New(field As Object)
    Me.field = field
  End Sub


End Class
