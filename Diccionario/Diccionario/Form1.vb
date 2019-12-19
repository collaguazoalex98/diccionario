Imports System
Public Class Form1
    Dim list_diccionario As New List(Of String)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim palabra, definicion, dic As String
        palabra = txtPalabra.Text
        definicion = txtDefinicion.Text
        dic = palabra + ":" + definicion
        Dim item1 As ListViewItem
        item1 = New ListViewItem(palabra, 0)
        item1.SubItems.Add(palabra)
        item1.SubItems.Add(definicion)




        Form2.lvDiccionario.Items.Add(item1)
        Form2.Show()
        Me.Hide()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtPalabra.Text = "" And txtDefinicion.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
        MsgBox("Seguro que quieres Salir")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Dim ruta = My.Computer.FileSystem.SpecialDirectories.Desktop & "\definicion.txt"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.FileSystem.WriteAllText(ruta, vbCrLf & "Palabras:   " & txtPalabra.Text & "Definicion:   " & txtDefinicion.Text & "Imagen " & PictureBox1.Text & vbCrLf, True)


        MessageBox.Show("Informacion Guardada")

        Button1.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.InitialDirectory = "Escritorio"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
