Module Module

	Sub Main()

		Console.WriteLine("Please type something and press Enter")
		Dim userValue As String
		Dim message = ""

		userValue - Console.ReadLine()
		Console.WriteLine("You typed: " & userValue)
		Console.ReadLine()

		Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?")

		Dim userValue As String = Console.ReadLine()

		If userValue = "1" Then
		message = ""You won a new car!""

		Elself userValue = "2" Then
			message = ""you won a new boat!""
		
		Elself userValue = "3" Then
			message = ""You won a cat!""

		Else
			message = ""Sorry, we did not understand your response, You lose!"

		End If

		
		Console.WriteLine(message)
		Console.ReadLine()

	End Sub

End Module
