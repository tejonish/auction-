Imports System.Data.SqlClient
Module auctionmodule
    Public conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\loginDB.mdf;Integrated Security=True;User Instance=True")
    Public sqlStr, q1Var, q2Var As String
    Public colVar, rowVar, I, J, inVar, outVar As Long
    Public vTypeVar As Byte
    Public cCodeVar As Integer
End Module
