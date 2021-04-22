Option Explicit On

Module Program
    Sub Main()
        Console.WriteLine("Zadej èíslo programu, který chceš spustit: ")
        Console.WriteLine("0 - Ukonèit program.")
        Console.WriteLine("1 - Výpoèet funkce sinus.")
        Console.WriteLine("2 - Interval náhodných èísel.")
        Console.WriteLine("3 - Losování Sportky.")
        Console.WriteLine("4 - Klesající posloupnost.")
        Console.WriteLine("5 - Klesající posloupnost 2.")
        Console.WriteLine("6 - Rozdíl prùmìru náhodných èísel.")
        Console.WriteLine("7 - Poèet tøíd a žákù.")
        Console.WriteLine("8 - Výpoèet kurzu Eura.")
        Console.WriteLine("9 - Sèítání do udaného èísla.")
        Console.WriteLine("a - Výpoèet dìlitelnosti èísla.")
        Console.WriteLine("b - Program na výpoèet malé násobilky.")
        Console.WriteLine("c - Porovnání znakù z tabulky ASCII.")

        Dim Vyber As Char = Console.ReadKey().KeyChar

        Select Case Vyber
            Case "0"
                Console.WriteLine("Program bude ukonèen.")
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
                Console.WriteLine("Neplatná volba.")
                Main()
        End Select

    End Sub

    Sub Sinus()
        'Výpoèet funkce sinus.'
        Dim i As Double

        For i = 0 To 2 * Math.PI Step 0.1
            Dim Index = Math.Round(i, 3)
            Dim sinus As Double = Math.Sin(Index)
            Console.WriteLine("Funkci Sin({0}) náleží hodnota {1}", Index, sinus)
        Next
    End Sub

    Sub Interval()
        'Interval náhodných èísel.'
        Randomize()
        Dim counter As Integer = 0

        For i = 0 To 9
            Dim NahodneCislo As Integer = ((100 - (-90)) * Rnd()) + (-90)
            Console.WriteLine("Náhodná èísla jsou: {0}", NahodneCislo)

            If NahodneCislo >= 10 And NahodneCislo <= 50 Then
                counter += 1
            End If
        Next
        Console.WriteLine("Bylo nalezeno {0} èísel v zadaném intervalu.", counter)
    End Sub

    Sub Sportka()
        'Losování èísel jako ve Sportce.'
        Randomize()
        Dim LosovanaCisla(4) As Integer

        For i = 0 To 4
            LosovanaCisla(i) = (49 * Rnd()) + 1
            If LosovanaCisla.Contains(LosovanaCisla(i)) Then
                LosovanaCisla(i) = (49 * Rnd()) + 1
            End If
        Next

        Array.Sort(LosovanaCisla)
        Console.Write("V dnešním losování Sportky byla vylosována èísla: ")

        For Each cislo As Integer In LosovanaCisla
            Console.Write(cislo & ", ")

        Next

    End Sub

    Sub Posloupnost()
        'Klesající posloupnost èísel od 8 do -8.'

        Console.Write("Seznam èísel je: ")
        For i = 8 To -8 Step -1
            Console.Write("{0}, ", i)
        Next

    End Sub

    Sub Posloupnost2()
        'Klesající posloupnost èísel od 8 do -8.'

        Console.Write("Seznam èísel je: ")
        For i = 8 To -8 Step -2
            Console.Write("{0}, ", i)
        Next

    End Sub

    Sub RozdilPrumeru()
        'Rozdíl prùmìru náhodných èísel od stredu intervalu (30).'
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
            Console.WriteLine("Prùmìr ({0}) náhodných èísel je vìtší než urèený støed. A rozdíl hodnot je {1}", Prumer, Prumer - 30)
        ElseIf Prumer < 30 Then
            Console.WriteLine("Prùmìr ({0}) náhodných èísel je menší než urèený støed. A rozdíl hodnot je {1}", Prumer, 30 - Prumer)
        Else
            Console.WriteLine("Prùmìr a støed jsou shodné.")
        End If

    End Sub

    Sub PocetTrid()
        'Poèet tøíd a žákù.'
        'Pro usnadnìní byl urèen poèet žákù v jednotlivých tøídách náhodnì z rozsahu 10 - 20."
        Console.WriteLine(vbCrLf & "Zadej poèet tøíd: ")
        Randomize()
        Dim PocetTrid As Integer = CInt(Console.ReadLine())
        Dim PocetZaku As Integer
        Dim PocetZakuCelkem As Integer = 0

        Console.Write("" & vbCrLf)
        Console.Write("Poèet žákù na jednotlivé tøídy: " & vbCrLf)
        For i = 0 To PocetTrid - 1
            PocetZaku = (11 * Rnd()) + 10
            PocetZakuCelkem += PocetZaku
            Console.WriteLine("{0}, ", PocetZaku)
        Next

        Console.Write("Poèet žákù celkem je: {0}" & vbCrLf, PocetZakuCelkem)

        Dim PrumernyPocet As Double = PocetZakuCelkem / PocetTrid
        Console.Write("Prùmerný poèet žákù na tøídu je: {0}." & vbCrLf, PrumernyPocet)

    End Sub

    Sub KurzEura()
        'Vyýpoèet kurzu Eura.'
        Randomize()
        Dim DobaMin As Integer = 20
        Dim KurzEuro As Single
        Dim VypisKurzu As String = ""

        Console.Write("" & vbCrLf)
        Console.Write("Kurzy Eura bìhem 20 minut: " & vbCrLf)
        For i = 1 To DobaMin
            KurzEuro = Math.Round((28 - 26) * Rnd() + 26, 2)

            VypisKurzu = VypisKurzu & CStr(KurzEuro) & " ¤ "

            If i Mod 5 = 0 Then

                Console.WriteLine(VypisKurzu)
                VypisKurzu = ""
            End If
        Next
    End Sub

    Sub Scitani()
        '(Souèet èísel od jedné do udaného èísla.)
        Dim vysledek As Integer = 0
        Console.Write("Zadej cislo: ")
        Dim cislo As Integer = CInt(Console.ReadLine())

        For i = 1 To cislo
            vysledek += i
        Next

        Console.WriteLine("Souèet èísel od jedné do udaného èísla èiní: {0}", vysledek)

    End Sub

    Sub Delitelnost()
        '(Výpoèet dìlitelnosti èísla.)
        Console.Write(vbCrLf & "Zadej cislo: ")
        Dim cislo As Integer = CInt(Console.ReadLine())
        Dim delitel As Integer = 0

        For i = 2 To cislo / 2

            If cislo Mod i = 0 Then
                Console.WriteLine("Èíslo {0} je dìlitelné èíslem: {1}", cislo, i)
                delitel = i
            End If

        Next

        If delitel = 0 Then
            Console.WriteLine("Zadané èíslo {0} je prvoèíslo.", cislo)
        End If

    End Sub

    Sub Nasobilka()
        '(Program na zkoušku malé násobilky pro èísla od 1 do 10.)
        Randomize()
        Dim vysledek As Integer
        Dim ErrCounter As Integer = 0

        For i = 1 To 10
            Dim cislo1 As Integer = (10 - 1) * Rnd() + 1
            Dim cislo2 As Integer = (10 - 1) * Rnd() + 1
            vysledek = cislo1 * cislo2
            Console.WriteLine(vbCrLf & "Zkus spoèítat nebo aspoò hádat výsledek pøíkladu {0} x {1}: ", cislo1, cislo2)

            If vysledek = CInt(Console.ReadLine()) Then
                Console.WriteLine("Úžasné! Malá násobilka pro tebe není problém!")
            Else
                Console.WriteLine("Tady ti to sice moc nejde, ale v jiných oborech možná exceluješ.")
                ErrCounter += 1
            End If
        Next

        Console.WriteLine("Dnes jsi udìlal {0} chyb. Dìkujeme za použití našeho programu.", ErrCounter)


    End Sub

    Sub TabulkaAscii()
        '(Porovnání znakù z tabulky ASCII.)
        Console.WriteLine(vbCrLf & "| Èíslo |                  | ASCII |")
        Console.WriteLine("....................................")

        For i = 65 To 99
            Console.WriteLine("| {0} |                         | {1} | ", i, Chr(i))
            Console.WriteLine("....................................")
        Next

    End Sub


End Module
