Imports BaseClasses

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim identifier As Integer = 3
        Dim ops = New Operations
        Dim results = ops.FindPersonByIdentifierAsTuple(identifier)

        If Not String.IsNullOrWhiteSpace(results.FirstName) Then
            MessageBox.Show($"{results.FirstName} {results.LastName} for id of {identifier}")
        Else
            MessageBox.Show($"Failed to locate a person with the id of {identifier}")
        End If

    End Sub
    Private Sub cmdGetFirstLastValuesNotFound_Click(sender As Object, e As EventArgs) Handles cmdGetFirstLastValuesNotFound.Click

        Dim identifier As Integer = 10
        Dim ops = New Operations
        Dim results = ops.FindPersonByIdentifierAsTuple(identifier)

        If Not String.IsNullOrWhiteSpace(results.FirstName) Then
            MessageBox.Show($"{results.FirstName} {results.LastName} for id of {identifier}")
        Else
            MessageBox.Show($"Failed to locate a person with the id of {identifier}")
        End If

    End Sub
End Class
