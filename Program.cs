int option;

do
{
    Console.WriteLine(@"
    --- Centro de Entrenamiento Técnico ---
    1. Nivel 1: Suma y validación numérica
    2. Nivel 2: Cálculo y condicionales
    3. Nivel 3: Manipulación de Cadenas
    4. Nivel 4: Operaciones Lógicas (Calculadora)
    5. Nivel 5: Análisis Numérico (Listas de enteros)
    6. Nivel 6: Gestión de Tareas (Listas de cadenas)
    7. Nivel 7: Arreglos y Búsqueda
    8. Nivel 8: Programación Orientada a Objetos (Clases)
    9. Nivel 9: CRUD de Objetos (Listas de objetos)
    10. Salir 
    ");

    Console.Write("Seleccione un nivel para iniciar: ");
    int.TryParse(Console.ReadLine(), out option);

    switch (option)
    {
        case 1:
            string valor1;
            string valor2;
            int num1;
            int num2;

            Console.Write("Ingrese primer numero: ");
            valor1 = Console.ReadLine();
            Console.Write("Ingrese segundo numero: ");
            valor2 = Console.ReadLine();

            if (int.TryParse(valor1, out num1) && int.TryParse(valor2, out num2))
            {
                var resultado = num1 + num2;
                Console.WriteLine($"El resultado de la suma {num1} + {num2} es: {resultado}");
            }
            else
            {
                Console.WriteLine("Valores incorrecto");
            }

            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            break;
        case 8:
            break;
        case 9:
            break;
        case 10:
            Console.WriteLine("Hasta luego!");
            break;
    }

}while(option != 10);