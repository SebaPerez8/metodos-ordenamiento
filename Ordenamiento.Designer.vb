<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordenamiento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdBurbuja = New System.Windows.Forms.Button()
        Me.cmdBurbBandera = New System.Windows.Forms.Button()
        Me.cmdSelecDirecta = New System.Windows.Forms.Button()
        Me.cmdInsercion = New System.Windows.Forms.Button()
        Me.cmdQuick = New System.Windows.Forms.Button()
        Me.cmdMerge = New System.Windows.Forms.Button()
        Me.cmdCrearVector = New System.Windows.Forms.Button()
        Me.picVector = New System.Windows.Forms.PictureBox()
        Me.txtTVector = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdVerVector = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.Vector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblComparacionesBurbuja = New System.Windows.Forms.Label()
        Me.lblAsignacionesBurbuja = New System.Windows.Forms.Label()
        Me.lblTiempoBurbuja = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCompBurbujaBandera = New System.Windows.Forms.Label()
        Me.lblAsignBurbujaBandera = New System.Windows.Forms.Label()
        Me.lblTiempoBurbujaBandera = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblCompSeleccionDirecta = New System.Windows.Forms.Label()
        Me.lblAsignSeleccionDirecta = New System.Windows.Forms.Label()
        Me.lblTiempoSeleccionDirecta = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdVaciar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        CType(Me.picVector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBurbuja
        '
        Me.cmdBurbuja.Location = New System.Drawing.Point(22, 24)
        Me.cmdBurbuja.Name = "cmdBurbuja"
        Me.cmdBurbuja.Size = New System.Drawing.Size(156, 32)
        Me.cmdBurbuja.TabIndex = 0
        Me.cmdBurbuja.Text = "Burbuja"
        Me.cmdBurbuja.UseVisualStyleBackColor = True
        '
        'cmdBurbBandera
        '
        Me.cmdBurbBandera.Location = New System.Drawing.Point(22, 62)
        Me.cmdBurbBandera.Name = "cmdBurbBandera"
        Me.cmdBurbBandera.Size = New System.Drawing.Size(156, 32)
        Me.cmdBurbBandera.TabIndex = 1
        Me.cmdBurbBandera.Text = "Burbuja con bandera"
        Me.cmdBurbBandera.UseVisualStyleBackColor = True
        '
        'cmdSelecDirecta
        '
        Me.cmdSelecDirecta.Location = New System.Drawing.Point(22, 100)
        Me.cmdSelecDirecta.Name = "cmdSelecDirecta"
        Me.cmdSelecDirecta.Size = New System.Drawing.Size(156, 32)
        Me.cmdSelecDirecta.TabIndex = 2
        Me.cmdSelecDirecta.Text = "Selección Directa"
        Me.cmdSelecDirecta.UseVisualStyleBackColor = True
        '
        'cmdInsercion
        '
        Me.cmdInsercion.Location = New System.Drawing.Point(22, 138)
        Me.cmdInsercion.Name = "cmdInsercion"
        Me.cmdInsercion.Size = New System.Drawing.Size(156, 32)
        Me.cmdInsercion.TabIndex = 3
        Me.cmdInsercion.Text = "Inserción"
        Me.cmdInsercion.UseVisualStyleBackColor = True
        '
        'cmdQuick
        '
        Me.cmdQuick.Location = New System.Drawing.Point(22, 176)
        Me.cmdQuick.Name = "cmdQuick"
        Me.cmdQuick.Size = New System.Drawing.Size(156, 32)
        Me.cmdQuick.TabIndex = 4
        Me.cmdQuick.Text = "Quick Sort"
        Me.cmdQuick.UseVisualStyleBackColor = True
        '
        'cmdMerge
        '
        Me.cmdMerge.Location = New System.Drawing.Point(22, 214)
        Me.cmdMerge.Name = "cmdMerge"
        Me.cmdMerge.Size = New System.Drawing.Size(156, 32)
        Me.cmdMerge.TabIndex = 5
        Me.cmdMerge.Text = "Merge Sort"
        Me.cmdMerge.UseVisualStyleBackColor = True
        '
        'cmdCrearVector
        '
        Me.cmdCrearVector.Location = New System.Drawing.Point(713, 12)
        Me.cmdCrearVector.Name = "cmdCrearVector"
        Me.cmdCrearVector.Size = New System.Drawing.Size(101, 32)
        Me.cmdCrearVector.TabIndex = 6
        Me.cmdCrearVector.Text = "Crear Vector"
        Me.cmdCrearVector.UseVisualStyleBackColor = True
        '
        'picVector
        '
        Me.picVector.Location = New System.Drawing.Point(414, 78)
        Me.picVector.Name = "picVector"
        Me.picVector.Size = New System.Drawing.Size(532, 387)
        Me.picVector.TabIndex = 7
        Me.picVector.TabStop = False
        '
        'txtTVector
        '
        Me.txtTVector.Location = New System.Drawing.Point(604, 19)
        Me.txtTVector.Name = "txtTVector"
        Me.txtTVector.Size = New System.Drawing.Size(103, 20)
        Me.txtTVector.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(515, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tamaño Vector:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(632, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Gráfico"
        '
        'cmdVerVector
        '
        Me.cmdVerVector.Location = New System.Drawing.Point(11, 15)
        Me.cmdVerVector.Name = "cmdVerVector"
        Me.cmdVerVector.Size = New System.Drawing.Size(75, 32)
        Me.cmdVerVector.TabIndex = 12
        Me.cmdVerVector.Text = "Ver Vector"
        Me.cmdVerVector.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Vector})
        Me.Grilla.Location = New System.Drawing.Point(11, 50)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(143, 405)
        Me.Grilla.TabIndex = 13
        '
        'Vector
        '
        Me.Vector.HeaderText = "Vector"
        Me.Vector.Name = "Vector"
        '
        'lblComparacionesBurbuja
        '
        Me.lblComparacionesBurbuja.AutoSize = True
        Me.lblComparacionesBurbuja.Location = New System.Drawing.Point(87, 112)
        Me.lblComparacionesBurbuja.Name = "lblComparacionesBurbuja"
        Me.lblComparacionesBurbuja.Size = New System.Drawing.Size(0, 13)
        Me.lblComparacionesBurbuja.TabIndex = 19
        '
        'lblAsignacionesBurbuja
        '
        Me.lblAsignacionesBurbuja.AutoSize = True
        Me.lblAsignacionesBurbuja.Location = New System.Drawing.Point(87, 88)
        Me.lblAsignacionesBurbuja.Name = "lblAsignacionesBurbuja"
        Me.lblAsignacionesBurbuja.Size = New System.Drawing.Size(0, 13)
        Me.lblAsignacionesBurbuja.TabIndex = 18
        '
        'lblTiempoBurbuja
        '
        Me.lblTiempoBurbuja.AutoSize = True
        Me.lblTiempoBurbuja.Location = New System.Drawing.Point(87, 63)
        Me.lblTiempoBurbuja.Name = "lblTiempoBurbuja"
        Me.lblTiempoBurbuja.Size = New System.Drawing.Size(0, 13)
        Me.lblTiempoBurbuja.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Comparaciones:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Asignaciones:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tiempo:"
        '
        'lblCompBurbujaBandera
        '
        Me.lblCompBurbujaBandera.AutoSize = True
        Me.lblCompBurbujaBandera.Location = New System.Drawing.Point(240, 112)
        Me.lblCompBurbujaBandera.Name = "lblCompBurbujaBandera"
        Me.lblCompBurbujaBandera.Size = New System.Drawing.Size(0, 13)
        Me.lblCompBurbujaBandera.TabIndex = 25
        '
        'lblAsignBurbujaBandera
        '
        Me.lblAsignBurbujaBandera.AutoSize = True
        Me.lblAsignBurbujaBandera.Location = New System.Drawing.Point(240, 88)
        Me.lblAsignBurbujaBandera.Name = "lblAsignBurbujaBandera"
        Me.lblAsignBurbujaBandera.Size = New System.Drawing.Size(0, 13)
        Me.lblAsignBurbujaBandera.TabIndex = 24
        '
        'lblTiempoBurbujaBandera
        '
        Me.lblTiempoBurbujaBandera.AutoSize = True
        Me.lblTiempoBurbujaBandera.Location = New System.Drawing.Point(240, 63)
        Me.lblTiempoBurbujaBandera.Name = "lblTiempoBurbujaBandera"
        Me.lblTiempoBurbujaBandera.Size = New System.Drawing.Size(0, 13)
        Me.lblTiempoBurbujaBandera.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(159, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Comparaciones:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(159, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Asignaciones:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(159, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Tiempo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(555, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(555, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(555, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(474, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Comparaciones:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(474, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Asignaciones:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(474, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Tiempo:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(717, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 13)
        Me.Label18.TabIndex = 37
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(717, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 13)
        Me.Label19.TabIndex = 36
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(717, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(0, 13)
        Me.Label20.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(636, 112)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 13)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Comparaciones:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(636, 88)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(73, 13)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Asignaciones:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(636, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 13)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "Tiempo:"
        '
        'lblCompSeleccionDirecta
        '
        Me.lblCompSeleccionDirecta.AutoSize = True
        Me.lblCompSeleccionDirecta.Location = New System.Drawing.Point(401, 112)
        Me.lblCompSeleccionDirecta.Name = "lblCompSeleccionDirecta"
        Me.lblCompSeleccionDirecta.Size = New System.Drawing.Size(0, 13)
        Me.lblCompSeleccionDirecta.TabIndex = 43
        '
        'lblAsignSeleccionDirecta
        '
        Me.lblAsignSeleccionDirecta.AutoSize = True
        Me.lblAsignSeleccionDirecta.Location = New System.Drawing.Point(401, 88)
        Me.lblAsignSeleccionDirecta.Name = "lblAsignSeleccionDirecta"
        Me.lblAsignSeleccionDirecta.Size = New System.Drawing.Size(0, 13)
        Me.lblAsignSeleccionDirecta.TabIndex = 42
        '
        'lblTiempoSeleccionDirecta
        '
        Me.lblTiempoSeleccionDirecta.AutoSize = True
        Me.lblTiempoSeleccionDirecta.Location = New System.Drawing.Point(401, 63)
        Me.lblTiempoSeleccionDirecta.Name = "lblTiempoSeleccionDirecta"
        Me.lblTiempoSeleccionDirecta.Size = New System.Drawing.Size(0, 13)
        Me.lblTiempoSeleccionDirecta.TabIndex = 41
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(320, 112)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(83, 13)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "Comparaciones:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(320, 88)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(73, 13)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Asignaciones:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(320, 63)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 13)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "Tiempo:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(871, 112)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(0, 13)
        Me.Label30.TabIndex = 49
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(871, 88)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(0, 13)
        Me.Label31.TabIndex = 48
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(871, 63)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(0, 13)
        Me.Label32.TabIndex = 47
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(790, 112)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(83, 13)
        Me.Label33.TabIndex = 46
        Me.Label33.Text = "Comparaciones:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(790, 88)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(73, 13)
        Me.Label34.TabIndex = 45
        Me.Label34.Text = "Asignaciones:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(790, 63)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(45, 13)
        Me.Label35.TabIndex = 44
        Me.Label35.Text = "Tiempo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.lblComparacionesBurbuja)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.lblAsignacionesBurbuja)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.lblTiempoBurbuja)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lblCompSeleccionDirecta)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.lblAsignSeleccionDirecta)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.lblTiempoSeleccionDirecta)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblTiempoBurbujaBandera)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.lblAsignBurbujaBandera)
        Me.GroupBox1.Controls.Add(Me.lblCompBurbujaBandera)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 480)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(935, 146)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monitoreo"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(804, 30)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(59, 13)
        Me.Label38.TabIndex = 53
        Me.Label38.Text = "Merge Sort"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(652, 30)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(57, 13)
        Me.Label37.TabIndex = 52
        Me.Label37.Text = "Quick Sort"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(504, 30)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(50, 13)
        Me.Label36.TabIndex = 52
        Me.Label36.Text = "Inserción"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(335, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Selección Directa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(171, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Burbuja con bandera"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Burbuja"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdMerge)
        Me.GroupBox2.Controls.Add(Me.cmdQuick)
        Me.GroupBox2.Controls.Add(Me.cmdInsercion)
        Me.GroupBox2.Controls.Add(Me.cmdSelecDirecta)
        Me.GroupBox2.Controls.Add(Me.cmdBurbBandera)
        Me.GroupBox2.Controls.Add(Me.cmdBurbuja)
        Me.GroupBox2.Location = New System.Drawing.Point(177, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(198, 269)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Métodos"
        '
        'cmdVaciar
        '
        Me.cmdVaciar.Location = New System.Drawing.Point(78, 471)
        Me.cmdVaciar.Name = "cmdVaciar"
        Me.cmdVaciar.Size = New System.Drawing.Size(104, 32)
        Me.cmdVaciar.TabIndex = 52
        Me.cmdVaciar.Text = "Vaciar mediciones"
        Me.cmdVaciar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(92, 15)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(62, 32)
        Me.cmdBorrar.TabIndex = 53
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'Ordenamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 638)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdVaciar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.cmdVerVector)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTVector)
        Me.Controls.Add(Me.picVector)
        Me.Controls.Add(Me.cmdCrearVector)
        Me.Name = "Ordenamiento"
        Me.Text = "Métodos de Ordenamiento"
        CType(Me.picVector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBurbuja As System.Windows.Forms.Button
    Friend WithEvents cmdBurbBandera As System.Windows.Forms.Button
    Friend WithEvents cmdSelecDirecta As System.Windows.Forms.Button
    Friend WithEvents cmdInsercion As System.Windows.Forms.Button
    Friend WithEvents cmdQuick As System.Windows.Forms.Button
    Friend WithEvents cmdMerge As System.Windows.Forms.Button
    Friend WithEvents cmdCrearVector As System.Windows.Forms.Button
    Friend WithEvents picVector As System.Windows.Forms.PictureBox
    Friend WithEvents txtTVector As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdVerVector As Button
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents Vector As DataGridViewTextBoxColumn
    Friend WithEvents lblComparacionesBurbuja As Label
    Friend WithEvents lblAsignacionesBurbuja As Label
    Friend WithEvents lblTiempoBurbuja As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCompBurbujaBandera As Label
    Friend WithEvents lblAsignBurbujaBandera As Label
    Friend WithEvents lblTiempoBurbujaBandera As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblCompSeleccionDirecta As Label
    Friend WithEvents lblAsignSeleccionDirecta As Label
    Friend WithEvents lblTiempoSeleccionDirecta As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdVaciar As Button
    Friend WithEvents cmdBorrar As Button
End Class
