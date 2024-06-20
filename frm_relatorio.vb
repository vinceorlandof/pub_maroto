Public Class frm_relatorio
    Dim carregado As Boolean = False
    Private Sub ESTOQUE_Click(sender As Object, e As EventArgs) Handles ESTOQUE.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub frm_relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        Try
            cont = 0
            sql = "SELECT * FROM estoque ORDER BY nome_produto ASC"
            rs = db.Execute(sql)
            With dgv_estoque
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    .Rows(cont).Tag = rs.Fields(0).Value
                    rs.MoveNext()
                Loop
            End With
            carregado = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_estoque_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_estoque.CellValueChanged
        Try
            If carregado = True Then


                With dgv_estoque
                    sql = "select * from estoque where nome_produto = '" & .CurrentRow.Cells(0).Value & "' "
                    rs = db.Execute(sql)
                    Dim aux_cod As String = rs.Fields(0).Value

                    Dim nome As String = .CurrentRow.Cells(0).Value
                    Dim preco As String = .CurrentRow.Cells(1).Value.ToString().Replace(",", ".")
                    Dim estoque As Integer = Integer.Parse(.CurrentRow.Cells(2).Value)

                    sql = "UPDATE estoque SET nome_produto = '" & nome & "', valor_unitario = " & preco & ", estoque = " & estoque & " WHERE codigo_produto = '" & aux_cod & "' "
                    rs = db.Execute(sql)
                    MsgBox("Dados atualizados com sucesso!")
                End With
            End If
        Catch ex As Exception
            MsgBox(sql)
        End Try
    End Sub
End Class