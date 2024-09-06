Imports System.Console

Module Program
    Sub Main()
        Dim num1, num2, product, dproduct As Double
        WriteLine("enter 2 two decimal numbers")
        num1 = ReadLine()
        num2 = ReadLine()
        product = num1 * num2
        dproduct = Math.Round(product, 2)
        WriteLine(dproduct)
        ReadKey()

    End Sub
End Module
