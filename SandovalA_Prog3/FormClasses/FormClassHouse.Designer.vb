<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassHouse
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
        Me.components = New System.ComponentModel.Container()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cobType = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpGarages = New System.Windows.Forms.GroupBox()
        Me.rdoGarage3 = New System.Windows.Forms.RadioButton()
        Me.rdoGarage2 = New System.Windows.Forms.RadioButton()
        Me.rdoGarage1 = New System.Windows.Forms.RadioButton()
        Me.grpRooms = New System.Windows.Forms.GroupBox()
        Me.rdoRoom4 = New System.Windows.Forms.RadioButton()
        Me.rdoRoom3 = New System.Windows.Forms.RadioButton()
        Me.rdoRoom2 = New System.Windows.Forms.RadioButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpGarages.SuspendLayout()
        Me.grpRooms.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(52, 186)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(121, 20)
        Me.txtID.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Not used"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(572, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Visible = False
        '
        'cobType
        '
        Me.cobType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobType.FormattingEnabled = True
        Me.cobType.Items.AddRange(New Object() {"Chicago", "Madison", "Platteville"})
        Me.cobType.Location = New System.Drawing.Point(51, 126)
        Me.cobType.Name = "cobType"
        Me.cobType.Size = New System.Drawing.Size(121, 21)
        Me.cobType.TabIndex = 0
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrice.Location = New System.Drawing.Point(54, 246)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 6
        Me.txtPrice.TabStop = False
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Price"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(77, 334)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(375, 334)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 5
        Me.btnModify.Text = "&MODIFY"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(650, 149)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 7
        Me.btnList.Text = "&LIST"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(650, 201)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&XIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpGarages
        '
        Me.grpGarages.Controls.Add(Me.rdoGarage3)
        Me.grpGarages.Controls.Add(Me.rdoGarage2)
        Me.grpGarages.Controls.Add(Me.rdoGarage1)
        Me.grpGarages.Location = New System.Drawing.Point(295, 201)
        Me.grpGarages.Name = "grpGarages"
        Me.grpGarages.Size = New System.Drawing.Size(243, 83)
        Me.grpGarages.TabIndex = 4
        Me.grpGarages.TabStop = False
        Me.grpGarages.Text = "Garages"
        '
        'rdoGarage3
        '
        Me.rdoGarage3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoGarage3.Location = New System.Drawing.Point(22, 32)
        Me.rdoGarage3.Name = "rdoGarage3"
        Me.rdoGarage3.Size = New System.Drawing.Size(62, 36)
        Me.rdoGarage3.TabIndex = 4
        Me.rdoGarage3.TabStop = True
        Me.rdoGarage3.Text = "3"
        Me.rdoGarage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGarage3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.rdoGarage3.UseVisualStyleBackColor = True
        '
        'rdoGarage2
        '
        Me.rdoGarage2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoGarage2.Location = New System.Drawing.Point(92, 32)
        Me.rdoGarage2.Name = "rdoGarage2"
        Me.rdoGarage2.Size = New System.Drawing.Size(62, 36)
        Me.rdoGarage2.TabIndex = 3
        Me.rdoGarage2.TabStop = True
        Me.rdoGarage2.Text = "2"
        Me.rdoGarage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGarage2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.rdoGarage2.UseVisualStyleBackColor = True
        '
        'rdoGarage1
        '
        Me.rdoGarage1.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoGarage1.Location = New System.Drawing.Point(162, 32)
        Me.rdoGarage1.Name = "rdoGarage1"
        Me.rdoGarage1.Size = New System.Drawing.Size(62, 36)
        Me.rdoGarage1.TabIndex = 2
        Me.rdoGarage1.TabStop = True
        Me.rdoGarage1.Text = "1"
        Me.rdoGarage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGarage1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.rdoGarage1.UseVisualStyleBackColor = True
        '
        'grpRooms
        '
        Me.grpRooms.Controls.Add(Me.rdoRoom4)
        Me.grpRooms.Controls.Add(Me.rdoRoom3)
        Me.grpRooms.Controls.Add(Me.rdoRoom2)
        Me.grpRooms.Location = New System.Drawing.Point(295, 79)
        Me.grpRooms.Name = "grpRooms"
        Me.grpRooms.Size = New System.Drawing.Size(243, 83)
        Me.grpRooms.TabIndex = 3
        Me.grpRooms.TabStop = False
        Me.grpRooms.Text = "Rooms"
        '
        'rdoRoom4
        '
        Me.rdoRoom4.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoRoom4.Location = New System.Drawing.Point(22, 32)
        Me.rdoRoom4.Name = "rdoRoom4"
        Me.rdoRoom4.Size = New System.Drawing.Size(62, 36)
        Me.rdoRoom4.TabIndex = 4
        Me.rdoRoom4.TabStop = True
        Me.rdoRoom4.Text = "4"
        Me.rdoRoom4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRoom4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.rdoRoom4.UseVisualStyleBackColor = True
        '
        'rdoRoom3
        '
        Me.rdoRoom3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoRoom3.Location = New System.Drawing.Point(92, 32)
        Me.rdoRoom3.Name = "rdoRoom3"
        Me.rdoRoom3.Size = New System.Drawing.Size(62, 36)
        Me.rdoRoom3.TabIndex = 3
        Me.rdoRoom3.TabStop = True
        Me.rdoRoom3.Text = "3"
        Me.rdoRoom3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRoom3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.rdoRoom3.UseVisualStyleBackColor = True
        '
        'rdoRoom2
        '
        Me.rdoRoom2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoRoom2.Location = New System.Drawing.Point(162, 32)
        Me.rdoRoom2.Name = "rdoRoom2"
        Me.rdoRoom2.Size = New System.Drawing.Size(62, 36)
        Me.rdoRoom2.TabIndex = 2
        Me.rdoRoom2.TabStop = True
        Me.rdoRoom2.Text = "2"
        Me.rdoRoom2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRoom2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.rdoRoom2.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FormClassHouse
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(760, 457)
        Me.Controls.Add(Me.grpRooms)
        Me.Controls.Add(Me.grpGarages)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.cobType)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormClassHouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Class House - Andre Sandoval"
        Me.grpGarages.ResumeLayout(False)
        Me.grpRooms.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents cobType As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnList As System.Windows.Forms.Button
   Friend WithEvents grpGarages As System.Windows.Forms.GroupBox
   Friend WithEvents rdoGarage3 As System.Windows.Forms.RadioButton
   Friend WithEvents rdoGarage2 As System.Windows.Forms.RadioButton
   Friend WithEvents rdoGarage1 As System.Windows.Forms.RadioButton
   Friend WithEvents grpRooms As System.Windows.Forms.GroupBox
   Friend WithEvents rdoRoom4 As System.Windows.Forms.RadioButton
   Friend WithEvents rdoRoom3 As System.Windows.Forms.RadioButton
   Friend WithEvents rdoRoom2 As System.Windows.Forms.RadioButton
   Protected WithEvents btnExit As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
