## Entrada e Saída de Dados em C#

**Entrada de Dados (Input)**: É a forma como você fala com o programa. Você fornece informações para que ele possa trabalhar.

**Saída de Dados (Output)**: É a forma como o programa responde a você. Ele mostra o resultado do processamento das informações que você deu.

Em C#, a gente usa principalmente duas classes para fazer isso, que ficam no *namespace System*.

1. Saída de Dados (Output)

*Console.WriteLine()*: Escreve algo na tela e, em seguida, pula para a próxima linha. É ótimo para mostrar mensagens, resultados ou variáveis.

EXEMPLO:

- *Console.WriteLine("Olá, mundo!");* // Isso vai mostrar a mensagem e o cursor vai para a próxima linha.
- *Console.Write():* Escreve algo na tela, mas mantém o cursor na mesma linha. Isso é útil para quando você quer, por exemplo, fazer uma pergunta e esperar a resposta na mesma linha.
- *Console.Write("Qual é o seu nome? ");* // O cursor continua na mesma linha, esperando a entrada.

2. Entrada de Dados (Input)

*Console.ReadLine()*: Lê uma linha inteira de texto digitada pelo usuário e a retorna como uma string.

EXEMPLO:

- *Console.Write("Qual é o seu nome? ");*
- *string nome = Console.ReadLine();*
- *Console.WriteLine("Olá, " + nome + "!");*

Observação: O *Console.ReadLine()* sempre lê o que é digitado como texto (string). Se você precisar que o usuário digite um número, você precisa converter essa string para o tipo numérico (como int ou double). Usamos a classe *Convert* ou os métodos *Parse()* para fazer essa conversão.

EXEMPLO:

- *Console.Write("Digite a sua idade: ");*
- *string idadeTexto = Console.ReadLine();* // A entrada é sempre uma string
- *int idade = Convert.ToInt32(idadeTexto);* // Converte a string para um número inteiro
//OU
- *int idade = int.Parse(idadeTexto);*// Converte a string para um número inteiro
- *Console.WriteLine("Sua idade é: " + idade);*