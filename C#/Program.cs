Console.WriteLine("Hello, World!");
Console.WriteLine(10.0 / 40);

//= operador de atribuição de valor 
string operacao = "Soma"; // Declaração de variável do tipo string
int numA = 5; // Declarção de variável do tipo int
int numB = 12;
Console.WriteLine(numA + numB);

// Console.WriteLine() - Instrução para escrita de mensagens do console
Console.WriteLine("A operação que está sendo realizada é " + operacao);
Console.WriteLine(numA + numB);

string mult = "mult"; // Declaração de variável tipo int
int numC = 4;
int numD = 4;
Console.WriteLine("numC * numD");
//Console.WriteLine() - Instrução para escrita de mensagens do console
Console.WriteLine("A operação que está sendo realizada é " + mult);
Console.WriteLine(numC * numD);

int idade = 20;
bool temCNH = false; // true or false

if ( idade > 18 && temCNH == true ) {
    Console.WriteLine("Pessoa é maior de idade e possui CNH.");
} else {
    Console.WriteLine("A pessoa não pode dirigir.");
}

if ( idade > 18 ) {
    if ( temCNH == true ) {
        Console.WriteLine("Pessoa é maior de idade e possui CNH.");
    } else {
     
        Console.WriteLine("Pessoa não possui CNH.");
    }
} else {
    Console.WriteLine("A pessoa não é maior de 18 anos.");
}






























































