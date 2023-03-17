namespace DiamanteDeLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int alturaMetadeDiamante = 1;
                string letraAuxiliar = "A";
                int espacoInterno = 1;
                string[] alfabeto = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };

                Console.Clear();
                Console.Write("Digite a letra que definirá o meio do diamante:");
                string letra = Console.ReadLine().ToUpper();
                while (letraAuxiliar != letra)
                {
                    letraAuxiliar = alfabeto[alturaMetadeDiamante];
                    alturaMetadeDiamante++;
                }
                int tamanhoEspaco = alturaMetadeDiamante - 1;
                for (int linha = 0; linha < alturaMetadeDiamante; linha++)
                {
                    for (int Espaco = 0; Espaco < tamanhoEspaco; Espaco++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(alfabeto[linha]);

                    if (alfabeto[linha] != "A")
                    {
                        for (int i = 0; i < espacoInterno; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(alfabeto[linha]);
                        espacoInterno += 2;
                    }
                    Console.WriteLine();

                    tamanhoEspaco--;
                }
                for (int linha = alturaMetadeDiamante - 2; linha >= 0; linha--)
                {
                    tamanhoEspaco++;
                    espacoInterno -= 2;
                    for (int Espaco = 0; Espaco < tamanhoEspaco + 1; Espaco++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(alfabeto[linha]);

                    if (alfabeto[linha] != "A")
                    {
                        for (int i = 0; i < espacoInterno - 2; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(alfabeto[linha]);

                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}