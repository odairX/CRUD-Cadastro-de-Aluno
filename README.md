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

Foi criado o formulário utilizando os recursos do Windows Forms Application, a partir da ToolBox, os controles GroupBox, Label, TextBox, Button e DataGridView conforme o leiaute da figura acima.

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

Assim temos prontos o banco de dados Aluno.fdb e a tabela Alunos na pasta no seu PC criados no FireBird.

* Vamos incluir uma referência ao provedor FireBird .NET Provider ( ADO.NET ) em nosso projeto via menu Project opção Add reference;

Selecionando a guia Browse e localizando o local onde você instalou as depedências do provedor:

![alt text](https://github.com/odairX/CRUD-Cadastro-de-Aluno-Escolar-Manager-2020-2/blob/master/img/img7.PNG)

### DEPOIS DE TERMINAR COM O BANCO DE DADOS FIREBIRD

## Estrutura do sistema CRUD Aluno

### O componente `Gerenciador de Soluçoes` no Visual Studio deve exibir a estrutura do app ao lado direito comforme imagem abaixo.

![alt text](https://github.com/odairX/CRUD-Cadastro-de-Aluno-Escolar-Manager-2020-2/blob/master/img/img8.PNG)

Agora vamos entender cada estrutura e pasta do codigo e seus metodos e classes.


1. Na classe form1.cs a partir da ToolBox, foi definido e criado os controles GroupBox, Label, TextBox, Button e DataGridView conforme o leiaute do sistema.

* Controles TextBox:

-txtMT
-txtNome
-txtEmail
-txtTelefone
-txtEndereco

*Controle Button:

btnProcurar
btnNovo
btnAlterar
btnExclui
btnLimpa
btnSair

*Controle DataGridView

dgvAlunos

2. A Classe AcessoFB.cs

Nesta classe definimos temos o construtor da classe é marcado como private. Somente a própria classe terá acesso a este método, exemplo:

private static readonly AcessoFB instanciaFireBird = new AcessoFB(); 

Esse exemplo usa o operador new.

O atributo instanciaFireBird é obtido via método getInstancia que é do tipo da classe; Este método retornará sempre o mesmo objeto.

Temos também a definição dos seguintes métodos:

*fb_GetDados - retorna um DataTable com as informações da tabela Alunos;
*fb_InserirDados - Recebe como parâmetro um objeto Aluno inclui um novo aluno na tabela;
*fb_ExcluirDados - Exclui um aluno existente pelo sua Matricula;
*fb_AlterarDados - Recebe como parâmetro um objeto aluno altere as informações de um aluno na tabela;
*fb_ProcuraDados - Localiza os dados de um aluno pelo sua matricula;

Dessa forma, temos uma classe que representa uma camada de acesso aos dados onde tratamos o acesso e a persistência aos dados.

3. A Classe Aluno.cs 

namespace CRUD_Aluno
{
    public class Aluno
    {
        public int Matricula{ get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}

Definindo o domínio, esta classe servirá basicamente como um DTO (Data Transfer Object) onde iremos repassar as informações entre a camada de interface e a camada de acesso aos dados.

4. Preenchendo os dados armazenados no DataGridView

No evento Load do formulário vamos preencher o controle DataGridView com todos os dados da tabela Alunos;

Para isso defina o código abaixo neste evento:

  private void Form1_Load(object sender, EventArgs e)
  {
            preencheGrid();
 }

5. O tipo de conversão usado foi o `Convert` método de conversão para converter cada tipo base em todos os outros tipos base. Nesse caso
converter o tipo inteiro em string ( Exibir em texto ), veja exemplo do codigo abaixo:

  private void btnProcurar_Click(object sender, EventArgs e)
    {
        int codigo = Convert.ToInt32(txtMT.Text);
        Alunos aluno = new Alunos();
        try
        {
            aluno = AcessoFB.fb_ProcuraDados(codigo);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
        }
        preencheDados(aluno);
    }

Portanto, foi utilizando o banco de dados FireBird, o provedor FireBird .NET e os recursos da ADO .NET criando uma camada de acesso a dados e implementamos os métodos que permitem realizar as operações CRUD na tabela Clientes.
