Imports System.IO

Public Class Form1
    Dim blnItemsValid As Boolean = True
    Sub Display()
        Dim strPlantName() As String
        Dim strPlantHeight() As String
        Dim strPlantValue() As String
        Dim PlantDataFile As StreamReader = File.OpenText("PlantData.txt")
        Dim intItemCounter As Integer

        Do While PlantDataFile.Peek <> -1
            PlantDataFile.ReadLine()
            intItemCounter = intItemCounter + 1
        Loop

        PlantDataFile.Close()

        ReDim strPlantName(intItemCounter - 1)
        ReDim strPlantHeight(intItemCounter - 1)
        ReDim strPlantValue(intItemCounter - 1)
        Dim PlantDataFile2 As StreamReader = File.OpenText("PlantData.txt")

        For i = 0 To intItemCounter - 1
            strPlantName(i) = PlantDataFile2.ReadLine()
            strPlantHeight(i) = PlantDataFile2.ReadLine()
            strPlantValue(i) = PlantDataFile2.ReadLine()
            lstDisplay.Items.Add(strPlantName(i) & " " & strPlantHeight(i) & "cm" & FormatCurrency(strPlantValue(i)))
        Next

        PlantDataFile2.Close()
    End Sub

    Sub DoValidation()
        If String.IsNullOrEmpty(txtPlantName.Text) Then
            MsgBox("Please enter a plant name.")
            blnItemsValid = False
            txtPlantName.Focus()
            Return
        ElseIf IsNumeric(txtPlantName.Text) = True Then
            MsgBox("Please enter a valid plant name.")
            blnItemsValid = False
            txtPlantName.Focus()
            Return
        ElseIf String.IsNullOrEmpty(txtHeight.Text) Then
            MsgBox("Please enter the plant height.")
            blnItemsValid = False
            txtHeight.Focus()
            Return
        ElseIf IsNumeric(txtHeight.Text) = False Then
            MsgBox("Please enter a valid plant height.")
            blnItemsValid = False
            txtHeight.Focus()
            Return
        ElseIf Val(txtHeight.Text) > 2000 Then
            MsgBox("Please enter a valid plant height.")
            blnItemsValid = False
            txtHeight.Focus()
            Return
        ElseIf Val(txtHeight.Text) < 5 Then
            MsgBox("Please enter a valid plant height.")
            blnItemsValid = False
            txtHeight.Focus()
            Return
        ElseIf String.IsNullOrEmpty(txtValue.Text) Then
            MsgBox("Please enter the value of the plant.")
            blnItemsValid = False
            txtValue.Focus()
            Return
        ElseIf IsNumeric(txtValue.Text) = False Then
            MsgBox("Please enter a valid plant value.")
            blnItemsValid = False
            txtValue.Focus()
            Return
        ElseIf IsNumeric(txtValue.Text) = False Then
            MsgBox("Please enter a valid plant value.")
            blnItemsValid = False
            txtValue.Focus()
            Return
        ElseIf Val(txtValue.Text) > 100 Then
            MsgBox("Please enter a valid plant value.")
            blnItemsValid = False
            txtValue.Focus()
            Return
        ElseIf Val(txtValue.Text) < 1 Then
            MsgBox("Please enter a valid plant value.")
            blnItemsValid = False
            txtValue.Focus()
            Return
        Else
            blnItemsValid = True
        End If
    End Sub

    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click
        Display()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        DoValidation()

        If blnItemsValid Then
            Dim strPlantName As String
            Dim strPlantHeight As String
            Dim dblPlantValue As Double
            Dim PlantDataFile As StreamWriter = File.AppendText("PlantData.txt")

            strPlantName = txtPlantName.Text
            strPlantHeight = txtHeight.Text
            dblPlantValue = txtValue.Text
            PlantDataFile.WriteLine(strPlantName)
            PlantDataFile.WriteLine(strPlantHeight)
            PlantDataFile.WriteLine(dblPlantValue)

            MessageBox.Show("Plant details have been successfully added to the textfile.")
            PlantDataFile.Close()
            Display()
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If String.IsNullOrEmpty(txtPlantName.Text) Then
            MessageBox.Show("Please enter a plant name.")
            blnItemsValid = False
            txtPlantName.Focus()
            Return
        ElseIf IsNumeric(txtPlantName.Text) = True Then
            MessageBox.Show("Please enter a valid plant name.")
            blnItemsValid = False
            txtPlantName.Focus()
            Return
        End If

        Dim strPlantName As String
        Dim strPlantHeight As String
        Dim strPlantValue As String
        Dim strPlantDisplay As String
        Dim PlantDatafile As StreamReader = File.OpenText("PlantData.txt")

        While PlantDatafile.Peek <> -1
            strPlantName = PlantDatafile.ReadLine
            strPlantHeight = PlantDatafile.ReadLine
            strPlantValue = PlantDatafile.ReadLine
            strPlantDisplay = txtPlantName.Text

            If strPlantName.Contains(strPlantDisplay) = True Then
                lstDisplay.Items.Add(strPlantName & " " & strPlantHeight & "cm" & " " & FormatCurrency(strPlantValue))
                Return
            End If
        End While
    End Sub

    Private Sub btnDisplayTallerThanAvg_Click(sender As Object, e As EventArgs) Handles btnDisplayTallerThanAvg.Click
        Dim strPlantName As String
        Dim strPlantHeight As String
        Dim strPlantValue As String
        Dim dblTotalHeight As Double = 0
        Dim dblAverageHeight As Double
        Dim PlantDataFile As StreamReader = File.OpenText("PlantData.txt")
        Dim intItemCounter As Integer = 0

        Do While PlantDataFile.Peek <> -1
            PlantDataFile.ReadLine()
            dblTotalHeight = dblTotalHeight + PlantDataFile.ReadLine()
            PlantDataFile.ReadLine()
            intItemCounter = intItemCounter + 1
        Loop

        dblAverageHeight = dblTotalHeight / intItemCounter

        While PlantDataFile.Peek <> -1
            strPlantName = PlantDataFile.ReadLine()
            strPlantHeight = PlantDataFile.ReadLine()
            strPlantValue = PlantDataFile.ReadLine()

            If strPlantHeight > dblAverageHeight Then
                lstDisplay.Items.Add(strPlantName & " " & strPlantHeight & "cm")
            End If
        End While
    End Sub

    Private Sub btnDisplayValue_Click(sender As Object, e As EventArgs) Handles btnDisplayValue.Click
        Dim dblTotalValue As Double = 0
        Dim PlantDataFile As StreamReader = File.OpenText("PlantData.txt")

        Do While PlantDataFile.Peek <> -1
            PlantDataFile.ReadLine()
            PlantDataFile.ReadLine()
            dblTotalValue = dblTotalValue + PlantDataFile.ReadLine()
        Loop
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim a As Control

        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            ElseIf TypeOf a Is ComboBox Then
                a.Text = Nothing
            End If
        Next

        lstDisplay.Items.Clear()
    End Sub
End Class
