Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNumberOfCookies_Click(sender As Object, e As EventArgs) Handles btnCalculateCalories.Click
        Dim cookiesEaten As Integer
        Dim caloriesConsumed As Integer

        Try
            cookiesEaten = CInt(txtNumberOfCookies.Text)
            caloriesConsumed = cookiesEaten * 300
            lblTotalCaloriesConsumed.Text = caloriesConsumed.ToString("D")
        Catch ex As Exception
            MessageBox.Show("Please enter a valid number for the amount of cookies eaten.")
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
