<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.comp = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.String_txt = New System.Windows.Forms.ListBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.picCompilar = New System.Windows.Forms.PictureBox()
    Me.picCargarArchivo = New System.Windows.Forms.PictureBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.P_reservadas = New System.Windows.Forms.ListBox()
    Me.C_Reales = New System.Windows.Forms.ListBox()
    Me.C_Enteras = New System.Windows.Forms.ListBox()
    Me.IDs_txt = New System.Windows.Forms.ListBox()
    Me.Salida_txt = New System.Windows.Forms.ListBox()
    Me.Entrada_txt = New System.Windows.Forms.ListBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.btnExportar = New System.Windows.Forms.Button()
    CType(Me.picCompilar, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picCargarArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'comp
    '
    Me.comp.AutoSize = True
    Me.comp.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.comp.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.comp.Location = New System.Drawing.Point(519, 9)
    Me.comp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.comp.Name = "comp"
    Me.comp.Size = New System.Drawing.Size(253, 61)
    Me.comp.TabIndex = 0
    Me.comp.Text = "Compilador"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.Label2.Location = New System.Drawing.Point(53, 95)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(173, 23)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Archivo entrada "
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.Label3.Location = New System.Drawing.Point(308, 95)
    Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(149, 23)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Archivo salida"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.Label4.Location = New System.Drawing.Point(480, 95)
    Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(211, 23)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Palabras reservadas "
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.Label5.Location = New System.Drawing.Point(704, 95)
    Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(44, 23)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "ID'S"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.Label6.Location = New System.Drawing.Point(806, 95)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(141, 23)
    Me.Label6.TabIndex = 9
    Me.Label6.Text = "Ctes. Enteras "
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.Label7.Location = New System.Drawing.Point(959, 95)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(137, 23)
    Me.Label7.TabIndex = 10
    Me.Label7.Text = "Ctes. Reales "
    '
    'String_txt
    '
    Me.String_txt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.String_txt.FormattingEnabled = True
    Me.String_txt.ItemHeight = 23
    Me.String_txt.Location = New System.Drawing.Point(1096, 133)
    Me.String_txt.Margin = New System.Windows.Forms.Padding(4)
    Me.String_txt.Name = "String_txt"
    Me.String_txt.Size = New System.Drawing.Size(159, 234)
    Me.String_txt.TabIndex = 18
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.Label1.Location = New System.Drawing.Point(471, 408)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(156, 23)
    Me.Label1.TabIndex = 22
    Me.Label1.Text = "Cargar archivo"
    '
    'picCompilar
    '
    Me.picCompilar.Location = New System.Drawing.Point(666, 439)
    Me.picCompilar.Name = "picCompilar"
    Me.picCompilar.Size = New System.Drawing.Size(100, 90)
    Me.picCompilar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.picCompilar.TabIndex = 23
    Me.picCompilar.TabStop = False
    '
    'picCargarArchivo
    '
    Me.picCargarArchivo.Location = New System.Drawing.Point(484, 439)
    Me.picCargarArchivo.Name = "picCargarArchivo"
    Me.picCargarArchivo.Size = New System.Drawing.Size(105, 90)
    Me.picCargarArchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.picCargarArchivo.TabIndex = 21
    Me.picCargarArchivo.TabStop = False
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.Label9.Location = New System.Drawing.Point(671, 408)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(100, 23)
    Me.Label9.TabIndex = 24
    Me.Label9.Text = "Compilar"
    '
    'P_reservadas
    '
    Me.P_reservadas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.P_reservadas.FormattingEnabled = True
    Me.P_reservadas.ItemHeight = 23
    Me.P_reservadas.Location = New System.Drawing.Point(495, 133)
    Me.P_reservadas.Margin = New System.Windows.Forms.Padding(4)
    Me.P_reservadas.Name = "P_reservadas"
    Me.P_reservadas.Size = New System.Drawing.Size(142, 234)
    Me.P_reservadas.TabIndex = 26
    '
    'C_Reales
    '
    Me.C_Reales.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.C_Reales.FormattingEnabled = True
    Me.C_Reales.ItemHeight = 23
    Me.C_Reales.Location = New System.Drawing.Point(953, 133)
    Me.C_Reales.Margin = New System.Windows.Forms.Padding(4)
    Me.C_Reales.Name = "C_Reales"
    Me.C_Reales.Size = New System.Drawing.Size(120, 234)
    Me.C_Reales.TabIndex = 29
    '
    'C_Enteras
    '
    Me.C_Enteras.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.C_Enteras.FormattingEnabled = True
    Me.C_Enteras.ItemHeight = 23
    Me.C_Enteras.Location = New System.Drawing.Point(810, 133)
    Me.C_Enteras.Margin = New System.Windows.Forms.Padding(4)
    Me.C_Enteras.Name = "C_Enteras"
    Me.C_Enteras.Size = New System.Drawing.Size(120, 234)
    Me.C_Enteras.TabIndex = 28
    '
    'IDs_txt
    '
    Me.IDs_txt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IDs_txt.FormattingEnabled = True
    Me.IDs_txt.ItemHeight = 23
    Me.IDs_txt.Location = New System.Drawing.Point(666, 133)
    Me.IDs_txt.Margin = New System.Windows.Forms.Padding(4)
    Me.IDs_txt.Name = "IDs_txt"
    Me.IDs_txt.Size = New System.Drawing.Size(120, 234)
    Me.IDs_txt.TabIndex = 27
    '
    'Salida_txt
    '
    Me.Salida_txt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Salida_txt.FormattingEnabled = True
    Me.Salida_txt.HorizontalScrollbar = True
    Me.Salida_txt.ItemHeight = 23
    Me.Salida_txt.Location = New System.Drawing.Point(258, 133)
    Me.Salida_txt.Margin = New System.Windows.Forms.Padding(4)
    Me.Salida_txt.Name = "Salida_txt"
    Me.Salida_txt.Size = New System.Drawing.Size(215, 234)
    Me.Salida_txt.TabIndex = 25
    '
    'Entrada_txt
    '
    Me.Entrada_txt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Entrada_txt.FormattingEnabled = True
    Me.Entrada_txt.ItemHeight = 23
    Me.Entrada_txt.Location = New System.Drawing.Point(13, 133)
    Me.Entrada_txt.Margin = New System.Windows.Forms.Padding(4)
    Me.Entrada_txt.Name = "Entrada_txt"
    Me.Entrada_txt.Size = New System.Drawing.Size(225, 234)
    Me.Entrada_txt.TabIndex = 30
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.Label10.Location = New System.Drawing.Point(1139, 95)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(118, 23)
    Me.Label10.TabIndex = 31
    Me.Label10.Text = "Ctes. String"
    '
    'btnExportar
    '
    Me.btnExportar.Location = New System.Drawing.Point(810, 439)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(102, 90)
    Me.btnExportar.TabIndex = 32
    Me.btnExportar.Text = "Exportar"
    Me.btnExportar.UseVisualStyleBackColor = True
    '
    'frmInicio
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Gainsboro
    Me.ClientSize = New System.Drawing.Size(1277, 604)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.Entrada_txt)
    Me.Controls.Add(Me.C_Reales)
    Me.Controls.Add(Me.C_Enteras)
    Me.Controls.Add(Me.IDs_txt)
    Me.Controls.Add(Me.P_reservadas)
    Me.Controls.Add(Me.Salida_txt)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.picCompilar)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.picCargarArchivo)
    Me.Controls.Add(Me.String_txt)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.comp)
    Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmInicio"
    Me.Text = "Form1"
    CType(Me.picCompilar, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picCargarArchivo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents comp As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents String_txt As System.Windows.Forms.ListBox
  Friend WithEvents picCargarArchivo As PictureBox
  Friend WithEvents Label1 As Label
  Friend WithEvents picCompilar As PictureBox
  Friend WithEvents Label9 As Label
  Friend WithEvents P_reservadas As System.Windows.Forms.ListBox
  Friend WithEvents C_Reales As System.Windows.Forms.ListBox
  Friend WithEvents C_Enteras As System.Windows.Forms.ListBox
  Friend WithEvents IDs_txt As System.Windows.Forms.ListBox
  Friend WithEvents Salida_txt As System.Windows.Forms.ListBox
  Friend WithEvents Entrada_txt As System.Windows.Forms.ListBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents btnExportar As Button

End Class
