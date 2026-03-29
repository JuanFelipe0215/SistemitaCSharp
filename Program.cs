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
            int num1;
            int num2;

            Console.Write("Ingrese primer numero: ");
            string valor1 = Console.ReadLine();
            Console.Write("Ingrese segundo numero: ");
            string valor2 = Console.ReadLine();

            if (int.TryParse(valor1, out num1) && int.TryParse(valor2, out num2))
            {
                var resultado = num1 + num2;
                Console.WriteLine($"El resultado de la suma {num1} + {num2} es: {resultado}");
            }
            else
            {
                Console.WriteLine("Valores incorrectos");
            }

            break;
        
        case 2:
            double nota1;
            double nota2;
            double nota3;
            string calificacion1;
            string calificacion2;
            string calificacion3;
            
            do
            {
                Console.Write("Ingrese nota 1: ");
                calificacion1 = Console.ReadLine();
                
            } while (!double.TryParse(calificacion1 , out nota1));
            
            do
            {
                Console.Write("Ingrese nota 2: ");
                calificacion2 = Console.ReadLine();
                
            } while (!double.TryParse(calificacion2 , out nota2));
            
            do
            {
                Console.Write("Ingrese nota 3: ");
                calificacion3 = Console.ReadLine();
                
            } while (!double.TryParse(calificacion3 , out nota3));
            
            var promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 3.0)
            {
                Console.WriteLine($"El promedio es: {promedio} \nEstado: Aprobado");
            }
            else
            {
                Console.WriteLine($"El promedio es: {promedio} \nEstado: Reprobado");
            }
            
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