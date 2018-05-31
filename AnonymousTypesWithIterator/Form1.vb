Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim dt = New DataTable With {.TableName = "MyTable"}

        dt.Columns.Add(New DataColumn With {.ColumnName = "Identifier",
                          .DataType = GetType(Int32),
                          .AutoIncrement = True, .AutoIncrementSeed = 1,
                          .ColumnMapping = MappingType.Hidden})

        dt.Columns.Add(New DataColumn With {.ColumnName = "Name",
                          .DataType = GetType(String)})

        dt.Columns.Add(New DataColumn With {.ColumnName = "Status",
                          .DataType = GetType(Boolean)})

        dt.Rows.Add(New Object() {Nothing, "Karen", False})
        dt.Rows.Add(New Object() {Nothing, "Karen", True})
        dt.Rows.Add(New Object() {Nothing, "Bill", True})
        dt.Rows.Add(New Object() {Nothing, "Karen", False})
        dt.Rows.Add(New Object() {Nothing, "Bill", True})

        DataGridView1.DataSource = dt

    End Sub

    Private Sub cmdExecute_Click(sender As Object, e As EventArgs) Handles cmdExecute.Click

        DataGridView2.Rows.Clear()

        For Each item In GetDuplicatesByIdendifier()
            DataGridView2.Rows.Add(item.Identifer, item.Name)
        Next

    End Sub
    Public Iterator Function GetDuplicatesByIdendifier() As IEnumerable(Of (Name As String, Identifer As Integer))
        Dim dt = CType(DataGridView1.DataSource, DataTable)

        Dim duplicates = dt.AsEnumerable().
                GroupBy(Function(r) New With
                           {
                           Key .Name = CStr(r("Name")),
                           Key .Status = r("Status"),
                           .Identifier = CInt(r("Identifier"))
                           }).
                Where(Function(gr) gr.Count() > 1).Select(Function(g) g.Key)

        For Each d In duplicates
            Yield (d.Name, d.Identifier)
        Next
    End Function

End Class
