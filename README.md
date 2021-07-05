# CIeT-dev-test
Teste de Desenvolvimento - Frontend e Backend

Instruções gerais
O desafio consiste em implementar um app de TODO List simples que possua um frontend e um backend para processar e armazenar as operações e dados.
A implementação foi realizada em C# e Vue.js

Critérios para avaliação

    Organização de código, arquitetura e boas práticas de programação (SOLID, Clean Code, etc)
    Como foi a utilização dos frameworks e bibliotecas utilizados e da linguagem de programação
    Comunicação entre as aplicações (frontend e backend) deverá ocorrer através do protocolo HTTP com chamadas Rest utilizando o formato JSON
    Documentação de como executar os projetos no ambiente local
    Implementação de testes de unidade (diferencial)
    Aplicações executando em containers Docker / docker-compose (diferencial)

Construindo um app de todo-list
Meu Todo List App
Frontend

    Faça o setup de um novo projeto
    Criar uma página com formulário para inclusão da lista de TODOs. A página deverá conter:
        Campo de input para inserir a descrição
        Botão para cadastrar
    Na mesma página, crie uma tabela para visualizar os itens já cadastrados. A tabela deverá possuir as seguintes ações para cada item:
        Botão para editar o texto
        Botão para excluir o item
        Botão para finalizar o item
    Os itens finalizados deverão ser apresentados em uma cor diferente dos demais itens na lista
    Criar uma opção para selecionar todos os itens da lista e um botão para finalizar todos com uma única ação
