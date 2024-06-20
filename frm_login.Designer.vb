<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_dev = New System.Windows.Forms.Button()
        Me.chk_visu = New System.Windows.Forms.CheckBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(72, 240)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(267, 26)
        Me.txt_usuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(69, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(69, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Senha"
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_sair.Location = New System.Drawing.Point(579, 28)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(125, 39)
        Me.btn_sair.TabIndex = 5
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'btn_dev
        '
        Me.btn_dev.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dev.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_dev.Location = New System.Drawing.Point(79, 518)
        Me.btn_dev.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_dev.Name = "btn_dev"
        Me.btn_dev.Size = New System.Drawing.Size(180, 81)
        Me.btn_dev.TabIndex = 6
        Me.btn_dev.Text = "Desenvolvedores"
        Me.btn_dev.UseVisualStyleBackColor = False
        '
        'chk_visu
        '
        Me.chk_visu.AutoSize = True
        Me.chk_visu.BackColor = System.Drawing.Color.Transparent
        Me.chk_visu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_visu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.chk_visu.Location = New System.Drawing.Point(72, 435)
        Me.chk_visu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_visu.Name = "chk_visu"
        Me.chk_visu.Size = New System.Drawing.Size(202, 30)
        Me.chk_visu.TabIndex = 7
        Me.chk_visu.Text = "Visualizar Senha"
        Me.chk_visu.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(72, 368)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(267, 26)
        Me.txt_senha.TabIndex = 8
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.pub_maroto_final.My.Resources.Resources.leprechaun
        Me.PictureBox1.Location = New System.Drawing.Point(315, 307)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 251)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.BackgroundImage = Global.pub_maroto_final.My.Resources.Resources.pub_login_img
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(731, 750)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.chk_visu)
        Me.Controls.Add(Me.btn_dev)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_usuario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PUB MAROTO -Início"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_dev As Button
    Friend WithEvents chk_visu As CheckBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
