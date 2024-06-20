Imports System.Windows.Controls

Public Class frm_cad_pes
    Private Sub btn_vtr_dev_Click(sender As Object, e As EventArgs) Handles btn_vtr_dev.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub btn_cad_func_Click(sender As Object, e As EventArgs) Handles btn_cad_func.Click
        Try
            telefone_unmask = txt_telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
            sql = "SELECT * FROM clientes WHERE cpf = '" & txt_cpf.Text & "' "
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "INSERT INTO clientes (cpf, nome, data_nasc, cep, rua, numero, bairro, cidade, uf, email, telefone) " &
                            "VALUES ('" & txt_cpf.Text & "', " &
                                    "'" & txt_nome.Text & "', " &
                                    "'" & cmb_data_nascimento.Value & "', " &
                                    "'" & txt_cep.Text & "', " &
                                    "'" & txt_logradouro.Text & "', " &
                                    "'" & txt_numero.Text & "', " &
                                    "'" & txt_bairro.Text & "', " &
                                    "'" & txt_cidade.Text & "', " &
                                    "'" & txt_uf.Text & "', " &
                                    "'" & txt_email.Text & "', " &
                                    "'" & txt_telefone.Text & "');"
                rs = db.Execute(sql)
            Else
                resp = MsgBox("Este username ja está cadastrado! gostaria de sobrescrever os dados? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "atenção")
                If resp = MsgBoxResult.Yes Then
                    sql = "UPDATE clientes SET " &
                        "nome = '" & txt_nome.Text & "', " &
                        "data_nasc = '" & cmb_data_nascimento.Text & "', " &
                        "cep = '" & txt_cep.Text & "', " &
                        "rua = '" & txt_logradouro.Text & "', " &
                        "numero = '" & txt_numero.Text & "', " &
                        "bairro = '" & txt_bairro.Text & "', " &
                        "cidade = '" & txt_cidade.Text & "', " &
                        "uf = '" & txt_uf.Text & "', " &
                        "email = '" & txt_email.Text & "', " &
                        "telefone = '" & txt_telefone.Text & "' " &
                        "WHERE cpf = '" & txt_cpf.Text & "'"

                    rs = db.Execute(sql)
                    MsgBox("dados gravados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "aviso")
                    limpar_dados()
                    carregar_dados()
                End If
                Exit Sub
            End If
            resposta = MsgBox("Cadastro realizado com sucesso!" + vbNewLine +
                                      "Deseja realizar novo cadastro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ATENÇÃO!")
            If resposta = vbYes Then
                ' Limpar os campos
            Else
                Me.Close()
                home.Show()
            End If
        Catch ex As Exception
            MsgBox("Erro ao cadastrar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        'Try
        If Not txt_cep.MaskCompleted Then
                Exit Sub
            Else
                sql = "SELECT * FROM cep WHERE CEP = '" & txt_cep.Text & "';"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    txt_logradouro.Text = rs.Fields(1).Value
                    txt_bairro.Text = rs.Fields(3).Value
                    txt_cidade.Text = rs.Fields(2).Value
                    txt_uf.Text = rs.Fields(4).Value
                Else
                    MsgBox("CEP não encontrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                    If txt_logradouro.Text.Length <> 0 Then
                        txt_logradouro.Text = ""
                        labeu.Text = ""
                        txt_cidade.Text = ""
                        txt_uf.Text = ""
                    End If
                    txt_numero.Select()
                End If
            End If
        'Catch ex As Exception
        ' MsgBox("Falha ao executar a consulta no banco de dados de CEP!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        ' Exit Sub
        'End Try
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
                    sql = "delete from clientes where cpf = '" & aux_usu & "'"
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



    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        btn_cad_func.Text = "SALVAR"
        With dgv_funcionario

            Try
                aux_usu = .CurrentRow.Cells(1).Value
                With .CurrentRow.Selected


                    sql = "Select * from clientes where cpf = '" & aux_usu & "'"
                    rs = db.Execute(sql)

                    txt_cpf.Text = rs.Fields(0).Value
                    txt_nome.Text = rs.Fields(1).Value
                    cmb_data_nascimento.Value = rs.Fields(2).Value
                    txt_cep.Text = rs.Fields(3).Value
                    txt_logradouro.Text = rs.Fields(4).Value
                    txt_numero.Text = rs.Fields(5).Value
                    txt_bairro.Text = rs.Fields(6).Value
                    txt_cidade.Text = rs.Fields(7).Value
                    txt_uf.Text = rs.Fields(8).Value
                    txt_email.Text = rs.Fields(9).Value
                    txt_telefone.Text = rs.Fields(10).Value




                End With
            Catch ex As Exception
                MsgBox("Nenhum usuário selecionado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End Try









        End With
    End Sub
    Sub limpar_dados()

        cmb_data_nascimento.ResetText()
        txt_nome.Clear()
        txt_telefone.Clear()
        txt_email.Clear()
        txt_cep.Clear()
        txt_logradouro.Clear()
        txt_numero.Clear()
        txt_bairro.Clear()
        txt_cidade.Clear()
        txt_uf.Clear()
        txt_cpf.Clear()

    End Sub

    Private Sub frm_cad_pes_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        limpar_dados()
    End Sub

    Private Sub frm_cad_pes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
    End Sub
End Class