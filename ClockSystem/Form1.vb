Imports System.Data.SqlClient
Imports System.Windows.Forms.MessageBox
Imports System.Windows.Forms.MessageBoxButtons
Imports System.Windows.Forms.MessageBoxOptions
Imports System.Windows.Forms.MessageBoxIcon
Imports System.Windows.Forms.MessageBoxDefaultButton
Imports System.Windows.Forms.Message
Imports System.Data.OleDb


Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        VersãoToolStripMenuItem.BackColor = Color.Gray
        VersãoToolStripMenuItem.ForeColor = Color.White

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        'If TextBox1.TextLength > 1 Then
        'Dim caixa As textbox1
        'Dim consulta As String = "SELECT * FROM processadores"
        'Dim conexao As SqlConnection = New SqlConnection("Data Source=WINDOWS10; Initial Catalog=clocksystem; Integrated Security=true; Pooling=false")
        'Dim comando As New SqlCommand(consulta, conexao)
        'comando.Parameters.Add(New SqlParameter("@clock", Label2.Text))
        'comando.Parameters.Add(New SqlParameter("@soquete", Label4.Text))
        'conexao.Open()
        'comando.ExecuteNonQuery()
        'conexao.Close()

        Panel1.Hide()

        If RadioButton1.Checked Then


            If TextBox1.Text.Length > 0 Then
                'Button3.Visible = True
                Try
                    Dim texto = UCase(TextBox1.Text)
                    GroupBox1.Visible = True
                    PictureBox1.Visible = False
                    GroupBox1.Text = TextBox1.Text
                    Dim consulta1 As String = "SELECT processador,clock,soquete,memoria FROM processadores WHERE processador LIKE '%" & texto & "%'"
                    Dim conexao1 As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & Application.StartupPath & "\clocksystem.mdb")
                    Dim comando1 As New OleDbCommand(consulta1, conexao1)
                    Dim da As New OleDbDataAdapter(comando1)
                    Dim dt As New DataTable

                    conexao1.Open()
                    da.Fill(dt)
                    Label2.Text = dt.Rows(0)("clock").ToString
                    TextBox2.Text = dt.Rows(0)("soquete").ToString
                    Label4.Text = dt.Rows(0)("memoria").ToString
                    comando1.ExecuteNonQuery()
                    conexao1.Close()

                    'Label2.Text = "800"
                    Timer1.Enabled = False
                Catch
                    TextBox1.Text = " "
                    MessageBox.Show("Informe o nome correto do processador " & TextBox1.Text & "!", "ClockSys", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Me.Close()


                    Dim texto = UCase(TextBox1.Text)
                    GroupBox1.Visible = True
                    PictureBox1.Visible = False
                    GroupBox1.Text = TextBox1.Text
                    Dim consulta1 As String = "SELECT processador,clock,soquete,  memoria FROM processadores WHERE processador LIKE '%" & texto & "%'"
                    Dim conexao1 As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & Application.StartupPath & "\clocksystem.mdb") 'o registro sera adicionado na pasta debug do projeto
                    Dim comando1 As New OleDbCommand(consulta1, conexao1)
                    Dim da As New OleDbDataAdapter(comando1)
                    Dim dt As New DataTable

                    conexao1.Open()
                    da.Fill(dt)
                    Label2.Text = dt.Rows(0)("clock").ToString
                    TextBox2.Text = dt.Rows(0)("soquete").ToString
                    Label4.Text = dt.Rows(0)("memoria").ToString
                    comando1.ExecuteNonQuery()
                    conexao1.Close()



                End Try


            End If

        End If






        If RadioButton2.Checked Then

            If TextBox1.Text.Length > 0 Then
                'Button3.Visible = True
                Try
                    Dim texto = UCase(TextBox1.Text)
                    GroupBox1.Visible = True
                    PictureBox1.Visible = False
                    GroupBox1.Text = TextBox1.Text
                    Dim consulta1 As String = "SELECT processador,clock,soquete,memoria FROM processadores WHERE processador LIKE '%" & texto & "%'"
                    Dim conexao1 As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & Application.StartupPath & "\clocksystem.mdb")
                    Dim comando1 As New OleDbCommand(consulta1, conexao1)
                    Dim da As New OleDbDataAdapter(comando1)
                    Dim dt As New DataTable

                    conexao1.Open()
                    da.Fill(dt)
                    Label2.Text = dt.Rows(0)("clock").ToString
                    TextBox2.Text = dt.Rows(0)("soquete").ToString
                    Label4.Text = dt.Rows(0)("memoria").ToString
                    comando1.ExecuteNonQuery()
                    conexao1.Close()

                    'Label2.Text = "800"
                    Timer1.Enabled = False
                Catch
                    TextBox1.Text = " "
                    MessageBox.Show("Informe o nome correto do processador " & TextBox1.Text & "!", "ClockSys", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Me.Close()


                    Dim texto = UCase(TextBox1.Text)
                    GroupBox1.Visible = True
                    PictureBox1.Visible = False
                    GroupBox1.Text = TextBox1.Text
                    Dim consulta1 As String = "SELECT processador,clock,soquete,  memoria FROM processadores WHERE processador LIKE '%" & texto & "%'"
                    Dim conexao1 As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & Application.StartupPath & "\clocksystem.mdb") 'o registro sera adicionado na pasta debug do projeto
                    Dim comando1 As New OleDbCommand(consulta1, conexao1)
                    Dim da As New OleDbDataAdapter(comando1)
                    Dim dt As New DataTable

                    conexao1.Open()
                    da.Fill(dt)
                    Label2.Text = dt.Rows(0)("clock").ToString
                    TextBox2.Text = dt.Rows(0)("soquete").ToString
                    Label4.Text = dt.Rows(0)("memoria").ToString
                    comando1.ExecuteNonQuery()
                    conexao1.Close()



                End Try

            End If

            ' If TextBox1.Text = "CORE I5" Then
            ' Dim texto = UCase(TextBox1.Text)
            ' GroupBox1.Visible = True
            '  PictureBox1.Visible = False
            ' GroupBox1.Text = TextBox1.Text
            '  Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            '   Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            '  Dim comando1 As New SqlCommand(consulta1, conexao1)
            '   Dim da As New SqlDataAdapter(comando1)
            '  Dim dt As New DataTable

            ' conexao1.Open()
            '  da.Fill(dt)
            '  Label2.Text = dt.Rows(0)("clock").ToString
            ' TextBox2.Text = dt.Rows(0)("soquete").ToString
            ' Label4.Text = dt.Rows(0)("memoria").ToString
            ' comando1.ExecuteNonQuery()
            ' conexao1.Close()

            'Label2.Text = "800"
            ' Timer1.Enabled = False


            'End If


            ' If TextBox1.Text = "CORE I3" Then
            '  Dim texto = UCase(TextBox1.Text)
            ' GroupBox1.Visible = True
            ' PictureBox1.Visible = False
            ' GroupBox1.Text = TextBox1.Text
            ' Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            '  Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            '  Dim comando1 As New SqlCommand(consulta1, conexao1)
            '  Dim da As New SqlDataAdapter(comando1)
            ' Dim dt As New DataTable

            ' conexao1.Open()
            ' da.Fill(dt)
            '  Label2.Text = dt.Rows(0)("clock").ToString
            '  TextBox2.Text = dt.Rows(0)("soquete").ToString
            ' Label4.Text = dt.Rows(0)("memoria").ToString
            ' comando1.ExecuteNonQuery()
            ' conexao1.Close()

            'Label2.Text = "800"
            ' Timer1.Enabled = False


            'End If


            'If TextBox1.Text = "PENTIUM" Then
            '  Dim texto = UCase(TextBox1.Text)
            '  GroupBox1.Visible = True
            ' PictureBox1.Visible = False
            '  GroupBox1.Text = TextBox1.Text
            '  Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            ' Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            ' Dim comando1 As New SqlCommand(consulta1, conexao1)
            ' Dim da As New SqlDataAdapter(comando1)
            ' Dim dt As New DataTable

            ' conexao1.Open()
            ' da.Fill(dt)
            ' Label2.Text = dt.Rows(0)("clock").ToString
            ' TextBox2.Text = dt.Rows(0)("soquete").ToString
            ' Label4.Text = dt.Rows(0)("memoria").ToString
            ' comando1.ExecuteNonQuery()
            ' conexao1.Close()

            'Label2.Text = "800"
            '  Timer1.Enabled = False


            'End If




            'If TextBox1.Text = "CELERON" Then
            ' Dim texto = UCase(TextBox1.Text)
            ' GroupBox1.Visible = True
            ' PictureBox1.Visible = False
            ' GroupBox1.Text = TextBox1.Text
            ' Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            ' Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            ' Dim comando1 As New SqlCommand(consulta1, conexao1)
            ' Dim da As New SqlDataAdapter(comando1)
            ' Dim dt As New DataTable

            ' conexao1.Open()
            ' da.Fill(dt)
            ' Label2.Text = dt.Rows(0)("clock").ToString
            '  TextBox2.Text = dt.Rows(0)("soquete").ToString
            '  Label4.Text = dt.Rows(0)("memoria").ToString
            ' comando1.ExecuteNonQuery()
            ' conexao1.Close()

            'Label2.Text = "800"
            ' Timer1.Enabled = False


            'End If


            ' If TextBox1.Text = "CELERON M" Then
            ' Dim texto = UCase(TextBox1.Text)
            ' GroupBox1.Visible = True
            ' PictureBox1.Visible = False
            ' GroupBox1.Text = TextBox1.Text
            ' Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            ' Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            '  Dim comando1 As New SqlCommand(consulta1, conexao1)
            '  Dim da As New SqlDataAdapter(comando1)
            ' Dim dt As New DataTable

            ' conexao1.Open()
            ' da.Fill(dt)
            ' Label2.Text = dt.Rows(0)("clock").ToString
            '  TextBox2.Text = dt.Rows(0)("soquete").ToString
            ' Label4.Text = dt.Rows(0)("memoria").ToString
            ' comando1.ExecuteNonQuery()
            'conexao1.Close()

            'Label2.Text = "800"
            ' Timer1.Enabled = False


            ' End If


            ' If TextBox1.Text = "CELERON D" Then
            '  Dim texto = UCase(TextBox1.Text)
            '  GroupBox1.Visible = True
            '  PictureBox1.Visible = False
            ' GroupBox1.Text = TextBox1.Text
            ' Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            ' Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            ' Dim comando1 As New SqlCommand(consulta1, conexao1)
            ' Dim da As New SqlDataAdapter(comando1)
            ' Dim dt As New DataTable

            ' conexao1.Open()
            ' da.Fill(dt)
            ' Label2.Text = dt.Rows(0)("clock").ToString
            ' TextBox2.Text = dt.Rows(0)("soquete").ToString
            ' Label4.Text = dt.Rows(0)("memoria").ToString
            ' comando1.ExecuteNonQuery()
            ' conexao1.Close()

            'Label2.Text = "800"
            ' Timer1.Enabled = False


            'End If



            'If TextBox1.Text = "CORE 2 DUO" Or TextBox1.Text = "CORE II DUO" Then
            ' Dim texto = UCase(TextBox1.Text)
            ' GroupBox1.Visible = True
            ' PictureBox1.Visible = False
            ' GroupBox1.Text = TextBox1.Text
            ' Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            '  Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            '  Dim comando1 As New SqlCommand(consulta1, conexao1)
            '  Dim da As New SqlDataAdapter(comando1)
            ' Dim dt As New DataTable

            ' conexao1.Open()
            ' da.Fill(dt)
            '  Label2.Text = dt.Rows(0)("clock").ToString
            '  TextBox2.Text = dt.Rows(0)("soquete").ToString
            ' Label4.Text = dt.Rows(0)("memoria").ToString
            '  comando1.ExecuteNonQuery()
            '  conexao1.Close()

            'Label2.Text = "800"
            '  Timer1.Enabled = False


            '  End If


            ' If TextBox1.Text = "CORE 2 EXTREME" Or TextBox1.Text = "CORE II EXTREME" Then
            '  Dim texto = UCase(TextBox1.Text)
            '  GroupBox1.Visible = True
            ' PictureBox1.Visible = False
            ' GroupBox1.Text = TextBox1.Text
            ' Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            '  Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            '  Dim comando1 As New SqlCommand(consulta1, conexao1)
            '  Dim da As New SqlDataAdapter(comando1)
            '  Dim dt As New DataTable

            '  conexao1.Open()
            '  da.Fill(dt)
            '  Label2.Text = dt.Rows(0)("clock").ToString
            '  TextBox2.Text = dt.Rows(0)("soquete").ToString
            '  Label4.Text = dt.Rows(0)("memoria").ToString
            ' comando1.ExecuteNonQuery()
            'conexao1.Close()

            'Label2.Text = "800"
            ' Timer1.Enabled = False


            ' End If


            'If TextBox1.Text = "CORE 2 QUAD" Or TextBox1.Text = "CORE II QUAD" Then
            ' Dim texto = UCase(TextBox1.Text)
            ' GroupBox1.Visible = True
            ' PictureBox1.Visible = False
            ' GroupBox1.Text = TextBox1.Text
            '  Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            '  Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            '  Dim comando1 As New SqlCommand(consulta1, conexao1)
            '  Dim da As New SqlDataAdapter(comando1)
            '  Dim dt As New DataTable

            ' conexao1.Open()
            '  da.Fill(dt)
            ' Label2.Text = dt.Rows(0)("clock").ToString
            '  TextBox2.Text = dt.Rows(0)("soquete").ToString
            '  Label4.Text = dt.Rows(0)("memoria").ToString
            '  comando1.ExecuteNonQuery()
            '  conexao1.Close()

            'Label2.Text = "800"
            ' Timer1.Enabled = False


            'End If


            ' If TextBox1.Text = "XEON" Then
            '  Dim texto = UCase(TextBox1.Text)
            ' GroupBox1.Visible = True
            ' PictureBox1.Visible = False
            '  GroupBox1.Text = TextBox1.Text
            ''  Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            '  Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            ' Dim comando1 As New SqlCommand(consulta1, conexao1)
            ' Dim da As New SqlDataAdapter(comando1)
            ' Dim dt As New DataTable

            ' conexao1.Open()
            ' da.Fill(dt)
            ' Label2.Text = dt.Rows(0)("clock").ToString
            ' TextBox2.Text = dt.Rows(0)("soquete").ToString
            '  Label4.Text = dt.Rows(0)("memoria").ToString
            ' comando1.ExecuteNonQuery()
            ' conexao1.Close()

            'Label2.Text = "800"
            'Timer1.Enabled = False


            'End If



            'If TextBox1.Text = "PENTIUM EXTREME EDITION" Or TextBox1.Text = "PENTIUM EXTREME" Or TextBox1.Text = "PENTIUM EE" Then
            'Dim texto = UCase(TextBox1.Text)
            'GroupBox1.Visible = True
            'PictureBox1.Visible = False
            'GroupBox1.Text = TextBox1.Text
            'Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            ' Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            '  Dim comando1 As New SqlCommand(consulta1, conexao1)
            '   Dim da As New SqlDataAdapter(comando1)
            '    Dim dt As New DataTable

            'conexao1.Open()
            'da.Fill(dt)
            'Label2.Text = dt.Rows(0)("clock").ToString
            'TextBox2.Text = dt.Rows(0)("soquete").ToString
            'Label4.Text = dt.Rows(0)("memoria").ToString
            'comando1.ExecuteNonQuery()
            'conexao1.Close()

            'Label2.Text = "800"
            'Timer1.Enabled = False


            'End If


            'If TextBox1.Text = "TURION II" Then
            'Dim texto = UCase(TextBox1.Text)
            'GroupBox1.Visible = True
            'PictureBox1.Visible = False
            'GroupBox1.Text = TextBox1.Text
            ' Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            ' Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            ' Dim comando1 As New SqlCommand(consulta1, conexao1)
            'Dim da As New SqlDataAdapter(comando1)
            'Dim dt As New DataTable

            'conexao1.Open()
            'da.Fill(dt)
            'Label2.Text = dt.Rows(0)("clock").ToString
            'TextBox2.Text = dt.Rows(0)("soquete").ToString
            'Label4.Text = dt.Rows(0)("memoria").ToString
            'comando1.ExecuteNonQuery()
            'conexao1.Close()

            'Label2.Text = "800"
            'Timer1.Enabled = False


            'End If


            ' If TextBox1.Text = "ATHLON II" Then
            ' Dim texto = UCase(TextBox1.Text)
            'GroupBox1.Visible = True
            ' PictureBox1.Visible = False
            ' GroupBox1.Text = TextBox1.Text
            'Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            ' Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            'Dim comando1 As New SqlCommand(consulta1, conexao1)
            'Dim da As New SqlDataAdapter(comando1)
            'Dim dt As New DataTable

            'conexao1.Open()
            ' da.Fill(dt)
            'Label2.Text = dt.Rows(0)("clock").ToString
            'TextBox2.Text = dt.Rows(0)("soquete").ToString
            'Label4.Text = dt.Rows(0)("memoria").ToString
            'comando1.ExecuteNonQuery()
            'conexao1.Close()

            'Label2.Text = "800"
            'Timer1.Enabled = False


            'End If



            'If TextBox1.Text = "V" Then
            'Dim texto = UCase(TextBox1.Text)
            'GroupBox1.Visible = True
            'PictureBox1.Visible = False
            'GroupBox1.Text = TextBox1.Text
            'Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            'Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            'Dim comando1 As New SqlCommand(consulta1, conexao1)
            'Dim da As New SqlDataAdapter(comando1)
            'Dim dt As New DataTable

            'conexao1.Open()
            'da.Fill(dt)
            'Label2.Text = dt.Rows(0)("clock").ToString
            'TextBox2.Text = dt.Rows(0)("soquete").ToString
            'Label4.Text = dt.Rows(0)("memoria").ToString
            'comando1.ExecuteNonQuery()
            'conexao1.Close()

            'Label2.Text = "800"
            'Timer1.Enabled = False


            'End If



            'If TextBox1.Text = "V SERIES" Then
            'Dim texto = UCase(TextBox1.Text)
            'GroupBox1.Visible = True
            ' PictureBox1.Visible = False
            'GroupBox1.Text = TextBox1.Text
            'Dim consulta1 As String = "SELECT * FROM processadores WHERE processador LIKE '%" & texto & "%'"
            'Dim conexao1 As SqlConnection = New SqlConnection("Data source=WINDOWS10; initial catalog=clocksystem; integrated security=true; pooling=false")
            'Dim comando1 As New SqlCommand(consulta1, conexao1)
            'Dim da As New SqlDataAdapter(comando1)
            ' Dim dt As New DataTable

            ' conexao1.Open()
            'da.Fill(dt)
            'Label2.Text = dt.Rows(0)("clock").ToString
            ' TextBox2.Text = dt.Rows(0)("soquete").ToString
            'Label4.Text = dt.Rows(0)("memoria").ToString
            'comando1.ExecuteNonQuery()
            'conexao1.Close()


            'Timer1.Enabled = False



        End If



    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        GroupBox1.Visible = False
        PictureBox1.Visible = True
        Timer1.Enabled = True
       
    End Sub


    'Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
    'Timer2.Enabled = True
    ' TextBox1.Text = "" Then
    '  MsgBox("Informe o nome correto do processador", MessageBoxButtons.OKCancel)
    'End If
    'Timer2.Enabled = False
    'End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.4shared.com/rar/1Fqkjh5jba/ClockSys.html")
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick


        Panel1.BringToFront()

        If RadioButton1.Checked Then
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If

        If RadioButton2.Checked Then
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If

    End Sub

    
    Private Sub VersãoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VersãoToolStripMenuItem.Click
        MsgBox("Versão do programa: 2.0 revision 1", MsgBoxStyle.Information)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        form2.show()
        Me.Hide()

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim texto = UCase(TextBox1.Text)
            GroupBox1.Visible = True
            PictureBox1.Visible = False
            GroupBox1.Text = TextBox1.Text
            Dim consulta1 As String = "SELECT processador,clock,soquete,memoria FROM processadores WHERE processador LIKE '%" & texto & "%'"
            Dim conexao1 As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & Application.StartupPath & "\clocksystem.mdb")
            Dim comando1 As New OleDbCommand(consulta1, conexao1)
            Dim da As New OleDbDataAdapter(comando1)
            Dim dt As New DataTable

            conexao1.Open()
            da.Fill(dt)
            Label2.Text = dt.Rows(0)("clock").ToString
            TextBox2.Text = dt.Rows(0)("soquete").ToString
            Label4.Text = dt.Rows(0)("memoria").ToString
            comando1.ExecuteNonQuery()
            conexao1.Close()

            'Label2.Text = "800"
            Timer1.Enabled = False
        Catch
            TextBox1.Text = " "
            MessageBox.Show("Informe o nome correto do processador " & TextBox1.Text & "!", "ClockSys", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.Close()


            Dim texto = UCase(TextBox1.Text)
            GroupBox1.Visible = True
            PictureBox1.Visible = False
            GroupBox1.Text = TextBox1.Text
            Dim consulta1 As String = "SELECT processador,clock,soquete,  memoria FROM processadores WHERE processador LIKE '%" & texto & "%'"
            Dim conexao1 As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & Application.StartupPath & "\clocksystem.mdb") 'o registro sera adicionado na pasta debug do projeto
            Dim comando1 As New OleDbCommand(consulta1, conexao1)
            Dim da As New OleDbDataAdapter(comando1)
            Dim dt As New DataTable

            conexao1.Open()
            da.Fill(dt)
            Label2.Text = dt.Rows(0)("clock").ToString
            TextBox2.Text = dt.Rows(0)("soquete").ToString
            Label4.Text = dt.Rows(0)("memoria").ToString
            comando1.ExecuteNonQuery()
            conexao1.Close()



        End Try
    End Sub



End Class
