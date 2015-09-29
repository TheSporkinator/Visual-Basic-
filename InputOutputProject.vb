Module Module1

    Sub Main()

        Dim userName As String
        Dim userNumber1 As Double  '<---- Double makes it to where the amount of numers that can be displayed is more, so isnted of only 100 being allowed in antything voer 100 can be in
        Dim userNumber2 As Double
        Dim numberTotal As Double

        Console.WriteLine("Hello and Welcome to your first Visual Basic Console Application")
        Console.ReadLine()

        Console.Write("To whom do I have the pleasure of talking with: ")  ' <---- Console.Write lets the text appear in the same line as the commans, so insted of typing below the sentence you type on the same level as it
        'Console.WriteLine displays the line but then goes down to the next one where you then type, if you want to type on teh same level as the text tehn use console.write
        userName = Console.ReadLine()
        Console.ReadLine()

        Console.WriteLine("Hello " + userName + " and welcome to the first VB ap." + vbCrLf)

        Console.WriteLine("Today you will be asked to pick two numbers to be added, subtracted, multiply, and divided")
        Console.ReadLine()

        Console.Write("What is your first number? : ")  '<---- No Console.WriteLine, that makes it dissapear for some reason
        userNumber1 = Console.ReadLine()

        Console.Write("What is your second number? : ")
        userNumber2 = Console.ReadLine()

        Console.WriteLine(vbCrLf)
        Console.WriteLine("Yout first number is: " & userNumber1)

        Console.WriteLine("Yout second number is: " & userNumber2)

        numberTotal = userNumber1 + userNumber2

        Console.WriteLine(vbCrLf)
        Console.WriteLine(userNumber1 & " + " & userNumber2 & " = " & numberTotal)


        numberTotal = userNumber1 - userNumber2

        Console.WriteLine(vbCrLf)
        Console.WriteLine(userNumber1 & " - " & userNumber2 & " = " & numberTotal)


        numberTotal = userNumber1 * userNumber2

        Console.WriteLine(vbCrLf)
        Console.WriteLine(userNumber1 & " * " & userNumber2 & " = " & numberTotal)


        numberTotal = userNumber1 / userNumber2

        Console.WriteLine(vbCrLf)
        Console.WriteLine(userNumber1 & " / " & userNumber2 & " = " & numberTotal)

        Console.ReadLine()
    End Sub

End Module
