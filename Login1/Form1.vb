Imports System.Diagnostics.Eventing.Reader
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Registrarse_Click(sender As Object, e As EventArgs) Handles Registrarse.Click

        If Correo.Text = "" And Contra.Text = "" Then

            MsgBox("Los campos se encuentran vacios")

        Else

            If Correo.Text = "" Then

                MsgBox("El campo USUARIO se encuentra vacio")

            Else

                If Contra.Text = "" Then

                    MsgBox("El campo CONTRASEÑA se encuentra vacio")

                Else

                    If Correo.Text = "Gara" And Contra.Text = "Arena" Then

                        MsgBox("Bienvenido a tu cuenta " + Correo.Text + " de la " + Contra.Text)

                    Else

                        MsgBox("Los datos son incorrectos")

                    End If
                End If
            End If
        End If




    End Sub
End Class
