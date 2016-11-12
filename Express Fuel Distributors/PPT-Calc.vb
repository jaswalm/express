Public Class PPT_Calc
    Private Sub calc_btn_Click(sender As Object, e As EventArgs) Handles calc_btn.Click
        Dim reg_gal As Integer = Val(Reg_1.Text)
        Dim reg_price As Decimal = Val(Reg_2.Text) * 0.99
        Dim plus_gal As Integer = Val(Plus_1.Text)
        Dim plus_price As Decimal = Val(Plus_2.Text) * 0.99
        Dim sup_gal As Integer = Val(Sup_1.Text)
        Dim sup_price As Decimal = Val(Sup_2.Text) * 0.99
        Dim ulsd_gal As Integer = Val(ULSD_1.Text)
        Dim ulsd_price As Decimal = Val(ULSD_2.Text) * 0.99
        Dim dulsd_gal As Integer = Val(DULSD_1.Text)
        Dim dulsd_price As Decimal = Val(DULSD_2.Text) * 0.99
        Dim tax_calc_reg As Decimal = (reg_gal * 0.687) + ((reg_gal - (reg_gal * 0.1)) * 0.0019)
        Dim tax_calc_plus As Decimal = (plus_gal * 0.687) + ((plus_gal - (plus_gal * 0.1)) * 0.0019)
        Dim tax_calc_sup As Decimal = (sup_gal * 0.687) + ((sup_gal - (sup_gal * 0.1)) * 0.0019)
        Dim tax_calc_ulsd As Decimal = (ulsd_gal * 0.8875) + ((ulsd_gal - (ulsd_gal * 0.02)) * 0.0019)
        Dim tax_calc_dulsd As Decimal = (dulsd_gal * 0.0036) + ((dulsd_gal - (dulsd_gal * 0.2)) * 0.0019)

        If (reg_gal = 0 And reg_price = 0) And (plus_gal = 0 And plus_price = 0) And (sup_gal = 0 And sup_price = 0) And (ulsd_gal = 0 And ulsd_price = 0) And (dulsd_gal = 0 And dulsd_price = 0) Then
            MessageBox.Show("Either a price And gallons are not entered!!")
        ElseIf (reg_gal > 0 And reg_price = 0) Or (plus_gal > 0 And plus_price = 0) Or (sup_gal > 0 And sup_price = 0) Or (ulsd_gal > 0 And ulsd_price = 0) Or (dulsd_gal > 0 And dulsd_price = 0) Then
            MessageBox.Show("Either a price And gallons are not entered!!")
        Else
            calc_total.Text = Format(((ulsd_gal * ulsd_price) + tax_calc_ulsd) + ((dulsd_gal * dulsd_price) + tax_calc_dulsd) + ((sup_gal * sup_price) + tax_calc_sup) + ((plus_gal * plus_price) + tax_calc_plus) + ((reg_gal * reg_price) + tax_calc_reg), "0.00")

        End If



    End Sub

    Private Sub copy_btn_Click(sender As Object, e As EventArgs) Handles copy_btn.Click
        My.Computer.Clipboard.SetText(calc_total.Text)
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        For Each Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

    End Sub
End Class
