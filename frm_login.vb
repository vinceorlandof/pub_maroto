Public Class frm_login
    Private Sub btn_dev_Click(sender As Object, e As EventArgs) Handles btn_dev.Click
        Me.Hide()
        frm_dev.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chk_visu_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visu.CheckedChanged
        If txt_senha.UseSystemPasswordChar = True Then
            txt_senha.UseSystemPasswordChar = False
        Else
            txt_senha.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sql = "SELECT * FROM funcionarios"
        rs = db.Execute(sql)
        rs.MoveFirst()
        While rs.EOF = False
            If txt_usuario.Text = rs.Fields(3).Value And txt_senha.Text = rs.Fields(4).Value Then
                MsgBox("Login efetuado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO!")
                Me.Hide()
                cargo = rs.Fields(2).Value
                id_funcionario = rs.Fields(0).Value
                home.ShowDialog()

                Exit While
            Else
                rs.MoveNext()
                If rs.EOF = True Then
                    MsgBox("Usuário ou senha incorretos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                End If
            End If
        End While
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
    End Sub
End Class
