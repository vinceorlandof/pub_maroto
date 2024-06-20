<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cad_funcionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_funcionarios))
        Me.txt_nome_funcionario = New System.Windows.Forms.TextBox()
        Me.txt_login_funcionario = New System.Windows.Forms.TextBox()
        Me.txt_senha_funcionario = New System.Windows.Forms.TextBox()
        Me.txt_confirma_senha = New System.Windows.Forms.TextBox()
        Me.cmb_cargo_funcionario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_salvar_funcionario = New System.Windows.Forms.Button()
        Me.btn_vtr_dev = New System.Windows.Forms.Button()
        Me.dgv_funcionario = New System.Windows.Forms.DataGridView()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuário = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        CType(Me.dgv_funcionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nome_funcionario
        '
        Me.txt_nome_funcionario.Location = New System.Drawing.Point(91, 241)
        Me.txt_nome_funcionario.Name = "txt_nome_funcionario"
        Me.txt_nome_funcionario.Size = New System.Drawing.Size(295, 22)
        Me.txt_nome_funcionario.TabIndex = 0
        '
        'txt_login_funcionario
        '
        Me.txt_login_funcionario.Location = New System.Drawing.Point(91, 317)
        Me.txt_login_funcionario.Name = "txt_login_funcionario"
        Me.txt_login_funcionario.Size = New System.Drawing.Size(155, 22)
        Me.txt_login_funcionario.TabIndex = 1
        '
        'txt_senha_funcionario
        '
        Me.txt_senha_funcionario.Location = New System.Drawing.Point(252, 317)
        Me.txt_senha_funcionario.Name = "txt_senha_funcionario"
        Me.txt_senha_funcionario.Size = New System.Drawing.Size(209, 22)
        Me.txt_senha_funcionario.TabIndex = 2
        '
        'txt_confirma_senha
        '
        Me.txt_confirma_senha.Location = New System.Drawing.Point(467, 317)
        Me.txt_confirma_senha.Name = "txt_confirma_senha"
        Me.txt_confirma_senha.Size = New System.Drawing.Size(209, 22)
        Me.txt_confirma_senha.TabIndex = 3
        '
        'cmb_cargo_funcionario
        '
        Me.cmb_cargo_funcionario.FormattingEnabled = True
        Me.cmb_cargo_funcionario.Items.AddRange(New Object() {"Barman", "Gerente", "Administrador"})
        Me.cmb_cargo_funcionario.Location = New System.Drawing.Point(412, 239)
        Me.cmb_cargo_funcionario.Name = "cmb_cargo_funcionario"
        Me.cmb_cargo_funcionario.Size = New System.Drawing.Size(162, 24)
        Me.cmb_cargo_funcionario.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(88, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NOME FUNCIONÁRIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(408, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CARGO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(88, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "USUÁRIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(248, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "SENHA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(464, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CONFIRMAR SENHA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(87, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "(Min. 6 caracteres   Max. 10)"
        '
        'btn_salvar_funcionario
        '
        Me.btn_salvar_funcionario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_salvar_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar_funcionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_salvar_funcionario.Location = New System.Drawing.Point(402, 407)
        Me.btn_salvar_funcionario.Name = "btn_salvar_funcionario"
        Me.btn_salvar_funcionario.Size = New System.Drawing.Size(132, 65)
        Me.btn_salvar_funcionario.TabIndex = 11
        Me.btn_salvar_funcionario.Text = "CADASTRAR"
        Me.btn_salvar_funcionario.UseVisualStyleBackColor = False
        '
        'btn_vtr_dev
        '
        Me.btn_vtr_dev.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_vtr_dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vtr_dev.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vtr_dev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_vtr_dev.Location = New System.Drawing.Point(92, 407)
        Me.btn_vtr_dev.Name = "btn_vtr_dev"
        Me.btn_vtr_dev.Size = New System.Drawing.Size(122, 65)
        Me.btn_vtr_dev.TabIndex = 12
        Me.btn_vtr_dev.Text = "Voltar ao Menu"
        Me.btn_vtr_dev.UseVisualStyleBackColor = False
        '
        'dgv_funcionario
        '
        Me.dgv_funcionario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.dgv_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_funcionario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nome, Me.Usuário, Me.Cargo})
        Me.dgv_funcionario.Location = New System.Drawing.Point(165, 490)
        Me.dgv_funcionario.Name = "dgv_funcionario"
        Me.dgv_funcionario.RowHeadersWidth = 51
        Me.dgv_funcionario.RowTemplate.Height = 24
        Me.dgv_funcionario.Size = New System.Drawing.Size(447, 202)
        Me.dgv_funcionario.TabIndex = 13
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.MinimumWidth = 8
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 150
        '
        'Usuário
        '
        Me.Usuário.HeaderText = "Usuário"
        Me.Usuário.MinimumWidth = 8
        Me.Usuário.Name = "Usuário"
        Me.Usuário.Width = 150
        '
        'Cargo
        '
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.MinimumWidth = 8
        Me.Cargo.Name = "Cargo"
        Me.Cargo.Width = 150
        '
        'btn_excluir
        '
        Me.btn_excluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_excluir.Location = New System.Drawing.Point(568, 407)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(122, 65)
        Me.btn_excluir.TabIndex = 14
        Me.btn_excluir.Text = "EXCLUIR"
        Me.btn_excluir.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_editar.Location = New System.Drawing.Point(252, 407)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(122, 65)
        Me.btn_editar.TabIndex = 15
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'frm_cad_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pub_maroto_final.My.Resources.Resources.leprechaun_cad_pes
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(778, 789)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.dgv_funcionario)
        Me.Controls.Add(Me.btn_vtr_dev)
        Me.Controls.Add(Me.btn_salvar_funcionario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_cargo_funcionario)
        Me.Controls.Add(Me.txt_confirma_senha)
        Me.Controls.Add(Me.txt_senha_funcionario)
        Me.Controls.Add(Me.txt_login_funcionario)
        Me.Controls.Add(Me.txt_nome_funcionario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cad_funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cad_funcionarios"
        CType(Me.dgv_funcionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nome_funcionario As TextBox
    Friend WithEvents txt_login_funcionario As TextBox
    Friend WithEvents txt_senha_funcionario As TextBox
    Friend WithEvents txt_confirma_senha As TextBox
    Friend WithEvents cmb_cargo_funcionario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_salvar_funcionario As Button
    Friend WithEvents btn_vtr_dev As Button
    Friend WithEvents dgv_funcionario As DataGridView
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Usuário As DataGridViewTextBoxColumn
    Friend WithEvents Cargo As DataGridViewTextBoxColumn
    Friend WithEvents btn_excluir As Button
    Friend WithEvents btn_editar As Button
End Class
