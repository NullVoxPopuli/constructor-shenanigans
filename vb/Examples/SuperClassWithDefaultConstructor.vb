
Public Class SuperClassWithDefaultConstructor


  Public field As Object

  ' 4. Implement a constructor with 0 arguments for the 
  '    SubClass to be happy. Why does the SubClass care
  '    about the SuperClass not having a parameterless 
  '    constructor?
  Sub New()
    field = "default"
  End Sub

  Sub New(field As Object)
    Me.field = field
  End Sub


End Class
