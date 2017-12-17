Public Class Form1
    Dim mon As Integer = 10000
    Dim happy As Integer = 50
    Dim clean As Integer = 100
    Dim hunger As Integer = 0
    Dim msg = "game over"
    Dim age As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 10000 '10 seconds
        Timer1.Enabled = True

        Timer2.Interval = 21000 '20 seconds
        Timer2.Enabled = True

        Timer3.Interval = 25000 '20 seconds
        Timer3.Enabled = True

        Timer4.Interval = 30000 '20 seconds
        Timer4.Enabled = True

        Timer5.Interval = 1000 '20 seconds
        Timer5.Enabled = True


        If age = 1 Then
            ftank.Text = "








  ,
 <><
  `
"
        ElseIf age = 2 Then
            ftank.Text = "





  /
 /\/
 \/\
  \  "

        ElseIf age = 3 Then
            ftank.Text = "





  /
,'`./
`.,'\
  \  "
        ElseIf age = 4 Then
            ftank.Text = "





   ,
  /|
 /_/ ,
/o \/|
\<_/\|
 \ \ `
  \| 
   `"
        ElseIf age = 5 Then
            ftank.Text = "





   ,
  /|
 /_|  ,
/o  \/|
\<__/\|
 \ |  `
  \|
   `"
        End If


    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click

        age = 1
        ftank.Text = "





        ,
       ()<  
        `"
        mon = 10000
        mony.Text = (mon & "/100")
        happy = 50
        happyy.Text = (happy & "/100")
        hunger = 99
        hung.Text = (hunger & "/100")
        clean = 100
        cleany.Text = (clean & "/100")

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mon = mon + 1
        mony.Text = (mon & "/100")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        hunger = hunger + 1
        hung.Text = (hunger & "/100")
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        happy = happy - 1
        happyy.Text = (happy & "/100")

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        clean = clean - 1
        cleany.Text = (clean & "/100")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mon = mon - 15
        mony.Text = (mon & "/100")
        happy = happy + 5
        happyy.Text = (happy & "/100")
        hunger = hunger - 20
        hung.Text = (hunger & "/100")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mon = mon - 5
        mony.Text = (mon & "/100")
        happy = happy + 5
        happyy.Text = (happy & "/100")
        clean = clean + 35
        cleany.Text = (clean & "/100")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mon = mon - 5
        mony.Text = (mon & "/100")
        happy = happy + 25
        happyy.Text = (happy & "/100")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If age = 1 Then
            mon = mon - 30
            mony.Text = (mon & "/100")
            ftank.Text = "





  /
 /\/
 \/\
  \  "
            age = 2

        ElseIf age = 2 Then
            mon = mon - 30
            mony.Text = (mon & "/100")
            ftank.Text = "





  /
,'`./
`.,'\
  \  "
            age = 3
        ElseIf age = 3 Then
            mon = mon - 30
            mony.Text = (mon & "/100")
            ftank.Text = "





   ,
  /|
 /_/ ,
/o \/|
\<_/\|
 \ \ `
  \| 
   `"
            age = 4

        ElseIf age = 4 Then
            mon = mon - 30
            mony.Text = (mon & "/100")
            ftank.Text = "





   ,
  /|
 /_|  ,
/o  \/|
\<__/\|
 \ |  `
  \|
   `"
            age = 5
        ElseIf age = 5 Then
            mon = mon - 30
            mony.Text = (mon & "/100")
            ftank.Text = "






       /`-._
      /_,.._`:-         
  ,.-'  ,   `-:..-')   
 : o ):';      _  {   
  `-._ `'__,.-'\`-.)
      `\\  \,.-'`"

            age = 6

        ElseIf age = 6 Then
            mon = mon - 30
            mony.Text = (mon & "/100")
            ftank.Text = "



        o                 o
                  o
         o   ______      o
           _/  (   \_
 _       _/  (       \_  O
| \_   _/  (   (    0  \
|== \_/  (   (          |
|=== _ (   (   (        |
|==_/ \_ (   (          |
|_/     \_ (   (    \__/
          \_ (      _/
            |  |___/
           /__/"
            age = 7
        ElseIf age = 7 Then
            mon = mon - 30
            mony.Text = (mon & "/100")
            ftank.Text = "


               __   __
              __ \ / __
             /  \ | /  \
                 \|/
            _,.---v---._
   /\__/\  /            \
   \_  _/ /              \ 
     \ \_|           @ __|
      \                \_
       \     ,__/       /"
            age = 8
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        If happy < 0 Then
            ftank.Text = "



|\    \ \ \ \ \ \ \      __   
|  \    \ \ \ \ \ \ \   | O~-_
|   >----|-|-|-|-|-|-|--|  __/
|  /    / / / / / / /   |__\  
|/     / / / / / / /

"

            MsgBox(msg)

        ElseIf happy < 15 Then
            happyy.BackColor = Color.Red

        ElseIf happy < 35 Then
            happyy.BackColor = Color.Yellow


        End If

        If mon < 0 Then
            ftank.Text = "



|\    \ \ \ \ \ \ \      __   
|  \    \ \ \ \ \ \ \   | O~-_
|   >----|-|-|-|-|-|-|--|  __/
|  /    / / / / / / /   |__\  
|/     / / / / / / /

"

            MsgBox(msg)

        ElseIf mon < 20 Then
            mony.BackColor = Color.Red
        ElseIf mon < 35 Then
            mony.BackColor = Color.Yellow

        End If


        If hunger > 100 Then
            ftank.Text = "



|\    \ \ \ \ \ \ \      __   
|  \    \ \ \ \ \ \ \   | O~-_
|   >----|-|-|-|-|-|-|--|  __/
|  /    / / / / / / /   |__\  
|/     / / / / / / /

"

            MsgBox(msg)

        ElseIf hunger > 90 Then
            hung.BackColor = Color.Red
        ElseIf hunger > 70 Then
            hung.BackColor = Color.Yellow

        End If
        If clean < 0 Then
            happy = happy - 20

        ElseIf clean < 20 Then
            mony.BackColor = Color.Red
        ElseIf clean < 35 Then
            mony.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

