Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim counter As Integer
		For counter = 1 To 7
			'MsgBox("Mindworx") for the user to print mindwor
			ListBox1.Items.Add(counter)
			If counter = 6 Then
				Exit For

			End If
		Next
	End Sub
End Class
