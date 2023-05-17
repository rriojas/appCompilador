Imports System.IO

Public Class frmInicio
  Dim wpalabra, wlinea, Estado, Token, Posicion, Caracter, columna, Encontro, wSalida
  Dim palabrareservada, Identificador, ConsInt, ConsString
  Dim direccion
  Dim Matriz(40, 40)
  Dim VectorPalabrasReservadas()
  Dim dialogoAbrirArchivo As OpenFileDialog
  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()

    dialogoAbrirArchivo = New OpenFileDialog()
    ' Add any initialization after the InitializeComponent() call.
    picCargarArchivo.Image = Image.FromFile("..\..\img\upload.png")
    picCompilar.Image = Image.FromFile("..\..\img\compile.png")
    LeerMatrizEstados("matrizEstados.csv")
    LeerPalabrasReservadas("palabrasReservadas.csv")
    For i = 0 To VectorPalabrasReservadas.Length - 1
      P_reservadas.Items.Add(VectorPalabrasReservadas(i) + "")
    Next
  End Sub
  Public Sub LeerPalabrasReservadas(archivo As String)
    Dim renglon As String
    Dim lector As StreamReader = New StreamReader(archivo)
    renglon = lector.ReadLine()
    VectorPalabrasReservadas = renglon.Split(",")

    lector.Close()
  End Sub

  Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
    Dim dialogoGuardar As New SaveFileDialog

    If dialogoGuardar.ShowDialog = DialogResult.Cancel Then
      Return
    End If

    Dim archivo As String = dialogoGuardar.FileName


    Dim sw As StreamWriter = New StreamWriter(archivo)

    For Each item In Salida_txt.Items
      If item.ToString() <> "" Then
        sw.WriteLine(item.ToString())
      End If


    Next
    sw.Close()

  End Sub

  Private Sub LeerMatrizEstados(archivo As String)
    Dim renglon As String
    Dim datosRenglon As String()
    Dim lector As StreamReader = New StreamReader(archivo)
    Dim r As Integer = 0
    While Not lector.EndOfStream
      renglon = lector.ReadLine()
      datosRenglon = renglon.Split(",")
      For c = 0 To datosRenglon.Length - 1
        Matriz(r, c) = datosRenglon(c)
      Next
      r += 1

    End While
    lector.Close()
  End Sub
  Private Sub picCargarArchivo_Click(sender As Object, e As EventArgs) Handles picCargarArchivo.Click
    'Programamos para abrir un archivo y trabajar en el

    If dialogoAbrirArchivo.ShowDialog() <> DialogResult.OK Then
      Return
    End If
    Dim archivo As String = dialogoAbrirArchivo.FileName
    Dim fileReader As System.IO.StreamReader 'Acomodar para leer linea por linea 
    fileReader = My.Computer.FileSystem.OpenTextFileReader(archivo) '
    Dim stringReader As String 'Declara la variable 
    While Not (fileReader.EndOfStream) 'Entra al ciclo y sigue hasta que termine de leer el archivo txt 
      stringReader = fileReader.ReadLine() 'Lee las lineas 
      Entrada_txt.Items.Add(stringReader) 'Se agrega el archivo en nuestro listbox de entrada
    End While
  End Sub
  Private Sub Compilar_txt_Click(sender As Object, e As EventArgs) Handles picCompilar.Click
    'Se programa el botón de compilar
    Dim Renglon = 0
    While (Renglon < Entrada_txt.Items.Count)
      Entrada_txt.SelectedIndex = Renglon 'Me posiciono en un elemento de la lista
      wlinea = Entrada_txt.Text 'Regresa el valor de donde estoy posicionado
      BuscaTokens() ' Trae todos los tokens agregados en el archivo
      Renglon = Renglon + 1
    End While
  End Sub
  Private Sub BuscaTokens()
    'Procedimiento para agregar los tokens
    Estado = 0
    Token = ""
    Posicion = 1
    'Len regresa la cantidad de caracteres de una variable de texto
    'Mid regresa un caracter de una variable de texto
    While Posicion <= Len(wlinea)
      Caracter = Mid(wlinea, Posicion, 1)
      CalcularColumna() 'Calcula la columna que le corresponde al caracter
      Estado = Matriz(Estado, columna) '
      If (Estado >= 100) Then 'Es estado aceptor?
        If (Len(Token) >= 0) Then
          ReconocerToken()
        End If
        Estado = 0
        Token = ""
        Salida_txt.Items.Add(Token) 'Agregar en el listbox de salida los tokens
      Else
        If (Estado <> 0) Then
          Token = Token + Caracter
        End If
      End If
      Posicion = Posicion + 1
    End While
    If (Len(Token) > 0) Then
      Caracter = " "
      CalcularColumna()
      Estado = Matriz(Estado, columna)
      ReconocerToken()
    End If
  End Sub
  Private Sub Buscapreservadas()
    Dim posicion
    posicion = 0
    direccion = -1
    While (Not (palabrareservada)) And (posicion < VectorPalabrasReservadas.Length)
      'P_reservadas.SelectedIndex = posicion

      If (UCase(Token) = UCase(VectorPalabrasReservadas(posicion))) Then 'Compara las variables en modo mayuscula
        palabrareservada = True
        direccion = posicion
      End If
      posicion += 1
    End While
  End Sub
  Private Sub BuscaIdentificadores()
    'Procedimiento para encontrar identificadores
    Dim Renglon2
    Renglon2 = 0
    Encontro = False
    While (Not (Encontro)) And (Renglon2 < IDs_txt.Items.Count)
      IDs_txt.SelectedIndex = Renglon2
      If (UCase(Token) = UCase(IDs_txt.Text)) Then
        Encontro = True
        direccion = Renglon2
      End If
      Renglon2 = Renglon2 + 1
    End While
    If (Not (Encontro)) Then
      IDs_txt.Items.Add(Token)
      direccion = IDs_txt.Items.Count - 1
    End If
  End Sub
  Private Sub ReconocerToken()
    'Programamos reconoce token para saber que tipo de token es cada palabra
    If (Estado = 100) Then
      palabrareservada = False
      Buscapreservadas()
      If palabrareservada Then
        wSalida = Token + " PR " + Str(direccion)
      Else
        BuscaIdentificadores()
        wSalida = Token + " ID " + Str(direccion)
      End If
      Posicion = Posicion - 1
    End If
    If Estado = 101 Then
      ConstantesEnteras()
      wSalida = Token + "Ctes.Enteras" + Str(direccion)
      Posicion = Posicion - 1
    End If
    If Estado = 102 Then
      ConstantesReales()
      wSalida = Token + "Ctes.Reales" + Str(direccion)
      Posicion = Posicion - 1
    End If
    If Estado = 103 Then
      Token = Token + Caracter
      ConstantesString()
      wSalida = Token + "Ctes.String" + Str(direccion)
    End If
    If Estado = 105 Then
      Token = Token + Caracter
      wSalida = Token + "Caracter Esp"
    End If
    If Estado = 106 Then
      Token = Token + Caracter
      wSalida = Token + "Caracter Esp"

    End If
    If Estado = 107 Then
      Token = Token + Caracter
      wSalida = Token + "Caracter Esp"

    End If
    If Estado = 108 Then
      Token = Token + Caracter
      wSalida = Token + "Caracter Esp"

    End If
    If Estado = 114 Then
      Token = Token + Caracter
      wSalida = Token + "Caracter Esp"

    End If
    If Estado = 115 Then
      Token = Token + Caracter
      wSalida = Token + "Caracter Esp"

    End If
    If Estado = 116 Then
      Token = Token + Caracter
      wSalida = Token + "Caracter Esp"

    End If
    If Estado = 117 Then
      Token = Token + Caracter
      wSalida = Token + "Caracter Esp"

    End If
    If Estado = 118 Then
      Token = Token + Caracter
      wSalida = Token + "Caracter Esp"

    End If
    If Estado = 119 Then
      Token = Token + Caracter
      wSalida = Token + "Caracter Esp"

    End If
    If Estado = 120 Then
      Token = Token + Caracter
      wSalida = Token + "Caracter Esp"

    End If
    If Estado = 121 Then
      Token = Token + Caracter
      wSalida = Token + "Caracter Esp"

    End If
    If Estado = 104 Then
      Token = Token + Caracter
      wSalida = Token + "Commentario"

    End If
    Salida_txt.Items.Add(wSalida) 'Añadimos el token en el listbox salida con el tipo de token que es
  End Sub
  Private Sub CalcularColumna()
    'Calcula el valor de la columna de cada caracter
    If Caracter >= "A" And Caracter <= "Z" Then
      columna = 0
    ElseIf Caracter >= "a" And Caracter <= "z" Then
      columna = 0
    ElseIf (Caracter >= "0" And Caracter <= "9") Then
      columna = 1
    ElseIf Caracter = "." Then
      columna = 2
    ElseIf Caracter = ChrW(34) Then
      columna = 3
    ElseIf Caracter = "/" Then
      columna = 4
    ElseIf Caracter = "*" Then
      columna = 5
    ElseIf Caracter = "+" Then
      columna = 6
    ElseIf Caracter = "-" Then
      columna = 7
    ElseIf Caracter = "<" Then
      columna = 8
    ElseIf Caracter = ">" Then
      columna = 9
    ElseIf Caracter = "(" Then
      columna = 10
    ElseIf Caracter = ")" Then
      columna = 11
    ElseIf Caracter = "[" Then
      columna = 12
    ElseIf Caracter = "]" Then
      columna = 13
    ElseIf Caracter = "{" Then
      columna = 14
    ElseIf Caracter = "}" Then
      columna = 15
    ElseIf Caracter = ";" Then
      columna = 16
    ElseIf Caracter = " " Then
      columna = 17
    ElseIf Caracter = "=" Then
      columna = 18
    ElseIf Caracter = "_" Then
      columna = 19
    End If
  End Sub
  Private Sub ConstantesEnteras()
    'Procedimiento para las constantes enteras
    Dim Renglon2
    Renglon2 = 0
    Encontro = False
    While (Not (Encontro)) And (Renglon2 < C_Enteras.Items.Count) 'Entra al ciclo, si encuentra un token le asigna un numero
      C_Enteras.SelectedIndex = Renglon2
      If (UCase(Token) = UCase(C_Enteras.Text)) Then
        Encontro = True
        direccion = Renglon2
      End If
      Renglon2 = Renglon2 + 1
    End While
    If (Not (Encontro)) Then
      C_Enteras.Items.Add(Token)
      direccion = C_Enteras.Items.Count - 1
    End If
  End Sub
  Private Sub ConstantesReales()
    'Procedimiento para las constantes reales
    Dim Renglon2
    Renglon2 = 0
    Encontro = False
    While (Not (Encontro)) And (Renglon2 < C_Reales.Items.Count)
      C_Reales.SelectedIndex = Renglon2
      If (UCase(Token) = UCase(C_Reales.Text)) Then
        Encontro = True
        direccion = Renglon2
      End If
      Renglon2 = Renglon2 + 1
    End While
    If (Not (Encontro)) Then
      C_Reales.Items.Add(Token)
      direccion = C_Reales.Items.Count - 1
    End If
  End Sub
  Private Sub ConstantesString()
    'Procedimiento para las constantes String
    Dim Renglon2
    Renglon2 = 0
    Encontro = False
    While (Not (Encontro)) And (Renglon2 < String_txt.Items.Count)
      String_txt.SelectedIndex = Renglon2
      If (UCase(Token) = UCase(String_txt.Text)) Then
        Encontro = True
        direccion = Renglon2
      End If
      Renglon2 = Renglon2 + 1
    End While
    If (Not (Encontro)) Then
      String_txt.Items.Add(Token)
      direccion = String_txt.Items.Count - 1
    End If
  End Sub

End Class
