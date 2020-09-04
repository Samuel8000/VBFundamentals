Imports System.Runtime.InteropServices

Module MainModule

    Sub Main()
        Dim products = LoadProducts()

        Console.WriteLine(products.ContainsKey(1))
        Console.WriteLine(products.ContainsKey(99))
        Console.ReadKey()
    End Sub
    Function LoadProducts() As Dictionary(Of Integer, Product)
        Dim products As New Dictionary(Of Integer, Product)
        Dim product As Product

        product = New Product() With {.ProductId = 1, .Name = "10 Speed bike", .ProductNumber = "10-SP", .ListPrice = 1431.5D}
        products.Add(key:=product.ProductId, value:=product)

        product = New Product() With {.ProductId = 2, .Name = "Bike Helmet", .ProductNumber = "BIKE-HE", .ListPrice = 39.99D}
        products.Add(product.ProductId, product)

        product = New Product() With {.ProductId = 3, .Name = "Inner Tube", .ProductNumber = "BIKE-IN-TUBE", .ListPrice = 4.99D}
        products.Add(product.ProductId, product)

        Return products
    End Function
End Module
