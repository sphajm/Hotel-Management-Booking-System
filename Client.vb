
Imports System.Data.SqlClient
Imports System.Diagnostics.Contracts
Public Class Client
    Dim Con As New SqlConnection("C:\USERS\SPHAM\ONEDRIVE\TÀI LIỆU\HOTELDB.MDF")
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con.Open()
        Dim query As String
        query = "insert into ClientTb1 values('" & CLNameTb.Text & "','" & GenderCb.SelectedItem.ToString() & "', " & CLAge.Text & ",'" & CLAge.Text & "','" & CLPhoneTb.Text & "','" & CountryCb.SelectedItem.ToString() & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Client Inserted Succesfully")
        Con.Close()
        Dim name As String = CLNameTb.Text
        Dim phone As String = CLPhoneTb.Text
        Dim age As Integer = Integer.Parse(CLAge.Text)
        Dim gender As String = GenderCb.SelectedItem.ToString()
        Dim country As String = CountryCb.SelectedItem.ToString()

        MessageBox.Show("Name: " & name & vbCrLf &
                        "Phone: " & phone & vbCrLf &
                        "Age: " & age.ToString() & vbCrLf &
                        "Gender: " & gender & vbCrLf &
                        "Country: " & country)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles CLAge.TextChanged

    End Sub

    Private Sub CountyCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CountryCb.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name As String = CLNameTb.Text
        Dim phone As String = CLPhoneTb.Text
        Dim age As Integer = Integer.Parse(CLAge.Text)
        Dim gender As String = GenderCb.SelectedItem.ToString()
        Dim country As String = CountryCb.SelectedItem.ToString()

        MessageBox.Show("Edited data:" & vbCrLf &
                        "Name: " & name & vbCrLf &
                        "Phone: " & phone & vbCrLf &
                        "Age: " & age.ToString() & vbCrLf &
                        "Gender: " & gender & vbCrLf &
                        "Country: " & country)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CLNameTb.Clear()
        CLPhoneTb.Clear()
        CLAge.Clear()
        GenderCb.SelectedIndex = -1
        CountryCb.SelectedIndex = -1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CLNameTb.Clear()
        CLPhoneTb.Clear()
        CLAge.Clear()
        GenderCb.SelectedIndex = -1
        CountryCb.SelectedIndex = -1
    End Sub
End Class