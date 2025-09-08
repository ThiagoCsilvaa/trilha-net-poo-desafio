# Desafio POO - Smartphones

## Descrição do Projeto
Este projeto é um desafio de **Programação Orientada a Objetos (POO)** em C#. O objetivo é criar uma hierarquia de classes que represente smartphones, demonstrando conceitos de **herança, polimorfismo e encapsulamento**.

No projeto, temos três classes principais:

- **Smartphone (abstrata)**: classe base com propriedades comuns e métodos gerais.
- **Nokia**: classe filha que herda de Smartphone e implementa o método `InstalarAplicativo` de forma específica.
- **Iphone**: classe filha que herda de Smartphone e implementa o método `InstalarAplicativo` de forma específica.

---

## Funcionalidades Implementadas

- **Ligar**: todos os smartphones podem ligar.
- **Receber ligação**: todos os smartphones podem receber ligação.
- **Instalar aplicativo**: cada smartphone implementa de forma diferente, demonstrando polimorfismo.
- **Encapsulamento**: propriedades como Modelo, IMEI e Memoria são privadas, garantindo segurança.

---

## Estrutura do Projeto

DesafioPOO/
│
├─ Models/
│ ├─ Smartphone.cs # Classe abstrata
│ ├─ Nokia.cs # Classe filha
│ └─ Iphone.cs # Classe filha
│
└─ Program.cs # Classe principal para testes

## Como Executar

1. Clone o repositório:

```bash
git clone https://github.com/ThiagoCsilvaa/trilha-net-poo-desafio.git

2. Entre na pasta do projeto:
cd trilha-net-poo-desafio

3. Execute o projeto:
dotnet run

Logo você verá a saída dos métodos Ligar, ReceberLigacao e InstalarAplicativo para cada smartphone.
