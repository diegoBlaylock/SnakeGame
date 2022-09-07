Public Class SnkePrt : Inherits PictureBox
    Public nextPrt As SnkePrt
    Public prevPrt As SnkePrt


    Public Sub moveF()
        Location = nextPrt.Location

    End Sub





End Class
