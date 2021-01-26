'Kendall Callister
'Tim Rossiter
'RCET0265
'Spring 2021
'Multiplication Table
'https://github.com/callkend/Multipilcation-Table.git

Option Explicit On
Option Strict On

Module Module1

    Sub Main()
        Dim tableSize As Int16
        Dim userInput As String
        Dim problem As Boolean = True

        'prompts user for the size of the Multiplication table and checks for valid input
        Do Until problem = False
            Try
                Console.WriteLine("Enter the size of Table")
                userInput = Console.ReadLine()
                problem = False
                tableSize = CDec(userInput)
            Catch ex As Exception
                Console.WriteLine($"{userInput} is invaild. Enter a Number")
                problem = True
            End Try
        Loop

        Console.WriteLine($"Here is a {tableSize} * {tableSize} Multiplication Table")

        'Creates the Multipication Table
        For j = 1 To tableSize
            For i = 1 To tableSize
                Console.Write(j * i)
                Console.Write(vbTab)
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module
