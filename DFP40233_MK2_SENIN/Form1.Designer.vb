<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblMaklumat = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblNegeri = New System.Windows.Forms.Label()
        Me.lblJantina = New System.Windows.Forms.Label()
        Me.lblKaedah = New System.Windows.Forms.Label()
        Me.lblPerisa = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.cboNegeri = New System.Windows.Forms.ComboBox()
        Me.rdoLelaki = New System.Windows.Forms.RadioButton()
        Me.rdoPerempuan = New System.Windows.Forms.RadioButton()
        Me.rdoCashless = New System.Windows.Forms.RadioButton()
        Me.rdoCash = New System.Windows.Forms.RadioButton()
        Me.chkStrawberi = New System.Windows.Forms.CheckBox()
        Me.chkCoklat = New System.Windows.Forms.CheckBox()
        Me.chkPisang = New System.Windows.Forms.CheckBox()
        Me.chkKopi = New System.Windows.Forms.CheckBox()
        Me.chkMilo = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnRead = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaklumat
        '
        Me.lblMaklumat.AutoSize = True
        Me.lblMaklumat.Location = New System.Drawing.Point(279, 25)
        Me.lblMaklumat.Name = "lblMaklumat"
        Me.lblMaklumat.Size = New System.Drawing.Size(117, 13)
        Me.lblMaklumat.TabIndex = 0
        Me.lblMaklumat.Text = "MAKLUMAT PELAJAR"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(23, 75)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(35, 13)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Nama"
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Location = New System.Drawing.Point(23, 103)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(39, 13)
        Me.lblNo.TabIndex = 2
        Me.lblNo.Text = "No.Tel"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(23, 136)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(39, 13)
        Me.lblAlamat.TabIndex = 3
        Me.lblAlamat.Text = "Alamat"
        '
        'lblNegeri
        '
        Me.lblNegeri.AutoSize = True
        Me.lblNegeri.Location = New System.Drawing.Point(23, 172)
        Me.lblNegeri.Name = "lblNegeri"
        Me.lblNegeri.Size = New System.Drawing.Size(38, 13)
        Me.lblNegeri.TabIndex = 4
        Me.lblNegeri.Text = "Negeri"
        '
        'lblJantina
        '
        Me.lblJantina.AutoSize = True
        Me.lblJantina.Location = New System.Drawing.Point(24, 212)
        Me.lblJantina.Name = "lblJantina"
        Me.lblJantina.Size = New System.Drawing.Size(41, 13)
        Me.lblJantina.TabIndex = 5
        Me.lblJantina.Text = "Jantina"
        '
        'lblKaedah
        '
        Me.lblKaedah.AutoSize = True
        Me.lblKaedah.Location = New System.Drawing.Point(23, 256)
        Me.lblKaedah.Name = "lblKaedah"
        Me.lblKaedah.Size = New System.Drawing.Size(86, 13)
        Me.lblKaedah.TabIndex = 6
        Me.lblKaedah.Text = "Kaedah Bayaran"
        '
        'lblPerisa
        '
        Me.lblPerisa.AutoSize = True
        Me.lblPerisa.Location = New System.Drawing.Point(24, 296)
        Me.lblPerisa.Name = "lblPerisa"
        Me.lblPerisa.Size = New System.Drawing.Size(36, 13)
        Me.lblPerisa.TabIndex = 7
        Me.lblPerisa.Text = "Perisa"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(149, 75)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(100, 20)
        Me.txtNama.TabIndex = 8
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(149, 136)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(100, 20)
        Me.txtAlamat.TabIndex = 12
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(149, 103)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(100, 20)
        Me.txtNo.TabIndex = 13
        '
        'cboNegeri
        '
        Me.cboNegeri.FormattingEnabled = True
        Me.cboNegeri.Items.AddRange(New Object() {"perlis", "kedah", "penang", "perak", "terengganu"})
        Me.cboNegeri.Location = New System.Drawing.Point(149, 169)
        Me.cboNegeri.Name = "cboNegeri"
        Me.cboNegeri.Size = New System.Drawing.Size(121, 21)
        Me.cboNegeri.TabIndex = 14
        '
        'rdoLelaki
        '
        Me.rdoLelaki.AutoSize = True
        Me.rdoLelaki.Location = New System.Drawing.Point(149, 210)
        Me.rdoLelaki.Name = "rdoLelaki"
        Me.rdoLelaki.Size = New System.Drawing.Size(53, 17)
        Me.rdoLelaki.TabIndex = 15
        Me.rdoLelaki.TabStop = True
        Me.rdoLelaki.Text = "Lelaki"
        Me.rdoLelaki.UseVisualStyleBackColor = True
        '
        'rdoPerempuan
        '
        Me.rdoPerempuan.AutoSize = True
        Me.rdoPerempuan.Location = New System.Drawing.Point(256, 212)
        Me.rdoPerempuan.Name = "rdoPerempuan"
        Me.rdoPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.rdoPerempuan.TabIndex = 16
        Me.rdoPerempuan.TabStop = True
        Me.rdoPerempuan.Text = "Perempuan"
        Me.rdoPerempuan.UseVisualStyleBackColor = True
        '
        'rdoCashless
        '
        Me.rdoCashless.AutoSize = True
        Me.rdoCashless.Location = New System.Drawing.Point(149, 256)
        Me.rdoCashless.Name = "rdoCashless"
        Me.rdoCashless.Size = New System.Drawing.Size(66, 17)
        Me.rdoCashless.TabIndex = 17
        Me.rdoCashless.TabStop = True
        Me.rdoCashless.Text = "cashless"
        Me.rdoCashless.UseVisualStyleBackColor = True
        '
        'rdoCash
        '
        Me.rdoCash.AutoSize = True
        Me.rdoCash.Location = New System.Drawing.Point(256, 256)
        Me.rdoCash.Name = "rdoCash"
        Me.rdoCash.Size = New System.Drawing.Size(49, 17)
        Me.rdoCash.TabIndex = 18
        Me.rdoCash.TabStop = True
        Me.rdoCash.Text = "Cash"
        Me.rdoCash.UseVisualStyleBackColor = True
        '
        'chkStrawberi
        '
        Me.chkStrawberi.AutoSize = True
        Me.chkStrawberi.Location = New System.Drawing.Point(149, 292)
        Me.chkStrawberi.Name = "chkStrawberi"
        Me.chkStrawberi.Size = New System.Drawing.Size(70, 17)
        Me.chkStrawberi.TabIndex = 19
        Me.chkStrawberi.Text = "Strawberi"
        Me.chkStrawberi.UseVisualStyleBackColor = True
        '
        'chkCoklat
        '
        Me.chkCoklat.AutoSize = True
        Me.chkCoklat.Location = New System.Drawing.Point(265, 296)
        Me.chkCoklat.Name = "chkCoklat"
        Me.chkCoklat.Size = New System.Drawing.Size(56, 17)
        Me.chkCoklat.TabIndex = 20
        Me.chkCoklat.Text = "Coklat"
        Me.chkCoklat.UseVisualStyleBackColor = True
        '
        'chkPisang
        '
        Me.chkPisang.AutoSize = True
        Me.chkPisang.Location = New System.Drawing.Point(355, 292)
        Me.chkPisang.Name = "chkPisang"
        Me.chkPisang.Size = New System.Drawing.Size(58, 17)
        Me.chkPisang.TabIndex = 21
        Me.chkPisang.Text = "Pisang"
        Me.chkPisang.UseVisualStyleBackColor = True
        '
        'chkKopi
        '
        Me.chkKopi.AutoSize = True
        Me.chkKopi.Location = New System.Drawing.Point(463, 296)
        Me.chkKopi.Name = "chkKopi"
        Me.chkKopi.Size = New System.Drawing.Size(47, 17)
        Me.chkKopi.TabIndex = 22
        Me.chkKopi.Text = "Kopi"
        Me.chkKopi.UseVisualStyleBackColor = True
        '
        'chkMilo
        '
        Me.chkMilo.AutoSize = True
        Me.chkMilo.Location = New System.Drawing.Point(591, 296)
        Me.chkMilo.Name = "chkMilo"
        Me.chkMilo.Size = New System.Drawing.Size(45, 17)
        Me.chkMilo.TabIndex = 23
        Me.chkMilo.Text = "Milo"
        Me.chkMilo.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bil, Me.nama, Me.noTel})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 355)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(309, 93)
        Me.DataGridView1.TabIndex = 24
        '
        'bil
        '
        Me.bil.HeaderText = "Bil"
        Me.bil.Name = "bil"
        '
        'nama
        '
        Me.nama.HeaderText = "nama"
        Me.nama.Name = "nama"
        '
        'noTel
        '
        Me.noTel.HeaderText = "noTel"
        Me.noTel.Name = "noTel"
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCreate.Location = New System.Drawing.Point(709, 50)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCreate.TabIndex = 25
        Me.BtnCreate.Text = "create"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'BtnRead
        '
        Me.BtnRead.BackColor = System.Drawing.SystemColors.Info
        Me.BtnRead.Location = New System.Drawing.Point(709, 103)
        Me.BtnRead.Name = "BtnRead"
        Me.BtnRead.Size = New System.Drawing.Size(75, 23)
        Me.BtnRead.TabIndex = 26
        Me.BtnRead.Text = "read"
        Me.BtnRead.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Silver
        Me.BtnUpdate.Location = New System.Drawing.Point(709, 159)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 27
        Me.BtnUpdate.Text = "update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnDelete.Location = New System.Drawing.Point(709, 212)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 28
        Me.BtnDelete.Text = "delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnRead)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.chkMilo)
        Me.Controls.Add(Me.chkKopi)
        Me.Controls.Add(Me.chkPisang)
        Me.Controls.Add(Me.chkCoklat)
        Me.Controls.Add(Me.chkStrawberi)
        Me.Controls.Add(Me.rdoCash)
        Me.Controls.Add(Me.rdoCashless)
        Me.Controls.Add(Me.rdoPerempuan)
        Me.Controls.Add(Me.rdoLelaki)
        Me.Controls.Add(Me.cboNegeri)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblPerisa)
        Me.Controls.Add(Me.lblKaedah)
        Me.Controls.Add(Me.lblJantina)
        Me.Controls.Add(Me.lblNegeri)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblNo)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblMaklumat)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMaklumat As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNo As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblNegeri As Label
    Friend WithEvents lblJantina As Label
    Friend WithEvents lblKaedah As Label
    Friend WithEvents lblPerisa As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents cboNegeri As ComboBox
    Friend WithEvents rdoLelaki As RadioButton
    Friend WithEvents rdoPerempuan As RadioButton
    Friend WithEvents rdoCashless As RadioButton
    Friend WithEvents rdoCash As RadioButton
    Friend WithEvents chkStrawberi As CheckBox
    Friend WithEvents chkCoklat As CheckBox
    Friend WithEvents chkPisang As CheckBox
    Friend WithEvents chkKopi As CheckBox
    Friend WithEvents chkMilo As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bil As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents noTel As DataGridViewTextBoxColumn
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
End Class
