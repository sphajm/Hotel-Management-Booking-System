Imports System.IO
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please fill in both textboxes.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If DateTimePicker2.Value < DateTimePicker1.Value Then
            MessageBox.Show("Please make sure that the end date is later than the start date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim data As String = String.Format("{0},{1},{2},{3}", TextBox1.Text, DateTimePicker1.Value.ToString("MM/dd/yyyy HH:mm:ss"), TextBox2.Text, DateTimePicker2.Value.ToString("MM/dd/yyyy HH:mm:ss"))

        File.AppendAllText("data.txt", data & Environment.NewLine)

        MessageBox.Show("Data has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        TextBox1.Clear()
        TextBox2.Clear()

        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
        File.AppendAllText("data.txt", data & Environment.NewLine)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If File.Exists("data.txt") Then
            File.WriteAllText("data.txt", "")
            MessageBox.Show("Data has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Data file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
