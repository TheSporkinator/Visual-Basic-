Module Module

	Sub Main()

		Console.WriteLine("Please type something and press Enter")
		Dim userValue As String

		userValue - Console.ReadLine()
		Console.WriteLine("You typed: " & userValue)
		Console.ReadLine()

		Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?")

		Dim userValue As String = Console.ReadLine()

		If userValue = "1" Then
			Console.WriteLine("You won a new car!")
			Console.ReadLine()
		Elself userValue = "2" Then
			Console.WriteLine("you won a new boat!")
			Console.ReadLine()
		Elself userValue = "3" Then
			Console.WriteLine("You won a cat!")
			Console.ReadLine()
		Else
			Console.WtiteLine("Sorry, we did not understand your response, You lose!"
			Console.ReadLine()
		End If



	End Sub

End Module
