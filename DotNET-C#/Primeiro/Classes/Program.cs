using Primeiro;

Pessoa pessoa = new Pessoa();
pessoa.Nome = "Silas Nazare";
pessoa.Idade = 33;
pessoa.Sexo = Sexos.Masculino;

Animal animal = new Animal();
animal.Nome = "Gandalf";
animal.Especie = "Gato";
animal.Dono = pessoa;

Console.WriteLine($"Nome: {animal.Nome}, da espécie {animal.Especie}.");
Console.WriteLine($"Pertence a: {animal.Dono.Nome}, de {animal.Dono.Idade} anos e do sexo {animal.Dono.Sexo}.");
