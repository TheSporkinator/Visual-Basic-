Module Module
	Sub Main ()
	
		'Dim numbers(0 to 4) As Integer
		'Dim Numner 4 As Integer

		'Numbers(0) = 4
		'Numbers(1) = 8
		'Numbers(2) = 15
		'Numbers(3) = 16
		'Numbers(4) = 23
		'Numbers(5) = 42

		'Dim numbers() As Integer = {4, 8, 15, 16, 23}


		'Console.WriteLine("The third element of the array contains: " & numbers(2))

		'Console.WriteLine(Iterating through the entire array:")

		'For index = 0 To numbers.Length - 1
			'Console.WriteLine(numbers(index))
		'Next


		'Dim names() As String = {"Bob", "Steve", "Brian", "Chuck"}
		'For Each name As String In names
			'Console.WriteLine(name)
		'Next


		Dim myText As String = "Now is the time for all good men to come to the aid of their country."

		Dim charArray(0 As Char = myText.ToCharArray()

		Array.Reverse(charArray)

		For Each myChar As Char In charArray
			Console.Write(myChar)
		Next



		Console.ReadLine()

	End Sub

End Module
