# CRUD-Cadastro-de-Aluno-Escolar-Manager-2020-2

## Escopo do Projeto

Este repositório contém arquivos criados e configurados de acordo com ambiente de densevolvimento listado abaixo. Nele vai ser apresentado como criar um CRUD cadastro aluno acessando o Banco de Dados e a tabela no FireBird usando a ferramenta de linha de comando ISQL Tool que vem junto como FireBird. 

Após clonar o projeto e instalar as dependências (mais sobre isso abaixo), você não precisará realizar algumas configuração adicionais. 

Todos os componentes estritamente necessários para o projeto já estão criados, mas você pode adicionar outros se julgar necessário. Você deverá complementar estes componentes de forma a satisfazer os requisitos listados na próxima seção.

- Buscar todos os alunos cadastrados, com informações sobre cada matricula;
- Exibir informações detalhadas de um aluno selecionado; 
- Adicionar um novo aluno à lista;
- Alterar um aluno da lista;
- Excluir um aluno da lista.

## Requisitos do projeto

1- O FireBird 3.0 - pode ser baixado no seguinte link:https://firebirdsql.org/en/server-packages/

2- Existem ferramentas com interface gráfica para administrar o Banco de Dados FireBird :(opcional) como exemplo a IBExpert.

3- O provedor FireBird .NET Provider 3.0.2.0.7 - pode ser baixado no link :https://www.firebirdsql.org/en/net-provider/

4- ADO.NET é um conjunto de classes do .NET Framework, desenvolvidas para facilitar o acesso das aplicações à bases de dados de diversos tipos, especialmente bancos de dados, como Firebird.

5- Windows Forms: A plataforma de desenvolvimento de Windows Forms dá suporte a um amplo conjunto de recursos de desenvolvimento de aplicativos.

6- Microsoft Visual Studio Community 2019( Opcional usar versões anteriores ) pode ser baixado no link: https://visualstudio.microsoft.com/pt-br/.

7- Sistema operacional windows 10 ( 32 bits ou 64 bits).

## Tela do sistema CRUD Aluno funcionando:

![alt text](https://github.com/odairX/CRUD-Cadastro-de-Aluno-Escolar-Manager-2020-2/blob/master/img/img1.PNG)

## Tela do sistema no Microsoft Visual Studio Community 2019

Assim que baixado o projeto no github, você poderá carregar o projeto no Microsoft Visual Studio a imagem abaixo mostra o projeto carregando.

![alt text](https://github.com/odairX/CRUD-Cadastro-de-Aluno-Escolar-Manager-2020-2/blob/master/img/img2.PNG)

##Instruções de funcionamento do sistema:

A primeira tarefa será criar um banco de dados e uma tabela no FireBird. Conforme imagem abaixo, mostra a ferramenta de linha de comando ISQL que é instalada junto com o Banco de Dados FireBird. Vamos criar um banco de dados com o nome aluno.fbd na pasta que você escolher no seu PC. Para isso podemos usar o comando CREATE DATABASE;

O comando CREATE DATABASE é responsável por criar o arquivo físico do banco de dados. Usando o comando CREATE DATABASE:

-Comado: create database "C:\Program Files (x86)\Firebird\Firebird_3_0\data\aluno.fdb" user 'SYSDBA' password '123';

![alt text](https://github.com/odairX/CRUD-Cadastro-de-Aluno-Escolar-Manager-2020-2/blob/master/img/img3.PNG)

Apos criar o Banco de Dados você deve conectar com um banco de dados existente usando o comando CONNECT;

-Comado: CONNECT "C:\Program Files (x86)\Firebird\Firebird_3_0\data\aluno.fdb" user 'SYSDBA' password '123';

![alt text](https://github.com/odairX/CRUD-Cadastro-de-Aluno-Escolar-Manager-2020-2/blob/master/img/img4.PNG)

Para criarmos uma tabela podemos usar o comando : CREATE TABLE

Vamos criar a tabela Alunos com os seguintes campos: Matricula, NOME, EMAIL, TELEFONE, ENDERECO, onde Matricula será uma chave primária.

COMADO SQL:

CREATE TABLE ALUNOS(
Matricula INT NOT NULL PRIMARY KEY, 
NOME VARCHAR(50), 
Email VARCHAR(50), 
Telefone CHAR(30), 
Endereco VARCHAR(100));

Exemplo:

![alt text](https://github.com/odairX/CRUD-Cadastro-de-Aluno-Escolar-Manager-2020-2/blob/master/img/img5.PNG)

A seguir podemos exibir as tabelas usando o comando SHOW TABLES; e visualizar a estrutura da nossa tabela usando o comando SHOW TABLES ALUNOS;

Para exibir os dados usamos o comando SELECT: Select * from alunos;

![alt text](https://github.com/odairX/CRUD-Cadastro-de-Aluno-Escolar-Manager-2020-2/blob/master/img/img6.PNG)

Assim temos prontos o banco de dados Aluno.fdb e a tabela Alunos na pasta c:\dados criados no FireBird.
