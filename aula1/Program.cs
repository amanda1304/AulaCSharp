namespace aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 26;
            string nomeCompleto = "Amanda Alves de França";
           // Console.WriteLine(nomeCompleto);
            var variavelSemTipo = "Amanda";
            Console.WriteLine(variavelSemTipo.GetType());
            Console.WriteLine("Digite o seu nome: ");
            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            string idadeUsuario = Console.ReadLine();
            
            Console.WriteLine($"Meu nome é {nomeUsuario} e a minha idade é {idadeUsuario}");
            
        }
    }
}
