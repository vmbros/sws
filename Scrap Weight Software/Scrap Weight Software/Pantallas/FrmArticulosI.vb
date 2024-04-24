Imports System.Data
Imports System.Data.OleDb
Imports Scrap_Weight_Software



Public Class FrmArticulosI
    Dim sda As OleDbCommand
    Dim scb As OleDbCommandBuilder
    Dim dr As OleDbDataReader

    Dim dt As DataTable
    Dim comando As String = "SELECT ItemCode, ItemName FROM OITM"

    Private Sub frmArticulosI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try


            Dim cn As New BD()

            sda = New OleDbCommand(comando, cn.abrirConexion())
            dr = sda.ExecuteReader()
            Dim sum = 10
            Dim cont = 0
            Dim left = 10
            While (dr.Read())
                Dim boton As New Button
                boton.Width = 150
                boton.Height = 150

                If (cont < 4) Then
                    boton.Left = left
                    boton.Top = sum
                    left += 160
                    cont = cont + 1

                Else
                    sum += 170
                    boton.Left = 10
                    boton.Top = sum
                    left = 170
                    cont = 1

                End If
                boton.Font = New Font("Arial", 12, FontStyle.Bold)
                boton.Name = dr("ItemCode")
                boton.Text = dr("ItemName")
                boton.BackColor = System.Drawing.Color.White

                AddHandler boton.Click, AddressOf ClickBotones
                Panel1.Controls.Add(boton)

            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
      


    End Sub


    Private Sub ClickBotones(ByVal sender As Object, ByVal e As EventArgs)
        Dim whichButton As Button
        Dim whichTabPage As Control

        If TypeOf sender Is Button Then

            whichButton = CType(sender, Button)
            whichTabPage = whichButton.Parent
            lblMetal.Text = whichButton.Text



            MessageBox.Show("Apretaste el " & whichButton.Name & " de la pestaña " & whichTabPage.Name)
        End If
    End Sub
End Class