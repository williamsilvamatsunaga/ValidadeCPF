public class Program
{


    static void Main(string[] args)
    {


        ValidaCPF pessoacpf = new ValidaCPF();

        Console.WriteLine("Digite o cpf: ");
        string cpf = Console.ReadLine();


        bool valido = pessoacpf.CalcularCPF(cpf);
        if (valido)
        {
            Console.WriteLine("Válido");
        }

        else
        {
            Console.WriteLine("Inválido");
        }
    }
}