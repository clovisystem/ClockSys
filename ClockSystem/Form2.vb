Imports System.Data.SqlClient
Imports System.Data.OleDb


Public Class Form2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim inclui As String = "INSERT INTO processadores(processador,clock,soquete,memoria)VALUES(@processador,@clock,@soquete,@memoria)"
        Dim conexao As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & Application.StartupPath & "\clocksystem.mdb") 'o registro sera adicionado na pasta debug do projeto
        Dim executa As New oledbCommand(inclui, conexao)
        executa.Parameters.Add(New oledbParameter("@processador", TextBox1.Text))
        executa.Parameters.Add(New oledbParameter("@clock", TextBox2.Text))
        executa.Parameters.Add(New oledbParameter("@soquete", TextBox3.Text))
        executa.Parameters.Add(New oledbParameter("@memoria", TextBox4.Text))
        conexao.Open()
        executa.ExecuteNonQuery()
        conexao.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        MsgBox("Seus dados foram enviados ao nosso banco de dados.", MsgBoxStyle.Information)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Form1.Show()
        Me.Hide()

    End Sub
End Class