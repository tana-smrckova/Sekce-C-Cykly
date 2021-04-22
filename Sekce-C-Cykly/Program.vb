Option Explicit On

Module Program
    Sub Main()
        Console.WriteLine("Zadej ��slo programu, kter� chce� spustit: ")
        Console.WriteLine("0 - Ukon�it program.")
        Console.WriteLine("1 - V�po�et funkce sinus.")
        Console.WriteLine("2 - Interval n�hodn�ch ��sel.")
        Console.WriteLine("3 - Losov�n� Sportky.")
        Console.WriteLine("4 - Klesaj�c� posloupnost.")
        Console.WriteLine("5 - Klesaj�c� posloupnost 2.")
        Console.WriteLine("6 - Rozd�l pr�m�ru n�hodn�ch ��sel.")
        Console.WriteLine("7 - Po�et t��d a ��k�.")
        Console.WriteLine("8 - V�po�et kurzu Eura.")
        Console.WriteLine("9 - S��t�n� do udan�ho ��sla.")
        Console.WriteLine("a - V�po�et d�litelnosti ��sla.")
        Console.WriteLine("b - Program na v�po�et mal� n�sobilky.")
        Console.WriteLine("c - Porovn�n� znak� z tabulky ASCII.")

        Dim Vyber As Char = Console.ReadKey().KeyChar

        Select Case Vyber
            Case "0"
                Console.WriteLine("Program bude ukon�en.")
                End
            Case "1"
                Sinus()
            Case "2"
                Interval()
            Case "3"
                Sportka()
            Case "4"
                Posloupnost()
            Case "5"
                Posloupnost2()
            Case "6"
                RozdilPrumeru()
            Case "7"
                PocetTrid()
            Case "8"
                KurzEura()
            Case "9"
                Scitani()
            Case "a"
                Delitelnost()
            Case "b"
                Nasobilka()
            Case "c"
                TabulkaAscii()
            Case Else
                Console.WriteLine("Neplatn� volba.")
                Main()
        End Select

    End Sub

    Sub Sinus()
        'V�po�et funkce sinus.'
        Dim i As Double

        For i = 0 To 2 * Math.PI Step 0.1
            Dim Index = Math.Round(i, 3)
            Dim sinus As Double = Math.Sin(Index)
            Console.WriteLine("Funkci Sin({0}) n�le�� hodnota {1}", Index, sinus)
        Next
    End Sub

    Sub Interval()
        'Interval n�hodn�ch ��sel.'
        Randomize()
        Dim counter As Integer = 0

        For i = 0 To 9
            Dim NahodneCislo As Integer = ((100 - (-90)) * Rnd()) + (-90)
            Console.WriteLine("N�hodn� ��sla jsou: {0}", NahodneCislo)

            If NahodneCislo >= 10 And NahodneCislo <= 50 Then
                counter += 1
            End If
        Next
        Console.WriteLine("Bylo nalezeno {0} ��sel v zadan�m intervalu.", counter)
    End Sub

    Sub Sportka()
        'Losov�n� ��sel jako ve Sportce.'
        Randomize()
        Dim LosovanaCisla(4) As Integer

        For i = 0 To 4
            LosovanaCisla(i) = (49 * Rnd()) + 1
            If LosovanaCisla.Contains(LosovanaCisla(i)) Then
                LosovanaCisla(i) = (49 * Rnd()) + 1
            End If
        Next

        Array.Sort(LosovanaCisla)
        Console.Write("V dne�n�m losov�n� Sportky byla vylosov�na ��sla: ")

        For Each cislo As Integer In LosovanaCisla
            Console.Write(cislo & ", ")

        Next

    End Sub

    Sub Posloupnost()
        'Klesaj�c� posloupnost ��sel od 8 do -8.'

        Console.Write("Seznam ��sel je: ")
        For i = 8 To -8 Step -1
            Console.Write("{0}, ", i)
        Next

    End Sub

    Sub Posloupnost2()
        'Klesaj�c� posloupnost ��sel od 8 do -8.'

        Console.Write("Seznam ��sel je: ")
        For i = 8 To -8 Step -2
            Console.Write("{0}, ", i)
        Next

    End Sub

    Sub RozdilPrumeru()
        'Rozd�l pr�m�ru n�hodn�ch ��sel od stredu intervalu (30).'
        Randomize()
        Dim PocetCisel As Integer = 20
        Dim LosovanaCisla As Integer
        Dim Soucet As Integer = 0

        For i = 0 To PocetCisel - 1
            LosovanaCisla = (41 * Rnd()) + 10
            Soucet += LosovanaCisla
            Console.Write(LosovanaCisla & ", ")
        Next

        Dim Prumer = Soucet / PocetCisel

        If Prumer > 30 Then
            Console.WriteLine("Pr�m�r ({0}) n�hodn�ch ��sel je v�t�� ne� ur�en� st�ed. A rozd�l hodnot je {1}", Prumer, Prumer - 30)
        ElseIf Prumer < 30 Then
            Console.WriteLine("Pr�m�r ({0}) n�hodn�ch ��sel je men�� ne� ur�en� st�ed. A rozd�l hodnot je {1}", Prumer, 30 - Prumer)
        Else
            Console.WriteLine("Pr�m�r a st�ed jsou shodn�.")
        End If

    End Sub

    Sub PocetTrid()
        'Po�et t��d a ��k�.'
        'Pro usnadn�n� byl ur�en po�et ��k� v jednotliv�ch t��d�ch n�hodn� z rozsahu 10 - 20."
        Console.WriteLine(vbCrLf & "Zadej po�et t��d: ")
        Randomize()
        Dim PocetTrid As Integer = CInt(Console.ReadLine())
        Dim PocetZaku As Integer
        Dim PocetZakuCelkem As Integer = 0

        Console.Write("" & vbCrLf)
        Console.Write("Po�et ��k� na jednotliv� t��dy: " & vbCrLf)
        For i = 0 To PocetTrid - 1
            PocetZaku = (11 * Rnd()) + 10
            PocetZakuCelkem += PocetZaku
            Console.WriteLine("{0}, ", PocetZaku)
        Next

        Console.Write("Po�et ��k� celkem je: {0}" & vbCrLf, PocetZakuCelkem)

        Dim PrumernyPocet As Double = PocetZakuCelkem / PocetTrid
        Console.Write("Pr�mern� po�et ��k� na t��du je: {0}." & vbCrLf, PrumernyPocet)

    End Sub

    Sub KurzEura()
        'Vy�po�et kurzu Eura.'
        Randomize()
        Dim DobaMin As Integer = 20
        Dim KurzEuro As Single
        Dim VypisKurzu As String = ""

        Console.Write("" & vbCrLf)
        Console.Write("Kurzy Eura b�hem 20 minut: " & vbCrLf)
        For i = 1 To DobaMin
            KurzEuro = Math.Round((28 - 26) * Rnd() + 26, 2)

            VypisKurzu = VypisKurzu & CStr(KurzEuro) & " � "

            If i Mod 5 = 0 Then

                Console.WriteLine(VypisKurzu)
                VypisKurzu = ""
            End If
        Next
    End Sub

    Sub Scitani()
        '(Sou�et ��sel od jedn� do udan�ho ��sla.)
        Dim vysledek As Integer = 0
        Console.Write("Zadej cislo: ")
        Dim cislo As Integer = CInt(Console.ReadLine())

        For i = 1 To cislo
            vysledek += i
        Next

        Console.WriteLine("Sou�et ��sel od jedn� do udan�ho ��sla �in�: {0}", vysledek)

    End Sub

    Sub Delitelnost()
        '(V�po�et d�litelnosti ��sla.)
        Console.Write(vbCrLf & "Zadej cislo: ")
        Dim cislo As Integer = CInt(Console.ReadLine())
        Dim delitel As Integer = 0

        For i = 2 To cislo / 2

            If cislo Mod i = 0 Then
                Console.WriteLine("��slo {0} je d�liteln� ��slem: {1}", cislo, i)
                delitel = i
            End If

        Next

        If delitel = 0 Then
            Console.WriteLine("Zadan� ��slo {0} je prvo��slo.", cislo)
        End If

    End Sub

    Sub Nasobilka()
        '(Program na zkou�ku mal� n�sobilky pro ��sla od 1 do 10.)
        Randomize()
        Dim vysledek As Integer
        Dim ErrCounter As Integer = 0

        For i = 1 To 10
            Dim cislo1 As Integer = (10 - 1) * Rnd() + 1
            Dim cislo2 As Integer = (10 - 1) * Rnd() + 1
            vysledek = cislo1 * cislo2
            Console.WriteLine(vbCrLf & "Zkus spo��tat nebo aspo� h�dat v�sledek p��kladu {0} x {1}: ", cislo1, cislo2)

            If vysledek = CInt(Console.ReadLine()) Then
                Console.WriteLine("ڞasn�! Mal� n�sobilka pro tebe nen� probl�m!")
            Else
                Console.WriteLine("Tady ti to sice moc nejde, ale v jin�ch oborech mo�n� exceluje�.")
                ErrCounter += 1
            End If
        Next

        Console.WriteLine("Dnes jsi ud�lal {0} chyb. D�kujeme za pou�it� na�eho programu.", ErrCounter)


    End Sub

    Sub TabulkaAscii()
        '(Porovn�n� znak� z tabulky ASCII.)
        Console.WriteLine(vbCrLf & "| ��slo |                  | ASCII |")
        Console.WriteLine("....................................")

        For i = 65 To 99
            Console.WriteLine("| {0} |                         | {1} | ", i, Chr(i))
            Console.WriteLine("....................................")
        Next

    End Sub


End Module
