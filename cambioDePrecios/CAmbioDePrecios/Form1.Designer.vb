<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxClave = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtUtilidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpBoxInfoProducto = New System.Windows.Forms.GroupBox()
        Me.txtUnidadMedida = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCostoUltimo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripción = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConexion = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpBoxInfoProducto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave:"
        '
        'txtBoxClave
        '
        Me.txtBoxClave.Location = New System.Drawing.Point(53, 6)
        Me.txtBoxClave.Name = "txtBoxClave"
        Me.txtBoxClave.Size = New System.Drawing.Size(72, 21)
        Me.txtBoxClave.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(87, 57)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 21)
        Me.txtPrecio.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(529, 236)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(87, 27)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtUtilidad
        '
        Me.txtUtilidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUtilidad.Location = New System.Drawing.Point(87, 84)
        Me.txtUtilidad.Name = "txtUtilidad"
        Me.txtUtilidad.ReadOnly = True
        Me.txtUtilidad.Size = New System.Drawing.Size(100, 21)
        Me.txtUtilidad.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Utilidad:"
        '
        'tbControl
        '
        Me.tbControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbControl.Controls.Add(Me.TabPage1)
        Me.tbControl.Controls.Add(Me.TabPage2)
        Me.tbControl.Location = New System.Drawing.Point(14, 14)
        Me.tbControl.Name = "tbControl"
        Me.tbControl.SelectedIndex = 0
        Me.tbControl.Size = New System.Drawing.Size(630, 297)
        Me.tbControl.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.btnAceptar)
        Me.TabPage1.Controls.Add(Me.grpBoxInfoProducto)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtBoxClave)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(622, 269)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Producto"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(131, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Producto:"
        '
        'grpBoxInfoProducto
        '
        Me.grpBoxInfoProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBoxInfoProducto.Controls.Add(Me.Panel2)
        Me.grpBoxInfoProducto.Controls.Add(Me.Panel1)
        Me.grpBoxInfoProducto.Controls.Add(Me.Label5)
        Me.grpBoxInfoProducto.Controls.Add(Me.txtDescripción)
        Me.grpBoxInfoProducto.Location = New System.Drawing.Point(7, 37)
        Me.grpBoxInfoProducto.Name = "grpBoxInfoProducto"
        Me.grpBoxInfoProducto.Size = New System.Drawing.Size(609, 193)
        Me.grpBoxInfoProducto.TabIndex = 7
        Me.grpBoxInfoProducto.TabStop = False
        Me.grpBoxInfoProducto.Text = "Información Producto"
        '
        'txtUnidadMedida
        '
        Me.txtUnidadMedida.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtUnidadMedida.Location = New System.Drawing.Point(102, 3)
        Me.txtUnidadMedida.Name = "txtUnidadMedida"
        Me.txtUnidadMedida.Size = New System.Drawing.Size(100, 21)
        Me.txtUnidadMedida.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Unidad medida:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCostoUltimo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtCosto)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtUtilidad)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Location = New System.Drawing.Point(9, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 113)
        Me.Panel1.TabIndex = 6
        '
        'txtCostoUltimo
        '
        Me.txtCostoUltimo.Location = New System.Drawing.Point(87, 30)
        Me.txtCostoUltimo.Name = "txtCostoUltimo"
        Me.txtCostoUltimo.Size = New System.Drawing.Size(100, 21)
        Me.txtCostoUltimo.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Costo último:"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(87, 3)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 21)
        Me.txtCosto.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Costo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripción:"
        '
        'txtDescripción
        '
        Me.txtDescripción.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripción.Location = New System.Drawing.Point(87, 20)
        Me.txtDescripción.Name = "txtDescripción"
        Me.txtDescripción.Size = New System.Drawing.Size(516, 21)
        Me.txtDescripción.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnConectar)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtConexion)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(622, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Conexión"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnConectar
        '
        Me.btnConectar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConectar.Location = New System.Drawing.Point(514, 240)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(102, 26)
        Me.btnConectar.TabIndex = 2
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Cadena de conexión:"
        '
        'txtConexion
        '
        Me.txtConexion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConexion.Location = New System.Drawing.Point(3, 21)
        Me.txtConexion.Multiline = True
        Me.txtConexion.Name = "txtConexion"
        Me.txtConexion.Size = New System.Drawing.Size(609, 213)
        Me.txtConexion.TabIndex = 0
        Me.txtConexion.Text = "Password=12345678;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User ID=sa;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Initial Catalog=C:\MyBusinessDatabase\MyBusiness" & _
    "POS2012.mdf;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data Source=SONOFGOD-PC\SQLEXPRESS,1433;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Workstation ID=SONOFGOD-" & _
    "PC;"
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(500, 9)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(144, 15)
        Me.lblEstado.TabIndex = 8
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(197, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(419, 23)
        Me.ComboBox1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtUnidadMedida)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(396, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(207, 113)
        Me.Panel2.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 319)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.tbControl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Cambio de precio"
        Me.tbControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grpBoxInfoProducto.ResumeLayout(False)
        Me.grpBoxInfoProducto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBoxClave As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtUtilidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grpBoxInfoProducto As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescripción As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtConexion As System.Windows.Forms.TextBox
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUnidadMedida As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCostoUltimo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
