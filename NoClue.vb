Module Module 
	Sub Main

		'Dim myString = String.Format("Make: {0} Module: {1}", "BMW", "745li", 1995)
		'Dim myString = String.Format("{):C}", 23.35)
		'Dim myString = String.Format("{0:N}", 1234567890)
		'Dim myString = String.Format({0:P}", 0.123)
		'Dim myString = String.Format("Phone number: {0:(###) ###-####}", 1234567890)
		
		'Dim myString =""
		'Dim myString As StringBuilder = New StringBuilder
		Dim myString As New StringBuilder


		For i = 1 To 100
			'myString = myString & "--" & CStr(i)
			'myString += "--" & CStr(i)

			Dim myString = "Its better to be lucky than good."

		Next


		Console.WriteLine(myString.ToString())
		Console.ReadLine()

	End Sub

End Module
