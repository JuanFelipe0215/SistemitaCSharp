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
    9. Salir.
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
            Console.Write("Ingrese su nombre: ");
            var name = Console.ReadLine();
            
            Console.Write("Ingrese su apellido: ");
            var lastname = Console.ReadLine();
            
            Console.WriteLine($"Hi! {name} {lastname}, how are you?");
            
            break;
        case 4:
            int number1;
            int number2;
            int result;
            bool valid;
            
            do
            {
                Console.Write("Ingrese el primer numero: ");
                valid = int.TryParse(Console.ReadLine(), out number1);

                if (!valid)
                {
                    Console.WriteLine("Ingrese un numero valido");
                }
                
            } while (!valid);
            
            do
            {
                Console.Write("Ingrese el segundo numero: ");
                valid = int.TryParse(Console.ReadLine(), out number2);

                if (!valid)
                {
                    Console.WriteLine("Ingrese un numero valido");
                }
                
            } while (!valid);
            
            Console.Write("Ingrese un operador para realizar la operación(+, -, *, /): ");
            var operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine($"El resultado de la suma {number1} + {number2}  es: {result}");
                    break;
                case "-":
                    result = number1 - number2;
                    Console.WriteLine($"El resultado de la resta {number1} - {number2}  es: {result}");
                    break;
                case "*":
                    result = number1 * number2;
                    Console.WriteLine($"El resultado de la multiplicación {number1} * {number2}  es: {result}");
                    break;
                case "/":

                    if (number2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por cero");
                        
                        do
                        {
                            Console.Write("Ingrese un numero diferente de cero: ");
                            valid = int.TryParse(Console.ReadLine(), out number2);

                            if (!valid)
                            {
                                Console.WriteLine("Ingrese un numero valido");
                            }
                
                        } while (!valid || number2 == 0);
                    }
                    
                    result = number1 / number2;
                    
                    Console.WriteLine($"El resultado de la division {number1} / {number2}  es: {result}");
                    break;
            }
            
            break;
        
        case 5:
            List<int> numbers = new List<int>();
            var sum = 0;
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese el numero {i + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            
            var mayor = numbers[0];
            var menor = numbers[0];
            
            foreach (var number in numbers)
            {
                sum += number;

                if (mayor < number)
                {
                    mayor = number;
                }
                
                if (menor > number)
                {
                    menor = number;
                }
            }
            
            Console.WriteLine($"La suma total es: {sum}");
            Console.WriteLine($"El numero mayor es: {mayor}");
            Console.WriteLine($"El numero menor es: {menor}");
            
            break;
        
        case 6:
            List<string> pendingTasks = new List<string>();
            int optionTask;
            
            do
            {
                Console.WriteLine(@"
                Menú:
                1. Agregar tarea.
                2. Ver tareas con indices.
                3. Eliminar tarea por indice.
                4. Salir.
                ");
            
                Console.Write("Ingrese una opcion: ");
                int.TryParse(Console.ReadLine(), out optionTask);

                switch (optionTask)
                {
                    case 1:
                        Console.Write("Ingrese tarea pendiente: ");
                        var task = Console.ReadLine();
                        
                        pendingTasks.Add(task);
                        break;
                    case 2:
                        foreach (var tasks in pendingTasks)
                        {
                            var index = pendingTasks.IndexOf(tasks);
                            Console.WriteLine($"Tarea: {tasks} - Indice: {index}");
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("Sistema Task: Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Ingrese un valor valido");
                        break;
                }
            } while (optionTask != 4);
            
            
            break;
        
        case 7:
            break;
        case 8:
            break;
        case 9:
            Console.WriteLine("Hasta luego!");
            break;
    }

}while(option != 9);