# Registro de Testes de Software


| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
| **Usuário**  	| O cadastro foi criado com sucesso. 	 |
| **Quantidade de erros**  	| 1 |
| **Avaliação:**  	| O cadastro ocorreu de forma harmoniosa se comunicando evalidando com os dados na nuvem. A princípio não foi implementada a mensagem de erro se caso os dados estivessem incorretos, buscaremos implementar esse aviso ao usuário na próxima etapa e impedir que o cadastro prossiga caso não exista um endereço de email válido.   |


https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/107646150/eab97651-7ab6-4e0e-bb06-b71f10b2ab32

_Video 1: Teste de cadastro de usuário_



https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/107646150/7829bef2-5f4e-472d-8b24-38b69a43232e

_Video 2: Teste de cadastro de usuário com email preenchido incorretamente_

<br><br>

| **Caso de Teste** 	| **CT-02 – Efetuar login** 	|
|:---:	|:---:	|
| **Usuário**  	| O login foi realizado com sucesso quando já cadastrado na plataforma, porém não avisa o usuário a inserção de dados incorretos. 	 |
| **Quantidade de erros**  	| 2 |
| **Avaliação**  	| O login foi realizado da maneira esperada. Não temos mensagem de erro em caso o usuário tentasse realizar login com os dados incorretos, a página realizaria um reload sem uma mensagem de retorno para o usuário, por tanto, buscaremos implementar esse feedback e melhoria na próxima etapa, percebemos também que se o usuário estiver cadastrado na plataforma, ainda que não tenha um email válido, ele consegue acessar o sistema e iremos buscar resolver isso. Tivemos diversas dificuldades na implementação, podemos destacar a conexão com banco de dados na nuvem, em vários momentos tivemos insucesso, mas foi resolvido com o passar desta etapa. O processo foi crucial para entendermos o funcionamento do MVC e o grupo se sente mais seguro ao manipular os códigos entre as pastas dele para as próximas funcionalidades.


https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/107646150/11658b1e-3941-42fc-a797-e9e317f512d0


_Video 4: Teste de login de usuário cadastrado na plataforma_



https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/107646150/eea5f5a6-9f6a-4ec9-b4b9-aa6b1637e184

_Video 5: Teste de login de usuário não cadastrado na plataforma_



https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/107646150/9732d07d-b4cd-4d53-aecb-487bfe34fb26

_Video 6: Teste de login de usuário cadastrado na plataforma com email incorreto_

<br><br>


| **Caso de Teste** 	| **CT-03 – Recuperação de senha** 	|
|:---:	|:---:	|
| **Usuário**  	| A recuperação de senha foi realizada com sucesso. 	 |
| **Quantidade de erros**  	| 0 |
| **Avaliação**  	| A restauração de senha foi concluída conforme previsto. Implementamos uma API que se conecta ao endereço de e-mail associado ao usuário em nosso banco de dados. Dessa maneira, ao solicitar a alteração de senha, um código será enviado para a caixa de entrada do e-mail cadastrado, permitindo que o usuário crie uma nova senha.    |


https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/107646150/3e4eef66-1a5e-4bc5-932c-76e363ac7dbb

_Video 7: Teste de recuperação e cadastro de uma nova senha._

<br><br>

| **Caso de Teste** 	| **CT-04 – Recomendação de jogos para o usuário**	|
|:---:	|:---:	|
| **Usuário**  	|  O sistema de recomendação de jogos para o usuário foi realizado com sucesso. 	 |
| **Quantidade de erros**  	| 0 |
| **Avaliação:**  	| A recomendação de jogos para o usuário foi realizada conforme o previsto.    |



https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/107646150/11ae6341-a4ba-474a-ba56-98d592900f0b

_Video 8: Teste de recomendação de jogos para o usuário_

<br><br>

| **Caso de Teste** 	| **CT-05 – Sistema de escolha de jogos para o usuário** 	|
|:---:	|:---:	|
| **Usuário**  	| O sistema de escolha de jogos com adição de favoritos foi realizado com sucesso. 	 |
| **Quantidade de erros**  	| 0 |
| **Avaliação:**  	| O sistema de escolha jogos com adição de favoritos para o usuário foi realizado conforme o previsto.   |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/107646150/da197504-f40f-4f50-a241-5f480809dc0b

_Video 8: Teste de escolha de jogos e adição de favoritos feitas pelo usuário._

<br><br>

| **Caso de Teste** 	| **CT-06 – Informações sobre os jogos recomendados** 	|
|:---:	|:---:	|
| **Usuário**  	| As informações sobre os jogos tiveram erro em alguns links "quebrados", porém a grande maioria está atualizado e ocorreu com sucesso.	 |
| **Quantidade de erros**  	| 2 |
| **Avaliação:**  	| Utilizamos a API rawg.io para obter informações sobre os jogos na nossa plataforma. Esta API fornece dados abrangentes, incluindo endpoints como website, imagem de fundo, nome, ID, plataformas, entre outros, porém se encontra com algumas páginas inválidas em alguns jogos listados, estamos buscando corrigir esse erro.    |


https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/107646150/044c4a51-1228-4464-9d65-89d6a408709d

_Video 9: Teste de visualização de informações a respeito do jogo com link quebrado (error 404)._



https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/107646150/164a69b2-de51-46d9-80e9-f7cd26f9f531

_Video 10: Teste de visualização de informações a respeito do jogo com link quebrado (página inválida)._





https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/107646150/37f36717-340b-4f90-9b3a-6d877fcaad33



_Video 9: Teste de visualização de informações a respeito do jogo funcionando corretamente com os demais jogos._


<br><br>

| **Caso de Teste** 	| **CT-07 – Lista de favoritos do usuário** 	|
|:---:	|:---:	|
| **Usuário**  	| A lista de favoritos do usuário foi visualizada com sucesso.	 |
| **Quantidade de erros**  	| 0 |
| **Avaliação:**  	| O teste de visualização dos favoritados foi realizado com sucesso.    |



https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/107646150/2179d442-736e-45b8-94a2-ba67eb9cd0b2

_Video 10: Teste de visualização de lista de favoritos do usuário._


<br><br>
