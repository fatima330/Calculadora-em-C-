# 🧮 Calculadora em C#

Uma calculadora simples desenvolvida em **C#**, utilizando o **.NET**, com o objetivo de praticar fundamentos de lógica de programação e estruturas de controle.

Este projeto foi desenvolvido como parte dos estudos de C# para colocar em prática conceitos básicos importantes para quem está começando na programação.

---

## 🎯 Objetivo do projeto

O objetivo principal é praticar conceitos fundamentais da linguagem C#, como:

- Variáveis
- Tipos de dados
- Entrada e saída de dados
- Conversão de valores
- `TryParse`
- `switch`
- `case`
- `break`
- `do while`
- Operadores aritméticos
- Interpolação de strings
- Estruturas de repetição
- Lógica de programação

A calculadora permite realizar:

- ➕ Adição
- ➖ Subtração
- ✖️ Multiplicação
- ➗ Divisão

Além disso, o usuário pode escolher se deseja realizar uma nova operação sem precisar executar o programa novamente.

---

## 🛠️ Tecnologias utilizadas

- **C#**
- **.NET**
- Aplicação de **Console**

---

# 📚 Principais conceitos utilizados

## 1. Variáveis

Variáveis são espaços utilizados para armazenar informações durante a execução do programa.

Exemplo:
double num1;

## 🔄 O que é o TryParse?

`TryParse` significa, de forma simples, **"tente converter"**.

Ele é utilizado quando queremos tentar transformar um texto em outro tipo de dado, como `int`, `double`, `decimal` etc.

Isso é muito importante porque tudo que o usuário digita através do:

Console.ReadLine()

Exwmplo: 
double num1 = double.TryParse(Console.ReadLine(), out double resultado);

## ❓ O que é o `if` ternário?

O **operador ternário** é uma forma mais curta de escrever uma estrutura `if/else` quando precisamos tomar uma decisão simples.

Ele recebe esse nome porque possui **três partes**:

O operador ternário segue esta estrutura:

CONDIÇÃO ? SE_FOR_VERDADEIRO : SE_FOR_FALSO
