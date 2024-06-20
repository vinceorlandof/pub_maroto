Public Class frm_pedidos
    Private Sub frm_comanda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_clientes_pedidos()
        carregar_itens_pedidos()
        For cont = 1 To 20
            cmb_qtde.Items.Add(cont)
        Next
        cmb_qtde.SelectedIndex = 0
        cont_itens = 1
        vtotal = 0
        With cmb_pagamento
            .Items.Add("Selecionar")
            .Items.Add("Dinheiro")
            .Items.Add("Cartão de Débito")
            .Items.Add("Cartão de Crédito")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub add_itens_Click(sender As Object, e As EventArgs) Handles add_itens.Click
        qtdeitens = Convert.ToInt32(cmb_qtde.Text)
        total = qtdeitens * valor_unitario
        dtg_itens.Rows.Add(cont_itens, cmb_itens_cardapio.Text, cmb_qtde.Text, valor_unitario, total)
        cont_itens += 1
        vtotal = 0
        For Each colunas As DataGridViewRow In dtg_itens.Rows
            vtotal = vtotal + colunas.Cells(4).Value
        Next
        txt_vtotal.Text = vtotal.ToString("R$ ##,###.00")
        cmb_qtde.SelectedIndex = 0

        verificaItemGratis()
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        sql = "SELECT * from clientes"
        rs = db.Execute(sql)
        rs.MoveFirst()

        While rs.Fields(1).Value <> cmb_clientes.Text
            rs.MoveNext()
        End While
        id_cliente = rs.Fields(0).Value

        sql = "INSERT INTO pedidos (id_cliente, id_funcionario, data, valor_total, observacoes, forma_pagamento, pedido_pronto) VALUES ('" & id_cliente & "', " & id_funcionario & ", '" & Date.Today & "', '" & vtotal & "', '" & txt_observacoes.Text & "', '" & cmb_pagamento.Text & "', 0)"
        rs = db.Execute(sql)

        sql = "SELECT TOP 1 * FROM pedidos ORDER BY id DESC"
        rs = db.Execute(sql)

        id_pedido = rs.Fields(0).Value
        cont = 0

        For Each row As DataGridViewRow In dtg_itens.Rows
            If Not row.IsNewRow Then ' Ignorar a linha "nova" (adicionar nova linha) do DataGridView
                sql = "SELECT * FROM estoque WHERE nome_produto = '" & row.Cells(1).Value & "' "
                rs = db.Execute(sql)
                id_item = rs.Fields(0).Value
                valor_unitario = rs.Fields(3).Value
                qtdeitens = Convert.ToInt32(row.Cells(2).Value)
                valort_item = qtdeitens * valor_unitario
                Dim novo_estoque As String = rs.Fields(4).Value - qtdeitens
                sql = "UPDATE estoque SET estoque = " & novo_estoque & " WHERE codigo_produto = '" & id_item & "' "
                rs = db.Execute(sql)
                sql = "INSERT INTO itens_pedido (id_item, id_pedido, quantidade, valor_final_item) VALUES (" & id_item & ", " & id_pedido & ", " & qtdeitens & ", '" & valort_item & "')"
                db.Execute(sql)
                cont += 1
            End If
        Next
        MsgBox("Dados salvos com sucesso!")

        txt_valorpago.Enabled = True
        txt_troco.Enabled = True

        cmb_clientes.SelectedIndex = 0
        cmb_itens_cardapio.SelectedIndex = 0
        cmb_qtde.SelectedIndex = 0
        txt_valor_unit.Clear()
        dtg_itens.Rows.Clear()
        txt_vtotal.Clear()
        cmb_pagamento.SelectedIndex = 0
        txt_valorpago.Clear()
        txt_troco.Clear()
        txt_observacoes.Clear()

    End Sub

    Private Sub cmb_itens_cardapio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_itens_cardapio.SelectedValueChanged
        If cmb_itens_cardapio.Text = "Selecionar Item" Then
            Exit Sub
        Else
            sql = "SELECT * FROM estoque WHERE nome_produto = '" & cmb_itens_cardapio.Text & "'"
            rs = db.Execute(sql)
            valor_unitario = rs.Fields(3).Value
            If cmb_itens_cardapio.Text = "Selecionar Item" Then
                txt_valor_unit.Clear()
            Else
                txt_valor_unit.Text = "R$ " & rs.Fields(3).Value
            End If
        End If
    End Sub
    Private Sub txt_valorpago_TextChanged(sender As Object, e As EventArgs) Handles txt_valorpago.TextChanged
        If txt_valorpago.TextLength > 0 Then
            troco = Convert.ToInt32(txt_valorpago.Text) - vtotal
            txt_troco.Text = troco.ToString("R$ ##,###.00")
        Else
            txt_troco.Text = "R$ 0,00"
        End If
    End Sub

    Private Sub cmb_pagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_pagamento.SelectedIndexChanged
        If cmb_pagamento.SelectedIndex = 0 Then
            txt_valorpago.Enabled = True
            txt_troco.Enabled = True
        End If

        If cmb_pagamento.SelectedIndex = 1 Then
            txt_valorpago.Enabled = True
            txt_troco.Enabled = True
        End If

        If cmb_pagamento.SelectedIndex = 2 Then
            txt_valorpago.Enabled = False
            txt_troco.Enabled = False
            txt_valorpago.Clear()
            txt_troco.Clear()
        End If

        If cmb_pagamento.SelectedIndex = 3 Then
            txt_valorpago.Enabled = False
            txt_troco.Enabled = False
            txt_valorpago.Clear()
            txt_troco.Clear()
        End If
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        With dtg_itens
            ' Try

            aux_usu = .CurrentRow.Cells(1).Value

            If .CurrentRow.Cells(1).Value = "" Then
                MsgBox("Nenhum produto selecionado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

            Else
                resp = MsgBox("Deseja apagar o produto: '" & .CurrentRow.Cells(1).Value & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                If resp = MsgBoxResult.Yes Then
                    .Rows.Remove(.CurrentRow)
                    MsgBox("Produto excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    carregar_dados()
                    txt_vtotal.Clear()
                End If
            End If

            'Catch ex As Exception
            'MsgBox("Erro ao excluir dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            ' End Try

        End With
    End Sub
End Class