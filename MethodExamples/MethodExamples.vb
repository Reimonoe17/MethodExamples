Option Explicit On
Option Strict On
Option Compare Text

Module MethodExamples

    Sub Main()

        'AddTwoNumbers() 'Calls subroutine
        'SayAMessage()
        'For index = 0 To 10
        '    RandomInteger()
        'Next
        'For index = 1 To 10
        '    Console.WriteLine(RandomNumber())
        'Next

        Console.WriteLine(SumResult(7, 7))

        Console.Read()
    End Sub

    Sub AddTwoNumbers()
        Dim result As Integer
        result = 2 + 2 'result only exists in the subroutine, outside of it nothing can be done with it
    End Sub

    Function SumResult(ByVal firstNumber As Integer, ByVal secondNumber As Integer) As Integer
        Dim result As Integer
        result = firstNumber + secondNumber
        Return result
    End Function

    Sub SayAMessage()
        Console.WriteLine("Howdy!")
    End Sub

    Sub RandomInteger()
        Randomize(DateTime.Now.Millisecond)
        Dim theRandomNumber As Single

        theRandomNumber = CInt(Rnd() * 100)

        Console.WriteLine(theRandomNumber)
    End Sub

    Function RandomNumber() As Integer
        Randomize()
        Return CInt(Rnd() * 15)
    End Function

End Module
