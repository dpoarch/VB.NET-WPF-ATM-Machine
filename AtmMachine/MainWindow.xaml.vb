Class MainWindow

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        LoadStart()
    End Sub

    Private Async Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        UnLoadStart()
        pleasewait.Visibility = Visibility.Visible
        Await PutTaskDelay()
        pleasewait.Visibility = Visibility.Hidden
        LoadPin()
    End Sub

    Private Sub btnBalance_Click(sender As Object, e As RoutedEventArgs) Handles btnBalance.Click
        UnLoadMainMenu()
        LoadBalanceMenu()
    End Sub

    Private Async Sub btnSavings_Click(sender As Object, e As RoutedEventArgs) Handles btnSavings.Click
        UnLoadBalanceMenu()
        LoadProcessing()
        Await PutTaskDelay()
        UnLoadProcessing()
        LoadAvailableBalance()
    End Sub

    Private Async Sub btnCurrent_Click(sender As Object, e As RoutedEventArgs) Handles btnCurrent.Click
        UnLoadBalanceMenu()
        LoadProcessing()
        Await PutTaskDelay()
        UnLoadProcessing()
        LoadAvailableBalance()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As RoutedEventArgs) Handles btnYes.Click
        UnLoadAvailableBalance()
        LoadMainMenu()
    End Sub

    Private Async Sub btnNo_Click(sender As Object, e As RoutedEventArgs) Handles btnNo.Click
        UnLoadAvailableBalance()
        LoadTakeCard()
        Await PutTaskDelay()
        UnLoadTakeCard()
        LoadStart()
    End Sub

    Private Sub btnWidthraw_Click(sender As Object, e As RoutedEventArgs) Handles btnWidthraw.Click
        UnLoadMainMenu()
        LoadWarn()
    End Sub

    Private Sub btnConfirmYes_Click(sender As Object, e As RoutedEventArgs) Handles btnConfirmYes.Click
        UnLoadWarn()
        LoadWidthrawMenu()
    End Sub

    Private Async Sub btnConfirmNo_Click(sender As Object, e As RoutedEventArgs) Handles btnConfirmNo.Click
        UnLoadWarn()
        LoadTakeCard()
        Await PutTaskDelay()
        UnLoadTakeCard()
        LoadStart()
    End Sub

    Private Sub btnWidthrawSavings_Click(sender As Object, e As RoutedEventArgs) Handles btnWidthrawSavings.Click
        UnLoadWidthrawMenu()
        LoadWidthrawButtons()
    End Sub

    Private Sub btnWidthrawCurrent_Click(sender As Object, e As RoutedEventArgs) Handles btnWidthrawCurrent.Click
        UnLoadWidthrawMenu()
        LoadWidthrawButtons()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As RoutedEventArgs) Handles btnMainMenu.Click
        UnLoadWidthrawButtons()
        LoadMainMenu()
    End Sub

    Private Sub btn30_Click(sender As Object, e As RoutedEventArgs) Handles btn30.Click
        UnLoadWidthrawButtons()
        LoadReceipt()
    End Sub

    Private Sub btn50_Click(sender As Object, e As RoutedEventArgs) Handles btn50.Click
        UnLoadWidthrawButtons()
        LoadReceipt()
    End Sub

    Private Sub btn100_Click(sender As Object, e As RoutedEventArgs) Handles btn100.Click
        UnLoadWidthrawButtons()
        LoadReceipt()
    End Sub

    Private Sub btn500_Click(sender As Object, e As RoutedEventArgs) Handles btn500.Click
        UnLoadWidthrawButtons()
        LoadReceipt()
    End Sub

    Private Sub btnOther_Click(sender As Object, e As RoutedEventArgs) Handles btnOther.Click
        UnLoadWidthrawButtons()
        LoadOther()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs) Handles btnClear.Click
        txtAmount.Text = ""
        Keyboard.Focus(txtAmount)
    End Sub

    Private Sub btnOtherConfirm_Click(sender As Object, e As RoutedEventArgs) Handles btnOtherConfirm.Click
        UnLoadOther()
        LoadReceipt()
    End Sub

    Private Async Sub btnReceiptYes_Click(sender As Object, e As RoutedEventArgs) Handles btnReceiptYes.Click
        UnLoadReceipt()
        LoadProcessing()
        Await PutTaskDelay()
        UnLoadProcessing()
        lblTakeCard.Visibility = Visibility.Visible
        Await PutTaskDelay()
        lblTakeCard.Visibility = Visibility.Hidden
        lblTakeCash.Visibility = Visibility.Visible
        Await PutTaskDelay()
        lblTakeCash.Visibility = Visibility.Hidden
        LoadStart()
    End Sub

    Private Async Sub btnReceiptNo_Click(sender As Object, e As RoutedEventArgs) Handles btnReceiptNo.Click
        UnLoadReceipt()
        LoadProcessing()
        Await PutTaskDelay()
        UnLoadProcessing()
        lblTakeCard.Visibility = Visibility.Visible
        Await PutTaskDelay()
        lblTakeCard.Visibility = Visibility.Hidden
        lblTakeCash.Visibility = Visibility.Visible
        Await PutTaskDelay()
        lblTakeCash.Visibility = Visibility.Hidden
        LoadStart()
    End Sub


    Private Async Sub txtPin_PasswordChanged(sender As Object, e As RoutedEventArgs)
        If txtPin.Password.Length = 6 Then
            txtPin.Password = ""
            UnLoadPin()
            lblWait.Visibility = Visibility.Visible
            Await PutTaskDelay()
            lblWait.Visibility = Visibility.Hidden
            LoadMainMenu()

        End If
    End Sub

    Private Async Function PutTaskDelay() As Task
        Await Task.Delay(3000)
    End Function

    Private Sub LoadStart()
        rect.Visibility = Visibility.Visible
        button.Visibility = Visibility.Visible
        label.Visibility = Visibility.Visible
    End Sub

    Private Sub UnLoadStart()
        rect.Visibility = Visibility.Hidden
        button.Visibility = Visibility.Hidden
        label.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadPin()
        enterPin.Visibility = Visibility.Visible
        txtPin.Visibility = Visibility.Visible
        txtPin.Focusable = True
        Keyboard.Focus(txtPin)
    End Sub

    Private Sub UnLoadPin()
        enterPin.Visibility = Visibility.Hidden
        txtPin.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadMainMenu()
        btnWidthraw.Visibility = Visibility.Visible
        btnBalance.Visibility = Visibility.Visible
        btnDeposit.Visibility = Visibility.Visible
    End Sub

    Private Sub UnLoadMainMenu()
        btnWidthraw.Visibility = Visibility.Hidden
        btnBalance.Visibility = Visibility.Hidden
        btnDeposit.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadBalanceMenu()
        btnSavings.Visibility = Visibility.Visible
        btnCurrent.Visibility = Visibility.Visible
    End Sub

    Private Sub UnLoadBalanceMenu()
        btnSavings.Visibility = Visibility.Hidden
        btnCurrent.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadSavings()
        btnSavings.Visibility = Visibility.Hidden
        btnCurrent.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadCurrent()
        btnSavings.Visibility = Visibility.Hidden
        btnCurrent.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadProcessing()
        lblProcess.Visibility = Visibility.Visible
    End Sub

    Private Sub UnLoadProcessing()
        lblProcess.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadAvailableBalance()
        lblAvailableBalance.Visibility = Visibility.Visible
        lblAvailableBalanceValue.Visibility = Visibility.Visible
        lblPerformAnother.Visibility = Visibility.Visible
        btnYes.Visibility = Visibility.Visible
        btnNo.Visibility = Visibility.Visible
    End Sub

    Private Sub UnLoadAvailableBalance()
        lblAvailableBalance.Visibility = Visibility.Hidden
        lblAvailableBalanceValue.Visibility = Visibility.Hidden
        lblPerformAnother.Visibility = Visibility.Hidden
        btnYes.Visibility = Visibility.Hidden
        btnNo.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadTakeCard()
        lblTransactionCanceled.Visibility = Visibility.Visible
    End Sub

    Private Sub UnLoadTakeCard()
        lblTransactionCanceled.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadWarn()
        lblWarn.Visibility = Visibility.Visible
        btnConfirmYes.Visibility = Visibility.Visible
        btnConfirmNo.Visibility = Visibility.Visible
    End Sub

    Private Sub UnLoadWarn()
        lblWarn.Visibility = Visibility.Hidden
        btnConfirmYes.Visibility = Visibility.Hidden
        btnConfirmNo.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadWidthrawMenu()
        btnWidthrawSavings.Visibility = Visibility.Visible
        btnWidthrawCurrent.Visibility = Visibility.Visible
    End Sub

    Private Sub UnLoadWidthrawMenu()
        btnWidthrawSavings.Visibility = Visibility.Hidden
        btnWidthrawCurrent.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadWidthrawButtons()
        lblSelectAmount.Visibility = Visibility.Visible
        btn30.Visibility = Visibility.Visible
        btn50.Visibility = Visibility.Visible
        btn100.Visibility = Visibility.Visible
        btn500.Visibility = Visibility.Visible
        btnOther.Visibility = Visibility.Visible
        btnMainMenu.Visibility = Visibility.Visible
    End Sub

    Private Sub UnLoadWidthrawButtons()
        lblSelectAmount.Visibility = Visibility.Hidden
        btn30.Visibility = Visibility.Hidden
        btn50.Visibility = Visibility.Hidden
        btn100.Visibility = Visibility.Hidden
        btn500.Visibility = Visibility.Hidden
        btnOther.Visibility = Visibility.Hidden
        btnMainMenu.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadReceipt()
        lblReceipt.Visibility = Visibility.Visible
        btnReceiptYes.Visibility = Visibility.Visible
        btnReceiptNo.Visibility = Visibility.Visible
    End Sub

    Private Sub UnLoadReceipt()
        lblReceipt.Visibility = Visibility.Hidden
        btnReceiptYes.Visibility = Visibility.Hidden
        btnReceiptNo.Visibility = Visibility.Hidden
    End Sub

    Private Sub LoadOther()
        lblPleaseEnterAmount.Visibility = Visibility.Visible
        txtAmount.Visibility = Visibility.Visible
        btnOtherConfirm.Visibility = Visibility.Visible
        btnClear.Visibility = Visibility.Visible
        txtAmount.Focusable = True
        Keyboard.Focus(txtAmount)
    End Sub

    Private Sub UnLoadOther()
        lblPleaseEnterAmount.Visibility = Visibility.Hidden
        txtAmount.Visibility = Visibility.Hidden
        btnOtherConfirm.Visibility = Visibility.Hidden
        btnClear.Visibility = Visibility.Hidden
    End Sub



End Class
