# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - A aplicação deve incluir uma página de cadastro para os novos usuários. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site #<br> - Clicar em "Cadastro/Login" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, senha, confirmação de senha) <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-02 – Efetuar login**	|
|Requisito Associado | RF-02	- A aplicação deve incluir uma página de login para os usuários. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site #<br> - Clicar no botão "Cadastro/Login" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Entrar". |
|Critério de Êxito | - O login foi realizado com sucesso. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-03 – Sistema de escolha de jogos pelo usuário**	|
|Requisito Associado | RF-03 -	A aplicação deve possuir um sistema de escolhas para o usuário identificar seus interesses acerca dos jogos. |
| Objetivo do Teste 	| Verificar se o usuário consegue escolher e selecionar os seus jogos favoritos. |
| Passos 	| - Estar logado ou criar uma conta <br> - Clicar no botão "Favoritos" <br> - Buscar na barra de pesquisa o nome dos jogos de interesse do usuário e selecioná-lo para adicionar a sua biblioteca. <br> 
|Critério de Êxito | - A adição de jogos escolhido pelo usuário em seu perfil foi realizada. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-04 – Recomendação de jogos para o usuário**	|
|Requisito Associado | RF-04	- A aplicação deve recomendar jogos de acordo com o interesse escolhido pelos usuários. |
| Objetivo do Teste 	| Verificar se o usuário recebe a recomendação de jogos de acordo com os interesses favoritados. |
| Passos 	| - Estar logado ou criar uma conta <br> - Clicar no botão "For You" para visualizar os jogos recomendados de acordo com os interesses cadastrados na aba favoritos. <br> 
|Critério de Êxito | - A recomendação de jogos para o usuário foi realizada. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-05 – Informações sobre os jogos recomendados**	|
|Requisito Associado | RF-05 -	A aplicação deve conter informações sobre os jogos recomendados aos usuários. |
| Objetivo do Teste 	| Verificar se o usuário consegue ter as informações sobre os jogos que lhe serão recomendados. |
| Passos 	| - Estar logado ou criar uma conta <br> - Clicar no botão "For You" para visualizar os jogos recomendados de acordo com os interesses cadastrados na aba favoritos. <br> - Clicar sobre o nome do jogo e visualizar informações a respeito dele.
|Critério de Êxito | - As informações sobre o jogo selecionado foi visualizada. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-06 – Favoritar os jogos escolhidos**|
|Requisito Associado | RF-06 -	A aplicação deve permitir que o usuário marque como "favorito" os jogos de sua escolha. |
| Objetivo do Teste 	| Verificar se o usuário consegue favoritar os jogos conforme suas escolhas. |
| Passos 	| - Estar logado ou criar uma conta <br> - Clicar no botão "Favoritos" ou "For You" <br> - Clicar sobre o botão em coração para favoritar o jogo visualizado. <br> - Ir na aba "Favoritos" e visualizar o jogo selecionado anteriormente.
|Critério de Êxito | - O usuário conseguiu favoritar o jogo de sua escolha. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-07 – Lista de favoritos no perfil do usuário**	|
|Requisito Associado | RF-07 -	A aplicação deve incluir uma lista de jogos favoritados no perfil do usuário. |
| Objetivo do Teste 	| Verificar se a lista de favoritos do usuário consta em seu perfil. |
| Passos 	| - Estar logado ou criar uma conta <br> - Clicar no botão "Perfil"<br> - Visualizar os jogos favoritados.<br>
|Critério de Êxito | - Lista de favoritos exibido no perfil do usuário. |
|:---:	|:---:	|
| **Caso de Teste**	| **CT-08 – Personalização de foto de perfil do usuário**	|
|Requisito Associado | RF-08	- A aplicação deve permitir que o usuário personalize sua foto de perfil. |
| Objetivo do Teste 	| Permitir que o usuário modifique sua foto de perfil. |
| Passos 	| - Estar logado ou criar uma conta <br> - Clicar no botão "Perfil"<br> - Clicar em "Alterar imagem de perfil"<br> - Selecionar imagem do computador no botão "Arquivo" <br> - Clicar em "Salvar alterações".
|Critério de Êxito | - Usuário conseguiu personalizar sua imagem de perfil. |
|:---:	|:---:	|
| **Caso de Teste** 	| **CT-09 – Recomendação de jogos feitas de um usuário para o outro**	|
|Requisito Associado | RF-09	- A aplicação deve permitir que os usuários recomendem jogos para outros usuários. |
| Objetivo do Teste 	| Permitir que o usuário recomende jogos para outro usuário. |
| Passos 	| - Estar logado ou criar uma conta <br> - Clicar no botão "Perfil"<br> - Clicar em "Look at this"<br> - O usuário deve selecionar os jogos de sua escolha para que esteja visível em seu perfil como recomendados <br> - Clicar em "Enviar".
|Critério de Êxito | - Usuário conseguiu fazer a recomendação de jogos para outros usuários em seu perfil. |
|:---:	|:---:	|
| **Caso de Teste**	| **CT-10 – Lista de recomendação de jogos feitas de um usuário para o outro**	|
|Requisito Associado | RF-10	- A aplicação deve incluir uma lista de jogos que os usuários recomendaram para outros usuários |
| Objetivo do Teste 	| Permitir que o usuário recomende jogos para outro usuário em lista. |
| Passos 	| - Estar logado ou criar uma conta <br> - Clicar no botão "Perfil"<br> - Clicar em "Look at this"<br> - O usuário deve selecionar os jogos de sua escolha para que esteja visível em seu perfil como recomendados <br> - Clicar em "Enviar".<br> Para visualizar a lista de jogos o usuário deve clicar em "Visualizar lista completa".<br>
|Critério de Êxito | - Usuário conseguiu fazer a recomendação de jogos em lista para outros usuários em seu perfil. |




 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
