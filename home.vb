Public Class home
    Private Sub SAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAIRToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub PEDIDOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PEDIDOSToolStripMenuItem.Click
        Me.Hide()
        frm_pedidos.Show()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Me.Hide()
        frm_cad_funcionarios.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.Hide()
        frm_cad_pes.Show()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        Me.Hide()
        frm_cad_prod.Show()
    End Sub

    Private Sub ESTOQUEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTOQUEToolStripMenuItem.Click
        Me.Hide()
        frm_relatorio.Show()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cargo = "Barman" Then
            FuncionáriosToolStripMenuItem.Visible = False
            ESTOQUEToolStripMenuItem.Visible = False
            ProdutosToolStripMenuItem.Visible = False
        End If

        If cargo = "Gerente" Then
            FuncionáriosToolStripMenuItem.Visible = False
        End If
    End Sub
End Class