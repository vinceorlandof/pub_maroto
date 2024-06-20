Public Class frm_cad_prod
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub btn_cad_func_Click(sender As Object, e As EventArgs) Handles btn_cad_func.Click
        If txt_nome_prod.Text = "" Or txt_desc_prod.Text = "" Or txt_cod_prod.Text = "" Or txt_val_unit.Text = "" Or txt_qtd.Text = "" Then

            MsgBox("Preencha Todos os Campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        End If

        sql = "select * from estoque where nome_produto = '" & txt_nome_prod.Text & "' OR codigo_produto = '" & txt_cod_prod.Text & "' "
        rs = db.Execute(sql)

        If rs.EOF = False Then
            MsgBox("Produto Já Cadastrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Else
            Dim valor_unit As String = txt_val_unit.Text.Replace(",", ".")
            sql = "insert into estoque (codigo_produto, nome_produto, descricao_produto, valor_unitario, estoque) values ('" & txt_cod_prod.Text & "', '" & txt_nome_prod.Text & "', '" & txt_desc_prod.Text & "', " & valor_unit & ", '" & txt_qtd.Text & "')"
            db.Execute(sql)
            MsgBox("Produto Cadastrado com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")

            txt_nome_prod.Text = ""
            txt_desc_prod.Text = ""
            txt_cod_prod.Text = ""
            txt_val_unit.Text = ""
            txt_qtd.Text = ""

        End If
    End Sub

    Private Sub frm_cad_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub
End Class