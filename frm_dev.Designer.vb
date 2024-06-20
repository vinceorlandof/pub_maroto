<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_dev
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_dev))
        Me.btn_sair_dev = New System.Windows.Forms.Button()
        Me.btn_vtr_dev = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_sair_dev
        '
        Me.btn_sair_dev.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_sair_dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair_dev.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair_dev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_sair_dev.Location = New System.Drawing.Point(450, 414)
        Me.btn_sair_dev.Name = "btn_sair_dev"
        Me.btn_sair_dev.Size = New System.Drawing.Size(122, 65)
        Me.btn_sair_dev.TabIndex = 6
        Me.btn_sair_dev.Text = "Sair"
        Me.btn_sair_dev.UseVisualStyleBackColor = False
        '
        'btn_vtr_dev
        '
        Me.btn_vtr_dev.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_vtr_dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vtr_dev.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vtr_dev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_vtr_dev.Location = New System.Drawing.Point(70, 414)
        Me.btn_vtr_dev.Name = "btn_vtr_dev"
        Me.btn_vtr_dev.Size = New System.Drawing.Size(122, 65)
        Me.btn_vtr_dev.TabIndex = 7
        Me.btn_vtr_dev.Text = "Voltar ao Login"
        Me.btn_vtr_dev.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(56, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(533, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Vicente Orlando Fresillo | RA: 1680482321041"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(78, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(494, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Jonatas A. Gouveia | RA:1680482321029"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.pub_maroto_final.My.Resources.Resources.Iconka_Lucky_Leprechaun_Leprechaun
        Me.PictureBox1.Location = New System.Drawing.Point(46, 521)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frm_dev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.pub_maroto_final.My.Resources.Resources.pub_login_img
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(650, 600)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_vtr_dev)
        Me.Controls.Add(Me.btn_sair_dev)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_dev"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_dev"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_sair_dev As Button
    Friend WithEvents btn_vtr_dev As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
