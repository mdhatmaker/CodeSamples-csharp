Imports T4
Imports T4.API

''' <summary>
''' Form that handles a single user instance.
''' </summary>
''' <remarks></remarks>
Public Class frmUser

    ''' <summary>
    ''' Reference to the parent window.
    ''' </summary>
    ''' <remarks></remarks>
    Private moParent As frmMain

    ''' <summary>
    ''' Reference to the specific user for this form.
    ''' </summary>
    ''' <remarks></remarks>
    Private WithEvents moUser As User

    ''' <summary>
    ''' Reference to the list of accounts for this user.
    ''' </summary>
    ''' <remarks></remarks>
    Private WithEvents moAccounts As AccountList

    ''' <summary>
    ''' Display the form for the master user.
    ''' </summary>
    ''' <param name="poParent"></param>
    ''' <remarks></remarks>
    Public Sub DisplayMasterUser(poParent As frmMain)

        moParent = poParent

        ' Get the master user reference, it is always index 0.
        moUser = moParent.Host.Users(0)
        moAccounts = moUser.Accounts

        ' Setup the form.
        Init()

        ' Show the form.
        Me.Show(poParent)

    End Sub

    ''' <summary>
    ''' Login the additional user.
    ''' </summary>
    ''' <param name="poParent"></param>
    ''' <param name="psUsername"></param>
    ''' <param name="psPassword"></param>
    ''' <remarks></remarks>
    Public Sub LoginUser(poParent As frmMain, psUsername As String, psPassword As String)

        moParent = poParent

        ' Login the user.
        moUser = moParent.Host.Users.LoginUser(psUsername, psPassword)
        moAccounts = moUser.Accounts

        ' Setup the form.
        Init()

        ' Show the form.
        Me.Show(poParent)

    End Sub

    ''' <summary>
    ''' Initialise the display of the form.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Init()

        ' Display the username and login state.
        If moUser.Master Then
            Me.Text = String.Format("{0} MASTER User", moUser.Username)
        Else
            Me.Text = String.Format("{0} User", moUser.Username)
        End If
        lblLoginResult.Text = moUser.LoginResult.ToString

        ' Display the list of roles this user has set.
        lstRoles.Items.Clear()
        For Each sRole As String In moUser.Roles
            If Not String.IsNullOrWhiteSpace(sRole) Then
                lstRoles.Items.Add(sRole)
            End If
        Next

        ' Display the list of accounts this user has permission for.
        DisplayAccounts()

        ' Display the list of exchanges this user can see.
        DisplayExchanges()

    End Sub

    ''' <summary>
    ''' Display the account list.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayAccounts()

        lstAccounts.Items.Clear()
        For Each oAccount As Account In moUser.Accounts.GetSortedList

            lstAccounts.Items.Add(String.Format("{0}, {1}, PL: {2}", oAccount.AccountNumber, oAccount.Status.ToString, oAccount.PL))

            ' Subscribe the account so that we can submit orders.
            oAccount.Subscribe()

        Next

    End Sub

    ''' <summary>
    ''' Display the list of exchanges.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayExchanges()

        lstExchanges.Items.Clear()
        For Each oUE As UserExchange In moUser.Exchanges.GetSortedList

            lstExchanges.Items.Add(String.Format("{0}, Permission: {1}/{2}", oUE.ExchangeID, oUE.HasPermission, oUE.HasChartPermission))

        Next

    End Sub

    ''' <summary>
    ''' Login of additional user succeeded.
    ''' </summary>
    ''' <param name="poUser"></param>
    ''' <remarks></remarks>
    Private Sub moUser_LoginSuccess(poUser As T4.API.User) Handles moUser.LoginSuccess

        ' Update the form.
        Me.BeginInvoke(New MethodInvoker(AddressOf Init))

    End Sub

    ''' <summary>
    ''' Login of additional user failed.
    ''' </summary>
    ''' <param name="poUser"></param>
    ''' <param name="penReason"></param>
    ''' <remarks></remarks>
    Private Sub moUser_LoginFailure(poUser As T4.API.User, penReason As T4.LoginResult) Handles moUser.LoginFailure

        ' Update the form.
        Me.BeginInvoke(New MethodInvoker(AddressOf Init))

    End Sub

    ''' <summary>
    ''' Submit a single order into the previously selected market.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdSubmitOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmitOrder.Click

        ' Check that we have a market selected on the main form.
        If Not moParent.Market Is Nothing Then

            ' Get the first account that this user can see, if any.
            If moUser.Accounts.Count > 0 Then

                ' Get the account.
                Dim oAccount As Account = moUser.Accounts(0)

                ' Use the settlement price of the market for the order limit price.
                Dim iTicks As Integer = moParent.Market.LastSettlement.Ticks

                ' Create the order submission object.
                Dim oSub As OrderList.Submission = oAccount.SubmitOrders(moParent.Market)

                ' Add a buy limit order for 1 lot at the last settlement price, ensuring that we set the User so that the order comes from us and not the master user.
                oSub.Add(BuySell.Buy, PriceType.Limit, TimeType.Normal, 1, iTicks, 0, OpenClose.Undefined, "", 0, ActivationType.Immediate, "", 0, Nothing, Nothing, True, moUser, True)

                ' Submit the order.
                oSub.Submit()

            End If

        End If

    End Sub

    ''' <summary>
    ''' Update our display of accounts.
    ''' </summary>
    ''' <param name="poAccounts"></param>
    ''' <remarks></remarks>
    Private Sub moAccounts_AccountDetails(poAccounts As API.AccountList.UpdateList) Handles moAccounts.AccountDetails

        ' Redisplaying entire list is not efficient but simple for this example.
        Me.BeginInvoke(New MethodInvoker(AddressOf DisplayAccounts))

    End Sub

    ''' <summary>
    ''' Update our display of accounts.
    ''' </summary>
    ''' <param name="poAccounts"></param>
    ''' <remarks></remarks>
    Private Sub moAccounts_AccountUpdate(poAccounts As API.AccountList.UpdateList) Handles moAccounts.AccountUpdate

        ' Redisplaying entire list is not efficient but simple for this example.
        Me.BeginInvoke(New MethodInvoker(AddressOf DisplayAccounts))

    End Sub

    ''' <summary>
    ''' Update our display of accounts.
    ''' </summary>
    ''' <param name="poAccounts"></param>
    ''' <remarks></remarks>
    Private Sub moAccounts_AccountComplete(poAccounts As API.AccountList.UpdateList) Handles moAccounts.AccountComplete

        ' Redisplaying entire list is not efficient but simple for this example.
        Me.BeginInvoke(New MethodInvoker(AddressOf DisplayAccounts))

    End Sub

    ''' <summary>
    ''' Logoff this user.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdLogoff_Click(sender As System.Object, e As System.EventArgs) Handles cmdLogoff.Click

        moUser.Logoff()

    End Sub

    ''' <summary>
    ''' Close the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmUser_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        ' Release the event handlers.
        moAccounts = Nothing
        moUser = Nothing

    End Sub

End Class