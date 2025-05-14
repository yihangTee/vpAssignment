Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Module App
    Public Staffs(9999) As Staff
    Public intCount As Integer = 0
    Public CurrentUserName As String
    Public CurrentUserDepartment As String
    Public CurrentUserID As String
    Public Function GetNextId() As String
        Dim db As New BL_farizDataContext()
        ' Find the latest StaffID in the database
        Dim latestStaff = (From s In db.Staffs
                           Order By s.StaffID Descending
                           Select s.StaffID).FirstOrDefault()

        Dim nextNumber As Integer = 1 ' Default if no staff exists yet

        If latestStaff IsNot Nothing Then
            ' Remove prefix "S" and convert the number part
            Dim numberPart As String = latestStaff.Substring(1) ' Assuming "S" prefix 
            Integer.TryParse(numberPart, nextNumber)
            nextNumber += 1 ' Increment
        End If

        ' Format back with leading zeros, example: ST001, ST002
        Dim nextStaffID As String = "S" & nextNumber.ToString("D4")

        Return nextStaffID
    End Function

    'Public Function ImageToByteArray(img As Image) As Byte()
    '    If img Is Nothing Then
    '        ' Handle the case where no image is provided
    '        Return Nothing
    '    End If
    '    'Convert the PictureBox image into Byte array to store into the database
    '    Using ms As New IO.MemoryStream()
    '        img.Save(ms, img.RawFormat)
    '        Return ms.ToArray()
    '    End Using

    'End Function
    Public Function ImageToByteArray(img As Image) As Byte()
        Using ms As New IO.MemoryStream()
            Dim bmp As New Bitmap(img)
            bmp.Save(ms, Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    Public Function ByteArrayToImage(byteArray As Byte()) As Image
        If byteArray Is Nothing OrElse byteArray.Length = 0 Then
            ' return a default placeholder image or Nothing
            Return Nothing
        End If
        Using ms As New IO.MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    Public Function IsValidName(ByVal strName As String) As Boolean
        'A valid name must only contain alphabetic characters
        Dim rawinput = strName.Replace(" ", "").Trim
        Dim currentCharacter As Char
        For i As Integer = 0 To rawinput.Length - 1
            currentCharacter = rawinput.Chars(i)
            'not include special char except empty space
            If Not (Char.IsLetter(currentCharacter)) Then
                Return False
            End If
        Next
        Return True

    End Function

    Public Function IsValidEmail(ByVal strEmail As String) As Boolean
        'a valid email address must contain at least a letter infront of "@", a "@", a letter between "@" and "." and a letter behind "'"
        Dim pattern As String = "^[a-z][a-z|0-9]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
        Dim match As System.Text.RegularExpressions.Match = Regex.Match(strEmail, pattern, RegexOptions.IgnoreCase)
        Return match.Success

    End Function

    Public Function IsValidPassword(ByVal strPassword As String) As Boolean
        ' a valid password must contain at least a number, uppercase & lowercase letter and special char
        Dim hasNum, hasCap, hasLow, hasSpe As Boolean
        Dim currentCharacter As Char

        For i As Integer = 0 To strPassword.Length - 1
            currentCharacter = strPassword.Chars(i)
            If (Integer.TryParse(currentCharacter, 0)) Then
                hasNum = True
            ElseIf Char.IsUpper(currentCharacter) Then
                hasCap = True
            ElseIf Char.IsLower(currentCharacter) Then
                hasLow = True
            Else
                hasSpe = True
            End If
        Next
        Return hasNum And hasCap And hasLow And hasSpe
    End Function

    Public Function IsValidConfirmPassword(ByVal strPassword As String,
                                            ByVal strConfirmPassword As String) As Boolean
        Return String.Equals(strPassword, strConfirmPassword)
    End Function

End Module
