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


