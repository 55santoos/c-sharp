//2.2

/*
Crie um código que delcare 3 variáveis: nota1, nota2 e nota3; 
Atribua um valor de 0 a 10 a cada uma. Calcule a média aritmética do aluno e exiba se o 
aluno foi aprovado utilizando uma estrutura condicional. 
(Sabendo que a média necessária a ser alcançada é 6)

*/


/*
Console.WriteLine("digite sua nota do primeiro bimestre");
        string nota1 = Console.ReadLine();
        int notas1 = int.Parse(nota1);

Console.WriteLine("digite sua nota do segundo bismestre");
string nota2 = Console.ReadLine();
        int notas2 = int.Parse(nota2);

Console.WriteLine("digite sua nota do terceiro bimestre");
string nota3 = Console.ReadLine();
        int notas3 = int.Parse(nota3);

Console.WriteLine("sua media é: ");
Console.WriteLine(nota1 + nota2 + nota3 );
*/





// exercicio 2.3

/*

Crie um código que declara 2 variáveis frutaA e frutaB; Atribua um valor de string a cada uma delas com
o nome de uma fruta e exiba uma mensagem caso as frutas sejam iguais e outra caso as frutas sejam diferentes.


string frutaA = "melao";
string frutaB = "jaca";

if (frutaA == frutaB)
{
    Console.WriteLine("a fruta A nao e igual a fruta B");
}
else
{
    Console.WriteLine("as frutas sao iguais");
}


/*

// execicio 2.4
 Escreva um algoritmo que tenha as variáveis A, B, C e imprima na tela se a soma de A + B é menor
que C.

int A = 9;
int B = 20;
int C = 30;

int soma = A + B;

if ( soma < C ) {
    Console.WriteLine("A soma de " + A + " + " + B + " é menor que " + C);
    Console.WriteLine("Soma: " + soma);
} else {
    Console.WriteLine("A soma de " + A + " + " + B + " não é menor que " + C);


}










// exercicio 2.5

 Faça um algoritmo que leia dois valores **inteiros** A e B se os valores forem iguais deverá se
somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se
atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

int A = int.Parse(Console.ReadLine()); // int.Parse() para interpretar a entrada como um inteiro
int B = int.Parse(Console.ReadLine());
int C; // Declaração sem atribuição de valor

if ( A == B ) {
    C = A + B;
} else {
    C = A * B;
}

Console.WriteLine( C );


*/


// exercicio 3.0


// 1 Escreva um programa que imprima os números de 1 a 10, um em cada linha.


/*
int contador = 1;

do {
    Console.WriteLine( contador );
    contador++; // contador = contador + 1;
} while ( contador < 11 );
*/

// 3.2 

/*int contadorA = 7;
int contadorB = 8;
int contador = 1;
int resultado = contadorA - contadorB;

do {
        Console.WriteLine(resultado);
contador++; // contador = contador + 7 

} while (contador < resultado);*/

// 3.3 

// 3.3 Solicite ao usuário um número inteiro e mostre a **tabuada** desse número, do 1 ao 10

/*Console.WriteLine("digite um numero para sua tábuada:");
int X = int.Parse(Console.ReadLine());
int cont = 0;

int resultado = X * cont;

do
{
    Console.WriteLine($"O calculo de multiplicacao entre {X} * {cont} e: " + resultado);
    cont++;
    resultado = cont * X; 
} while (cont <= 10000000000);

*/

// 3.4

//Peça que o usuário digite uma senha. Repita a solicitação enquanto a senha estiver incorreta. Compare a senha inserida pelo usuário com uma senha predefinida em um string, ex:
// string senha = “1234”

/*Console.WriteLine("digite um numero inteiro");
int X = int.Parse(Console.ReadLine());
int cont = 0;

int resultado = X;
int senha = 555;

if (X == senha)
{
    Console.WriteLine("A senha esta correta");
}
else {


    Console.WriteLine("A senha está incorreta");

} 
 /*

// 3.5
 
 //Escreva um programa que faça a contagem regressiva de 10 até 1 e exiba uma mensagem como "Fogo!" ao final.
*/

/*int numA = 10;
int numB = 1;
int resut = numB - numA;

do
{
    Console.WriteLine(numA);
    resut = numB - numA;
    numA--;
    
} while (resut <= 0);


if (resut >= 0) 
{
    Console.WriteLine("Fogo!!!");
}
*/






























