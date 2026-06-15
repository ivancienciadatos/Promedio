using System;

namespace MiPrimerProyecto
{
    class PromedioNotas
    {
        static void Main(string[] args)
        {
            // ====================================================
            // COLO COLO COLOC
            // ====================================================
            string nombreEstudiante = "";
            bool esNombreValido = false;

            do
            {
                Console.Write("Nombre del estudiante: ");
                nombreEstudiante = Console.ReadLine();

                // no esté vacío
                if (string.IsNullOrWhiteSpace(nombreEstudiante))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Error! El nombre no puede estar vacío.\n");
                    Console.ResetColor();
                    continue; // Vuelve a empezar el ciclo de inmediato
                }

                // Revisamos letra por letra del nombre
                esNombreValido = true; // Asumimos que está bien hasta demostrar lo contrario
                foreach (char caracter in nombreEstudiante)
                {
                    // Si NO es letra y NO es un espacio vacío, el nombre no es válido
                    if (!char.IsLetter(caracter) && caracter != ' ')
                    {
                        esNombreValido = false;
                        break; // Rompemos el análisis de letras porque ya falló una
                    }
                }

                if (esNombreValido == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Error! El nombre solo debe contener letras y espacios.\n");
                    Console.ResetColor();
                }

            } while (esNombreValido == false);

            // ====================================================
            // 2. INGRESO Y VALIDACIÓN DE LAS 3 NOTAS (Rango 1,0 a 7,0)
            // ====================================================
            double nota1 = 0, nota2 = 0, nota3 = 0;

            // --- NOTA 1 ---
            bool esNota1Valida = false;
            while (esNota1Valida == false)
            {
                Console.Write("Ingrese Nota 1 : ");
                string entrada = Console.ReadLine();

                // Validar que sea un número y además esté entre 1,0 y 7,0
                if (double.TryParse(entrada, out nota1) && nota1 >= 1.0 && nota1 <= 7.0)
                {
                    esNota1Valida = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Error! La nota debe ser un número entre 1,0 y 7,0.\n");
                    Console.ResetColor();
                }
            }

            // --- NOTA 2 ---
            bool esNota2Valida = false;
            while (esNota2Valida == false)
            {
                Console.Write("Ingrese Nota 2 : ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out nota2) && nota2 >= 1.0 && nota2 <= 7.0)
                {
                    esNota2Valida = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Error! La nota debe ser un número entre 1,0 y 7,0.\n");
                    Console.ResetColor();
                }
            }

            // --- NOTA 3 ---
            bool esNota3Valida = false;
            while (esNota3Valida == false)
            {
                Console.Write("Ingrese Nota 3 : ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out nota3) && nota3 >= 1.0 && nota3 <= 7.0)
                {
                    esNota3Valida = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Error! La nota debe ser un número entre 1,0 y 7,0.\n");
                    Console.ResetColor();
                }
            }

            // ====================================================
            // 3. CAMBIE CAMBIE CAMBIR+E
            // ====================================================
            double promedio = (nota1 + nota2 + nota3) / 3.0;

            // Redondeamos el promedio a un solo decimal 
            promedio = Math.Round(promedio, 1);

            Console.WriteLine("\n========================================");
            Console.WriteLine($"Estudiante: {nombreEstudiante}");
            Console.WriteLine($"Promedio Final: {promedio}");

            // Evaluación de aprobación (4,0 a 7,0)
            if (promedio >= 4.0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" APROBADO ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" REPROBADO ");
            }
            Console.ResetColor();
            Console.WriteLine("========================================");
        }
    }
}






