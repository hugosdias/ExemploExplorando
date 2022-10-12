using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


//------------------ ATRIBUINDO TIPO DE VALOR ----------------------------

int a = 20;

int b = a;
b = 60;

Console.WriteLine($"Valor de A: {a}");
Console.WriteLine($"Valor de B: {b}");












//----------------------- TIPO REFERÊNCIA ---------------------------------

// Pessoa p1 = new Pessoa(nome: "Hugo", sobrenome: "Sanguino Dias");

// //Pessoa p2 = new Pessoa(nome: "Gustavo", sobrenome: "Sanguino Dias");
// Pessoa p2 = p1;
// p2.Nome = "Vinicius";

// Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
// Console.WriteLine($"Nome da pessoa p2: {p2.NomeCompleto}");







//-------------------------------- METODO EXTENSAO ---------------------------------

// int numero = 20;
// bool par = false;

// //IF Ternário
// //par = numero % 2 == 0;
// par = numero.EhPar();

// string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");
// Console.WriteLine(mensagem);



//----------------------- CLASSE GENÉRICA --------------------------------


// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);


// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("Teste");

// Console.WriteLine(arrayString[0]);




//--------------------------------------- VARIAVEL DINAMICA -----------------------------------------

// dynamic variavelDinamica = 4;


// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//      Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH: mm")}");
// }

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");



//------------------------------ TIPO ANÔNIMO EM COLEÇÃO -------------------------------------

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }

//--------------------------- TIPO ANÔNIMO ---------------------------------------------

// var tipoAnonimo = new {Nome = "Hugo", Sobrenome = "Sanguino Dias", Altura = 1.65 };

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);









// bool? desejaReceberEmail = null;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
//  {
//     Console.WriteLine("O usuário optou por receber e-mail.");
//  }
//  else
//  {
//      Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
//  }






//--------------------------------DESSERIALIZAÇÃO ------------------------------------------

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//      Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
//                         $"{(venda.Desconto.HasValue ? $" Desconto de: {venda.Desconto}" : " Item sem desconto")}");
// }




//--------------------------------- ARQUIVO JASON -------------------------------

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);





// int numero = 21;

// bool ehPar = false;

// //IF Ternário

// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par." : "ímpar."));



// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }






//----------------------------------------- DESCONSTRUTOR -------------------------------------

// Pessoa p1 = new Pessoa("Hugo", "Sanguino");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");




//--------------------------------- METODO TUPLA ----------------------------------
// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso)
// {
//     //Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }




//----------------------------------- TUPLA -------------------------------

// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Hugo", "Sanguino", 1.65M);

// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Hugo", "Sanguino", 1.65M);

// var outroExemploTuplaCreate = Tuple.Create(1, "Hugo", "Sanguino", 1.65M);

// Console.WriteLine($"ID: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");





//----------------------------------- DICTIONARY --------------------------------------

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("PR", "Paraná");
// estados.Add("RJ", "Rio de Janeiro");

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// Console.Write("Digite a chave para remover: ");
// string chaveRemover = Console.ReadLine();
// estados.Remove(chaveRemover);
// // estados["PR"] = "Paraná - valor alterado";

// Console.WriteLine("--------------------");

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// Console.Write("Digite uma chave para adicionar: ");

// string chave = Console.ReadLine();

// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existente. Pode adicionar a chave: {chave}");

// }

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// Console.WriteLine("------------------");

// Console.WriteLine(estados["RJ"]);





//---------------------------------- SISTEMA DE PILHA -------------------------------
// ULTIMO QUE ENTRA, PRIMEIRO QUE SAI


// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);


// foreach(int item in pilha)
// {

//     Console.WriteLine(item);

// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }






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

