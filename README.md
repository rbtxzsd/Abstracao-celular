# Abstração de um celular - Programação orientada a objetos 

## 📋 Descrição do Desafio
O objetivo deste desafio é aplicar os conceitos de **abstração**, **herança** e **polimorfismo** em C#, modelando um sistema que representa diferentes modelos de celulares.

A proposta é criar uma estrutura onde diferentes marcas e modelos possam ter comportamentos específicos, garantindo maior reuso e organização do código.

---

## 🛠 Estrutura do Projeto
O sistema é um **aplicativo de console** em .NET que utiliza:

- **Classe abstrata** para definir o modelo base de um celular.
- **Classes derivadas** que representam modelos específicos (Nokia e iPhone).
- **Sobrescrita de métodos** para comportamentos exclusivos de cada modelo.

📌 **Diagrama de classes utilizado:**

![Diagrama classes](diagrama.png)

---

## 📌 Regras e Requisitos
1. A classe `Smartphone` deve ser **abstrata** e não pode ser instanciada.
2. As classes `Nokia` e `Iphone` devem **herdar** de `Smartphone`.
3. O método `InstalarAplicativo` deve ser **sobrescrito** nas classes `Nokia` e `Iphone`, pois cada modelo instala aplicativos de forma diferente.

## 💭 Reflexões sobre o desafio
Durante este exercício, pude solidificar minhas bases em Programação Orientada a Objetos (POO), aprofundando meus conhecimentos no uso de classes, herança e polimorfismo.
A prática de implementar uma classe abstrata, criar classes derivadas e sobrescrever métodos me ajudou a compreender melhor como estruturar um código mais organizado, reutilizável e flexível.