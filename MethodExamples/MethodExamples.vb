Option Explicit On
Option Strict On
Option Compare Text

Module MethodExamples

    Sub Main()

        AddTwoNumbers() 'Calls subroutine
        SayAMessage()

        Console.Read()
    End Sub

    Sub AddTwoNumbers()
        Dim result As Integer
        result = 2 + 2 'result only exists in the subroutine, outside of it nothing can be done with it
    End Sub

    Sub SayAMessage()
        Console.WriteLine("Howdy!")
    End Sub


End Module
