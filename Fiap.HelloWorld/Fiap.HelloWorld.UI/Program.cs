// See https://aka.ms/new-console-template for more information
using Fiap.HelloWorld.UI;
using Fiap.HelloWorld.UI.Models;

Console.WriteLine("Hello, World!");

//Instanciar um Aluno
Aluno aluno = new Aluno();

//Atribuir o nome ao aluno
aluno.Nome = "João";
aluno.Cpf = "1234234";

//Exibir o nome
Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Cpf);

//Instanciar um Cachorro
Cachorro dog = new Cachorro(15, 5, "Brutus")
{
    Dono = "Thiago"
};

//Exibir o nome, peso, idade e dono
Console.WriteLine($"Nome: {dog.Nome}, Peso: {dog.Peso}, Idade: {dog.Idade}, Dono: {dog.Dono}");

// Fazer o Aluno andar!

aluno.Andar();
aluno.Andar("FIAP");

//Setar Genero
aluno.Genero = Genero.Masculino;
//Exibir o genero
Console.WriteLine(aluno.Genero);

//Criar uma lista de Cachorro
IList<Cachorro> listaCachorros = new List<Cachorro>();

//Adicionar 2 dogs na lista
Cachorro doguinho = new Cachorro(7, 3, "Corki")
{
    Dono = "Luis"
};

listaCachorros.Add(dog);
listaCachorros.Add(doguinho);

//Exibir a quantidade de dogs na lista
Console.WriteLine($"Quantidade de Dogs na lista: {listaCachorros.Count}");

//Exibir os dados dos dogs da lista

foreach (var item in listaCachorros)
{
    Console.WriteLine($"Nome: {item.Nome}, Peso: {item.Peso}, Idade: {item.Idade}, Dono: {item.Dono}");

}
