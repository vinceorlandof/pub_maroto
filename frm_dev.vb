Public Class frm_dev
    Private WithEvents Timer1 As New Timer()
    Private FrameIndex As Integer = 0
    Private Frames As New List(Of Image)()
    Private Sub frm_dev_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_vtr_dev_Click(sender As Object, e As EventArgs) Handles btn_vtr_dev.Click
        Me.Hide()
        frm_login.Show()

    End Sub

    Private Sub btn_sair_dev_Click(sender As Object, e As EventArgs) Handles btn_sair_dev.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        ' Carregar os frames do GIF em uma lista
        Frames.Add(Image.FromFile(Application.StartupPath & "\imagens\mapa do maroto.gif"))
        ' Adicionar outros frames se necessário
        'Frames.Add(Image.FromFile("caminho_para_seu_gif\outro_frame.gif"))

        ' Iniciar o timer para animar o GIF
        Timer1.Interval = 1000 ' Intervalo de tempo entre os frames (em milissegundos)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If FrameIndex < Frames.Count - 1 Then
            ' Exibir o próximo frame do GIF
            PictureBox1.Image = Frames(FrameIndex)
            FrameIndex += 1
        Else

            ' Exibir uma imagem estática ao chegar ao último frame
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\imagens\Iconka-Lucky-Leprechaun-Leprechaun.ico")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Timer1.Stop() ' Parar o timer se desejar interromper a animação
        End If
    End Sub


End Class