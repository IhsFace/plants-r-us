<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtPlantName = New TextBox()
        txtHeight = New TextBox()
        txtValue = New TextBox()
        btnDisplayAll = New Button()
        btnAdd = New Button()
        btnFind = New Button()
        btnDisplayTallerThanAvg = New Button()
        btnDisplayValue = New Button()
        btnClear = New Button()
        lstDisplay = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(250, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 59)
        Label1.TabIndex = 0
        Label1.Text = "Plants R Us"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(91, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 32)
        Label2.TabIndex = 1
        Label2.Text = "Plant Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(90, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 32)
        Label3.TabIndex = 2
        Label3.Text = "Height (cm)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(123, 255)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 32)
        Label4.TabIndex = 3
        Label4.Text = "Value ($)"
        ' 
        ' txtPlantName
        ' 
        txtPlantName.Location = New Point(350, 123)
        txtPlantName.Name = "txtPlantName"
        txtPlantName.Size = New Size(200, 39)
        txtPlantName.TabIndex = 4
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(350, 183)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(200, 39)
        txtHeight.TabIndex = 5
        ' 
        ' txtValue
        ' 
        txtValue.Location = New Point(350, 248)
        txtValue.Name = "txtValue"
        txtValue.Size = New Size(200, 39)
        txtValue.TabIndex = 6
        ' 
        ' btnDisplayAll
        ' 
        btnDisplayAll.Location = New Point(57, 352)
        btnDisplayAll.Name = "btnDisplayAll"
        btnDisplayAll.Size = New Size(200, 100)
        btnDisplayAll.TabIndex = 7
        btnDisplayAll.Text = "Display All Plant Details"
        btnDisplayAll.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(295, 352)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(200, 100)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add Plant"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnFind
        ' 
        btnFind.Location = New Point(528, 352)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(200, 100)
        btnFind.TabIndex = 9
        btnFind.Text = "Find Plant"
        btnFind.UseVisualStyleBackColor = True
        ' 
        ' btnDisplayTallerThanAvg
        ' 
        btnDisplayTallerThanAvg.Location = New Point(57, 498)
        btnDisplayTallerThanAvg.Name = "btnDisplayTallerThanAvg"
        btnDisplayTallerThanAvg.Size = New Size(325, 100)
        btnDisplayTallerThanAvg.TabIndex = 10
        btnDisplayTallerThanAvg.Text = "Display All Plants Taller Than Average Height"
        btnDisplayTallerThanAvg.UseVisualStyleBackColor = True
        ' 
        ' btnDisplayValue
        ' 
        btnDisplayValue.Location = New Point(404, 498)
        btnDisplayValue.Name = "btnDisplayValue"
        btnDisplayValue.Size = New Size(325, 100)
        btnDisplayValue.TabIndex = 11
        btnDisplayValue.Text = "Display Total Value Of All Stock"
        btnDisplayValue.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(57, 859)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 46)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lstDisplay
        ' 
        lstDisplay.FormattingEnabled = True
        lstDisplay.Location = New Point(57, 619)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(672, 228)
        lstDisplay.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(774, 929)
        Controls.Add(lstDisplay)
        Controls.Add(btnClear)
        Controls.Add(btnDisplayValue)
        Controls.Add(btnDisplayTallerThanAvg)
        Controls.Add(btnFind)
        Controls.Add(btnAdd)
        Controls.Add(btnDisplayAll)
        Controls.Add(txtValue)
        Controls.Add(txtHeight)
        Controls.Add(txtPlantName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Plants R Us"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPlantName As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents btnDisplayAll As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents btnDisplayTallerThanAvg As Button
    Friend WithEvents btnDisplayValue As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lstDisplay As ListBox

End Class
