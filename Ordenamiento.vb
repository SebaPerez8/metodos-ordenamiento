Public Class Ordenamiento

    Declare Function GetTickCount Lib "kernel32" () As Long

    Dim V() As Long
    Dim Aux As Long
    Dim cComparaciones As Long, cAsignaciones As Long
    Dim TiempoInicio As Long, TiempoFin As Long, TiempoTranscurrido As Double

    Dim Lienzo As Graphics
    Dim Lapiz As Brush
    Dim Goma As Brush

    Dim fph As Single
    Dim fpv As Single

    Private Sub Ordenamiento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Lienzo = picVector.CreateGraphics
        Lapiz = Brushes.Black
        Goma = Brushes.White

    End Sub

    Private Sub cmdCrearVector_Click(sender As Object, e As EventArgs) Handles cmdCrearVector.Click

        Dim R As New Random
        Dim i, c, k, Limite As Integer

        ReDim V(Val(txtTVector.Text) - 1)

        Limite = V.GetUpperBound(0)
        i = 0
        While i <= Limite
            k = R.Next(Limite + 1)
            c = 0
            While c < i
                If V(c) = k Then
                    k = R.Next(Limite + 1)
                    c = -1
                End If
                c = c + 1
            End While
            V(i) = k
            i = i + 1
        End While

        GraficarVector()

    End Sub

    Private Sub cmdVerVector_Click(sender As Object, e As EventArgs) Handles cmdVerVector.Click

        Grilla.Rows.Clear()

        Dim i, UltimaPos As Integer
        UltimaPos = V.GetUpperBound(0)
        i = 0

        While i <= UltimaPos
            Grilla.Rows.Add(V(i))
            i = i + 1
        End While

    End Sub

    Private Sub cmdBurbuja_Click(sender As Object, e As EventArgs) Handles cmdBurbuja.Click

        Burbuja()
        Burbuja_Monitoreada()


    End Sub

    Private Sub Burbuja()

        Dim i, Limite As Integer

        Limite = V.GetUpperBound(0)
        While Limite > 0
            i = 0
            While i < Limite
                If V(i) > V(i + 1) Then
                    Aux = V(i)
                    V(i) = V(i + 1)
                    V(i + 1) = Aux
                    GraficarBarra(i)
                    GraficarBarra(i + 1)
                End If
                i = i + 1
            End While
            Limite = Limite - 1
        End While

    End Sub

    Private Sub Burbuja_Monitoreada()

        Dim i, Limite As Integer
        cAsignaciones = 0
        cComparaciones = 0

        TiempoInicio = GetTickCount()

        cAsignaciones = cAsignaciones + 1
        Limite = V.GetUpperBound(0)
        cComparaciones = cComparaciones + 1
        While Limite > 0
            cAsignaciones = cAsignaciones + 1
            i = 0
            cComparaciones = cComparaciones + 1
            While i < Limite
                cComparaciones = cComparaciones + 1
                If V(i) > V(i + 1) Then
                    cAsignaciones = cAsignaciones + 3
                    Aux = V(i)
                    V(i) = V(i + 1)
                    V(i + 1) = Aux
                End If
                cAsignaciones = cAsignaciones + 1
                i = i + 1
            End While
            cAsignaciones = cAsignaciones + 1
            Limite = Limite - 1
        End While

        TiempoFin = GetTickCount()

        lblTiempoBurbuja.Text = TiempoFin - TiempoInicio
        lblAsignacionesBurbuja.Text = cAsignaciones
        lblComparacionesBurbuja.Text = cComparaciones

    End Sub

    Private Sub cmdBurbBandera_Click(sender As Object, e As EventArgs) Handles cmdBurbBandera.Click

        BurbujaConBandera()
        BurbujaConBandera_Monitoreada()


    End Sub

    Private Sub BurbujaConBandera()

        Dim i, Limite As Integer
        Dim Bandera As Boolean

        Bandera = True
        Limite = V.GetUpperBound(0)
        While Limite > 0 And Bandera = True
            Bandera = False
            i = 0
            While i < Limite
                If V(i) > V(i + 1) Then
                    Bandera = True
                    Aux = V(i)
                    V(i) = V(i + 1)
                    V(i + 1) = Aux
                    GraficarBarra(i)
                    GraficarBarra(i + 1)
                End If
                i = i + 1
            End While
            Limite = Limite - 1
        End While

    End Sub

    Private Sub BurbujaConBandera_Monitoreada()

        Dim i, Limite As Integer
        Dim Bandera As Boolean
        cAsignaciones = 0
        cComparaciones = 0

        TiempoInicio = GetTickCount()

        cAsignaciones = cAsignaciones + 1
        Bandera = True
        cAsignaciones = cAsignaciones + 1
        Limite = V.GetUpperBound(0)
        cComparaciones = cComparaciones + 3
        While Limite > 0 And Bandera
            cAsignaciones = cAsignaciones + 1
            Bandera = False
            cAsignaciones = cAsignaciones + 1
            i = 0
            cComparaciones = cComparaciones + 1
            While i < Limite
                cComparaciones = cComparaciones + 1
                If V(i) > V(i + 1) Then
                    cAsignaciones = cAsignaciones + 1
                    Bandera = True
                    cAsignaciones = cAsignaciones + 3
                    Aux = V(i)
                    V(i) = V(i + 1)
                    V(i + 1) = Aux
                End If
                cAsignaciones = cAsignaciones + 1
                i = i + 1
            End While
            cAsignaciones = cAsignaciones + 1
            Limite = Limite - 1
        End While

        TiempoFin = GetTickCount()

        lblTiempoBurbujaBandera.Text = TiempoFin - TiempoInicio
        lblAsignBurbujaBandera.Text = cAsignaciones
        lblCompBurbujaBandera.Text = cComparaciones

    End Sub

    Private Sub cmdSelecDirecta_Click(sender As Object, e As EventArgs) Handles cmdSelecDirecta.Click

        SeleccionDirecta()
        SeleccionDirecta_Monitoreada()

    End Sub

    Private Sub SeleccionDirecta()

        Dim i, j As Integer
        Dim Menor, Limite As Integer
        Limite = V.GetUpperBound(0)

        For i = 0 To Limite
            Menor = i
            For j = i + 1 To Limite
                If V(Menor) > V(j) Then
                    Menor = j
                End If
            Next j
            Aux = V(i)
            V(i) = V(Menor)
            V(Menor) = Aux
            GraficarBarra(i)
        Next

    End Sub

    Private Sub SeleccionDirecta_Monitoreada()

        Dim i, j As Integer
        Dim Menor, Limite As Integer
        cAsignaciones = 0
        cComparaciones = 0

        cAsignaciones = cAsignaciones + 1
        Limite = V.GetUpperBound(0)
        cComparaciones = cComparaciones + 1
        For i = 0 To Limite
            cAsignaciones = cAsignaciones + 1
            Menor = i
            cComparaciones = cComparaciones + 1
            For j = i + 1 To Limite
                cComparaciones = cComparaciones + 1
                If V(Menor) > V(j) Then
                    cAsignaciones = cAsignaciones + 1
                    Menor = j
                End If
            Next j
            cAsignaciones = cAsignaciones + 3
            Aux = V(i)
            V(i) = V(Menor)
            V(Menor) = Aux
        Next

        lblAsignSeleccionDirecta.Text = cAsignaciones
        lblCompSeleccionDirecta.Text = cComparaciones

    End Sub

    Private Sub cmdInsercion_Click(sender As Object, e As EventArgs) Handles cmdInsercion.Click

        Insercion()

    End Sub

    Private Sub Insercion()

        Dim i, Frontera As Integer
        Frontera = 0
        While Frontera < V.GetUpperBound(0)
            i = Frontera
            Aux = V(i + 1)

            While i >= 0 AndAlso (Aux < V(i))
                V(i + 1) = V(i)
                GraficarBarra(i + 1)
                i = i - 1
            End While
            V(i + 1) = Aux
            GraficarBarra(i + 1)
            Frontera = Frontera + 1
        End While


    End Sub


    Private Sub cmdQuick_Click(sender As Object, e As EventArgs) Handles cmdQuick.Click

        QuickSort(0, V.GetUpperBound(0))

    End Sub

    Private Sub QuickSort(LIzq As Integer, LDer As Integer)


        Dim pd, pi, Pivote As Integer
        pi = LIzq
        pd = LDer
        Pivote = V(pi)
        While pi < pd
            While (V(pd) >= Pivote) And (pi < pd)
                pd = pd - 1
            End While

            V(pi) = V(pd)
            GraficarBarra(pi)
            'pi = pi + 1

            While (V(pi) < Pivote) And (pi < pd)
                pi = pi + 1
            End While
            V(pd) = V(pi)
            GraficarBarra(pd)
            'pd = pd - 1
        End While

        V(pi) = Pivote
        GraficarBarra(pi)
        If (pi + 1 < LDer) Then
            QuickSort(pi + 1, LDer)
        End If
        If (LIzq < pd + 1) Then
            QuickSort(LIzq, pd - 1)
        End If

    End Sub

    Private Sub cmdMerge_Click(sender As Object, e As EventArgs) Handles cmdMerge.Click

        MergeSort()

    End Sub

    Private Sub MergeSort()

        Dim IzqA, DerA, IzqB, DerB As Integer
        Dim AnchoSeccion, Limite As Integer
        Limite = V.GetUpperBound(0)

        AnchoSeccion = 1
        While AnchoSeccion <= Limite + 1
            IzqA = 0
            DerA = IzqA + AnchoSeccion - 1
            IzqB = DerA + 1
            DerB = IzqB + AnchoSeccion - 1
            If DerB > Limite Then
                DerB = Limite
            End If
            While IzqB <= Limite
                MezclarV(IzqA, DerA, IzqB, DerB)
                IzqA = DerB + 1
                DerA = IzqA + AnchoSeccion - 1
                IzqB = DerA + 1
                DerB = IzqB + AnchoSeccion - 1
                If DerB > Limite Then
                    DerB = Limite
                End If
            End While
            AnchoSeccion = AnchoSeccion * 2
        End While

    End Sub

    Private Sub MezclarV(iA As Integer, dA As Integer, iB As Integer, dB As Integer)

        Dim VAux(dB - iA) As Long
        Dim i As Integer
        Dim iInicio As Integer = iA

        i = 0
        While iA <= dA And iB <= dB
            If V(iA) < V(iB) Then
                VAux(i) = V(iA)
                iA = iA + 1
            Else
                VAux(i) = V(iB)
                iB = iB + 1
            End If
            i = i + 1
        End While

        If iA > dA Then
            While i <= VAux.GetUpperBound(0)
                VAux(i) = V(iB)
                iB = iB + 1
                i = i + 1
            End While
        Else
            While i <= VAux.GetUpperBound(0)
                VAux(i) = V(iA)
                iA = iA + 1
                i = i + 1
            End While
        End If

        i = 0
        While i <= VAux.GetUpperBound(0)
            V(i + iInicio) = VAux(i)
            GraficarBarra(i + iInicio)
            i = i + 1
        End While

    End Sub
    'Error de indice fuera del limite de la matriz?????


    Private Sub GraficarVector()

        Dim i As Long, Limite As Long = V.GetUpperBound(0)

        i = 0
        While i <= Limite
            GraficarBarra(i)
            i = i + 1
        End While

    End Sub

    Private Sub GraficarBarra(i As Long)

        Dim x, y, Ancho, Alto As Integer

        fph = picVector.Width / (V.GetUpperBound(0) + 1)
        fpv = picVector.Height / (V.GetUpperBound(0))

        x = fph * i
        y = picVector.Height - (fpv * V(i))
        Ancho = fph
        Alto = fpv * V(i)

        Lienzo.FillRectangle(Goma, x, 0, Ancho + 1, picVector.Height)
        Lienzo.FillRectangle(Lapiz, x, y, Ancho + 1, Alto)

    End Sub

    Private Sub cmdVaciar_Click(sender As Object, e As EventArgs) Handles cmdVaciar.Click

        lblAsignacionesBurbuja.Text = ""
        lblComparacionesBurbuja.Text = ""
        lblTiempoBurbuja.Text = ""
        lblAsignBurbujaBandera.Text = ""
        lblCompBurbujaBandera.Text = ""
        lblTiempoBurbujaBandera.Text = ""
        lblAsignSeleccionDirecta.Text = ""
        lblCompSeleccionDirecta.Text = ""

    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        Grilla.Rows.Clear()
    End Sub

End Class
