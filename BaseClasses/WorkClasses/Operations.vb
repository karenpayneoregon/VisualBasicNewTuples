Public Class Operations
    '
    ' Mocked data
    '
    Protected People As New List(Of Person) From
        {
            New Person With
            {
                .Identifier = 1,
                .FirstName = "Karen",
                .LastName = "Payne",
                .Email = "kp@gmail.com",
                .Account = New BusinessAccount With
                {
                    .AccountIdentifier = 12,
                    .BusinessName = "KP Club"
                }
            },
            New Person With
            {
                .Identifier = 2,
                .FirstName = "Jim",
                .LastName = "White",
                .Email = "jw@gmail.com",
                .Account = New BusinessAccount With
                {
                    .AccountIdentifier = 5, .BusinessName = "JW Corp"
                }
            },
            New Person With
            {
                .Identifier = 3,
                .FirstName = "Mary",
                .LastName = "Adams",
                .Email = "ma@gmail.com",
                .Account = New PersonalAccount With {.AccountIdentifier = 12, .Name = "Mary's Lambs"
            }}
        }
    ''' <summary>
    ''' This method gets each character in a static string and gets the code for each
    ''' character along with how many times it appears in the string.
    ''' 
    ''' With old tuples we would have as returned values
    ''' Item1 for Item
    ''' Item2 for Occurrences
    ''' Item3 for Code
    ''' 
    ''' While with ValueTuple we name each item being returned to the caller
    ''' </summary>
    ''' <param name="pChar">Character to find in the string</param>
    ''' <returns>ValueTuple (Item As Char, Occurrences As Integer, Code As Integer)</returns>
    ''' <remarks>
    ''' There is no intent to send a character in that does not exists in
    ''' the string to work with as this is a simple demo to demo ValueTuplle
    ''' and not assertion.
    ''' </remarks>
    Public Function CouldHaveBeenAnonymousResults(pChar As Char) As (Item As Char, Occurrences As Integer, Code As Integer)

        Dim results =
                (
                    From T In
                    (
                        From c In "T0*A1?0*23aTA3 4T4\+a4 ?407#?A*6T+".ToCharArray()
                        Group c By c Into Group Select New With
                        {
                            .Item = c,
                            .Occurrences = Group.Count,
                            .Code = Asc(c)
                        }
                    ).ToList.OrderBy(Function(x) x.Item)
                ).FirstOrDefault(Function(x) x.Item = pChar)


        Return (results.Item, results.Occurrences, results.Code)

    End Function
    ''' <summary>
    ''' This version returns two string values if the identifier is found.
    ''' If the identifier is not found the caller can check if one of the tuple members
    ''' is an empty string
    ''' </summary>
    ''' <param name="pIdentifier"></param>
    ''' <returns>ValueTuple (FirstName As String, LastName As String)</returns>
    Public Function FindPersonByIdentifierAsTuple(pIdentifier As Integer) As (FirstName As String, LastName As String)
        Dim personData = People.FirstOrDefault(Function(person) person.Identifier = pIdentifier)

        If personData Is Nothing Then
            Return ("", "")
        Else
            Return (personData.FirstName, personData.LastName)
        End If

    End Function
    ''' <summary>
    ''' This version returns an entire person object if the identifier is found
    ''' in the list.
    ''' If the identifier is not found the caller can check if the returning Person
    ''' object is Nothing/Null
    ''' </summary>
    ''' <param name="pIdentifier"></param>
    ''' <returns>Person object</returns>
    Public Function FindPersonByIdentifierAsPerson(pIdentifier As Integer) As Person
        Return People.FirstOrDefault(Function(person) person.Identifier = pIdentifier)
    End Function
End Class



