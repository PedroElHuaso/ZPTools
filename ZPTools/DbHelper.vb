Imports System.Configuration
Imports System.Text
Imports System.Data.SqlClient

Public Class DbHelper
    Public Shared Function GetConnectionString() As String
        Dim server = ConfigurationManager.AppSettings("DbServer")
        Dim db = ConfigurationManager.AppSettings("DbName")
        Dim user = ConfigurationManager.AppSettings("DbUser")
        Dim pwdEncrypted = ConfigurationManager.AppSettings("DbPassword")

        'Decodifica la password da Base64
        Dim pwdBytes = Convert.FromBase64String(pwdEncrypted)
        Dim password = Encoding.UTF8.GetString(pwdBytes)

        'Costruisce la connection string
        Return $"Server={server};Database={db};User Id={user};Password={password};"
    End Function
End Class
