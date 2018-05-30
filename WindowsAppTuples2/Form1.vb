Imports BaseClasses

Public Class Form1
    Private Sub cmdGetPersonGood_Click(sender As Object, e As EventArgs) Handles cmdGetPersonGood.Click
        ' there is a person with id 3
        Dim identifier As Integer = 3
        Dim ops = New Operations
        Dim results = ops.FindPersonByIdentifierAsPerson(identifier)

        If results Is Nothing Then
            MessageBox.Show($"Failed to locate a person with the id of {identifier}")
        Else
            MessageBox.Show($"{results.FirstName} {results.LastName} for id of " &
                            $"{identifier} Business {results.IsBussinessAccount}" &
                            $"with account id {results.Account.Id}")
        End If
    End Sub

    Private Sub cmdGetPersonBad_Click(sender As Object, e As EventArgs) Handles cmdGetPersonBad.Click
        ' there is no person with id of 10
        Dim identifier As Integer = 10
        Dim ops = New Operations
        Dim results = ops.FindPersonByIdentifierAsPerson(identifier)

        If results Is Nothing Then
            MessageBox.Show($"Failed to locate a person with the id of {identifier}")
        Else
            MessageBox.Show($"{results.FirstName} {results.LastName} for id of " &
                            $"{identifier} Business {results.IsBussinessAccount}" &
                            $"with account id {results.Account.Id}")
        End If
    End Sub
End Class
