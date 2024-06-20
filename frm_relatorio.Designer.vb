<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_relatorio))
        Me.ESTOQUE = New System.Windows.Forms.Button()
        Me.dgv_estoque = New System.Windows.Forms.DataGridView()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor_Unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Em_Estoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgv_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ESTOQUE
        '
        Me.ESTOQUE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.ESTOQUE.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESTOQUE.ForeColor = System.Drawing.Color.Black
        Me.ESTOQUE.Location = New System.Drawing.Point(135, 158)
        Me.ESTOQUE.Name = "ESTOQUE"
        Me.ESTOQUE.Size = New System.Drawing.Size(482, 130)
        Me.ESTOQUE.TabIndex = 0
        Me.ESTOQUE.Text = "LISTAGEM ESTOQUE"
        Me.ESTOQUE.UseVisualStyleBackColor = False
        '
        'dgv_estoque
        '
        Me.dgv_estoque.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.dgv_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_estoque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nome, Me.Valor_Unitario, Me.Em_Estoque})
        Me.dgv_estoque.Location = New System.Drawing.Point(71, 305)
        Me.dgv_estoque.Name = "dgv_estoque"
        Me.dgv_estoque.RowHeadersWidth = 51
        Me.dgv_estoque.RowTemplate.Height = 24
        Me.dgv_estoque.Size = New System.Drawing.Size(624, 154)
        Me.dgv_estoque.TabIndex = 1
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.MinimumWidth = 6
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 125
        '
        'Valor_Unitario
        '
        Me.Valor_Unitario.HeaderText = "Valor_Unitario"
        Me.Valor_Unitario.MinimumWidth = 6
        Me.Valor_Unitario.Name = "Valor_Unitario"
        Me.Valor_Unitario.Width = 125
        '
        'Em_Estoque
        '
        Me.Em_Estoque.HeaderText = "Em_Estoque"
        Me.Em_Estoque.MinimumWidth = 6
        Me.Em_Estoque.Name = "Em_Estoque"
        Me.Em_Estoque.Width = 125
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(303, 480)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 58)
        Me.Button3.TabIndex = 56
        Me.Button3.Text = "VOLTAR AO MENU"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frm_relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pub_maroto_final.My.Resources.Resources.leprechaun_cad_pes
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(772, 621)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgv_estoque)
        Me.Controls.Add(Me.ESTOQUE)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_relatorio"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_relatorio"
        CType(Me.dgv_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ESTOQUE As Button
    Friend WithEvents dgv_estoque As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Valor_Unitario As DataGridViewTextBoxColumn
    Friend WithEvents Em_Estoque As DataGridViewTextBoxColumn
End Class
