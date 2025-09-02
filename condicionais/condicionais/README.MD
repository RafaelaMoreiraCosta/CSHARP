## Estruturas condicionais em C#
As estruturas condicionais são a forma como um programa "toma decisões". Elas permitem que você execute um bloco de código apenas se uma determinada condição for verdadeira. Se a condição for falsa, esse bloco de código é ignorado e outro pode ser executado. Imagine que você está programando um jogo. Você pode usar uma condicional para verificar: "Se o jogador tiver 0 pontos de vida, então exiba a mensagem 'Fim de Jogo'".

Em C#, as principais estruturas de decisão são o *if*, o *if-else* e o *switch*.

1. A Estrutura **if**: O if é a estrutura condicional mais básica. Ele verifica uma condição e, se ela for verdadeira, executa o código que está dentro do seu bloco.

Sintaxe:

*if (condição){// Código a ser executado se a condição for verdadeira.}*

Exemplo:

*int idade = 18;*

*if (idade >= 18)*
*{*
    *Console.WriteLine("Você é maior de idade.");*
*}*
Observe que neste caso, como a idade é 18, a condição idade >= 18 é verdadeira, e a mensagem será exibida.

2. A Estrutura **if-else**: O if-else permite que você defina um caminho alternativo. Por exemplo se a condição do if for falsa, o código dentro do bloco else será executado.

Sintaxe:

*if (condição){// Código para quando a condição é verdadeira.}*
*else{// Código para quando a condição é falsa.}*

Exemplo:

*int nota = 7;*

*if (nota >= 7)*
*{*
    *Console.WriteLine("Aprovado!");*
*}*
*else*
*{*
    *Console.WriteLine("Reprovado.");*
*}*
Como a nota é 7, a primeira condição é verdadeira, e o programa exibirá "Aprovado!". Se a nota fosse 6, o bloco else seria executado, exibindo "Reprovado.".

Você também pode encadear múltiplas condições usando else if:

Exemplo: 

*int nota = 8;*

*if (nota >= 9)*
*{*
    *Console.WriteLine("Excelente!");*
*}*
*else if (nota >= 7)*
*{*
    *Console.WriteLine("Aprovado!");*
*}*
*else*
*{*
    *Console.WriteLine("Reprovado.");*
}
O programa verifica as condições em ordem. Assim que encontra uma verdadeira, ele executa o bloco correspondente e ignora o resto da estrutura.

3. A Estrutura **switch**: O switch é ideal para situações em que você precisa verificar uma variável contra múltiplos valores fixos. Ele é uma alternativa mais limpa e organizada para múltiplos if-else if.

Sintaxe:

*switch (variavel)*
*{*
    *case valor1:*
        *// Código para quando a variável for igual a valor1.*
        *break;*
    *case valor2:*
        *// Código para quando a variável for igual a valor2.*
        *break;*
    *default:*
        *// Código para quando nenhum dos casos for correspondido.*
        *break;*
*}*

Exemplo:

*string diaDaSemana = "Terça";*

*switch (diaDaSemana)*
*{*
    *case "Segunda":*
        *Console.WriteLine("Início da semana de trabalho.");*
        *break;*
    *case "Sexta":*
        *Console.WriteLine("Fim de semana chegando!");*
        *break;*
    *default:*
        *Console.WriteLine("Dia normal da semana.");*
        *break;*
*}*
Neste exemplo, o switch verifica o valor da variável diaDaSemana. Ele encontra a correspondência em default e exibe a mensagem "Dia normal da semana.". O comando break é crucial para sair do switch após a execução do bloco de código.
