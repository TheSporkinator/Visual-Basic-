Module Module
	Sub Main ()

		'Dim myString = "Go to the folder called 'My Documents' on your c:\ drive ..."

		'Dim myString = "Go to the folder" & _
			'"Called 'My Documents" " & _
			'"on your C"\ " _
			'& "drive."

		'Dim myString = "My ""so aclled"" life"

		'Dim myString = "What if I need" & vbCrLf & "a ner line?"


		Dim myString = String.Format("{0}!", "Hello")
		




		'Console.WriteLine(myString)
		Console.WriteLine("{0}", "Hello")
		Console.ReadLine()


	End Sub

End Module
