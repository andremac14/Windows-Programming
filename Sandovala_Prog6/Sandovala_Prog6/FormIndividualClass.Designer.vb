<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIndividualClass
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
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim DeptPositionLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIndividualClass))
        Me.ActivityDataSet = New Sandovala_Prog6.ActivityDataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New Sandovala_Prog6.ActivityDataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New Sandovala_Prog6.ActivityDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmployeeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnReload = New System.Windows.Forms.ToolStripButton()
        Me.btnAllEmployees = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.DeptPositionTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        UserNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        DeptPositionLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        CType(Me.ActivityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeeBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(169, 70)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(63, 13)
        UserNameLabel.TabIndex = 1
        UserNameLabel.Text = "User Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(169, 96)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(169, 122)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(169, 148)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 7
        DepartmentLabel.Text = "Department:"
        '
        'DeptPositionLabel
        '
        DeptPositionLabel.AutoSize = True
        DeptPositionLabel.Location = New System.Drawing.Point(169, 174)
        DeptPositionLabel.Name = "DeptPositionLabel"
        DeptPositionLabel.Size = New System.Drawing.Size(73, 13)
        DeptPositionLabel.TabIndex = 9
        DeptPositionLabel.Text = "Dept Position:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(169, 200)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "Email:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(169, 226)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 13
        PhoneLabel.Text = "Phone:"
        '
        'ActivityDataSet
        '
        Me.ActivityDataSet.DataSetName = "ActivityDataSet"
        Me.ActivityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.ActivityDataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sandovala_Prog6.ActivityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeBindingNavigator
        '
        Me.EmployeeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeeBindingNavigator.BindingSource = Me.EmployeeBindingSource
        Me.EmployeeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeeBindingNavigatorSaveItem, Me.btnReload, Me.btnAllEmployees, Me.btnExit})
        Me.EmployeeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeeBindingNavigator.Name = "EmployeeBindingNavigator"
        Me.EmployeeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeeBindingNavigator.Size = New System.Drawing.Size(564, 25)
        Me.EmployeeBindingNavigator.TabIndex = 0
        Me.EmployeeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EmployeeBindingNavigatorSaveItem
        '
        Me.EmployeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeeBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeeBindingNavigatorSaveItem.Name = "EmployeeBindingNavigatorSaveItem"
        Me.EmployeeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmployeeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnReload
        '
        Me.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(47, 22)
        Me.btnReload.Text = "Reload"
        '
        'btnAllEmployees
        '
        Me.btnAllEmployees.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAllEmployees.Image = CType(resources.GetObject("btnAllEmployees.Image"), System.Drawing.Image)
        Me.btnAllEmployees.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAllEmployees.Name = "btnAllEmployees"
        Me.btnAllEmployees.Size = New System.Drawing.Size(85, 22)
        Me.btnAllEmployees.Text = "All Employees"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(29, 22)
        Me.btnExit.Text = "Exit"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(248, 67)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserNameTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(248, 93)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(248, 119)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 6
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(248, 145)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DepartmentTextBox.TabIndex = 8
        '
        'DeptPositionTextBox
        '
        Me.DeptPositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "DeptPosition", True))
        Me.DeptPositionTextBox.Location = New System.Drawing.Point(248, 171)
        Me.DeptPositionTextBox.Name = "DeptPositionTextBox"
        Me.DeptPositionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DeptPositionTextBox.TabIndex = 10
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(248, 197)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 12
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(248, 223)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTextBox.TabIndex = 14
        '
        'FormIndividualClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 321)
        Me.ControlBox = False
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(DeptPositionLabel)
        Me.Controls.Add(Me.DeptPositionTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.EmployeeBindingNavigator)
        Me.Name = "FormIndividualClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prog6 - Andre Sandoval"
        CType(Me.ActivityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeeBindingNavigator.ResumeLayout(False)
        Me.EmployeeBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ActivityDataSet As ActivityDataSet
   Friend WithEvents EmployeeBindingSource As BindingSource
   Friend WithEvents EmployeeTableAdapter As ActivityDataSetTableAdapters.EmployeeTableAdapter
   Friend WithEvents TableAdapterManager As ActivityDataSetTableAdapters.TableAdapterManager
   Friend WithEvents EmployeeBindingNavigator As BindingNavigator
   Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
   Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
   Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
   Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
   Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
   Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
   Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
   Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
   Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
   Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
   Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
   Friend WithEvents EmployeeBindingNavigatorSaveItem As ToolStripButton
   Friend WithEvents UserNameTextBox As TextBox
   Friend WithEvents FirstNameTextBox As TextBox
   Friend WithEvents LastNameTextBox As TextBox
   Friend WithEvents DepartmentTextBox As TextBox
   Friend WithEvents DeptPositionTextBox As TextBox
   Friend WithEvents EmailTextBox As TextBox
   Friend WithEvents PhoneTextBox As TextBox
   Friend WithEvents btnReload As ToolStripButton
   Friend WithEvents btnAllEmployees As ToolStripButton
   Friend WithEvents btnExit As ToolStripButton
End Class
