Public Class frmMain
    Dim ColCount, RowCount, GameTime As Integer 'sütun sayısı, kolon sayısı, oyunda geçen zaman
    Dim GameMinesBtn() As Button 'oyundaki mayınların butonları: onlara erişimi kolaylaştırmak için lazım
    Dim MinePlaces() As Boolean 'mayınların hangi butonların ardında saklı olduğunu belirtiyor...
    Dim MineNumbers() As Integer 'butonlardaki rakamları: o karenin etrafında kaç mayın var???
    Dim MineGuess() As Boolean 'hangi butonlarda mayın olduğu tahmin ediliyor
    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape : Me.Close() 'ESC tuşuna basılırsa oyunu kapat
        End Select
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tsmiLevels_Click(tsmiLevel1, e) 'oyun ilk başladığında level1de oyuna başla
    End Sub
    Private Sub tsmiNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNew.Click, tsmiNew2.Click
        Call CreateNewGame()
    End Sub
    Private Sub tsmiLevels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiLevel1.Click, tsmiLevel2.Click, tsmiLevel3.Click, tsmiLevel4.Click, tsmiLevel5.Click
        Dim GameLevel As Integer = Microsoft.VisualBasic.Right(sender.text, 1)
        tsmiLevel.Text = "Level " & GameLevel
        tsmiLevel1.Checked = False : tsmiLevel2.Checked = False : tsmiLevel3.Checked = False : tsmiLevel4.Checked = False : tsmiLevel5.Checked = False : sender.checked = True
        RowCount = GameLevel * 4 : ColCount = GameLevel * 4
        Call CreateNewGame()
    End Sub
    Private Sub Shuffle(ByRef ArrayToBeShuffled As Array, Optional ByVal NumberOfTimesToShuffle As Integer = 7)
        Dim rndPosition As New Random(DateTime.Now.Millisecond)
        For i As Integer = 1 To NumberOfTimesToShuffle
            For i2 As Integer = 1 To ArrayToBeShuffled.Length
                swap(ArrayToBeShuffled(rndPosition.Next(0, ArrayToBeShuffled.Length)), ArrayToBeShuffled(rndPosition.Next(0, ArrayToBeShuffled.Length)))
            Next i2
        Next i
    End Sub
    Private Sub swap(ByRef arg1 As Object, ByRef arg2 As Object) 'belirtilen iki değişkenin değerleri yer değiştiriliyor
        Dim strTemp As String : strTemp = arg1 : arg1 = arg2 : arg2 = strTemp
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim GameMin As String = Math.Floor(Convert.ToDouble(GameTime / 60)).ToString.PadLeft(2, "0") 'oyunda geçen süreye bakarak toplam dakika bulunuyor, çift haneli olarak
        Dim GameSec As String = Math.Floor(Convert.ToDouble(GameTime Mod 60)).ToString.PadLeft(2, "0") 'topplam süreden dakika çıkarılarak kalan saniye bulunuyor, çift haneli olarak
        lblTime.Text = "Your time: " + GameMin + ":" + GameSec : GameTime += 1 'en son olarak da geçen süre yazdırılıyor ve geçen saniye bir arttırılıyor
    End Sub
    Private Sub ClearGame()
        'butonlar ve pictureboxlar siliniyor
        For i = 0 To Me.Controls.Count - 1
            Try
                If Me.Controls(i).Name = "GameButtons" Or Me.Controls(i).Name = "GamePictures" Then Me.Controls.Remove(Me.Controls(i)) : i -= 1
            Catch ex As Exception
                Exit For
            End Try
        Next
        'değikenler ve zaman sıfırlanıyor...
        Timer1.Enabled = False : GameTime = 0 : ReDim MinePlaces(RowCount * ColCount - 1) : ReDim MineNumbers(RowCount * ColCount - 1) : ReDim MineGuess(RowCount * ColCount - 1) : ReDim GameMinesBtn(ColCount * RowCount - 1)
    End Sub
    Private Sub CreateNewGame()
        Call ClearGame() 'ilk olarak form sıfırlanıyor
        For i = 0 To (ColCount * RowCount - 1)
            GameMinesBtn(i) = New Button : MinePlaces(i) = False : MineNumbers(i) = 0
            GameMinesBtn(i).SetBounds((i Mod ColCount) * 30 + 30, Math.Floor(i / RowCount) * 30 + 50, 30, 30) : GameMinesBtn(i).Tag = i
            GameMinesBtn(i).Parent = Me : GameMinesBtn(i).Visible = True : GameMinesBtn(i).Name = "GameButtons" : GameMinesBtn(i).TabStop = False
            AddHandler GameMinesBtn(i).MouseDown, AddressOf GameButtons_MouseDown
        Next
        'burda mayınların yerlerini belirliyoruz
        For i = 0 To CInt(RowCount * ColCount / 6)
            MinePlaces(i) = True
        Next : Shuffle(MinePlaces) 'ilk önce belli miktarda mayın erleştiriliyor, sonra da onların yerleri karıştırılıyor
        For i = 0 To (ColCount * RowCount - 1) 'bu bölümde mayınların yanlarındaki rakamlar yazılacak
            If MinePlaces(i) = True Then 'eğer su andaki karede mayın varsa etrafındaki mrakamları bir artırcak
                MineNumbers(i) = -1 'mayınların olduğu karelerde mayın numaraları -1... normalde 0...
                If i >= ColCount Then 'mayının yukarısındaki sayıyı artırmak için en üst satır olmaması lazım
                    If MinePlaces(i - ColCount) = False Then MineNumbers(i - ColCount) += 1

                    If i Mod ColCount > 0 Then 'mayının üst solundaki sayıyı artırmak için en solda da olmaması gerekiyor
                        If MinePlaces(i - ColCount - 1) = False Then MineNumbers(i - ColCount - 1) += 1
                    End If
                    If i Mod RowCount < RowCount - 1 Then 'mayının üst sağındaki sayıyı artırmak için en sağda da olmaması gerekiyor
                        If MinePlaces(i - ColCount + 1) = False Then MineNumbers(i - ColCount + 1) += 1
                    End If


                End If
                If Math.Floor(i / RowCount) < RowCount - 1 Then 'mayının aşağısındaki satırı artırmak için en alt satır olmaması gerekiyor
                    If MinePlaces(i + ColCount) = False Then MineNumbers(i + ColCount) += 1

                    If i Mod ColCount > 0 Then 'mayının solundaki sayıyı artırmak için en solda olmaması gerekiyor
                        If MinePlaces(i + ColCount - 1) = False Then MineNumbers(i + ColCount - 1) += 1
                    End If
                    If i Mod RowCount < RowCount - 1 Then 'mayının sağındaki sayıyı artırmak için en sağda olmaması gerekiyor
                        If MinePlaces(i + ColCount + 1) = False Then MineNumbers(i + ColCount + 1) += 1
                    End If


                End If
                If i Mod ColCount > 0 Then 'mayının solundaki sayıyı artırmak için en solda olmaması gerekiyor
                    If MinePlaces(i - 1) = False Then MineNumbers(i - 1) += 1
                End If
                If i Mod RowCount < RowCount - 1 Then 'mayının sağındaki sayıyı artırmak için en sağda olmaması gerekiyor
                    If MinePlaces(i + 1) = False Then MineNumbers(i + 1) += 1
                End If

            End If
        Next
        Timer1.Enabled = True : Call Timer1_Tick(Me, System.EventArgs.Empty)
        Me.Width = ColCount * 30 + 60 : Me.Height = RowCount * 30 + 120 : lblStatus.Text = (CInt(RowCount * ColCount / 6) + 1).ToString.PadLeft(2, "0") & " mines left."
    End Sub
    Private Sub CheckEndofGame()
        If Microsoft.VisualBasic.Left(lblStatus.Text, 2) = "00" Then
            'eğer tüm mayınları bulduğunu iddia ediyorsa bi kontol et bakalım...
            For i = 0 To RowCount * ColCount - 1
                If MinePlaces(i) <> MineGuess(i) Then Exit Sub 'eğer bir mayın tahmininin bile yeri yanlışsa çık
            Next
            Call EndOfGameProcedures() : MsgBox("bravo") 'yok tüm tahminler doğruysa e walla bravo
        End If
    End Sub
    Private Sub EndofGame()
        For i = 0 To RowCount * ColCount - 1
            If MinePlaces(i) = True Then
                Dim tmpGamePic As New PictureBox : tmpGamePic.SetBounds((i Mod ColCount) * 30 + 30, Math.Floor(i / RowCount) * 30 + 50, 30, 30) : tmpGamePic.BackgroundImage = ImageList1.Images(2)
                tmpGamePic.Parent = Me : tmpGamePic.Visible = True : tmpGamePic.Name = "GamePictures"
            End If
        Next
        Call EndOfGameProcedures()
    End Sub
    Private Sub EndOfGameProcedures()
        Timer1.Enabled = False : lblStatus.Text = "Click to start" : lblTime.Text = ""
        For i = 0 To Me.Controls.Count - 1
            If Me.Controls(i).Name = "GameButtons" Then Me.Controls(i).SendToBack() : Me.Controls(i).Enabled = False
            If Me.Controls(i).Name = "GamePictures" Then Me.Controls(i).BringToFront() : Me.Controls(i).Enabled = False
        Next
    End Sub
    Private Sub GameButtons_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            If MinePlaces(sender.tag) = True Then sender.visible = False : Call EndofGame() : Exit Sub Else Call OpenEmptyBoxes(sender.tag)
        ElseIf e.Button = MouseButtons.Right Then
            Dim tmpGamePic As New PictureBox : tmpGamePic.SetBounds(sender.left, sender.top, 30, 30) : tmpGamePic.BackgroundImage = ImageList1.Images(0) : tmpGamePic.Name = "GamePictures"
            tmpGamePic.Parent = Me : tmpGamePic.Visible = True : tmpGamePic.TabStop = False : sender.visible = False : tmpGamePic.Tag = sender.tag & "?"
            AddHandler tmpGamePic.MouseDown, AddressOf GamePictures_MouseDown
            MineGuess(sender.tag) = True
            lblStatus.Text = (Microsoft.VisualBasic.Left(lblStatus.Text, 2) - 1).ToString.PadLeft(2, "0") & " mines left."
        End If
        Call CheckEndofGame()
    End Sub
    Private Sub GamePictures_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            If Microsoft.VisualBasic.Right(sender.tag, 1) = "?" Then
                sender.BackgroundImage = ImageList1.Images(1) : sender.tag = Microsoft.VisualBasic.Left(sender.tag, Len(sender.tag) - 1)
                lblStatus.Text = (Microsoft.VisualBasic.Left(lblStatus.Text, 2) + 1).ToString.PadLeft(2, "0") & " mines left."
                MineGuess(sender.tag) = False
            Else
                For i = 0 To Me.Controls.Count - 1
                    If Me.Controls(i).Tag = sender.tag Then Me.Controls(i).Visible = True : Exit For
                Next
                Me.Controls.Remove(sender)
            End If
        End If
    End Sub
    Private Sub OpenEmptyBoxes(ByVal ButtonQueue As Integer)
        If GameMinesBtn(ButtonQueue).FlatStyle = 0 Then Exit Sub
        GameMinesBtn(ButtonQueue).FlatStyle = 0 : GameMinesBtn(ButtonQueue).Enabled = False : GameMinesBtn(ButtonQueue).Text = MineNumbers(ButtonQueue)
        If MineNumbers(ButtonQueue) = 0 Then
            GameMinesBtn(ButtonQueue).Text = ""
            If ButtonQueue Mod ColCount > 0 Then
                Call OpenEmptyBoxes(ButtonQueue - 1) 'eğer en solda değilse bir soldakini aç
                If ButtonQueue >= ColCount Then Call OpenEmptyBoxes(ButtonQueue - ColCount - 1) 'eğer en üstte değilse bir üsttekini aç
                If Math.Floor(ButtonQueue / RowCount) < RowCount - 1 Then Call OpenEmptyBoxes(ButtonQueue + ColCount - 1) 'eğer en altta değilse bir alttakini aç
            End If
            If ButtonQueue Mod RowCount < RowCount - 1 Then
                Call OpenEmptyBoxes(ButtonQueue + 1) 'eğer en sağda edğilse bir sağdakini aç
                If ButtonQueue >= ColCount Then Call OpenEmptyBoxes(ButtonQueue - ColCount + 1) 'eğer en üstte değilse bir üsttekini aç
                If Math.Floor(ButtonQueue / RowCount) < RowCount - 1 Then Call OpenEmptyBoxes(ButtonQueue + ColCount + 1) 'eğer en altta değilse bir alttakini aç
            End If
            If ButtonQueue >= ColCount Then Call OpenEmptyBoxes(ButtonQueue - ColCount) 'eğer en üstte değilse bir üsttekini aç
            If Math.Floor(ButtonQueue / RowCount) < RowCount - 1 Then Call OpenEmptyBoxes(ButtonQueue + ColCount) 'eğer en altta değilse bir alttakini aç
        End If
    End Sub
End Class
