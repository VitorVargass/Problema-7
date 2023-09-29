


using System.Runtime.CompilerServices;

class Program
    {
           static void Main(string[] args)
        {
                Investimento investimento = new Investimento();
                investimento.Ler();
                investimento.Calcular();
        }
    }
    class Investimento
    {
        private double valorP;
        private double taxa;
        private double meses;
        private double resultado_final;
        private double resgate;
        private double saldo;
        private double rendimento;
        private string verify;
        private int numMes;
        private double rendimento_restante;
        private double periodo_restante;
        private double saldo_restante;
        private double resultado_mes;



        public void Ler()
        {
            Console.WriteLine("Digite o valor presente:");
            valorP = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a taxa de juros:");
            taxa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o período em meses:");
            meses = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Haverá resgate? Aperte Y(yes) ou N(no):");
            verify = Console.ReadLine();

            if (verify == "y" || verify == "Y")
            {
                Console.WriteLine("Digite o valor do resgate:");
                resgate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite em qual mes sera feito resgate:");
                numMes = Convert.ToInt32(Console.ReadLine());
            } else {
                Console.WriteLine("Prosseguindo sem resgate.");
                numMes = Convert.ToInt32(meses);
                resgate = 0;
            }
        }

        public void Calcular()
        {
                //  F = p * ( 1 + i ) ^n

                // valor calculado até o mes 5 
                resultado_mes = valorP * Math.Pow(1 + taxa / 100, numMes); // 1159

                // valor do 5 mes com resgate
                saldo_restante = resultado_mes - resgate; // 659

                // rendimento calculado 
                rendimento_restante = resultado_mes - valorP;

                // resultado final da aplicaçao
                resultado_final = valorP * Math.Pow(1 + taxa / 100, meses);


            Console.WriteLine($"Saldo liquido restante : {saldo_restante:C} "); // quanto sobrou dps do resgate
            Console.WriteLine($"Rendimento restante: {rendimento_restante:C}"); // quanto rendeu
            Console.WriteLine($"Resultado final: {resultado_final:C} "); // resultado final sem nada
            
        }
    }