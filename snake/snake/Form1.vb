Imports System.ComponentModel

Public Class Form1
    Public blk As BlackBox = New BlackBox
    Public deriction As Integer = 1
    Public slength As Integer = 1
    Public score As Integer = 0
    Public body As List(Of SnkePrt) = New List(Of SnkePrt)
    Public tail As SnkePrt
    Public head As SnkePrt
    Public times = 4
    Public snkheadcolor As Color = Color.FromArgb(255, 60, 200, 100)
    Public snktailcolor As Color = Color.LightGreen
    Public wall As Color = Color.BurlyWood
    Public back As Color = Color.LemonChiffon
    Public scoreclr As Color = Color.DarkOliveGreen
    Public berry As Color = Color.LightSteelBlue
    Public enemies As List(Of PictureBox) = New List(Of PictureBox)

    Public Sub hitself()
        For Each item In body
            If head.Bounds.IntersectsWith(item.Bounds) And item.Name <> head.Name And slength <> 5 Then
                head.BackColor = Color.Red

                Foward.Stop()
                UpDown.Stop()
                Threading.Thread.Sleep(500)



                pnlGameover.Show()
            End If
        Next
    End Sub

    Public Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Short) As Short
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        convert(Me)
        Me.ClientSize = New Size(1024, 704)
        lblscore.Location = New Point(Int(PictureBox3.Width / 2) - Int(lblscore.Width / 2), Int(PictureBox3.Height / 2) - Int(lblscore.Height / 2))
        Me.Location = New Point((Int(Screen.PrimaryScreen.Bounds.Width / 2)) - Int(Me.Width / 2), (Int(Screen.PrimaryScreen.Bounds.Height / 2)) - Int(Me.Height / 2))
        Randomize()
        Panel1.Controls.Add(pctBerry)
        head = prtHead
        spawn()
        prtHead.prevPrt = prtHead
        tail = prtHead
        body.Add(prtHead)
        pnlpause.Location = New Point(Int(Me.Panel1.Width / 2) - Int(pnlpause.Width / 2), Int(Me.Panel1.Height / 2) - Int(pnlpause.Height / 2))

        lblscore.Text = "0"
    End Sub

    Public Sub convert(m As Object)
        For Each item In m.Controls
            If TypeOf item Is Label Or TypeOf item Is Button Or TypeOf item Is TextBox Then
                item.font = blk.pressstart(item)
            End If
            If TypeOf item Is Panel Then
                convert(item)
            End If
        Next
    End Sub

    Private Sub UpDown_Tick(sender As Object, e As EventArgs) Handles UpDown.Tick
        If GetKeyState(Keys.Up) < 0 Then
            If deriction <> 2 Or slength = 1 Then

                If Not head.prevPrt.Top = head.Top + 16 Then
                    deriction = 0
                End If
            End If
        End If
        If GetKeyState(Keys.Down) < 0 Then

            If deriction <> 0 Or slength = 1 Then
                If Not head.prevPrt.Top = head.Top - 16 Then
                    deriction = 2
                End If
            End If
        End If
        If GetKeyState(Keys.Right) < 0 Then
            If deriction <> 3 Or slength = 1 Then
                If Not head.prevPrt.Left = head.Left + 16 Then
                    deriction = 1
                End If
            End If
        End If
        If GetKeyState(Keys.Left) < 0 Then
            If deriction <> 1 Or slength = 1 Then
                If Not head.prevPrt.Left = head.Left - 16 Then
                    deriction = 3
                End If
            End If
        End If
        If GetKeyState(Keys.Space) < 0 Then
            ppause()
        End If


    End Sub



    Private Sub Foward_Tick(sender As Object, e As EventArgs) Handles Foward.Tick
        Dim sp As Integer = 16

        If slength = 1 Then



            Select Case deriction
                Case 0
                    prtHead.Top -= sp
                Case 1
                    prtHead.Left += sp
                Case 2
                    prtHead.Top += sp
                Case 3
                    prtHead.Left -= sp
            End Select
        Else
            'For Each item In rev(body)
            'item.moveF()
            '
            'N'ext
            Select Case deriction
                Case 0
                    If tail Is Nothing Then
                        tail = head.nextPrt
                    End If
                    tail.Location = New Point(head.Left, head.Top - sp)
                    head.BackColor = snktailcolor
                    head.BringToFront()
                    head = tail
                    head.BackColor = snkheadcolor
                    tail = tail.nextPrt

                Case 1
                    If tail Is Nothing Then
                        tail = head.nextPrt
                    End If
                    tail.Location = New Point(head.Left + sp, head.Top)
                    head.BackColor = snktailcolor
                    head.BringToFront()
                    head = tail
                    head.BackColor = snkheadcolor
                    tail = tail.nextPrt
                Case 2
                    If tail Is Nothing Then
                        tail = head.nextPrt
                    End If
                    tail.Location = New Point(head.Left, head.Top + sp)
                    head.BackColor = snktailcolor
                    head.BringToFront()
                    head = tail
                    head.BackColor = snkheadcolor
                    tail = tail.nextPrt
                Case 3
                    If tail Is Nothing Then
                        tail = head.nextPrt
                    End If
                    tail.Location = New Point(head.Left - sp, head.Top)
                    head.BackColor = snktailcolor
                    head.BringToFront()
                    head = tail
                    head.BackColor = snkheadcolor
                    tail = tail.nextPrt
            End Select
        End If

        If head.Bounds.IntersectsWith(pctBerry.Bounds) Then
            hitBerry()
        End If

        For Each item In enemies
            If head.Bounds.IntersectsWith(item.Bounds) Then
                head.BackColor = Color.Red

                Foward.Stop()
                UpDown.Stop()
                Threading.Thread.Sleep(500)



                pnlGameover.Show()
            End If
        Next


        If head.Right > Panel1.Width Or head.Top < 0 Or head.Left < 0 Or head.Bottom > Panel1.Height Then
            'If Not head.Bounds.IntersectsWith(Panel1.Bounds) Then
            If chkWalls.Checked Then

                Foward.Stop()
                UpDown.Stop()
                pnlGameover.Show()
            Else
                If head.Right > Panel1.Width Then
                    head.Left = 0
                ElseIf head.Top < 0 Then
                    head.Top = Panel1.Height - head.Height
                ElseIf head.Left < 0 Then
                    head.Left = Panel1.Width - head.Width
                ElseIf head.Bottom > Panel1.Height Then
                    head.Top = 0
                End If
            End If


        End If

        hitself()

    End Sub

    Public Function rand(number As Integer)
        Randomize()
        Return Math.Round(Rnd() * number)
    End Function

    Public Sub hitBerry()
        spawn()

        For i = 1 To times
            Dim prt As New SnkePrt


            prt.Name = Str(slength)
            prt.Size = prtHead.Size
            prt.BackColor = Color.LightGreen
            prt.Location = tail.Location
            prt.nextPrt = tail
            prt.prevPrt = head
            prt.nextPrt.prevPrt = prt
            prt.SendToBack()
            head.nextPrt = prt
            tail = prt
            body.Add(prt)
            Panel1.Controls.Add(prt)
            slength += 1
            score += 1
        Next
        If CheckBox1.Checked And RadioButton1.Checked Then
            spawne()
        End If

        lblscre.Text = score.ToString

        If CheckBox1.Checked And RadioButton2.Checked Then
            Dim eny As New PictureBox
            eny.Size = New Size(16, 16)

            eny.Name = enemies.Count.ToString
            eny.BackColor = Color.Orange
            If slength = 5 Then

                Select Case deriction
                    Case 0
                        eny.Location = New Point(tail.Left, tail.Top + 16)
                    Case 1
                        eny.Location = New Point(tail.Left - 16, tail.Top)
                    Case 2
                        eny.Location = New Point(tail.Left, tail.Top - 16)
                    Case 3
                        eny.Location = New Point(tail.Left + 16, tail.Top)
                End Select

                enemies.Add(eny)
                Panel1.Controls.Add(eny)
            Else
                If tail.Top = tail.nextPrt.nextPrt.nextPrt.nextPrt.nextPrt.Bottom Then
                    eny.Location = New Point(tail.Left, tail.Top + 16)

                ElseIf tail.Bottom = tail.nextPrt.nextPrt.nextPrt.nextPrt.nextPrt.Top Then
                    eny.Location = New Point(tail.Left, tail.Top - 16)
                ElseIf tail.Right = tail.nextPrt.nextPrt.nextPrt.nextPrt.nextPrt.Left Then
                    eny.Location = New Point(tail.Left - 16, tail.Top)
                ElseIf tail.Left = tail.nextPrt.nextPrt.nextPrt.nextPrt.nextPrt.Right Then
                    eny.Location = New Point(tail.Left + 16, tail.Top)

                Else

                End If

                enemies.Add(eny)
                Panel1.Controls.Add(eny)
            End If




        End If

        lblscore.Text = score
        lblscore.Location = New Point(Int(PictureBox3.Width / 2) - Int(lblscore.Width / 2), Int(PictureBox3.Height / 2) - Int(lblscore.Height / 2))

    End Sub

    Public Function rev(list As List(Of SnkePrt))
        Dim list2 As List(Of SnkePrt) = New List(Of SnkePrt)
        Dim i As Integer = list.Count - 1
        Do
            list2.Add(list(i))
            i -= 1
        Loop While i <> -1

        Return list2
    End Function

    Public Sub spawne()
        Dim eny As New PictureBox
        eny.Size = New Size(16, 16)
        eny.Location = New Point(Int((rand((Panel1.Width / 16) - 1)) * 16), Int((rand((Panel1.Height / 16) - 1)) * 16) + 16)
        eny.Name = enemies.Count.ToString
        eny.BackColor = Color.Orange
        For Each item In body
            If eny.Location = item.Location Or eny.Location = pctBerry.Location Then
                spawne()
            End If
        Next
        enemies.Add(eny)
        Panel1.Controls.Add(eny)

    End Sub
    Public Sub spawn()
        pctBerry.Location = New Point(Int((rand((Panel1.Width / 16) - 1)) * 16), Int((rand((Panel1.Height / 16) - 1)) * 16))
        For Each item In body

            For Each item2 In enemies
                If pctBerry.Location = item.Location Or pctBerry.Location = item2.Location Then
                    spawn()
                End If
            Next
        Next
    End Sub

    Public Sub ppause()
        Foward.Stop()
        UpDown.Stop()
        pnlpause.Visible = True
        pnlpause.BringToFront()
        pausetime.Start()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub pausetime_Tick(sender As Object, e As EventArgs) Handles pausetime.Tick

        If GetKeyState(Keys.Space) < 0 Then
            Panel2.Visible = False
            pnlpause.Visible = False
            pausetime.Stop()
            UpDown.Start()

            Foward.Start()

            Threading.Thread.Sleep(200)

        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Hide()
        Button4.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Show()
        Panel2.BringToFront()
        Button4.Show()

    End Sub

    Private Sub pctheadcolor_Click(sender As Object, e As EventArgs) Handles pctheadcolor.Click
        'colorhead.ShowDialog()
        If colorhead.ShowDialog <> DialogResult.Cancel Then
            snkheadcolor = colorhead.Color
            head.BackColor = colorhead.Color
            pctheadcolor.BackColor = colorhead.Color
        End If
    End Sub

    Private Sub pctScore_Click(sender As Object, e As EventArgs) Handles pctScore.Click
        If colorhead.ShowDialog <> DialogResult.Cancel Then
            scoreclr = colorhead.Color
            lblscore.ForeColor = colorhead.Color
            pctScore.BackColor = colorhead.Color
        End If
    End Sub

    Private Sub pctsnkbody_Click(sender As Object, e As EventArgs) Handles pctsnkbody.Click
        If colorhead.ShowDialog <> DialogResult.Cancel Then
            snktailcolor = colorhead.Color
            For Each item In body
                If item IsNot head Then
                    item.BackColor = colorhead.Color
                End If
            Next
            pctsnkbody.BackColor = colorhead.Color
        End If
    End Sub

    Private Sub pctwall_Click(sender As Object, e As EventArgs) Handles pctwall.Click
        If colorhead.ShowDialog <> DialogResult.Cancel Then
            wall = colorhead.Color
            pctwall.BackColor = colorhead.Color
            PictureBox1.BackColor = colorhead.Color
            PictureBox2.BackColor = colorhead.Color
            PictureBox3.BackColor = colorhead.Color
            pctrwall.BackColor = colorhead.Color
            lblscore.BackColor = colorhead.Color
        End If
    End Sub

    Private Sub pctBerryclr_Click(sender As Object, e As EventArgs) Handles pctBerryclr.Click
        If colorhead.ShowDialog <> DialogResult.Cancel Then
            berry = colorhead.Color
            pctBerry.BackColor = colorhead.Color
            pctBerryclr.BackColor = colorhead.Color
        End If
    End Sub

    Private Sub pctback_Click(sender As Object, e As EventArgs) Handles pctback.Click
        If colorhead.ShowDialog <> DialogResult.Cancel Then
            BackColor = colorhead.Color
            Panel1.BackColor = colorhead.Color
            pctback.BackColor = colorhead.Color
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpDown.Start()
        Foward.Start()
        pnlpause.Visible = False
        Threading.Thread.Sleep(200)
        pausetime.Stop()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            RadioButton1.Show()
            RadioButton2.Show()
        Else
            For Each cont In Panel1.Controls.OfType(Of PictureBox)



                If enemies.Contains(cont) Then

                    Panel1.Controls.Remove(cont)
                End If

            Next
            enemies.Clear()
            RadioButton1.Hide()
            RadioButton2.Hide()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        score = 0
        prtHead.Location = New Point(64, 64)
        head = prtHead
        spawn()
        prtHead.prevPrt = prtHead
        tail = prtHead
        For Each item In body
            If item IsNot prtHead Then
                Panel1.Controls.Remove(item)

            End If
        Next
        body.Clear()
        body.Add(prtHead)
        deriction = 1
        slength = 1
        For Each item In enemies

            Panel1.Controls.Remove(item)


        Next
        enemies.Clear()
        Foward.Start()
        UpDown.Start()
        pnlGameover.Hide()

    End Sub


End Class
