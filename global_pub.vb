Module global_pub
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, id_cliente As String
    Public database As String = Application.StartupPath & "\database\db_pub_maroto_final.mdb"
    Public folder, cpf_unmask, telefone_unmask, photoname As String
    Public resposta, aux_usu, resp As String
    Public last_id, id_pessoa, id_funcionario, id_pedido, id_item As Integer
    Public qtdeitens As Integer
    Public valort_item, valor_unitario, total, vtotal, troco As Decimal
    Public cont, cont_itens As Integer
    Public cargo As String
    Public totalQtd As Integer = 0


    Sub conectar_banco()
        Try
            db = New ADODB.Connection
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & database & ";")
        Catch ex As Exception
            MsgBox("Falha na conexão ao banco de dados! Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_dados()
        ' Try
        conectar_banco()

        With frm_cad_funcionarios.dgv_funcionario
            sql = "select * from funcionarios"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields("nome").Value, rs.Fields("usuario").Value, rs.Fields("cargo").Value)
                rs.MoveNext()
            Loop

        End With


        With frm_cad_pes.dgv_funcionario
            sql = "select * from clientes"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields("nome").Value, rs.Fields("cpf").Value, rs.Fields("telefone").Value, rs.Fields("email").Value)
                rs.MoveNext()
            Loop

        End With



        '  Catch ex As Exception
        'MsgBox("erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "atenção")
        '  End Try

    End Sub
    Sub carregar_clientes_pedidos()
        'Try
        frm_pedidos.cmb_clientes.Items.Add("Selecionar cliente")
        sql = "SELECT cpf, nome FROM clientes"
        rs = db.Execute(sql)
        rs.MoveFirst()
        While rs.EOF = False
            frm_pedidos.cmb_clientes.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        End While
        frm_pedidos.cmb_clientes.SelectedIndex = 0
        ' Catch ex As Exception
        '  MsgBox("Falha ao carregar clientes!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        ' Exit Sub
        ' End Try
    End Sub

    Sub carregar_itens_pedidos()
        Try
            frm_pedidos.cmb_itens_cardapio.Items.Add("Selecionar Item")
            sql = "SELECT * FROM estoque;"
            rs = db.Execute(sql)
            rs.MoveFirst()
            While rs.EOF = False
                frm_pedidos.cmb_itens_cardapio.Items.Add(rs.Fields(1).Value)
                rs.MoveNext()
            End While
            frm_pedidos.cmb_itens_cardapio.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Falha ao carregar itens!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Exit Sub
        End Try
    End Sub

   
    Sub verificaItemGratis()
        With frm_pedidos
            totalQtd = 0
            For Each row As DataGridViewRow In .dtg_itens.Rows
                If Not row.IsNewRow AndAlso Not row.Cells("Quantidade").Value Is Nothing Then
                    totalQtd += Convert.ToInt32(row.Cells("Quantidade").Value)
                End If
            Next

            Dim aCada As Integer = 10
            Dim gratis As Integer = totalQtd \ aCada

            if gratis > 0 Then
                MsgBox("O Cliente tem direito a " & gratis & " cervejas gratis")
            end if  

           
        End With

    End Sub

End Module
