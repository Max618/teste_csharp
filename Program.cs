using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, note;
            decimal value;
            int operation;
            Console.Write("Digite seu nome: ");
            name = Console.ReadLine();
            Console.Write("Digite o valor inicial: ");
            value = Decimal.Parse(Console.ReadLine());
            BankAccount account = new BankAccount(name, value);
            Console.Clear();
            do{
                
                Console.WriteLine("Digite a operação:");
                Console.WriteLine("1 - inserir deposito");
                Console.WriteLine("2 - realizar saque");
                Console.WriteLine("3 - visualizar saldo");
                Console.WriteLine("4 - visualizar histórico");
                Console.WriteLine("5 - sair");
                operation = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch(operation){
                    case 1:
                        Console.WriteLine("Digite o Valor");
                        value = Decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a nota da operação");
                        note = Console.ReadLine();
                        try{
                            account.MakeDeposit(value, DateTime.Now,note);
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    break;
                    case 2:
                        Console.WriteLine("Digite o Valor");
                        value = Decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a nota da operação");
                        note = Console.ReadLine();
                        try{
                            account.MakeWithdrawal(value, DateTime.Now,note);
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    break;
                    case 3:
                        Console.WriteLine($"Saldo atual: {account.Balance}");
                    break;
                    case 4:
                        Console.WriteLine(account.GetAccountHistory());
                    break;
                    case 5:
                        Console.WriteLine("Até Mais!");
                    break;
                }

            }while(operation != 5);
        }
    }
}
