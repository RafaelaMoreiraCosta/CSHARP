## O que são Variáveis?
Pense em uma variável como uma caixa que você usa para guardar informações. Cada caixa tem um nome (para você saber o que está guardado lá dentro) e um tipo (para definir que tipo de coisa a caixa pode armazenar). Por exemplo, você pode ter uma caixa com o nome "idade" que só guarda números inteiros, ou uma caixa com o nome "informacoes" que guarda textos. Em C#, as variáveis funcionam exatamente assim. Elas são locais na memória do computador que servem para armazenar dados. A grande vantagem é que o valor de uma variável pode mudar durante a execução do programa.

**Declarando e Usando uma Variável**
Para usar uma variável, você precisa fazer duas coisas: declarar e atribuir.

1. Declaração: É quando você cria a caixa. Você precisa dizer o tipo e o nome da variável.

*Sintaxe: tipo nomeDaVariavel;*

Exemplos:

- string nome;   // Declara uma variável para guardar texto.
- int idade;     // Declara uma variável para guardar números inteiros.
- double altura; // Declara uma variável para guardar números decimais.

2. Atribuição: É quando você coloca um valor dentro da caixa. Você usa o sinal de igual (=).

*Sintaxe: nomeDaVariavel = valor;*

Exemplos:

- nome = "João";
- idade = 25;
- altura = 1.75;

Você também pode declarar e atribuir um valor na mesma linha, o que é muito comum:

*Sintaxe: tipo nomeDaVariavel = valor;*

Exemplos:

- string nome = "Maria";
- int idade = 30;

**Tipos de Variáveis Comuns em C#**
C# é uma linguagem de "tipagem forte", significa que toda variável precisa ter um tipo definido. Isso ajuda o compilador a evitar erros e garante a segurança do seu código.

**Tipo da Variável**	**O que armazena**                        **Exemplo de uso**
string	                Texto (uma sequência de caracteres)	        string nome = "Ana";
int	                    Números inteiros (sem ponto decimal)	    int numeroDeAlunos = 15;
double	                Números decimais (com ponto flutuante)	    double media = 8.5;
bool	                Valores lógicos (verdadeiro ou falso)	    bool ehMaiorDeIdade = true;
char	                Um único caractere	char inicial = 'J';