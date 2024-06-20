Public Class frm_cad_funcionarios
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cargo_funcionario.SelectedIndexChanged

    End Sub

    Private Sub btn_vtr_dev_Click(sender As Object, e As EventArgs) Handles btn_vtr_dev.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub btn_salvar_funcionario_Click(sender As Object, e As EventArgs) Handles btn_salvar_funcionario.Click
        If txt_senha_funcionario.Text = txt_confirma_senha.Text Then


            If rs.EOF = True Then

                sql = "INSERT INTO funcionarios (nome, cargo, usuario, senha) " &
                  "VALUES ('" & txt_nome_funcionario.Text & "', " &
                           "'" & cmb_cargo_funcionario.Text & "', " &
                           "'" & txt_login_funcionario.Text & "', " &
                           "'" & txt_confirma_senha.Text & "');"

                rs = db.Execute(sql)
                carregar_dados()
                resposta = MsgBox("Cadastro realizado com sucesso!" + vbNewLine +
                              "Deseja realizar novo cadastro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ATENÇÃO!")
                If resposta = vbYes Then

                    limpar_dados()


                Else
                    Me.Close()
                    home.Show()
                End If
            Else
                resp = MsgBox("Este username ja está cadastrado! gostaria de sobrescrever os dados? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "atenção")
                If resp = MsgBoxResult.Yes Then
                    sql = "SELECT * from funcionarios"
                    rs = db.Execute(sql)
                    aux_usu = rs.Fields(0).Value
                    sql = "UPDATE funcionarios SET " &
                          "nome = '" & txt_nome_funcionario.Text & "', " &
                          "cargo = '" & cmb_cargo_funcionario.Text & "', " &
                          "senha = '" & txt_senha_funcionario.Text & "', " &
                          "usuario = '" & txt_login_funcionario.Text & "'" &
                            "WHERE id = " & aux_usu & ""

                    rs = db.Execute(sql)
                    MsgBox("dados gravados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "aviso")
                    limpar_dados()
                    carregar_dados()



                End If




            End If
        Else
            MsgBox("Campos de senha e confirmação de senha não conferem!")
            txt_confirma_senha.Select()
            Exit Sub
        End If
    End Sub

    Private Sub frm_cad_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
    End Sub


    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        With dgv_funcionario
            ' Try
            aux_usu = .CurrentRow.Cells(1).Value

            If .CurrentRow.Cells(1).Value = "" Then
                MsgBox("Nenhum usuário selecionado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

            Else
                resp = MsgBox("Deseja apagar o usuario: '" & .CurrentRow.Cells(0).Value & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete from funcionarios where usuario = '" & aux_usu & "'"
                    rs = db.Execute(sql)
                    MsgBox("Usuário excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    carregar_dados()
                    limpar_dados()

                End If
            End If

            'Catch ex As Exception
            'MsgBox("Erro ao excluir dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            ' End Try

        End With
    End Sub
    Sub limpar_dados()

        txt_nome_funcionario.Clear()
        txt_senha_funcionario.Clear()
        txt_confirma_senha.Clear()
        txt_login_funcionario.Clear()
        cmb_cargo_funcionario.SelectedIndex = -1

    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        With dgv_funcionario

            'Try
            aux_usu = .CurrentRow.Cells(1).Value
                With .CurrentRow.Selected


                sql = "Select * from funcionarios where usuario = '" & aux_usu & "'"
                rs = db.Execute(sql)

                    txt_nome_funcionario.Text = rs.Fields(1).Value
                    cmb_cargo_funcionario.Text = rs.Fields(2).Value
                    txt_login_funcionario.Text = rs.Fields(3).Value
                    txt_senha_funcionario.Text = rs.Fields(4).Value


                End With
            'Catch ex As Exception
            'MsgBox("Nenhum usuário selecionado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            'End Try









        End With
    End Sub

    Private Sub txt_senha_funcionario_TextChanged(sender As Object, e As EventArgs) Handles txt_senha_funcionario.TextChanged

    End Sub
End Class