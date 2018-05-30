Imports BaseClasses
Public Class Form1
    ''' <summary>
    ''' Base example for returning the result of a Lambda query
    ''' which is setup as an anonymous type which in turn the
    ''' results are setup in a named tuple.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ops As New Operations
        Dim letter = "A"c
        Dim results = ops.CouldHaveBeenAnonymousResults(letter)
        MessageBox.Show($"Letter: {letter} Code: {results.Code} Occurs in string: {results.Occurrences}")
    End Sub
End Class
