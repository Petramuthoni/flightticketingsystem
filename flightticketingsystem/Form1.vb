Imports System.Data.OleDb
Public Class Form1
    Const Dubai = 67.9
    Const London = 90.87
    Const Russia = 110.9
    Const China = 100.0
    Const India = 70.87
    Const Tax = 0.12
    Dim totaltax As Double

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label36.Click

    End Sub

    Private Sub Label40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label40.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReceipt.Click
        'firstclass Dubai 
        If ComboBox1.Text = "Dubai" And rbFirstclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = Dubai.ToString("c")
            totaltax = Dubai * Tax
            lblTax.Text = totaltax.ToString("c")
            lblTotal.Text = FormatCurrency(totaltax + Dubai)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "Dubai"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Dubai" And rbFirstclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = Dubai.ToString("c")
            totaltax = 0
            lblTax.Text = totaltax.ToString("c")
            lblTotal.Text = FormatCurrency(totaltax + Dubai)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "Dubai"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Dubai" And rbFirstclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = Dubai * 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = Val(lblTax.Text) + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Dubai"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Dubai" And rbFirstclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = Dubai * 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Dubai"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'secondclass Dubai
        ElseIf ComboBox1.Text = "Dubai" And rbSecondclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (Dubai / 2)
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "Dubai"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Dubai" And rbSecondclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = Dubai / 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "Dubai"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Dubai" And rbSecondclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (Dubai * 2) / 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Dubai"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Dubai" And rbSecondclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = (Dubai * 2) / 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Dubai"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'thirdclass Dubai
        ElseIf ComboBox1.Text = "Dubai" And rbThirdclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (Dubai / 2.5)
            totaltax = (lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "Dubai"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Dubai" And rbThirdclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = (Dubai / 2.5)
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "Dubai"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Dubai" And rbThirdclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (Dubai * 2) / 2.5
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Dubai"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Dubai" And rbThirdclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = (Dubai * 2) / 2.5
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Dubai"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'firstclass london
        ElseIf ComboBox1.Text = "London" And rbFirstclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = London
            totaltax = London * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + London
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "London"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "London" And rbFirstclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = London
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + London
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "London"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "London" And rbFirstclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = London * 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "London"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "London" And rbFirstclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = London * 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "London"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'secondclass london
        ElseIf ComboBox1.Text = "London" And rbSecondclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = London / 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "London"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "London" And rbSecondclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = London / 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "London"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "London" And rbSecondclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (London * 2) / 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "London"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "London" And rbSecondclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = (London * 2) / 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "London"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'thirdclass london
        ElseIf ComboBox1.Text = "London" And rbThirdclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (London / 2.5)
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "London"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "London" And rbThirdclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = (London / 2.5)
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "London"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "London" And rbThirdclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (London * 2) / 2.5
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "London"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "London" And rbThirdclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = (London * 2) / 2.5
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "London"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'firstclass Russia
        ElseIf ComboBox1.Text = "Russia" And rbFirstclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = Russia
            totaltax = Russia * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Russia
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "Russia"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Russia" And rbFirstclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = Russia
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Russia
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "Russia"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Russia" And rbFirstclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = Russia * 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Russia"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Russia" And rbFirstclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = Russia * 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Russia"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'secondclass russia
        ElseIf ComboBox1.Text = "Russia" And rbSecondclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = Russia / 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "Russia"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Russia" And rbSecondclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = Russia / 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "Russia"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Russia" And rbSecondclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (Russia * 2) / 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Russia"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Russia" And rbSecondclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = (Russia * 2) / 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Russia"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'thirdclass russia
        ElseIf ComboBox1.Text = "Russia" And rbThirdclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = Russia / 2.5
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "Russia"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Russia" And rbThirdclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = Russia / 2.5
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "Russia"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Russia" And rbThirdclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (Russia * 2) / 2.5
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Russia"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "Russia" And rbThirdclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = (Russia * 2) / 2.5
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Russia"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'firstclass india
        ElseIf ComboBox1.Text = "India" And rbFirstclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = India
            totaltax = India * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + India
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "India"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "India" And rbFirstclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = India
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + India
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "India"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "India" And rbFirstclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = India * 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "India"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "India" And rbFirstclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = (India * 2)
            totaltax = (0)
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "India"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'secondclass india
        ElseIf ComboBox1.Text = "India" And rbSecondclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = India / 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "India"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "India" And rbSecondclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = India / 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "India"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "India" And rbSecondclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (India * 2) / 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "India"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "India" And rbSecondclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = (India * 2) / 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "India"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'thirdclass india
        ElseIf ComboBox1.Text = "India" And rbThirdclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = India / 2.5
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "India"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "India" And rbThirdclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = India / 2.5
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "India"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "India" And rbThirdclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (India * 2) / 2.5
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "kenya"
            lblTo.Text = "India"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "India" And rbThirdclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = (India * 2) / 2.5
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "India"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'firstclass china
        ElseIf ComboBox1.Text = "China" And rbFirstclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = China
            totaltax = China * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + China
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "China"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "China" And rbFirstclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = China
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + China
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "China"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "China" And rbFirstclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = China * 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "China"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "China" And rbFirstclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = China * 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "China"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbFirstclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'secondclass china
        ElseIf ComboBox1.Text = "China" And rbSecondclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = China / 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "China"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "China" And rbSecondclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = China / 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "China"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "China" And rbSecondclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (China * 2) / 2
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "China"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "China" And rbSecondclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = (China * 2) / 2
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "China"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbSecondclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
            'thirdclass china
        ElseIf ComboBox1.Text = "China" And rbThirdclass.Checked And rbSingle.Checked And rbAdult.Checked Then
            lblSubtotal.Text = China / 2.5
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "China"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbSingle.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "China" And rbThirdclass.Checked And rbSingle.Checked And rbChild.Checked Then
            lblSubtotal.Text = (China / 2.5)
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Kenya"
            lblTo.Text = "China"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbSingle.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "China" And rbThirdclass.Checked And rbReturn.Checked And rbAdult.Checked Then
            lblSubtotal.Text = (China * 2) / 2.5
            totaltax = Val(lblSubtotal.Text) * Tax
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "Return"
            lblTo.Text = "China"
            lblPass.Text = txtpass.Text
            lblID.Text = txtId.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbReturn.Text
            lblAdult.Text = rbAdult.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()
        ElseIf ComboBox1.Text = "China" And rbThirdclass.Checked And rbReturn.Checked And rbChild.Checked Then
            lblSubtotal.Text = (China * 2) / 2.5
            totaltax = 0
            lblTax.Text = totaltax
            lblTotal.Text = totaltax + Val(lblSubtotal.Text)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = "China"
            lblTo.Text = "Kenya"
            lblPass.Text = txtpass.Text
            lblClass.Text = rbThirdclass.Text
            lblTicket.Text = rbReturn.Text
            lblChild.Text = rbChild.Text
            lblTime.Text = TimeOfDay
            lblRef.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today()



        End If
        GroupBox7.BackColor = Color.LightBlue


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Dubai")
        ComboBox1.Items.Add("London")
        ComboBox1.Items.Add("Russia")
        ComboBox1.Items.Add("China")
        ComboBox1.Items.Add("India")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        ' Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\fdos\help\me\flightticketingsystem\flightticketingsystem\flightticketingsystem\bin\Debug\flightdb.mdb

        Dim ConnectionString As String
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "\flightdb.mdb"
        Dim conn As New OleDbConnection(ConnectionString)
        Dim insert As String = "INSERT INTO Travellers VALUES('" & txtFname.Text & "','" & txtLname.Text & "','" & txtId.Text & "','" & txtpass.Text & "','" & ComboBox1.Text & "','" & lblPrice.Text & "','" & rbFirstclass.Checked & "','" & rbSecondclass.Checked & "','" & rbThirdclass.Checked & "','" & rbSingle.Checked & "','" & rbReturn.Checked & "')"
        Dim cmd As New OleDbCommand(insert, conn)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Thank you for flying with us")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
       
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim ConnectionString As String
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "\flightdb.mdb"
        Dim conn As New OleDbConnection(ConnectionString)
        Dim delete As String = "DELETE FROM Travellers WHERE Firstname='" & txtFname.Text & "'"
        Dim cmd As New OleDbCommand(delete, conn)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data deleted successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRet.Click

        Dim ConnectionString As String
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "\flightdb.mdb"
        Dim conn As New OleDbConnection(ConnectionString)
        'Dim delete As String = "DELETE FROM Travellers WHERE Firstname='" & txtFname.Text & "'"
        Dim cmd As New OleDbCommand("SELECT * FROM Travellers WHERE Firstname='" & txtFname.Text & "'", conn)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet()

        Try
            conn.Open()
            adapter.Fill(ds, "Traveller")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                'txtFname.Text = ds.Tables(0).Rows(i).Item(0)
                txtLname.Text = ds.Tables(0).Rows(i).Item(1)
                txtId.Text = ds.Tables(0).Rows(i).Item(2)
                txtpass.Text = ds.Tables(0).Rows(i).Item(3)
                ComboBox1.Text = ds.Tables(0).Rows(i).Item(4)
                lblPrice.Text = ds.Tables(0).Rows(i).Item(5)
                rbFirstclass.Checked = ds.Tables(0).Rows(i).Item(6)
                rbSecondclass.Checked = ds.Tables(0).Rows(i).Item(7)
                rbThirdclass.Checked = ds.Tables(0).Rows(i).Item(8)
                rbSingle.Checked = ds.Tables(0).Rows(i).Item(9)
                rbReturn.Checked = ds.Tables(0).Rows(i).Item(10)

            Next


        Catch ex As Exception

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ConnectionString As String
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "\flightdb.mdb"
        Dim conn As New OleDbConnection(ConnectionString)
        Dim update As String = "UPDATE  Travellers SET Firstname='" & txtFname.Text & "'Lastname='" & txtLname.Text & "'IDnumber='" & txtId.Text & "'Passengernumber='" & txtpass.Text & "'Destination='" & ComboBox1.Text & "'Price='" & lblPrice.Text & "' WHERE IDnumber='" & txtId.Text & "'"
        Dim cmd As New OleDbCommand(update, conn)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data updated successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub txtUp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUp.Click
        Dim ConnectionString As String
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "\flightdb.mdb"
        Dim conn As New OleDbConnection(ConnectionString)
        Dim update As String = "UPDATE  Travellers SET Firstname='" & txtFname.Text & "',Lastname='" & txtLname.Text & "',IDnumber='" & txtId.Text & "',Passengernumber='" & txtpass.Text & "',Destination='" & ComboBox1.Text & "',Price='" & lblPrice.Text & "' WHERE Firstname='" & txtFname.Text & "'"
        Dim cmd As New OleDbCommand(update, conn)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data updated successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
