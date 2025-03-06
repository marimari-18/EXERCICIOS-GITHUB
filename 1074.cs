using System;

class Program {
    static void Main() {
        int N = int.Parse(Console.ReadLine()); // Lê o número de casos de teste

        for (int i = 0; i < N; i++) {
            int X = int.Parse(Console.ReadLine()); // Lê o número a ser classificado
            
            if (X == 0) {
                Console.WriteLine("NULL");
            } else if (X % 2 == 0) { // Número é par
                if (X > 0) {
                    Console.WriteLine("EVEN POSITIVE");
                } else {
                    Console.WriteLine("EVEN NEGATIVE");
                }
            } else { // Número é ímpar
                if (X > 0) {
                    Console.WriteLine("ODD POSITIVE");
                } else {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        }
    }
}
