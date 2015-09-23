Module Module
	Sub Main()

		Call displayTheMessage()

		'displayTheMessage()

		'Dim myValue As String = syperSecretFormula()
		'Dim myValue As String = superSecretFormula("bob")
		'Console.WriteLine(myValue)

		Console.WriteLine(superSecretFormula())
		Console.WriteLine(superSecretFormula("Bob"))


		Console.ReadLine()		
	End Sub

	'Sub displayTheMessage()
			'Console.WriteLine("From displayTheMessage")


	'End Sub

	Function superSecretFormula() As String
		Return "Hello World!"
	End Function

	Function superSecretFormula(ByVal name As String) As String
		Return String.Format("Hello World, {0}", name)
	End Function
	

	Console.ReadLine()
End Sub

End Module
