<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cad_prod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_prod))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_cad_func = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_nome_prod = New System.Windows.Forms.TextBox()
        Me.txt_val_unit = New System.Windows.Forms.MaskedTextBox()
        Me.txt_qtd = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_desc_prod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cod_prod = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(580, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CADASTRO PRODUTOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(37, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 18)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "PRODUTO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(206, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 18)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "QUANTIDADE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(35, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 18)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "VALOR UNITÁRIO"
        '
        'btn_cad_func
        '
        Me.btn_cad_func.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_cad_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cad_func.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_func.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_cad_func.Location = New System.Drawing.Point(576, 379)
        Me.btn_cad_func.Name = "btn_cad_func"
        Me.btn_cad_func.Size = New System.Drawing.Size(122, 65)
        Me.btn_cad_func.TabIndex = 49
        Me.btn_cad_func.Text = "CADASTRAR"
        Me.btn_cad_func.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(38, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 65)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "VOLTAR AO MENU"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_nome_prod
        '
        Me.txt_nome_prod.Location = New System.Drawing.Point(40, 150)
        Me.txt_nome_prod.Multiline = True
        Me.txt_nome_prod.Name = "txt_nome_prod"
        Me.txt_nome_prod.Size = New System.Drawing.Size(396, 30)
        Me.txt_nome_prod.TabIndex = 51
        '
        'txt_val_unit
        '
        Me.txt_val_unit.Location = New System.Drawing.Point(38, 314)
        Me.txt_val_unit.Name = "txt_val_unit"
        Me.txt_val_unit.Size = New System.Drawing.Size(135, 22)
        Me.txt_val_unit.TabIndex = 52
        '
        'txt_qtd
        '
        Me.txt_qtd.Location = New System.Drawing.Point(209, 314)
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.Size = New System.Drawing.Size(108, 22)
        Me.txt_qtd.TabIndex = 53
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.pub_maroto_final.My.Resources.Resources.enfeite_pedidos
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(339, 338)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 106)
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'txt_desc_prod
        '
        Me.txt_desc_prod.Location = New System.Drawing.Point(40, 241)
        Me.txt_desc_prod.Name = "txt_desc_prod"
        Me.txt_desc_prod.Size = New System.Drawing.Size(396, 22)
        Me.txt_desc_prod.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(37, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 18)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "DESCRIÇÃO PRODUTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(518, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "ID PRODUTO"
        '
        'txt_cod_prod
        '
        Me.txt_cod_prod.Location = New System.Drawing.Point(521, 182)
        Me.txt_cod_prod.Name = "txt_cod_prod"
        Me.txt_cod_prod.Size = New System.Drawing.Size(104, 22)
        Me.txt_cod_prod.TabIndex = 58
        '
        'frm_cad_prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pub_maroto_final.My.Resources.Resources.estaeregg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(761, 469)
        Me.Controls.Add(Me.txt_cod_prod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_desc_prod)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_qtd)
        Me.Controls.Add(Me.txt_val_unit)
        Me.Controls.Add(Me.txt_nome_prod)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_cad_func)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cad_prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cad_prod"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btn_cad_func As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_nome_prod As TextBox
    Friend WithEvents txt_val_unit As MaskedTextBox
    Friend WithEvents txt_qtd As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_desc_prod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cod_prod As TextBox
End Class
