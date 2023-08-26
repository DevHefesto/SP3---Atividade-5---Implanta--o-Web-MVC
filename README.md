# Sistema de Gestão de Clínicas Veterinárias - Projeto Balti

Bem-vindo ao projeto de desenvolvimento do Sistema de Gestão de Clínicas Veterinárias, criado para a empresa Balti. Este sistema visa auxiliar na administração e gerenciamento de clínicas veterinárias, proporcionando um ambiente eficiente e organizado para a equipe e clientes.

## Visão Geral

Este projeto consiste na criação de um sistema web para a empresa Balti, que atua na área de gestão de clínicas veterinárias. O sistema permitirá o gerenciamento de informações de pacientes, agendamentos, registros médicos, históricos de tratamentos, faturamento e muito mais.

## Tecnologias Utilizadas

- ASP.NET Core MVC: Framework utilizado para o desenvolvimento da aplicação web.
- C#: Linguagem de programação principal para o desenvolvimento back-end.
- HTML, CSS e Bootstrap: Linguagens e framework para a criação de interfaces de usuário responsivas e estilizadas.
- SQL Server: Banco de dados utilizado para armazenar as informações do sistema.
- Entity Framework Core: Framework de mapeamento objeto-relacional para acesso ao banco de dados.
- Git: Sistema de controle de versão utilizado para o desenvolvimento colaborativo.

## Funcionalidades

O Sistema de Gestão de Clínicas Veterinárias terá as seguintes funcionalidades principais:

- Cadastro de pacientes e seus detalhes.
- Agendamento de consultas e procedimentos.
- Registro de histórico médico e tratamentos.
- Controle de faturamento e pagamentos.
- Visualização de relatórios e estatísticas.

## Instalação e Execução

1. Clone este repositório para sua máquina local.
2. Abra o projeto utilizando o Visual Studio ou alguma IDE compatível.
3. Certifique-se de que o .NET Core SDK e o SQL Server estão instalados.
4. Configure a string de conexão com o banco de dados no arquivo `appsettings.json`.
5. Execute as migrações do Entity Framework para criar o banco de dados: `dotnet ef database update`.
6. Execute o projeto: `dotnet run`.
7. Acesse a aplicação no seu navegador através do endereço `http://localhost:5000`.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir um pull request se quiser adicionar novas funcionalidades, corrigir bugs ou melhorar o código.
