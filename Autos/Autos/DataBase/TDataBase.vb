Imports System.Data.SqlClient
Imports MySqlConnector
Public Class TDataBase
    'Protected conn As SqlConnection
    Protected myConn As MySqlConnection
    'Protected cmd As SqlCommand
    Protected cmd As MySqlCommand
    Protected reader As MySqlDataReader


    Public Sub New()
        myConn = New MySqlConnection(cadenaConexion)
        'conn = New SqlConnection("Data Source=PCDAB\SQLEXPRESS;Initial Catalog=AutosDB;Trusted_Connection=True;MultipleActiveResultSets=true")
        cmd = New MySqlCommand()
    End Sub
    Public Sub New(ConexionString As String)
        myConn = New MySqlConnection(ConexionString)
    End Sub
    Public Sub Conectarse()
        Try
            myConn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub Cerrar()
        Try
            'reader.Dispose()
            myConn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
