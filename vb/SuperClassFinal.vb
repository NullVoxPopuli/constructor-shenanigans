' 1. A standard super class that has a constructor.
'    It is intuitive to think that if a sub class inherits 
'    from this super class, that the constructors would also
'    be inherited.
Public Class SuperClassFinal

  Public field As Object

  ' 4. Implement a constructor with 0 arguments for the 
  '    sub class to be happy. Without this, the sub class
  '    doesn't know how to make an instance of itself without
  '    any parameters. This is fine, but obnoxious that once
  '    we use a parameter constructor in the subclass, 
  '    that this is no longer inherited.
  Sub New()
    field = "default"
  End Sub

  ' 2. A constructor with a parameter is created, this is
  '    what we want our sub class to inherit. 
  Sub New(field As Object)
    Me.field = field
  End Sub
End Class
