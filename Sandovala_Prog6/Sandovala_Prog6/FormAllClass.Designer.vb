<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAllClass
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
      Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.ActivityDataSet = New Sandovala_Prog6.ActivityDataSet()
      Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.EmployeeTableAdapter = New Sandovala_Prog6.ActivityDataSetTableAdapters.EmployeeTableAdapter()
      Me.TableAdapterManager = New Sandovala_Prog6.ActivityDataSetTableAdapters.TableAdapterManager()
      Me.dgvAll = New System.Windows.Forms.DataGridView()
      Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.btnLocation = New System.Windows.Forms.Button()
      Me.btnReload = New System.Windows.Forms.Button()
      Me.btnIndividual = New System.Windows.Forms.Button()
      CType(Me.ActivityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
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
      'dgvAll
      '
      Me.dgvAll.AutoGenerateColumns = False
      Me.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvAll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7})
      Me.dgvAll.DataSource = Me.EmployeeBindingSource
      Me.dgvAll.Location = New System.Drawing.Point(40, 59)
      Me.dgvAll.Name = "dgvAll"
      Me.dgvAll.Size = New System.Drawing.Size(645, 220)
      Me.dgvAll.TabIndex = 1
      '
      'DataGridViewTextBoxColumn1
      '
      Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserName"
      DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
      Me.DataGridViewTextBoxColumn1.HeaderText = "User Name"
      Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
      '
      'DataGridViewTextBoxColumn2
      '
      Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
      DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
      Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
      Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
      Me.DataGridViewTextBoxColumn2.Width = 120
      '
      'DataGridViewTextBoxColumn3
      '
      Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
      DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle9
      Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
      Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
      Me.DataGridViewTextBoxColumn3.Width = 120
      '
      'DataGridViewTextBoxColumn4
      '
      Me.DataGridViewTextBoxColumn4.DataPropertyName = "Department"
      DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle10
      Me.DataGridViewTextBoxColumn4.HeaderText = "Department"
      Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
      Me.DataGridViewTextBoxColumn4.Width = 70
      '
      'DataGridViewTextBoxColumn5
      '
      Me.DataGridViewTextBoxColumn5.DataPropertyName = "DeptPosition"
      DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle11
      Me.DataGridViewTextBoxColumn5.HeaderText = "Position"
      Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
      '
      'DataGridViewTextBoxColumn7
      '
      Me.DataGridViewTextBoxColumn7.DataPropertyName = "Phone"
      DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle12
      Me.DataGridViewTextBoxColumn7.HeaderText = "Phone"
      Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
      Me.DataGridViewTextBoxColumn7.Width = 70
      '
      'btnExit
      '
      Me.btnExit.Location = New System.Drawing.Point(610, 312)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(75, 23)
      Me.btnExit.TabIndex = 2
      Me.btnExit.Text = "Exit"
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'btnLocation
      '
      Me.btnLocation.Location = New System.Drawing.Point(407, 312)
      Me.btnLocation.Name = "btnLocation"
      Me.btnLocation.Size = New System.Drawing.Size(75, 23)
      Me.btnLocation.TabIndex = 3
      Me.btnLocation.Text = "Location"
      Me.btnLocation.UseVisualStyleBackColor = True
      '
      'btnReload
      '
      Me.btnReload.Location = New System.Drawing.Point(233, 312)
      Me.btnReload.Name = "btnReload"
      Me.btnReload.Size = New System.Drawing.Size(75, 23)
      Me.btnReload.TabIndex = 4
      Me.btnReload.Text = "Reload"
      Me.btnReload.UseVisualStyleBackColor = True
      '
      'btnIndividual
      '
      Me.btnIndividual.Location = New System.Drawing.Point(40, 312)
      Me.btnIndividual.Name = "btnIndividual"
      Me.btnIndividual.Size = New System.Drawing.Size(75, 23)
      Me.btnIndividual.TabIndex = 5
      Me.btnIndividual.Text = "Individual"
      Me.btnIndividual.UseVisualStyleBackColor = True
      '
      'FormAllClass
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(730, 357)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnIndividual)
      Me.Controls.Add(Me.btnReload)
      Me.Controls.Add(Me.btnLocation)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.dgvAll)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "FormAllClass"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Prog 6 - Andre Sandoval"
      CType(Me.ActivityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents ActivityDataSet As ActivityDataSet
   Friend WithEvents EmployeeBindingSource As BindingSource
   Friend WithEvents EmployeeTableAdapter As ActivityDataSetTableAdapters.EmployeeTableAdapter
   Friend WithEvents TableAdapterManager As ActivityDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvAll As DataGridView
    Friend WithEvents btnExit As Button
   Friend WithEvents btnLocation As Button
   Friend WithEvents btnReload As Button
   Friend WithEvents btnIndividual As Button
   Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
