Imports acc = ACCPAC.Advantage
Imports System.Runtime.InteropServices
Friend Class acctstate

    Public frmvend As String
    Public Tovend As String
    Public fdate As String
    Public tdate As String


    Friend Property ERPSession As acc.Session
    Friend Property Company As ERPCompany
    Friend Property SessionDate As String
    Friend Property ObjectHandle As String
    Friend compid As String
    Friend compname As String
    Private _oldVendNumb As String = ""
    <DllImport("a4wroto.dll", EntryPoint:="rotoSetObjectWindow", CharSet:=CharSet.Ansi)>
    Private Shared Sub rotoSetObjectWindow(
        <MarshalAs(UnmanagedType.I8)> ByVal objectHandle As Long,
        <MarshalAs(UnmanagedType.I8)> ByVal hWnd As Long)
    End Sub

    Friend Sub New(ByVal ses As acc.Session, ByVal comp As ERPCompany, ByVal sesDate As String)
        InitializeComponent()
        ' ObjectHandle = ""
        ERPSession = ses
        Company = comp
        compid = comp.ID
        compname = comp.Name
        SessionDate = sesDate

    End Sub

    Friend Sub New(ByVal _objectHandle As String)
        InitializeComponent()
        ObjectHandle = _objectHandle
    End Sub

    Friend Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub acctstate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not ObjectHandle Is Nothing Then
                SessionFromERP(Handle)
            End If

            'mSession.Init("", "GL", "GL0001", "65A")
            'acsignon.Signon(mSession)
            'compid = mSession.CompanyID
            'compname = mSession.CompanyName

            'xdbcom = mSession.GetDBLink(tagDBLinkTypeEnum.DBLINK_COMPANY, tagDBLinkFlagsEnum.DBLINK_FLG_READONLY)

            'If compid = "" Then
            '    Close()
            'End If
            Txttoacct.Text = "zzzzzzzzzzzzzzzzzzzzzzzzz"
            Rbfunc.Checked = True
            Rbwcl.Checked = True



        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Close()
        End Try
    End Sub



    Private Sub Bexit_Click(sender As Object, e As EventArgs) Handles CMDClose.Click
        Close()
    End Sub

    Private Sub Bprint_Click(sender As Object, e As EventArgs) Handles Bprint.Click
        Try
            Dim fmonth As String = ""
            If DateTimePicker1.Value.Month.ToString.Length < 2 Then
                fmonth = "0" & DateTimePicker1.Value.Month
            Else
                fmonth = DateTimePicker1.Value.Month
            End If

            Dim tmonth As String = ""
            If DateTimePicker2.Value.Month.ToString.Length < 2 Then
                tmonth = "0" & DateTimePicker2.Value.Month
            Else
                tmonth = DateTimePicker2.Value.Month
            End If

            Dim tday As String = ""
            If DateTimePicker2.Value.Day.ToString.Length < 2 Then
                tday = "0" & DateTimePicker2.Value.Day
            Else
                tday = DateTimePicker2.Value.Day
            End If
            Dim fday As String = ""
            If DateTimePicker1.Value.Day.ToString.Length < 2 Then
                fday = "0" & DateTimePicker1.Value.Day
            Else
                fday = DateTimePicker1.Value.Day
            End If
            fdate = DateTimePicker1.Value.Year & fmonth & fday
            tdate = DateTimePicker2.Value.Year & tmonth & tday
            If Trim(Txtfrmacct.Text) <= Trim(Txttoacct.Text) Then
                If fdate <= tdate Then
                    'If Rbfunc.Checked = True Then
                    '    rdoc = mSession.ReportSelect("FAccountStatement", "", "")
                    'ElseIf RbSrc.Checked = True Then
                    '    rdoc = mSession.ReportSelect("SAccountStatement", "", "")

                    'End If


                    Dim f As Form = New crviewer(ObjectHandle, ERPSession, Txtfrmacct.Text, Txttoacct.Text, fdate, tdate, Rbfunc.Checked, RbSrc.Checked, Rbwcl.Checked, Rbwocl.Checked)
                    f.Show()


                    'Dim clsopt As String = ""
                    'If Rbwcl.Checked = True Then
                    '    clsopt = "clper"
                    'ElseIf Rbwocl.Checked = True Then
                    '    clsopt = "wper"
                    'End If

                    'rdoc.PrinterSetup(mSession.GetPrintSetup("", ""))
                    'rdoc.SetParam("Facctid", Txtfrmacct.Text)
                    'rdoc.SetParam("Tacctid", Txttoacct.Text)
                    'rdoc.SetParam("Frmdate", fdate)
                    'rdoc.SetParam("Todate", tdate)
                    'rdoc.SetParam("clsopt", clsopt)
                    'rdoc.SetParam("coname", compname)



                    'rdoc.NumOfCopies = 1
                    'rdoc.Destination = tagPrintDestinationEnum.PD_PREVIEW
                    'rdoc.PrintReport()
                Else
                    MessageBox.Show("From Date  greater than To Date")
                End If
            Else
                MessageBox.Show("From Account No greater than To Account No")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bffind_Click(sender As Object, e As EventArgs) Handles bffind.Click
        Dim vfnd As FromFinder = New FromFinder("GLAMF", "Accounts", New String() {"ACCTID", "ACCTDESC"}, ERPSession, "", "")

        Dim r As DialogResult = vfnd.ShowDialog(Me)
        If r = DialogResult.OK Then
            Txtfrmacct.Text = vfnd.Result.ToArray()(0)
            Txttoacct.Text = vfnd.Result.ToArray()(0)
            fndEditBoxValidate(Txtfrmacct, EventArgs.Empty)
        End If

    End Sub

    Private Sub btfind_Click(sender As Object, e As EventArgs) Handles btfind.Click
        Dim vfnd As FromFinder = New FromFinder("GLAMF", "Accounts", New String() {"ACCTID", "ACCTDESC"}, ERPSession, "", "")

        Dim r As DialogResult = vfnd.ShowDialog(Me)
        If r = DialogResult.OK Then
            Txttoacct.Text = vfnd.Result.ToArray()(0)
            fndEditBoxValidate(Txttoacct, EventArgs.Empty)
        End If
    End Sub
    Private Sub fndEditBoxValidate(ByVal sender As Object, ByVal e As EventArgs)
        If CmdClose.Focused Then Return
        Dim txb As TextBox = CType(sender, TextBox)
        If String.IsNullOrEmpty(txb.Text) Then Return
        Dim msg As String = ""
        Dim s As String() = New String() {}

        Select Case txb.Name.Trim()
            Case "txtfrmcus"

                If _oldVendNumb.Trim() <> txb.Text.Trim() Then
                    msg = getValidationData("select ID=ACCTID,NAM=ACCTDESC,SW=ACTIVESW from GLAMF where ACCTID='" & txb.Text & "'", s)

                    If msg <> "" Then
                        MessageBox.Show(Me, msg, "Account Statement", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                        Return
                    End If

                    If s.Length = 0 Then
                        MessageBox.Show(Me, "Account """ & txb.Text & """ does not exists.", "Account Statement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txb.Focus()
                        txb.SelectAll()
                        Return
                    End If

                    If s(2).Trim() = "0" Then
                        MessageBox.Show(Me, "Account """ & txb.Text & """ is not active.", "Account Statement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txb.Focus()
                        txb.SelectAll()
                        Return
                    End If


                End If
                Txtfrmacct.Text = s(0)
            Case "Txttocus"

                If _oldVendNumb.Trim() <> txb.Text.Trim() Then
                    msg = getValidationData("select ID=ACCTID,NAM=ACCTDESC,SW=ACTIVESW from GLAMF where ACCTID='" & txb.Text & "'", s)

                    If msg <> "" Then
                        MessageBox.Show(Me, msg, "Account Statement", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                        Return
                    End If

                    If s.Length = 0 Then
                        MessageBox.Show(Me, "Account """ & txb.Text & """ does not exists.", "Account Statement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txb.Focus()
                        txb.SelectAll()
                        Return
                    End If

                    If s(2).Trim() = "0" Then
                        MessageBox.Show(Me, "Account """ & txb.Text & """ is not active.", "Account Statement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txb.Focus()
                        txb.SelectAll()
                        Return
                    End If


                End If


                Txttoacct.Text = s(0)
                ' End If
        End Select
    End Sub
    Private Function getValidationData(ByVal sql As String, <Out> ByRef data As String()) As String
        data = New String(2) {}
        Dim hasRecs As Boolean = False

        Try
            Dim lnk As acc.DBLink = ERPSession.OpenDBLink(acc.DBLinkType.Company, acc.DBLinkFlags.[ReadOnly])
            Dim opQry As acc.View = lnk.OpenView("CS0120")
            opQry.Cancel()
            opQry.Browse(sql, True)
            opQry.InternalSet(256)

            While opQry.Fetch(False)
                hasRecs = True
                data(0) = opQry.Fields.FieldByName("ID").Value.ToString().Trim()
                data(1) = opQry.Fields.FieldByName("NAM").Value.ToString().Trim()
                data(2) = opQry.Fields.FieldByName("SW").Value.ToString().Trim()

            End While

            opQry.Dispose()
            lnk.Dispose()
            If Not hasRecs Then data = New String() {}
            Return ""
        Catch ex As Exception
            Dim erstr As String = ""
            Dim erlst As List(Of String) = New List(Of String)()
            Util.FillErrors(ex, ERPSession, erlst)

            For Each s As String In erlst
                erstr += s & vbCrLf
            Next

            Dim ms As String = "Sage 300 ERP Error: " & erstr
            Return ms
        End Try
    End Function
    Private Sub SessionFromERP(ByVal frmHwnd As IntPtr)
        Dim lhWnd As Long = Nothing

        Try
            If ERPSession Is Nothing Then ERPSession = New acc.Session()
            If ERPSession.IsOpened Then ERPSession.Dispose()
            ERPSession.Init(ObjectHandle, "AS", "AS0001", "67A")

            If Not Long.TryParse(ObjectHandle, lhWnd) Then
                MessageBox.Show("Invalid Sage 300 ERP object handle.", "Account Statement Utility", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                ERPSession.Dispose()
                Return
            End If

            rotoSetObjectWindow(lhWnd, frmHwnd.ToInt64())
            Company = New ERPCompany(ERPSession.CompanyName, ERPSession.CompanyID)
            SessionDate = ERPSession.SessionDate.ToString()
        Catch ex As Exception
            Dim erstr As String = ""
            Dim erlst As List(Of String) = New List(Of String)()
            Util.FillErrors(ex, ERPSession, erlst)

            For Each s As String In erlst
                erstr += s & vbCrLf
            Next

            Dim ms As String = "Sage 300 ERP Error: " & erstr
            ERPSession.Dispose()
            MessageBox.Show(ms, "Account Statement", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End Try
    End Sub

    'Private Sub ClearAll(ByVal Optional includeVend As Boolean = True)
    '    If includeVend Then
    '        txtfrmcus.Clear()

    '    End If

    '    _oldVendNumb = ""

    'End Sub

End Class