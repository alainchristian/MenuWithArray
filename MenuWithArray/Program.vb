Imports System

Module Program
    Sub Main()
        Dim choice As String
        Dim Arr() As Integer = {}
        Dim size As Integer
        Dim found As Boolean = False
        Dim el, foundIndex As Integer
        Dim elCount As Integer = 0
        Do
            Console.WriteLine("Menu")
            Console.WriteLine("1. Initialize")
            Console.WriteLine("2. Search")
            Console.WriteLine("3. Delete")
            Console.WriteLine("4. Add")
            Console.WriteLine("5. Display")
            Console.WriteLine("Your choice:")
            choice = Console.ReadLine()
            If choice = "stop" Then
                Exit Do
            End If
            Select Case choice
                Case "1"
                    Console.Clear()
                    Console.WriteLine("Initialization")
                    Console.Write("How many elements:")
                    size = Console.ReadLine()
                    ReDim Arr(size - 1)
                    For i = 0 To Arr.Length - 1
                        Console.Write("Element{0}: ", i + 1)
                        Arr(i) = Console.ReadLine()
                    Next
                Case "2"
                    Console.Clear()
                    Console.WriteLine("Search")
                    If Arr.Length = 0 Then
                        Console.WriteLine("No elements to search!!")
                    Else
                        Console.Write("Element to search: ")
                        el = Console.ReadLine
                        'Findin element
                        For i = 0 To Arr.Length - 1
                            If Arr(i) = el Then
                                found = True
                                foundIndex = i
                                Exit For
                            End If
                        Next
                        'Count occurance
                        For i = 0 To Arr.Length - 1
                            If Arr(i) = el Then
                                elCount += 1
                            End If
                        Next
                        Console.WriteLine("{0} found at index {1}, occurs {2} times", el, foundIndex, elCount)
                    End If
                Case "3"
                    Console.Clear()
                    Console.WriteLine("Delete")
                    Console.Write("Element to delete:")
                    el = Console.ReadLine()
                    foundIndex = Array.IndexOf(Arr, el)
                    If foundIndex >= 0 Then
                        For i = foundIndex To Arr.Length - 2
                            Arr(i) = Arr(i + 1)
                        Next
                        ReDim Preserve Arr(Arr.Length - 2)
                    End If

                Case "4"
                    Console.Clear()
                    Console.WriteLine("Add")
                    Console.Write("Element to Add:")
                    el = Console.ReadLine()
                    ReDim Preserve Arr(Arr.Length)
                    Arr(Arr.Length - 1) = el

                Case "5"
                    Console.Clear()
                    Console.WriteLine("Display")
                    Console.WriteLine("Array elements:")
                    For Each ele As Integer In Arr
                        Console.WriteLine(ele)
                    Next

                Case Else
                    Console.Clear()
                    Console.WriteLine("Invalid choice")
            End Select
        Loop While choice <> "stop"

    End Sub
End Module
