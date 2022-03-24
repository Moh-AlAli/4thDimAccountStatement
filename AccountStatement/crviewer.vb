Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Friend Class crviewer
    Dim rdoc As New ReportDocument()
    Dim conrpt As New ConnectionInfo()
    Dim server As String = ""
    Dim uid As String = ""
    Dim pass As String = ""

    Private ccompid As String
    Private ccompname As String
    Private crbfun As Boolean
    Private crbsrc As Boolean
    Private cfdate As String
    Private ctdate As String
    Private cfrmacc As String
    Private ctoacc As String
    Private cwcl As Boolean
    Private cwocl As Boolean
    Friend Property ObjectHandle As String
    Friend Sub New(ByVal objecthandle As String, ByVal compid As String, ByVal compname As String, ByVal frmacc As String, ByVal toacc As String, ByVal fd As String, ByVal td As String, ByVal rbfun As Boolean, ByVal rbsrc As Boolean, ByVal rbwcl As Boolean, ByVal rbwocl As Boolean)
        InitializeComponent()
        objecthandle = objecthandle
        ccompid = compid
        crbfun = rbfun
        crbsrc = rbsrc
        cfdate = fd
        ctdate = td
        cfrmacc = frmacc
        ctoacc = toacc
        cwcl = rbwcl
        cwocl = rbwocl
        ccompname = compname
    End Sub
    Friend Sub New(ByVal objecthandle As String)
        InitializeComponent()
        objecthandle = objecthandle
    End Sub
    Friend Function createdes(ByVal key As String) As TripleDES
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim des As TripleDES = New TripleDESCryptoServiceProvider()
        des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key))
        des.IV = New Byte(des.BlockSize \ 8 - 1) {}
        Return des
    End Function
    Friend Function Decryption(ByVal cyphertext As String, ByVal key As String) As String
        Dim b As Byte() = Convert.FromBase64String(cyphertext)
        Dim des As TripleDES = createdes(key)
        Dim ct As ICryptoTransform = des.CreateDecryptor()
        Dim output As Byte() = ct.TransformFinalBlock(b, 0, b.Length)
        Return Encoding.Unicode.GetString(output)
    End Function
    Friend Function Readconnectionstring() As String

        Dim secretkey As String = "Fhghqwjehqwlegtoit123mnk12%&4#"
        Dim path As String = ("txtcon\prucon.txt")
        Dim sr As New StreamReader(path)

        server = sr.ReadLine()
        Dim db As String = sr.ReadLine()
        uid = sr.ReadLine()
        pass = sr.ReadLine()


        server = Decryption(server, secretkey)
        uid = Decryption(uid, secretkey)
        pass = Decryption(pass, secretkey)

        Dim cons As String = "" ' = "Data Source =" & server & "; DataBase =" & Agescreen.compid & "; User Id =" & uid & "; Password =" & pass & ";"

        Return cons
    End Function
    Private Sub Cryviewer_Load(sender As Object, e As EventArgs) Handles cryviewer.Load

        Try

            If crbfun = True Then
                rdoc.Load("reports\FAccountStatement.rpt")
            ElseIf crbsrc = True Then
                rdoc.Load("reports\SAccountStatement.rpt")

            End If


            Dim tabs As Tables = rdoc.Database.Tables

            Dim fdate As String = cfdate
            Dim tdate As String = ctdate
            Dim clsopt As String = ""
            If cwcl = True Then
                clsopt = "clper"
            ElseIf cwocl = True Then
                clsopt = "wper"
            End If


            Readconnectionstring()



            For Each TAB As CrystalDecisions.CrystalReports.Engine.Table In tabs
                Dim tablog As TableLogOnInfo = TAB.LogOnInfo
                conrpt.ServerName = server '"ACCPAC" '
                conrpt.DatabaseName = ccompid
                conrpt.UserID = uid '"sa" '
                conrpt.Password = pass '"admin@123" '
                'conrpt.IntegratedSecurity = True
                tablog.ConnectionInfo = conrpt
                TAB.ApplyLogOnInfo(tablog)
            Next


            'Dim sec As Section
            'Dim secs As Sections
            'Dim rob As ReportObject
            'Dim robs As ReportObjects
            'Dim subrpobj As SubreportObject
            'Dim subrp As ReportDocument
            'Dim crSubTables As Tables
            'Dim crsubtable As Table
            'secs = rdoc.ReportDefinition.Sections
            'Dim crtableLogoninfo As New TableLogOnInfo
            'Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo
            'Dim subConInfo As New ConnectionInfo
            'For Each sec In secs
            '    robs = sec.ReportObjects
            '    For Each rob In robs
            '        If rob.Kind = ReportObjectKind.SubreportObject Then
            '            subrpobj = CType(rob, SubreportObject)
            '            subrp = subrpobj.OpenSubreport(subrpobj.SubreportName)
            '            Dim name As String = subrp.Name


            'If subrp.Name = "openbal" Then
            '    crSubTables = subrp.Database.Tables
            '    For Each crsubtable In crSubTables
            '        crtableLogoninfo = crsubtable.LogOnInfo
            '        subConInfo.ServerName = server
            '        subConInfo.DatabaseName = ccompid
            '        subConInfo.UserID = uid
            '        subConInfo.Password = pass
            '        crtableLogoninfo.ConnectionInfo = subConInfo 'ConInfo.ConnectionInfo
            '        crsubtable.ApplyLogOnInfo(crtableLogoninfo)
            '    Next
            'End If
            'End If

            '    Next
            'Next



            rdoc.SetParameterValue("Facctid", cfrmacc)
            rdoc.SetParameterValue("Tacctid", ctoacc)
            rdoc.SetParameterValue("Frmdate", fdate)
            rdoc.SetParameterValue("Todate", tdate)
            rdoc.SetParameterValue("clsopt", clsopt)
            rdoc.SetParameterValue("coname", ccompname)

            cryviewer.ReportSource = rdoc


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If rdoc Is Nothing Then
                rdoc.Close()
                rdoc.Dispose()
            End If
        End Try

    End Sub

   
End Class
