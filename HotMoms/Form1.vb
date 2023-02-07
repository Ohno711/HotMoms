Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Private Sub lsbList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbList.SelectedIndexChanged
        If lsbList.SelectedIndex = 0 Then
            lblName.Text = "Ms. Arens"
            picTeach.Image = My.Resources.cosch
        ElseIf lsbList.SelectedIndex = 1 Then
            lblName.Text = "Mr. Nipert"
            picTeach.Image = My.Resources.nipert
        ElseIf lsbList.SelectedIndex = 2 Then
            lblName.Text = "Ms. Jones"
            picTeach.Image = My.Resources.jomes
        ElseIf lsbList.SelectedIndex = 3 Then
            lblName.Text = "Ms. Selimovic"
            picTeach.Image = My.Resources.semvic
        ElseIf lsbList.SelectedIndex = 4 Then
            lblName.Text = "Ms. Green"
            picTeach.Image = My.Resources.greem
        End If
    End Sub
End Class
