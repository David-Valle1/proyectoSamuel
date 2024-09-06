using System;
using System.Collections.Generic;

class Proyecto
{
    static void Main()
    {
        bool Continuar = true;
        bool regresar = true;

        

        List<string> ProductosComprados = new List<string>();
        List<double> PreciosVentas = new List<double>();

        Console.WriteLine("|---------| Mercadito Valle |---------|");
        Console.WriteLine("Bienvenido a nuestro sistema de ventas");
        Console.Write("Por favor ingrese su nombre: ");
        string nombre = Console.ReadLine();
        Console.Write($"{nombre} por favor ingrese su edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        int precio = 0;
        string NProducto = "";


        while (Continuar)
        {
            Console.Clear();
            Console.WriteLine($"{nombre} elija la categoria del producto a comprar");
            Console.WriteLine("1. Alimentos y bebidas");
            Console.WriteLine("2. Frutas");
            Console.WriteLine("3. Lacteos y embutidos");
            Console.WriteLine("=======================================");
            Console.WriteLine(" Si desea salir del programa escriba 4 ");
            Console.WriteLine("======================================="); string categoria = Console.ReadLine();

            switch (categoria)
            {
                case "1":
                    regresar = true; 
                    while (regresar)
                    {
                        Console.Clear();
                        Console.WriteLine("1. Arroz 1 L ------------------- 15 Lps");
                        Console.WriteLine("2. Frijoles 2.5 L -------------- 40 Lps");
                        Console.WriteLine("3. Espagueti 1 L --------------- 20 Lps");
                        Console.WriteLine("4. Aceite vegetal 1 litro ------ 50 Lps");
                        Console.WriteLine("5. Atun enlatado Lata ---------- 65 Lps");
                        Console.WriteLine("6. Galletas saladas paquete ---- 25 Lps");
                        Console.WriteLine("7. Jugo de naranja 1 litro ----- 35 Lps");
                        Console.WriteLine("8. Jugo de manzana  2 litros --- 40 Lps");
                        Console.WriteLine("9. Harina de maíz 1 L ---------- 10 Lps");
                        Console.WriteLine("10. Azúcar 1 L ----------------- 12 Lps");
                        Console.WriteLine("=======================================");
                        Console.WriteLine("     Si desea regresar escriba 11      ");
                        Console.WriteLine("=======================================");

                        Console.Write($"{nombre} ingrese el numero del producto que desea comprar: ");
                        string producto = Console.ReadLine();

                        if (producto == "1")
                        {
                            precio = 15;
                            NProducto = "Arroz";
                        }
                        else if (producto == "2")
                        {
                            precio = 40;
                            NProducto = "Frijoles";

                        }
                        else if (producto == "3")
                        {
                            precio = 20;
                            NProducto = "Espagueti";

                        }
                        else if (producto == "4")
                        {
                            precio = 50;
                            NProducto = "Aceite vegetal";

                        }
                        else if (producto == "5")
                        {
                            precio = 65;
                            NProducto = "Atun enlatado";

                        }
                        else if (producto == "6")
                        {
                            precio = 25;
                            NProducto = "Galletas saladas";

                        }
                        else if (producto == "7")
                        {
                            precio = 35;
                            NProducto = "Jugo de naranja";

                        }
                        else if (producto == "8")
                        {
                            precio = 40;
                            NProducto = "Jugo de manzana";

                        }
                        else if (producto == "9")
                        {
                            precio = 10;
                            NProducto = "Harina de maíz";

                        }
                        else if (producto == "10")
                        {
                            precio = 12;
                            NProducto = "Azúcar";

                        }
                        else if (producto == "11")
                        {
                            regresar = false;

                        }
                        else
                        {
                            Console.WriteLine($"{nombre} no tenemos el producto seleccionado");
                            precio = 0;
                        }
                     
                        if (producto != "11")
                        {
                            
                            Console.Clear();
                            Console.WriteLine($"{nombre} el precio de {NProducto} es: {precio} Lps");
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.Write($"Ingrese la cantidad deseada de {NProducto}: ");
                            int cantidad = Convert.ToInt32(Console.ReadLine());
                            double subtotal = (precio * cantidad);
                            double impuesto = subtotal * 0.15; 
                            double descuento = 0;

                            if (edad >= 60)
                            {
                                descuento = subtotal * 0.3;
                            }

                            double total = subtotal + impuesto - descuento;
                            ProductosComprados.Add($"{cantidad} de {NProducto} ");
                            PreciosVentas.Add(total);

                            Console.WriteLine($"El valor a pagar es de: {total} Lps");
                            Console.WriteLine($"Impuesto: {impuesto} y un descuento: {descuento} Lps");
                            Console.ReadKey();
                        }
                    }
                    break;

                case "2":
                    regresar = true; 
                    while (regresar)
                    {
                        Console.Clear();
                        Console.WriteLine("1. Mango ----------------------- 15 Lps");
                        Console.WriteLine("2. Sandias --------------------- 50 Lps");
                        Console.WriteLine("3. Piña ------------------------ 40 Lps");
                        Console.WriteLine("4. Melon ----------------------- 30 Lps");
                        Console.WriteLine("5. Tamarindo 1L ---------------- 15 Lps");
                        Console.WriteLine("6. Albaricoque ------------------ 4 Lps");
                        Console.WriteLine("7. Fresas 1 L ------------------ 60 Lps");
                        Console.WriteLine("8. Naranjas --------------------- 3 Lps");
                        Console.WriteLine("9. Limones ---------------------- 4 Lps");
                        Console.WriteLine("10. Platanos ------------------- 12 Lps");
                        Console.WriteLine("=======================================");
                        Console.WriteLine("     Si desea regresar escriba 11      ");
                        Console.WriteLine("=======================================");

                        Console.Write($"{nombre} ingrese el numero del producto que desea comprar: ");
                        string producto = Console.ReadLine();

                        if (producto == "1")
                        {
                            precio = 15;
                            NProducto = "Mango";
                        }
                        else if (producto == "2")
                        {
                            precio = 50;
                            NProducto = "Sandia";
                        }
                        else if (producto == "3")
                        {
                            precio = 40;
                            NProducto = "Piña";
                        }
                        else if (producto == "4")
                        {
                            precio = 30;
                            NProducto = "Melon";
                        }
                        else if (producto == "5")
                        {
                            precio = 15;
                            NProducto = "Tamarindo";
                        }
                        else if (producto == "6")
                        {
                            precio = 4;
                            NProducto = "Albaricoque";
                        }
                        else if (producto == "7")
                        {
                            precio = 60;
                            NProducto = "Fresas";
                        }
                        else if (producto == "8")
                        {
                            precio = 3;
                            NProducto = "Naranjas";
                        }
                        else if (producto == "9")
                        {
                            precio = 4;
                            NProducto = "Limones";
                        }
                        else if (producto == "10")
                        {
                            precio = 12;
                            NProducto = "Platanos";
                        }
                        else if (producto == "11")
                        {
                            regresar = false;
                        }
                        else
                        {
                            Console.WriteLine($"{nombre} no tenemos el producto seleccionado");
                            precio = 0;
                        }


                        if (producto != "11")
                        {

                            Console.Clear();
                            Console.WriteLine($"{nombre} el precio de {NProducto} es: {precio} Lps");
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.Write($"Ingrese la cantidad deseada de {NProducto}: ");
                            int cantidad = Convert.ToInt32(Console.ReadLine());
                            double subtotal = (precio * cantidad);
                            double impuesto = subtotal * 0;
                            double descuento = 0;

                            if (edad >= 60)
                            {
                                descuento = subtotal * 0.3;
                            }

                            double total = subtotal + impuesto - descuento;
                            ProductosComprados.Add($"{cantidad} de {NProducto} ");
                            PreciosVentas.Add(total);

                            Console.WriteLine($"El valor a pagar es de: {total} Lps");
                            Console.WriteLine($"Impuesto: {impuesto} y un descuento: {descuento} Lps");
                            Console.ReadKey();
                        }
                    }
                    break;

                case "3":
                    regresar = true; 
                    while (regresar)
                    {
                        Console.Clear();
                        Console.WriteLine("1. Queso 1 L -------------------- 40 Lps");
                        Console.WriteLine("2. Quesillo 1 L ----------------- 60 Lps");
                        Console.WriteLine("3. Mantequilla 1 L -------------- 50 Lps");
                        Console.WriteLine("4. Requeson --------------------- 45 Lps");
                        Console.WriteLine("5. Quajada ---------------------- 70 Lps");
                        Console.WriteLine("6. Chorizo barbacoa 1L ---------- 46 Lps");
                        Console.WriteLine("7. Copetines 1L ----------------- 40 Lps");
                        Console.WriteLine("8. Hot Dog reyenos 1L ----------- 40 Lps");
                        Console.WriteLine("9. Jamon 1 L -------------------- 40 Lps");
                        Console.WriteLine("10. Mortadela 1 L --------------- 36 Lps");
                        Console.WriteLine("=======================================");
                        Console.WriteLine("==== Si desea regresar escriba 11 =====");
                        Console.WriteLine("=======================================");

                        Console.Write($"{nombre} ingrese el numero del producto que desea comprar: ");
                        string producto = Console.ReadLine();

                        if (producto == "1")
                        {
                            precio = 40;
                            NProducto = "Queso";
                        }
                        else if (producto == "2")
                        {
                            precio = 60;
                            NProducto = "Quesillo";
                        }
                        else if (producto == "3")
                        {
                            precio = 50;
                            NProducto = "Mantequilla";
                        }
                        else if (producto == "4")
                        {
                            precio = 45;
                            NProducto = "Requeson";
                        }
                        else if (producto == "5")
                        {
                            precio = 70;
                            NProducto = "Quajada";
                        }
                        else if (producto == "6")
                        {
                            precio = 46;
                            NProducto = "Chorizo barbacoa";
                        }
                        else if (producto == "7")
                        {
                            precio = 40;
                            NProducto = "Copetines";
                        }
                        else if (producto == "8")
                        {
                            precio = 40;
                            NProducto = "Hot Dog reyenos";
                        }
                        else if (producto == "9")
                        {
                            precio = 40;
                            NProducto = "Jamon";
                        }
                        else if (producto == "10")
                        {
                            precio = 36;
                            NProducto = "Mortadela";
                        }
                        else if (producto == "11")
                        {
                            regresar = false;
                        }
                        else
                        {
                            Console.WriteLine($"{nombre} no tenemos el producto seleccionado");
                            precio = 0;
                        }


                        if (producto != "11")
                        {

                            Console.Clear();
                            Console.WriteLine($"{nombre} el precio de {NProducto} es: {precio} Lps");
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.Write($"Ingrese la cantidad deseada de {NProducto}: ");
                            int cantidad = Convert.ToInt32(Console.ReadLine());
                            double subtotal = (precio * cantidad);
                            double impuesto = subtotal * 0.15;
                            double descuento = 0;

                            if (edad >= 60)
                            {
                                descuento = subtotal * 0.3;
                            }

                            double total = subtotal + impuesto - descuento;
                            ProductosComprados.Add($"{cantidad} de {NProducto} ");
                            PreciosVentas.Add(total);

                            Console.WriteLine($"El valor a pagar es de: {total} Lps");
                            Console.WriteLine($"Impuesto: {impuesto} y un descuento: {descuento} Lps");
                            Console.ReadKey();
                        }
                    }
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Está saliendo del sistema. Gracias por su compra vuelva pronto.");
                    FacturaFinal(ProductosComprados, PreciosVentas); 
                    Continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }


    static void FacturaFinal(List<string> productosComprados, List<double> preciosVentas)
    {
        Console.Clear();
        Console.WriteLine("------------- Factura Final ------------");
        Console.WriteLine("Cantidad y Producto              Precio");

        double totalFactura = 0;

        for (int i = 0; i < productosComprados.Count; i++)
        {
            Console.WriteLine($"{productosComprados[i]} ----- {preciosVentas[i]} Lps.");
            totalFactura += preciosVentas[i];
        }

        Console.WriteLine("------------------------------------------");
        Console.WriteLine($" Total del monto  a pagar: {totalFactura} Lps.");
        Console.ReadKey();
    }

}
