Imports System.Drawing.Text
Imports System.IO

Public Class BlackBox
    Dim version As String = "1.0.0"
    Dim owner As String = "Diego"
    Dim fontind = 0
    Public Shared font As New PrivateFontCollection()

    Function readFile(path As String)
        Return My.Computer.FileSystem.ReadAllText(path)
    End Function

    ''' <summary>
    ''' Writes text to a File.
    ''' </summary>
    ''' <param name="path">filePath</param>
    ''' <param name="text">content</param>
    ''' <param name="append">append</param>
    Sub WriteTxt(path As String, text As String, append As Boolean)
        My.Computer.FileSystem.WriteAllText(path, text, append)
    End Sub

    Sub CreateFile(path As String)
        File.Create(path).Dispose()
    End Sub


    Sub ClrText(textObject As Object)
        textObject.text = ""
    End Sub

    Class XMath
        Dim TAU As Double = Math.PI * 2
        Dim PHI As Double = (1 + Math.Sqrt(5)) / 2

        Function FibbSeq(term As Integer)
            If term = 0 Then
                Return 0
            ElseIf term = 1 Then
                Return 1

            Else
                Return FibbSeq(term - 1) + FibbSeq(term - 2)
            End If
        End Function

    End Class


    Class BobMail


        Class Email

        End Class


    End Class


    Public Shared Sub Main()
        Font.AddFontFile("prstart.ttf")
    End Sub
    Sub Hide(objectx As Object)
        objectx.visible = False
    End Sub

    Sub Shw(objectx As Object)
        objectx.visible = True
    End Sub

    Function CountFiles(folder As String)
        Dim files = My.Computer.FileSystem.GetFiles(folder)
        Return files.Count
    End Function

    Function getFilesFromFolder(folder As String)

        Return My.Computer.FileSystem.GetFiles(folder).Reverse()
    End Function

    Public Function pressstart(obj As Object)
        If fontind = 0 Then
            Main()
            Return New Font(font.Families(0), obj.font.size, FontStyle.Regular)
            fontind += 1
            MsgBox(font.Families.Count)
        Else
            Return New Font(font.Families(0), obj.font.size, FontStyle.Regular)
        End If


    End Function
End Class
