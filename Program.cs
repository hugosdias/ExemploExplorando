using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Hugo", sobrenome: "Sanguino Dias");
Pessoa p2 = new Pessoa(nome: "Leticia", sobrenome: "Veloso");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

