<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cad_pes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_pes))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_data_nascimento = New System.Windows.Forms.DateTimePicker()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_logradouro = New System.Windows.Forms.TextBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.btn_cad_func = New System.Windows.Forms.Button()
        Me.btn_vtr_dev = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.labeu = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.vsdf = New System.Windows.Forms.Label()
        Me.dgv_funcionario = New System.Windows.Forms.DataGridView()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        CType(Me.dgv_funcionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(82, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cadastro De Clientes"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(87, 261)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(131, 22)
        Me.txt_cpf.TabIndex = 2
        '
        'cmb_data_nascimento
        '
        Me.cmb_data_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nascimento.Location = New System.Drawing.Point(236, 261)
        Me.cmb_data_nascimento.Name = "cmb_data_nascimento"
        Me.cmb_data_nascimento.Size = New System.Drawing.Size(123, 22)
        Me.cmb_data_nascimento.TabIndex = 4
        '
        'txt_telefone
        '
        Me.txt_telefone.Location = New System.Drawing.Point(91, 310)
        Me.txt_telefone.Mask = "(99) 00000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(131, 22)
        Me.txt_telefone.TabIndex = 6
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(239, 310)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(123, 22)
        Me.txt_email.TabIndex = 9
        '
        'txt_logradouro
        '
        Me.txt_logradouro.Location = New System.Drawing.Point(579, 218)
        Me.txt_logradouro.Name = "txt_logradouro"
        Me.txt_logradouro.Size = New System.Drawing.Size(174, 22)
        Me.txt_logradouro.TabIndex = 13
        '
        'txt_numero
        '
        Me.txt_numero.AcceptsReturn = True
        Me.txt_numero.Location = New System.Drawing.Point(430, 261)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(131, 22)
        Me.txt_numero.TabIndex = 15
        '
        'txt_bairro
        '
        Me.txt_bairro.Location = New System.Drawing.Point(579, 261)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(131, 22)
        Me.txt_bairro.TabIndex = 19
        '
        'txt_cidade
        '
        Me.txt_cidade.Location = New System.Drawing.Point(430, 310)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(131, 22)
        Me.txt_cidade.TabIndex = 21
        '
        'txt_uf
        '
        Me.txt_uf.Location = New System.Drawing.Point(579, 310)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(92, 22)
        Me.txt_uf.TabIndex = 23
        '
        'btn_cad_func
        '
        Me.btn_cad_func.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_cad_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cad_func.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_func.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_cad_func.Location = New System.Drawing.Point(322, 346)
        Me.btn_cad_func.Name = "btn_cad_func"
        Me.btn_cad_func.Size = New System.Drawing.Size(171, 30)
        Me.btn_cad_func.TabIndex = 27
        Me.btn_cad_func.Text = "CADASTRAR"
        Me.btn_cad_func.UseVisualStyleBackColor = False
        '
        'btn_vtr_dev
        '
        Me.btn_vtr_dev.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_vtr_dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vtr_dev.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vtr_dev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_vtr_dev.Location = New System.Drawing.Point(625, 24)
        Me.btn_vtr_dev.Name = "btn_vtr_dev"
        Me.btn_vtr_dev.Size = New System.Drawing.Size(184, 28)
        Me.btn_vtr_dev.TabIndex = 28
        Me.btn_vtr_dev.Text = "Voltar ao Menu"
        Me.btn_vtr_dev.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(431, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 18)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "N°"
        '
        'labeu
        '
        Me.labeu.AutoSize = True
        Me.labeu.BackColor = System.Drawing.Color.Transparent
        Me.labeu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.labeu.Location = New System.Drawing.Point(575, 240)
        Me.labeu.Name = "labeu"
        Me.labeu.Size = New System.Drawing.Size(54, 18)
        Me.labeu.TabIndex = 30
        Me.labeu.Text = "Bairro"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(428, 290)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 18)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Cidade"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(427, 198)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 18)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "CEP"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(88, 290)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 18)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Telefone"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(232, 240)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(164, 18)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Data De Nascimento"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(243, 290)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 18)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "E-mail"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(88, 240)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 18)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "CPF"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(575, 290)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 18)
        Me.Label24.TabIndex = 39
        Me.Label24.Text = "UF"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(575, 197)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(95, 18)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Logradouro"
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(430, 218)
        Me.txt_cep.Mask = "00000-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(131, 22)
        Me.txt_cep.TabIndex = 40
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(88, 218)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(272, 22)
        Me.txt_nome.TabIndex = 41
        '
        'vsdf
        '
        Me.vsdf.AutoSize = True
        Me.vsdf.BackColor = System.Drawing.Color.Transparent
        Me.vsdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vsdf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.vsdf.Location = New System.Drawing.Point(89, 198)
        Me.vsdf.Name = "vsdf"
        Me.vsdf.Size = New System.Drawing.Size(53, 18)
        Me.vsdf.TabIndex = 42
        Me.vsdf.Text = "Nome"
        '
        'dgv_funcionario
        '
        Me.dgv_funcionario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.dgv_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_funcionario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nome, Me.CPF, Me.Telefone, Me.Email})
        Me.dgv_funcionario.Location = New System.Drawing.Point(56, 389)
        Me.dgv_funcionario.Name = "dgv_funcionario"
        Me.dgv_funcionario.RowHeadersWidth = 51
        Me.dgv_funcionario.RowTemplate.Height = 24
        Me.dgv_funcionario.Size = New System.Drawing.Size(728, 244)
        Me.dgv_funcionario.TabIndex = 43
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.MinimumWidth = 8
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 150
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.MinimumWidth = 8
        Me.CPF.Name = "CPF"
        Me.CPF.Width = 150
        '
        'Telefone
        '
        Me.Telefone.HeaderText = "Telefone"
        Me.Telefone.MinimumWidth = 8
        Me.Telefone.Name = "Telefone"
        Me.Telefone.Width = 150
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.MinimumWidth = 8
        Me.Email.Name = "Email"
        Me.Email.Width = 150
        '
        'btn_excluir
        '
        Me.btn_excluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_excluir.Location = New System.Drawing.Point(540, 346)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(170, 30)
        Me.btn_excluir.TabIndex = 44
        Me.btn_excluir.Text = "EXCLUIR"
        Me.btn_excluir.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_editar.Location = New System.Drawing.Point(131, 346)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(171, 30)
        Me.btn_editar.TabIndex = 45
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'frm_cad_pes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pub_maroto_final.My.Resources.Resources.leprechaun_cad_pes
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(843, 679)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.dgv_funcionario)
        Me.Controls.Add(Me.vsdf)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.labeu)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btn_vtr_dev)
        Me.Controls.Add(Me.btn_cad_func)
        Me.Controls.Add(Me.txt_uf)
        Me.Controls.Add(Me.txt_cidade)
        Me.Controls.Add(Me.txt_bairro)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.txt_logradouro)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.cmb_data_nascimento)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cad_pes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cad_pes"
        CType(Me.dgv_funcionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents cmb_data_nascimento As DateTimePicker
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_logradouro As TextBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents btn_cad_func As Button
    Friend WithEvents btn_vtr_dev As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents labeu As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents vsdf As Label
    Friend WithEvents dgv_funcionario As DataGridView
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents Telefone As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents btn_excluir As Button
    Friend WithEvents btn_editar As Button
End Class
