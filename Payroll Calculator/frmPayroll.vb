Public Class frmPayroll
    Const cdecFica As Decimal = 0.0765D
    Const cdecFed As Decimal = 0.22D
    Const cdecState As Decimal = 0.04D
    Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFica.Text = ""
        lblFederal.Text = ""
        lblState.Text = ""
        lblNet.Text = ""
        txtIncome.Clear()
        txtIncome.Focus()
    End Sub

    Private Sub btnTaxCalc_Click(sender As Object, e As EventArgs) Handles btnTaxCalc.Click
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal
        strIncome = txtIncome.Text
        decIncome = Convert.ToDecimal(strIncome)
        decFica = decIncome * cdecFica
        decFederal = decIncome * cdecFed
        decState = decIncome * cdecState
        decNet = decIncome - decFica - decFederal - decState
        lblFica.Text = decFica.ToString("C")
        lblFederal.Text = decFederal.ToString("C")
        lblState.Text = decState.ToString("C")
        lblNet.Text = decNet.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFica.Text = ""
        lblFederal.Text = ""
        lblState.Text = ""
        lblNet.Text = ""
        txtIncome.Clear()
        txtIncome.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class
