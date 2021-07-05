# CI&T - Dev Test - Backend
## Desafio Turma Análise e Desenvolvimento de Sistemas 2021/1 - UNA


O desafio consiste em implementar um app de TODO List simples que possua um frontend e um backend para processar e armazenar as operações e dados. 

Tecnologias Utilizadas:
- .Net Core 5.0 (C#)
- Entity Framework Core

## Critérios Estabelecidos para Avaliação 

- Organização de código, arquitetura e boas práticas de programação (SOLID, Clean Code, etc)
- Como foi a utilização dos frameworks e bibliotecas utilizados e da linguagem de programação
- Comunicação entre as aplicações (frontend e backend) deverá ocorrer através do protocolo HTTP com chamadas Rest utilizando o formato JSON
- Documentação de como executar os projetos no ambiente local
- Implementação de testes de unidade (diferencial)
- Aplicações executando em containers Docker / docker-compose (diferencial)

## Instalação

O backend necessita de ambiente Linux com Docker.
Para executar é necessário baixar o projeto localmente e executar o comando:

```sh
docker build -f Dockerfile -t desafio-ciet
```

## Documentação da API

A documentação da API pode ser acessada juntamente com uma versão de demonstração conforme tabela à baixo

| Recurso | Local |
| ------ | ------ |
| Projeto de Backend | https://github.com/rochajario/CIeT-dev-test-api |
| Projeto de Frontend | https://github.com/rochajario/CIeT-dev-test-app |

## Desenvolvedor

Jario Rocha dos Santos Junior - 2021 | https://www.linkedin.com/in/rochajario/ | rochajario@gmail.com

## Licença
MIT
