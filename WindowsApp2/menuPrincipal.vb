﻿Imports MySql.Data.MySqlClient

Public Class menuPrincipal
    Private formMaterias As Object

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        maestro.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        alumnos.Show()
        Me.Hide()
    End Sub

    Private Sub menuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        materias.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        grupos.Show()
        Me.Hide()
    End Sub
End Class

