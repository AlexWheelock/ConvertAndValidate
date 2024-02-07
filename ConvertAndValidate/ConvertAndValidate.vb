'Alex Wheelock
'RCET 0265
'Spring 2024
'Convert and Validate
'https://github.com/AlexWheelock/ConvertAndValidate.git

Option Strict On
Option Explicit On

Module ConvertAndValidate

    Sub Main()

        Dim usernResponse As String
        Dim aValidNumber As Integer

        Do

            Console.WriteLine($"Enter a number:")

            usernResponse = Console.ReadLine()

            If ConversionValid(usernResponse, aValidNumber) = True Then
                aValidNumber = CInt(usernResponse)
                Console.WriteLine($"{usernResponse} converted successfully to {aValidNumber}!")

            Else

                Console.WriteLine($"Oops, {usernResponse} does not seem to be a number")

            End If

        Loop

    End Sub

    'make this work


    Function ConversionValid(convertThisString As String, ByRef toThisInteger As Integer) As Boolean

        Dim status As Boolean

        Try
            toThisInteger = CInt(convertThisString)
            status = True
        Catch ex As Exception
            status = False
        End Try

        Return status

    End Function

End Module
