Public Class SubClassWithBothConstructors
  Inherits SuperClassWithDefaultConstructor

  ' 10. appease the compiler
  Sub New()
    MyBase.New()
  End Sub

  Sub New(parameter)
    MyBase.New(parameter)
  End Sub
End Class
