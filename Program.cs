Console.Write("Digite seu nome:");
string name = Console.ReadLine();
//interpolação de string Console.WriteLine($"Olá {name}!"); ele vai executar o "Olá Rielydi"
Console.WriteLine($"Olá {name}!");
Console.Write("Digite seu ano de nascimento ");
//int.parse converte o ReadLine que é uma string para um inteiro int de idade ou seja numero inteiro 10, 20, ..
int yar = int.Parse(Console.ReadLine());
int age = 2023 - yar;
Console.WriteLine($"Voce tem {age} anos!");
//if é a condição "Se" se isso for verdade execute isso. no caso de IF e ELSE é aconselhado usar bloco de codigos com as chaves {}
/*desviar expressoes podemos usar o (&&) que é o operador [E]
podemos usar o operador (||) que é o [OU]
exemplo if (age >= 18 && name = "rielydi") execute isso!
exemplo dois: if (age >=18 || name = "rielydi") execute isso!

*/
if (age >= 18)
{
    Console.WriteLine("Voce é maior de idade!");
}
//comparando se o age é igual a 12( se não, mas.. é o else if) se nada de cima for verdadeiro vai pro ELSE
else if (age == 12)
{
    Console.WriteLine("Não era pra voce nem estar aqui!");
}
//else é a condição "Se Não" ("SE"se isso for verdade, execute isso! "ELSE" se não execute tal coisa.
else
{

    Console.WriteLine("Voce é menor de idade!");

}
//-----------------------------------------------------------------------------------------------------------

//existe variavel para armazenar objeto. e tem como armazenar mais de um objeto dentro que é o Array []

//array de string [] podemos utilizar o inicializador de arrays é atribuir a ele = (site sharplab.io)

string[] names = { "rielydi", "joao", "josé" };
