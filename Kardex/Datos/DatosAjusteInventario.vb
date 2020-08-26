Imports System.Data.SqlClient

Public Class DatosAjusteInventario : Inherits dtsKardex
    Sub Guardar()
        Dim adp As New dtsKardexTableAdapters.AjusteInventarioTableAdapter
        adp.Connection.ConnectionString = GetSetting("SeeSoft", "SeePos", "Conexion")
        adp.Update(Me.AjusteInventario)

        Dim adpDet As New dtsKardexTableAdapters.AjusteInventario_DetalleTableAdapter
        adpDet.Connection.ConnectionString = GetSetting("SeeSoft", "SeePos", "Conexion")
        adpDet.Update(Me.AjusteInventario_Detalle)
    End Sub
End Class
