using ExemploExplorando.Models;
using System.Globalization;

try
{

    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

} catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
























// string dataString = "2022-12-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// // DateTime data = DateTime.Parse(dataString);

// if(sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data valida.");
// }




// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToShortDateString());





//Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));
//Mês representado com letra maiscula
//horas em minutos fica no formato 12h, em maisculo fica no formado 24h
















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //altera cultura do sistema

// decimal valorMonetario = 1582.40M;

// Console.WriteLine("Dólar: " + valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //determina para qual cultura será convertida a variavel

// Console.WriteLine("Reais: " + valorMonetario.ToString("C2")); //quantidade de casas decimais (C é currency)

// double porcentagem = .0321;

// Console.WriteLine("Porcentagem: " + porcentagem.ToString("P")); //P é para porcentagem

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));













// Pessoa p1 = new Pessoa(nome: "Hugo", sobrenome: "Sanguino Dias");
// Pessoa p2 = new Pessoa(nome: "Leticia", sobrenome: "Veloso");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

