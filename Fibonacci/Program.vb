Imports System

Module Program
    Sub Main(args As String())
        Dim list As New ArrayList
        Dim num As New Integer
        Dim cont = 0
        Dim e = 2
        list.Add(0)
        list.Add(1)
        'EL PROGRAMA SE EJECUTA SIEMPRE Y CUANDO EL NUMERO INTRODUCIDO SEA DIFERENTE A -1. SI EL USUARIO INTRODUCE EL -1 EL PROGRAMA SE APAGA
        While num <> -1
            Console.WriteLine("Introduzca cuantos numeros debe de sacar el programa de la secuencia fibonacci, introduzca -1 para salir del programa")
            num = Console.ReadLine()
            If num <> -1 Then
                Console.WriteLine("La secuencia: ")
                While cont <> num
                    list.Add(list(e - 1) + list(e - 2))
                    e += 1
                    cont += 1
                End While
                cont = 0
                While cont <> num
                    Console.WriteLine(list(cont).ToString)
                    cont += 1
                End While
            End If
        End While
        Console.WriteLine("Apagando programa...")
    End Sub
End Module
