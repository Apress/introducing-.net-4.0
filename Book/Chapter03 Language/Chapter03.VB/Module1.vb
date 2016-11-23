Module Module1

    Sub Main()

        'Line continuation
        Dim numbers() As Integer = {1, 2, 3, 4, 5}

        Dim query = From n In numbers
        Select n
        Where n > 5

        'Anon method
        Dim add = Function(x As Integer, y As Integer)
                      Return x + y
                  End Function

        'Collection initialization
        Dim TraitsNotFoundInJobAgents As New List(Of String) From {
        "technical knowledge", "honesty", "a reflection"
        }

    End Sub

    'Nullable optional params
    Public Sub MyFunction(ByVal Val1 As String, Optional ByVal z As Integer? = Nothing)
    End Sub

    'Automatic properties
    Public Class AdvancedTiger
        Property Name() As String
    End Class

End Module
