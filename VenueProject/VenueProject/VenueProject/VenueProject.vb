Public Class frmVenueProject
    Dim decLOW_PRICE As Decimal = 10.99
    Dim decMID_PRICE As Decimal = 15.99
    Dim decHIGH_PRICE As Decimal = 20.99
    Dim decVIP_CHARGE As Decimal = 20.99
    Dim decSALES_TAX As Decimal = 0.05
    Dim decSubTotal As Decimal = 0
    Dim intNumberOfTickets As Integer = 0
    Dim intPitTickets As Integer = 50
    Dim intTickets As Integer = 0
    Dim strTickets As String = ""

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub HighPrice_Click(sender As Object, e As EventArgs) Handles Button84.Click, Button63.Click, Button42.Click, Button105.Click, Button1.Click, btnE9.Click, btnE8.Click, btnE7.Click, btnE6.Click, btnE5.Click, btnE4.Click, btnE3.Click, btnE20.Click, btnE2.Click, btnE19.Click, btnE18.Click, btnE17.Click, btnE16.Click, btnE15.Click, btnE14.Click, btnE13.Click, btnE12.Click, btnE11.Click, btnE10.Click, btnE1.Click, btnD9.Click, btnD8.Click, btnD7.Click, btnD6.Click, btnD5.Click, btnD4.Click, btnD3.Click, btnD20.Click, btnD2.Click, btnD19.Click, btnD18.Click, btnD17.Click, btnD16.Click, btnD15.Click, btnD14.Click, btnD13.Click, btnD12.Click, btnD11.Click, btnD10.Click, btnD1.Click, btnC9.Click, btnC8.Click, btnC7.Click, btnC6.Click, btnC5.Click, btnC4.Click, btnC3.Click, btnC20.Click, btnC2.Click, btnC19.Click, btnC18.Click, btnC17.Click, btnC16.Click, btnC15.Click, btnC14.Click, btnC13.Click, btnC12.Click, btnC11.Click, btnC10.Click, btnC1.Click, btnB9.Click, btnB8.Click, btnB7.Click, btnB6.Click, btnB5.Click, btnB4.Click, btnB3.Click, btnB20.Click, btnB2.Click, btnB19.Click, btnB18.Click, btnB17.Click, btnB16.Click, btnB15.Click, btnB14.Click, btnB13.Click, btnB12.Click, btnB11.Click, btnB10.Click, btnB1.Click, btnA9.Click, btnA8.Click, btnA7.Click, btnA6.Click, btnA5.Click, btnA4.Click, btnA3.Click, btnA20.Click, btnA2.Click, btnA19.Click, btnA18.Click, btnA17.Click, btnA16.Click, btnA15.Click, btnA14.Click, btnA13.Click, btnA12.Click, btnA11.Click, btnA10.Click, btnA1.Click
        Dim theButton As Button = sender 'Makes a button alias in order to control all seats in the High price range
        If theButton.BackColor = Color.Crimson Then 'this controls the second click (if the user is deselecting the seat)
            theButton.BackColor = Color.Gold
            decSubTotal = decSubTotal - decHIGH_PRICE
            lblSubTotal.Text = "Sub Total: " & decSubTotal.ToString("C")
            intNumberOfTickets = intNumberOfTickets - 1
            If decSubTotal = 0.0 Then
                btnCheckout.Visible = False
                lblSubTotal.Visible = False
            End If
        Else 'this controls the first click (when the user is selecting the seat)
            decSubTotal = decSubTotal + decHIGH_PRICE
            theButton.BackColor = Color.Crimson
            intNumberOfTickets = intNumberOfTickets + 1
            btnCheckout.Visible = True
            lblSubTotal.Text = "Sub Total: " & decSubTotal.ToString("C")
            lblSubTotal.Visible = True
        End If
    End Sub

    'This follows the exact same format as the Sub above, but is for the Mid price tickets.
    Private Sub MidPrice_Click(sender As Object, e As EventArgs) Handles Button210.Click, Button189.Click, Button168.Click, Button147.Click, Button126.Click, btnJ9.Click, btnJ8.Click, btnJ7.Click, btnJ6.Click, btnJ5.Click, btnJ4.Click, btnJ3.Click, btnJ20.Click, btnJ2.Click, btnJ19.Click, btnJ18.Click, btnJ17.Click, btnJ16.Click, btnJ15.Click, btnJ14.Click, btnJ13.Click, btnJ12.Click, btnJ11.Click, btnJ10.Click, btnJ1.Click, btnI9.Click, btnI8.Click, btnI7.Click, btnI6.Click, btnI5.Click, btnI4.Click, btnI3.Click, btnI20.Click, btnI2.Click, btnI19.Click, btnI18.Click, btnI17.Click, btnI16.Click, btnI15.Click, btnI14.Click, btnI13.Click, btnI12.Click, btnI11.Click, btnI10.Click, btnI1.Click, btnH9.Click, btnH8.Click, btnH7.Click, btnH6.Click, btnH5.Click, btnH4.Click, btnH3.Click, btnH20.Click, btnH2.Click, btnH19.Click, btnH18.Click, btnH17.Click, btnH16.Click, btnH15.Click, btnH14.Click, btnH13.Click, btnH12.Click, btnH11.Click, btnH10.Click, btnH1.Click, btnG9.Click, btnG8.Click, btnG7.Click, btnG6.Click, btnG5.Click, btnG4.Click, btnG3.Click, btnG20.Click, btnG2.Click, btnG19.Click, btnG18.Click, btnG17.Click, btnG16.Click, btnG15.Click, btnG14.Click, btnG13.Click, btnG12.Click, btnG11.Click, btnG10.Click, btnG1.Click, btnF9.Click, btnF8.Click, btnF7.Click, btnF6.Click, btnF5.Click, btnF4.Click, btnF3.Click, btnF20.Click, btnF2.Click, btnF19.Click, btnF18.Click, btnF17.Click, btnF16.Click, btnF15.Click, btnF14.Click, btnF13.Click, btnF12.Click, btnF11.Click, btnF10.Click, btnF1.Click
        Dim theButton As Button = sender
        If theButton.BackColor = Color.Crimson Then
            theButton.BackColor = Color.LightSkyBlue
            decSubTotal = decSubTotal - decMID_PRICE
            lblSubTotal.Text = "Sub Total: " & decSubTotal.ToString("C")
            intNumberOfTickets = intNumberOfTickets - 1
            If decSubTotal = 0.0 Then
                btnCheckout.Visible = False
                lblSubTotal.Visible = False
            End If
        Else
            decSubTotal = decSubTotal + decMID_PRICE
            theButton.BackColor = Color.Crimson
            intNumberOfTickets = intNumberOfTickets + 1
            btnCheckout.Visible = True
            lblSubTotal.Text = "Sub Total: " & decSubTotal.ToString("C")
            lblSubTotal.Visible = True
        End If
    End Sub

    'Controls when the user clicks the PIT button
    Private Sub btnPIT_Click(sender As Object, e As EventArgs) Handles btnPIT.Click
        Dim strPitTickets As String = ""
        If btnPIT.BackColor = Color.PaleGreen Then 'when the user clicks, an input box appears to enter the quantity of tickets wanted
            strPitTickets = InputBox("How many would you like?")
            If IsNumeric(strPitTickets) Then 'checks the ensure that the user input a numeric number
                intTickets = Convert.ToInt16(strPitTickets)
                If intTickets > 0 And intTickets <= intPitTickets Then 'ensures that the user input a positive number and that the number of tickets they want are avalible
                    intNumberOfTickets = intNumberOfTickets + intTickets
                    decSubTotal = decSubTotal + (intTickets * decLOW_PRICE)
                    btnCheckout.Visible = True
                    lblSubTotal.Text = "Sub Total: " & decSubTotal.ToString("C")
                    lblSubTotal.Visible = True
                    btnPIT.BackColor = Color.Crimson
                    btnPitClear.Visible = True
                    lblAvaliblePIT.Visible = False
                    lblPitTickets.Text = "You have selected " & intTickets.ToString & " tickets."
                    lblPitTickets.Visible = True
                Else
                    MsgBox("Error. Invalid Entry.")
                End If
            Else
                MsgBox("Error. Invalid Entry.")
            End If
        End If
    End Sub

    'This clears the PIT tickets from the selection when the user clicks it. 
    Private Sub btnPitClear_Click(sender As Object, e As EventArgs) Handles btnPitClear.Click
        btnPIT.BackColor = Color.PaleGreen
        lblPitTickets.Visible = False
        lblAvaliblePIT.Visible = True
        btnPitClear.Visible = False
        intNumberOfTickets = intNumberOfTickets - intTickets
        decSubTotal = decSubTotal - (intTickets * decLOW_PRICE)
        intTickets = 0
        lblSubTotal.Text = "Sub Total: " & decSubTotal.ToString("C")
        If decSubTotal = 0.0 Then
            btnCheckout.Visible = False
            lblSubTotal.Visible = False
        End If
    End Sub

    'Closes the Seat Selection page and shows the Checkout page
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        lblSubTotal.Visible = False
        lblAvaliblePIT.Visible = False
        lblCheckoutHeader.Visible = True
        lblCheckoutTickets.Visible = True
        lblEmail.Visible = True
        lblFirstName.Visible = True
        lblLastName.Visible = True
        lblPhoneNumber.Visible = True
        tbEmail.Visible = True
        tbFirstName.Visible = True
        tbLastName.Visible = True
        tbPhoneNumber.Visible = True
        grpVIP.Visible = True
        btnGoBack.Visible = True
        btnPurchase.Visible = False
        lblClosing.Visible = False
        lblPickup.Visible = False
        btnNext.Visible = False
        btnPitClear.Visible = False
        lblPitTickets.Visible = False
        btnPurchase.Visible = True
        pnlCheckout.Visible = True
        strTickets = "Your Tickets: "
        'These go through the seats to determine which ones the user has selected, if it has then it adds the seat name to a the string strTckets
        For i As Integer = 1 To 20
            If Me.Controls("btnA" & i).BackColor = Color.Crimson Then
                strTickets = strTickets & " - A" & i.ToString
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnB" & i).BackColor = Color.Crimson Then
                strTickets = strTickets & " - B" & i.ToString
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnC" & i).BackColor = Color.Crimson Then
                strTickets = strTickets & " - C" & i.ToString
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnD" & i).BackColor = Color.Crimson Then
                strTickets = strTickets & " - D" & i.ToString
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnE" & i).BackColor = Color.Crimson Then
                strTickets = strTickets & " - E" & i.ToString
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnF" & i).BackColor = Color.Crimson Then
                strTickets = strTickets & " - F" & i.ToString
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnG" & i).BackColor = Color.Crimson Then
                strTickets = strTickets & " - G" & i.ToString
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnH" & i).BackColor = Color.Crimson Then
                strTickets = strTickets & " - H" & i.ToString
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnI" & i).BackColor = Color.Crimson Then
                strTickets = strTickets & " - I" & i.ToString
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnJ" & i).BackColor = Color.Crimson Then
                strTickets = strTickets & " - J" & i.ToString
            End If
        Next
        If btnPIT.BackColor = Color.Crimson Then
            strTickets = strTickets & " - " & intTickets.ToString & " PIT Ticket(s)."
        End If
        lblCheckoutTickets.Text = strTickets
    End Sub

    'This controls what happens when the user selects a VIP option
    Private Sub btnVIPEnter_Click(sender As Object, e As EventArgs) Handles btnVIPEnter.Click
        If rbtnYes.Checked Then 'If yes then it adds $20.99 per ticket before tax, calculates tax, and displays the total
            lblCheckoutSubTotal.Text = "Sub Total:   " & (decSubTotal + (intNumberOfTickets * decVIP_CHARGE)).ToString("C")
            lblCheckoutTax.Text = "Tax:   " & ((decSubTotal + (intNumberOfTickets * decVIP_CHARGE)) * decSALES_TAX).ToString("C")
            lblCheckoutTotal.Text = "Total:   " & (decSubTotal + (intNumberOfTickets * decVIP_CHARGE) + (decSubTotal * decSALES_TAX)).ToString("C")
            lblCheckoutSubTotal.Visible = True
            lblCheckoutTax.Visible = True
            lblCheckoutTotal.Visible = True
        End If
        If rbtnNo.Checked Then 'If no then it just calculates the tax, and displays the total
            lblCheckoutSubTotal.Text = "Sub Total:   " & decSubTotal.ToString("C")
            lblCheckoutTax.Text = "Tax:   " & (decSubTotal * decSALES_TAX).ToString("C")
            lblCheckoutTotal.Text = "Total:   " & (decSubTotal + (decSubTotal * decSALES_TAX)).ToString("C")
            lblCheckoutSubTotal.Visible = True
            lblCheckoutTax.Visible = True
            lblCheckoutTotal.Visible = True
        End If
    End Sub

    'This controls when the user clicks the Go Back button. It closes the Checkout page and reopens the Seat Selection page. 
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        pnlCheckout.Visible = False
        lblSubTotal.Visible = True
        strTickets = "" 'This needs to be cleared because the user could change what tickets they have selected before clicking Checkout again.
        lblCheckoutSubTotal.Visible = False
        lblCheckoutTax.Visible = False
        lblCheckoutTotal.Visible = False
        rbtnNo.Checked = False
        rbtnYes.Checked = False
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        'Ensures that the user has entered all of the required information before purchasing the tickets
        If tbFirstName.Text = "" Or tbLastName.Text = "" Or tbEmail.Text = "" Or tbPhoneNumber.Text = "" Then
            MsgBox("Please enter information for all fields.")
        ElseIf lblCheckoutSubTotal.Visible = False Then
            MsgBox("Please select a VIP option.")
        Else
            'If all information has been entered, the Checkout page is cleared so that the only option is to hit the Next button
            lblCheckoutHeader.Visible = False
            lblCheckoutSubTotal.Visible = False
            lblCheckoutTax.Visible = False
            lblCheckoutTickets.Visible = False
            lblCheckoutTotal.Visible = False
            lblEmail.Visible = False
            lblFirstName.Visible = False
            lblLastName.Visible = False
            lblPhoneNumber.Visible = False
            tbEmail.Visible = False
            tbFirstName.Visible = False
            tbLastName.Visible = False
            tbPhoneNumber.Visible = False
            grpVIP.Visible = False
            btnGoBack.Visible = False
            btnPurchase.Visible = False
            lblClosing.Text = strTickets
            lblClosing.Visible = True
            lblPickup.Visible = True
            btnNext.Visible = True
            tbEmail.Text = ""
            tbFirstName.Text = ""
            tbLastName.Text = ""
            tbPhoneNumber.Text = ""
            rbtnNo.Checked = False
            rbtnYes.Checked = False
        End If
    End Sub

    'When the Next button is clicked this checks what buttons have been selected by the user who just made a purchase. 
    'Those tickets are then disabled so that other people cannot buy purchased tickets.
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        For i As Integer = 1 To 20
            If Me.Controls("btnA" & i).BackColor = Color.Crimson Then
                Me.Controls("btnA" & i).BackColor = Color.Gray
                Me.Controls("btnA" & i).Enabled = False
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnB" & i).BackColor = Color.Crimson Then
                Me.Controls("btnB" & i).BackColor = Color.Gray
                Me.Controls("btnB" & i).Enabled = False
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnC" & i).BackColor = Color.Crimson Then
                Me.Controls("btnC" & i).BackColor = Color.Gray
                Me.Controls("btnC" & i).Enabled = False
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnD" & i).BackColor = Color.Crimson Then
                Me.Controls("btnD" & i).BackColor = Color.Gray
                Me.Controls("btnD" & i).Enabled = False
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnE" & i).BackColor = Color.Crimson Then
                Me.Controls("btnE" & i).BackColor = Color.Gray
                Me.Controls("btnE" & i).Enabled = False
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnF" & i).BackColor = Color.Crimson Then
                Me.Controls("btnF" & i).BackColor = Color.Gray
                Me.Controls("btnF" & i).Enabled = False
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnG" & i).BackColor = Color.Crimson Then
                Me.Controls("btnG" & i).BackColor = Color.Gray
                Me.Controls("btnG" & i).Enabled = False
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnH" & i).BackColor = Color.Crimson Then
                Me.Controls("btnH" & i).BackColor = Color.Gray
                Me.Controls("btnH" & i).Enabled = False
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnI" & i).BackColor = Color.Crimson Then
                Me.Controls("btnI" & i).BackColor = Color.Gray
                Me.Controls("btnI" & i).Enabled = False
            End If
        Next
        For i As Integer = 1 To 20
            If Me.Controls("btnJ" & i).BackColor = Color.Crimson Then
                Me.Controls("btnJ" & i).BackColor = Color.Gray
                Me.Controls("btnJ" & i).Enabled = False
            End If
        Next
        'If PIT Tickets were prchased the quantity is subtracted from the total avalible PIT Tickets
        'The PIT button is only disabled if there are 0 PIT Tickets left
        If btnPIT.BackColor = Color.Crimson Then
            intPitTickets = intPitTickets - intTickets
            lblAvaliblePIT.Text = intPitTickets.ToString & " Tickets Left"
            btnPIT.BackColor = Color.PaleGreen
            If intPitTickets = 0 Then
                btnPIT.BackColor = Color.Gray
                btnPIT.Enabled = False
                lblAvaliblePIT.Visible = False
            End If
        End If
        strTickets = ""
        decSubTotal = 0.0
        intNumberOfTickets = 0
        intTickets = 0
        pnlCheckout.Visible = False
        lblAvaliblePIT.Visible = True
        btnCheckout.Visible = False
    End Sub
End Class
