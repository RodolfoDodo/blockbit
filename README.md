# blockbit
Projeto de Automação

Para iniciafr o projeto e preciso instalar na sua máquina o .NET Core

Clone o projeto

Acessar a pasta onde foi clonado e execute o comando dotnet test

O projeto foi desenvolvido no padrão page object utilizando o framework Coypu e Junit

------ Sobre o Projeto -------
A classe Basetest e a classe responsável por está configurada com o Coypu ela possuir todas as configurações do projeto para realizar o acesso ao navegador e realizar os testes

A classe Models e a classe responsável por amarzenar e manter o padrão de massa de teste Code First

Todas as classe na pasta Page e responsável por ter a implementação do Page Object nelas contém os seletores css, xpath e Id. E seus métados de ação.  

Na pasta Test e onde temos as classes responsáveis pora executar todos os testes 


------ Sobre os Testes -------

Estou realizando 2 testes o primeiro e o acesso informando o e-mail e a senha depois verificando se o usuário com o nome José José Breno Pires está realmente logado. 

O outro teste e acessando o e-mail e encaminhando uma resposta. 

------- Não foi Implementado ---------

Não foi implementado o anexo no projeto pelo seguinte motivo não sei como mapear o elemento e subir o arquivo para o gmail, o elemento que selecionar o anexo e js ele e dinamico e com isso
fica dificil de manipular. 

Eu deixei o projeto configurado da forma que eu queria para subir o anexo tem uma pasta images nela contem um arquivo atraves do metado Environment.CurrentDirectory eu realizo o upload da imagem  mas como não conseguir manipular o elemento do anexo não e possível realizar 


No arquivo csproj o codigo 
<Content Include="images/**">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    
 faz com que toda a vez que o projeto for executado criar uma pasta no bin chamada de images carregando assim a imagem que está na pasta 
 
 


