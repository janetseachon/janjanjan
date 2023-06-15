Public Class frmCal
    Dim operand1, operand2 As Double
    Dim [Operator] As String

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtText.Text = txtText.Text & sender.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtText.Text = txtText.Text & sender.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtText.Text = txtText.Text & sender.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtText.Text = txtText.Text & sender.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtText.Text = txtText.Text & sender.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtText.Text = txtText.Text & sender.Text
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtText.Text = txtText.Text & sender.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtText.Text = txtText.Text & sender.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtText.Text = txtText.Text & sender.Text
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtText.Text = txtText.Text & sender.Text
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtText.Clear()
        operand1 = 0
        operand2 = 0

    End Sub

    Private Sub btnBackSpace_Click(sender As Object, e As EventArgs) Handles btnBackSpace.Click
        If txtText.Text.Count > 0 Then
            txtText.Text = txtText.Text.Remove(txtText.Text.Count - 1, 1)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        operand1 = Val(txtText.Text)
        [Operator] = "+"
        txtText.Clear()

    End Sub

    Private Sub btnEqu_Click(sender As Object, e As EventArgs) Handles btnEqu.Click
        operand2 = Val(txtText.Text)
        Select Case [Operator]
            Case "+"
                txtText.Text = operand1 + operand2
            Case "-"
                txtText.Text = operand1 - operand2
            Case "*"
                txtText.Text = operand1 * operand2
            Case "/"
                If operand2 = 0 Then
                    txtText.Text = "Infinity"
                Else
                    txtText.Text = operand1 / operand2
                End If
            Case "e"
                txtText.Text = Math.Pow(operand1, operand2)
        End Select
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        operand1 = Val(txtText.Text)
        [Operator] = "-"
        txtText.Clear()
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        operand1 = Val(txtText.Text)
        [Operator] = "*"
        txtText.Clear()
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        operand1 = Val(txtText.Text)
        [Operator] = "/"
        txtText.Clear()
    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        txtText.Enabled = False
    End Sub

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        txtText.Enabled = True
    End Sub

    Private Sub frmCal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.AppStat = "Trial Version" Then

            If My.Settings.LoadCount < 0 Then
                Form2.ShowDialog()
            End If

            Me.Text = My.Settings.AppStat & " : Counter =>" & My.Settings.LoadCount
            My.Settings.LoadCount -= 1
            My.Settings.Save()
        Else
            Me.Text = My.Settings.AppStat
        End If
    End Sub

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        txtText.Text = -1 * (txtText.Text)
    End Sub

    Private Sub btnInv_Click(sender As Object, e As EventArgs) Handles btnInv.Click
        If txtText.Text = "" Or txtText.Text = "0" Then
            txtText.Text = "Invalid"
        Else
            txtText.Text = 1 / Val(txtText.Text)
        End If
    End Sub

    Private Sub btnSqr_Click(sender As Object, e As EventArgs) Handles btnSqr.Click
        txtText.Text = Math.Sqrt(Val(txtText.Text))
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        operand1 = Val(txtText.Text)
        [Operator] = "e"
        txtText.Clear()
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If InStr(txtText.Text, ".") > 0 Then
            Exit Sub
        Else
            txtText.Text = txtText.Text & "."
        End If
    End Sub

End Class
