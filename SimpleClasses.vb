Module Module1

    Sub Main()

        'Dim myNewCar As Car = New Car()
        Dim myNewCar As New Car
        'Dim myOtherCar As Car = myNewCar

        'Dim myOtherCar As New Car("Bmw", 2005, 30000)

        Carlot.AddToInvintory(myNewCar)

        myNewCar.Make = "Oldsmobile"
        myNewCar.Modle = "Cutlas Supreme"
        myNewCar.Year = 1986
        myNewCar.Color = "Silver"

        'With myNewCar
        '.Make = "Olds"
        '.Modle = "Cutlas"
        '.Year = 1986
        '.Color = "Silver"
        'End With

        'Console.WriteLine("{0} - {1} - {2}" , myNewCar.Make, myNewCar.Modle, myNewCar.Year, myNewCar.Color.ToString())

        'Console.WriteLine(determineMarketValue(myNewCar))

        Console.WriteLine("Before: " & myNewCar.Make)
        doByValue(myNewCar)
        Console.WriteLine("After by Value: " & myNewCar.Make)


        doByReferenece(myNewCar)
        Console.WriteLine("After by Reference: " & myNewCar.Make)


        Console.ReadLine()


    End Sub

    'Function determineMarketValue(ByVal myCar As Car) As Double
        'Super secret formula


        'Return 100
    'End Function



    Sub doByValue(ByVal myCar As Car)
        myCar = New Car
        myCar.Make = "Bmw"
    End Sub



    Sub doByReference(ByRef myCar As Car)
        myCar = New Car
        myCar.Make = "Bmw"
    End Sub

End Module

Public Class Car

    Public Make() As String
    Public Modle() As String
    Public Year As Integer
    Public Color As String
    Public Amount As Double
    Public Surcharge As Double



    Public Sub New()

    End Sub

    Public Sub New(ByVal _make As String, ByVal _year As Integer, ByVal amount As Double)
        Me.Make = _make
        Me.Year = _year
        Me.Amount = _amount
        Me.Surcharge = amount * 1.025

    End Sub





    Public Function determinMarketValue() As Double
        'Super Secret Formula

        Return 100.0

    End Function

    Public Sub myMethod(ByVal my Parameter As String)

    End Sub

    Public Sub myMethod(ByVal anotherVersion As String, ByVal myParameter As String)

    End Sub

    Public Sub myMethod(ByVa myParameter As Integer)

    End Sub




End Class


Public Class Carlot

    Public Shared Sub AddtoInventory(ByVal newCar As Car)
        'body of the method goes here.

    End Sub

End Class

    End Sub
End Class
