Imports ADODB
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Form1

    Private DB_CONN As String
    Private CURRENT_PRODUCT As Recordset

    Private nuevoPrecio As Decimal
    Private porcentajeGanancia As Decimal


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'DB_CONN = "Provider=SQLNCLI.1;Password=12345678;Persist Security Info=True;User ID=sa;Initial Catalog=C:\MyBusinessDatabase\MyBusinessPOS2012.mdf;Data Source=TCP:.\SQLEXPRESS,1400;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=SONOFGOD-PC;Use Encryption for Data=False;Tag with column collation when possible=False;MARS Connection=False;DataTypeCompatibility=0;Trust Server Certificate=False;"

        'DB_CONN = "Provider=SQLNCLI;Password=12345678;Persist Security Info=True;User ID=sa;Initial Catalog=C:\MyBusinessDatabase\MyBusinessPOS2012.mdf;Data Source=SONOFGOD-PC\SQLEXPRESS,1433; Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=SONOFGOD-PC;Use Encryption for Data=False;Tag with column collation when possible=False;MARS Connection=False;DataTypeCompatibility=0;Trust Server Certificate=False;"

        lblEstado.Text = "DESCONECTADO"
        lblEstado.ForeColor = Color.Red

        btnAceptar.Enabled = False

    End Sub


    Private Sub txtBoxClave_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBoxClave.KeyUp

        If e.KeyCode = Keys.Enter Then
            If txtBoxClave.Text.Trim.Length > 0 Then
                CURRENT_PRODUCT = crearRecorset("SELECT * FROM prods WHERE ARTICULO = " + txtBoxClave.Text)


                If CURRENT_PRODUCT.EOF Then
                    MsgBox("No se encontró el producto indicado")
                Else
                    txtPrecio.Text = CURRENT_PRODUCT.Fields("PRECIO1").Value.ToString
                    txtDescripción.Text = CURRENT_PRODUCT.Fields("DESCRIP").Value.ToString
                    txtCosto.Text = CURRENT_PRODUCT.Fields("COSTO").Value.ToString
                    txtCostoUltimo.Text = CURRENT_PRODUCT.Fields("COSTO_U").Value.ToString
                    txtPrecio.Text = CURRENT_PRODUCT.Fields("PRECIO1").Value.ToString
                    txtUtilidad.Text = CURRENT_PRODUCT.Fields("U1").Value.ToString
                    txtUnidadMedida.Text = CURRENT_PRODUCT.Fields("UNIDAD").Value.ToString


                End If

            End If
        End If

    End Sub

    Private Sub txtBoxClave_LostFocus(sender As Object, e As System.EventArgs) Handles txtBoxClave.LostFocus


        If txtBoxClave.Text.Trim.Length > 0 Then
            CURRENT_PRODUCT = crearRecorset("SELECT * FROM prods WHERE ARTICULO = " + txtBoxClave.Text)


            If CURRENT_PRODUCT.EOF Then
                MsgBox("No se encontró el producto indicado")
                txtBoxClave.Focus()
            Else
                ' txtBoxPrecioActual.Text = CURRENT_PRODUCT.Fields("PRECIO1").Value.ToString
            End If

        End If


    End Sub


    Function crearRecorset(ByVal SQLConsulta As String) As Recordset

        Dim recorset As Recordset = New Recordset

        Try
            recorset.Open(SQLConsulta, DB_CONN, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly)
        Catch SQLexc As SqlException
            MsgBox("Hubo un error al crear el recordSet" & SQLexc.Message)
        End Try
        Return recorset
    End Function

    Private Sub txtPrecio_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPrecio.KeyUp

        If e.KeyCode = Keys.Enter Then

            If txtPrecio.Text.Trim.Length > 0 Then

                btnAceptar.Focus()

                Dim nuevoPrecio As Decimal = CDec(txtPrecio.Text)
                Dim porcerntajeGanancia As Decimal = ((nuevoPrecio - CDec(CURRENT_PRODUCT.Fields("COSTO_U").Value)) * 100) / CDec(CURRENT_PRODUCT.Fields("COSTO_U").Value)
                txtUtilidad.Text = porcerntajeGanancia.ToString

            End If
        End If
    End Sub

    'Private Sub txtPrecioNuevo_LostFocus(sender As Object, e As System.EventArgs) Handles txtPrecio.LostFocus
    '    If txtPrecio.Text.Trim.Length > 0 Then

    '        btnAceptar.Focus()


    '        nuevoPrecio = CDec(txtPrecio.Text)
    '        porcentajeGanancia = ((nuevoPrecio - CDec(CURRENT_PRODUCT.Fields("COSTO_U").Value)) * 100) / CDec(CURRENT_PRODUCT.Fields("COSTO_U").Value)
    '        txtUtilidad.Text = porcentajeGanancia.ToString



    '    End If
    'End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

        Dim RESPUESTA As Recordset = crearRecorset("UPDATE prods set PRECIO1 = '" + nuevoPrecio.ToString + "', U1='" + porcentajeGanancia.ToString + "' WHERE ARTICULO = '" + CURRENT_PRODUCT.Fields("ARTICULO").Value.ToString + "' ")

        txtBoxClave.Text = ""
        'txtBoxPrecioActual.Text = ""
        txtUtilidad.Text = ""
        txtPrecio.Text = ""
        txtBoxClave.Focus()

    End Sub

    Private Sub bntConectar_Click(sender As System.Object, e As System.EventArgs) Handles btnConectar.Click


        Dim pruebaConex As SqlConnection = New SqlConnection
        Try
            pruebaConex.ConnectionString = txtConexion.Text

            pruebaConex.Open()
            lblEstado.Text = "CONECTADO"
            lblEstado.ForeColor = Color.Green
            DB_CONN = txtConexion.Text.Replace(vbNewLine, " ")
            DB_CONN = DB_CONN & "Persist Security Info=True;Provider=SQLNCLI;Use Procedure for Prepare=1;Auto Translate=True;Use Encryption for Data=False;Tag with column collation when possible=False;MARS Connection=False;DataTypeCompatibility=0;Trust Server Certificate=False;Packet Size=4096;"

            pruebaConex.Close()
            btnAceptar.Enabled = True
            btnConectar.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Verificar cadena de conexión")
        End Try

    End Sub

End Class



'Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

'    EMPRESA = crearRecorset("SELECT * FROM econfig")
'    CURRENT_ESTACION = crearRecorset("SELECT * FROM estaciones WHERE Estacion = '" & ESTACION & "'")

'    If CURRENT_ESTACION.EOF Then
'        MsgBox("No se encuentra la estación solicitada: " & ESTACION, vbInformation)
'        Exit Sub
'    End If

'    CURRENT_IMPRESORA = CURRENT_ESTACION.Fields("pticket").Value.ToString

'End Sub





