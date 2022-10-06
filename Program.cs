using ExemploExplorando.Models;
using System.Globalization;

//---------------------------------- SISTEMA DE PILHA -------------------------------
// ULTIMO QUE ENTRA, PRIMEIRO QUE SAI


Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);


foreach(int item in pilha)
{
    
    Console.WriteLine(item);
    
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(20);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}





















// ---------------------------------- FILAS ------------------------------
// PRIMEIRO QUE ENTRA, PRIMEIRO QUE SAI

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach( int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


//------------------------- EXCEÇÃO ----------------------------------------





// new ExemploExcecao().Metodo1();



//------------------------- LENDO ARQUIVO ------------------------------------

// try
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// } 

// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorre um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }

// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }

// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }

// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }
















//------------------------------------ DATE TIME -------------------------------------------







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










//----------------------------- CULTURE / CURRENCY --------------------------------------------





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

