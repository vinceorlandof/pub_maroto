<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pedidos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pedidos))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.add_itens = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtg_itens = New System.Windows.Forms.DataGridView()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrição = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorUnitário = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_clientes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Item = New System.Windows.Forms.Label()
        Me.cmb_itens_cardapio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_qtde = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_troco = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_valorpago = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_vtotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.cmb_pagamento = New System.Windows.Forms.ComboBox()
        Me.txt_valor_unit = New System.Windows.Forms.TextBox()
        Me.txt_observacoes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_excluir = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg_itens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 25)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "PEDIDOS DO CLIENTE"
        '
        'add_itens
        '
        Me.add_itens.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.add_itens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_itens.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_itens.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.add_itens.Location = New System.Drawing.Point(533, 244)
        Me.add_itens.Name = "add_itens"
        Me.add_itens.Size = New System.Drawing.Size(137, 30)
        Me.add_itens.TabIndex = 52
        Me.add_itens.Text = "INCLUIR ITEM"
        Me.add_itens.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(819, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 58)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "VOLTAR AO MENU"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.pub_maroto_final.My.Resources.Resources.enfeite_pedidos
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(509, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 141)
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'dtg_itens
        '
        Me.dtg_itens.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.dtg_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_itens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Produto, Me.Descrição, Me.Quantidade, Me.ValorUnitário, Me.ValorTotal})
        Me.dtg_itens.Location = New System.Drawing.Point(17, 329)
        Me.dtg_itens.Name = "dtg_itens"
        Me.dtg_itens.RowHeadersWidth = 51
        Me.dtg_itens.RowTemplate.Height = 24
        Me.dtg_itens.Size = New System.Drawing.Size(932, 164)
        Me.dtg_itens.TabIndex = 58
        '
        'Produto
        '
        Me.Produto.HeaderText = "Produto"
        Me.Produto.MinimumWidth = 8
        Me.Produto.Name = "Produto"
        Me.Produto.Width = 150
        '
        'Descrição
        '
        Me.Descrição.HeaderText = "Descrição"
        Me.Descrição.MinimumWidth = 8
        Me.Descrição.Name = "Descrição"
        Me.Descrição.Width = 200
        '
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Quantidade"
        Me.Quantidade.MinimumWidth = 8
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.Width = 150
        '
        'ValorUnitário
        '
        Me.ValorUnitário.HeaderText = "ValorUnitário"
        Me.ValorUnitário.MinimumWidth = 8
        Me.ValorUnitário.Name = "ValorUnitário"
        Me.ValorUnitário.Width = 150
        '
        'ValorTotal
        '
        Me.ValorTotal.HeaderText = "ValorTotal"
        Me.ValorTotal.MinimumWidth = 8
        Me.ValorTotal.Name = "ValorTotal"
        Me.ValorTotal.Width = 150
        '
        'cmb_clientes
        '
        Me.cmb_clientes.FormattingEnabled = True
        Me.cmb_clientes.Location = New System.Drawing.Point(17, 135)
        Me.cmb_clientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_clientes.Name = "cmb_clientes"
        Me.cmb_clientes.Size = New System.Drawing.Size(352, 24)
        Me.cmb_clientes.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "CLIENTE"
        '
        'Item
        '
        Me.Item.AutoSize = True
        Me.Item.BackColor = System.Drawing.Color.Transparent
        Me.Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Item.Location = New System.Drawing.Point(14, 180)
        Me.Item.Name = "Item"
        Me.Item.Size = New System.Drawing.Size(91, 18)
        Me.Item.TabIndex = 62
        Me.Item.Text = "PRODUTO"
        '
        'cmb_itens_cardapio
        '
        Me.cmb_itens_cardapio.FormattingEnabled = True
        Me.cmb_itens_cardapio.Location = New System.Drawing.Point(17, 200)
        Me.cmb_itens_cardapio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_itens_cardapio.Name = "cmb_itens_cardapio"
        Me.cmb_itens_cardapio.Size = New System.Drawing.Size(352, 24)
        Me.cmb_itens_cardapio.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(201, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "QTDE"
        '
        'cmb_qtde
        '
        Me.cmb_qtde.FormattingEnabled = True
        Me.cmb_qtde.Location = New System.Drawing.Point(204, 268)
        Me.cmb_qtde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_qtde.Name = "cmb_qtde"
        Me.cmb_qtde.Size = New System.Drawing.Size(128, 24)
        Me.cmb_qtde.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(50, 581)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 18)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "TIPO DE PAGAMENTO"
        '
        'txt_troco
        '
        Me.txt_troco.Location = New System.Drawing.Point(617, 602)
        Me.txt_troco.Name = "txt_troco"
        Me.txt_troco.Size = New System.Drawing.Size(142, 22)
        Me.txt_troco.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(613, 581)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 18)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "TROCO"
        '
        'txt_valorpago
        '
        Me.txt_valorpago.Location = New System.Drawing.Point(476, 602)
        Me.txt_valorpago.Name = "txt_valorpago"
        Me.txt_valorpago.Size = New System.Drawing.Size(128, 22)
        Me.txt_valorpago.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(472, 581)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 18)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "VALOR PAGO"
        '
        'txt_vtotal
        '
        Me.txt_vtotal.Location = New System.Drawing.Point(784, 527)
        Me.txt_vtotal.Name = "txt_vtotal"
        Me.txt_vtotal.Size = New System.Drawing.Size(142, 22)
        Me.txt_vtotal.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(780, 506)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 18)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "TOTAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 18)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "VAL. UNITÁRIO"
        '
        'btn_finalizar
        '
        Me.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_finalizar.Location = New System.Drawing.Point(784, 592)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(167, 58)
        Me.btn_finalizar.TabIndex = 75
        Me.btn_finalizar.Text = "finalizar"
        Me.btn_finalizar.UseVisualStyleBackColor = False
        '
        'cmb_pagamento
        '
        Me.cmb_pagamento.FormattingEnabled = True
        Me.cmb_pagamento.Location = New System.Drawing.Point(53, 602)
        Me.cmb_pagamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_pagamento.Name = "cmb_pagamento"
        Me.cmb_pagamento.Size = New System.Drawing.Size(352, 24)
        Me.cmb_pagamento.TabIndex = 76
        '
        'txt_valor_unit
        '
        Me.txt_valor_unit.Location = New System.Drawing.Point(21, 270)
        Me.txt_valor_unit.Name = "txt_valor_unit"
        Me.txt_valor_unit.Size = New System.Drawing.Size(128, 22)
        Me.txt_valor_unit.TabIndex = 77
        '
        'txt_observacoes
        '
        Me.txt_observacoes.Location = New System.Drawing.Point(53, 527)
        Me.txt_observacoes.Name = "txt_observacoes"
        Me.txt_observacoes.Size = New System.Drawing.Size(632, 22)
        Me.txt_observacoes.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 506)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 18)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "OBSERVAÇÕES DO PEDIDO"
        '
        'btn_excluir
        '
        Me.btn_excluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_excluir.Location = New System.Drawing.Point(709, 244)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(170, 30)
        Me.btn_excluir.TabIndex = 80
        Me.btn_excluir.Text = "EXCLUIR ITEM"
        Me.btn_excluir.UseVisualStyleBackColor = False
        '
        'frm_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pub_maroto_final.My.Resources.Resources.estaeregg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1061, 697)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.txt_observacoes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_valor_unit)
        Me.Controls.Add(Me.cmb_pagamento)
        Me.Controls.Add(Me.btn_finalizar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_vtotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_valorpago)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_troco)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_qtde)
        Me.Controls.Add(Me.Item)
        Me.Controls.Add(Me.cmb_itens_cardapio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_clientes)
        Me.Controls.Add(Me.dtg_itens)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.add_itens)
        Me.Controls.Add(Me.Label5)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_comanda"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg_itens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents add_itens As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtg_itens As DataGridView
    Friend WithEvents cmb_clientes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Item As Label
    Friend WithEvents cmb_itens_cardapio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_qtde As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_troco As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_valorpago As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_vtotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Produto As DataGridViewTextBoxColumn
    Friend WithEvents Descrição As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents ValorUnitário As DataGridViewTextBoxColumn
    Friend WithEvents ValorTotal As DataGridViewTextBoxColumn
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents cmb_pagamento As ComboBox
    Friend WithEvents txt_valor_unit As TextBox
    Friend WithEvents txt_observacoes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_excluir As Button
End Class
