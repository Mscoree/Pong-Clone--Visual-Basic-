Imports System.Drawing
Public Class Form1
    Dim graphical, bbg As Graphics
    Dim sourceRect, destinationRect As Rectangle
    Dim bitmap, backBuffer As Bitmap
    Dim PaddleX As Integer = 1, PaddleY As Integer = 1, Paddle2X As Integer = 720, Paddle2Y As Integer = 420, r1 As Integer, score As Integer = 0, score2 As Integer = 0, BallX As Integer = 330, BallY As Integer = 200, ballHeight As Integer = 30, ballWidth As Integer = 30, verticalMomentum, HorizMomentum As Integer
    '#Region "Hide Cursor"
    '    Private Sub pongMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '        Windows.Forms.Cursor.Hide()
    '    End Sub
    '#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bitmap = New Bitmap(Tiles.Image)
        graphical = Me.CreateGraphics
        backBuffer = New Bitmap(Me.Width, Me.Height)
        Tiles.Hide()
        verticalMomentum = -10 + Int(Rnd() * 10)
        HorizMomentum = -10 + Int(Rnd() * 10)

    End Sub
    Private Sub DrawAll()
        Dim X, Y As Integer
        For X = 0 To 15
            For Y = 0 To 10
                sourceRect = New Rectangle(0, 0, 50, 50)
                destinationRect = New Rectangle(X * 50, Y * 50, 50, 50)
                graphical.DrawImage(bitmap, destinationRect, sourceRect, GraphicsUnit.Pixel)
            Next
        Next
        sourceRect = New Rectangle(50, 0, 30, 100)
        graphical.DrawImage(bitmap, PaddleX, PaddleY, sourceRect, GraphicsUnit.Pixel)
        graphical.DrawImage(bitmap, Paddle2X, Paddle2Y, sourceRect, GraphicsUnit.Pixel)
        sourceRect = New Rectangle(0, 50, ballWidth, ballHeight)
        graphical.DrawImage(bitmap, BallX, BallY, sourceRect, GraphicsUnit.Pixel)
        Ball()

        graphical = Graphics.FromImage(backBuffer)
        bbg = Me.CreateGraphics
        bbg.DrawImage(backBuffer, 0, 0, Me.Width, Me.Height)


    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.W
                If PaddleY > 0 Then PaddleY = PaddleY - 5
            Case Keys.S
                If PaddleY < 420 Then PaddleY = PaddleY + 5
            Case Keys.Q
                '    Case Keys.Up
                '        Paddle2Y = Paddle2Y - 5
                '    Case Keys.Down
                '        Paddle2Y = Paddle2Y + 5
                '    Case Keys.Q
                End
        End Select
        DrawAll()
    End Sub
    Private Sub Ball()
        BallY = BallY + verticalMomentum
        BallX = BallX + HorizMomentum
        If BallY = 0 Then verticalMomentum = -verticalMomentum
        If BallY = 490 Then verticalMomentum = -verticalMomentum
        If (BallX + ballWidth + 1) = 61 And BallY > PaddleY + 20 Then
            HorizMomentum = -HorizMomentum
        End If


















    End Sub
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        DrawAll()
    End Sub

End Class


