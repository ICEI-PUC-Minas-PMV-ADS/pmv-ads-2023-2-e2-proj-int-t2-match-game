# Especificações do Projeto

Abaixo é possível conferir as especificações do projeto Match Game, como as histórias de usuários, requisitos funcionais e não funcionais, e restrições do desenvolvimento - levando em consideração as personas e público-alvo, que foram definidos anteriormente na documentação.

## Personas


| Mateus Oliveira | INFORMAÇÕES | APLICATIVOS MAIS UTILIZADOS |
| ------------- | ----------- | --------------------------- |
| ![Rectangle 2](https://github.com/GabrielBruno7/planty/assets/114627827/d0124e53-5e52-452a-b14c-4bb10e75747e) | **Idade:** 19 anos <br> **Ocupação:** Consultor de Marketing Digital, <br> Mateus atua como consultor de marketing <br> digital. Ele trabalha com empresas e marcas<br> para desenvolver estratégias eficazes de<br> marketing online. | <ul> <li> Aventura <li> Ação <li> Esportes </ul> |
| **MOTIVAÇÕES** | **FRUSTRAÇÕES** | **HOBBIES** |
|Mateus encontra motivação em<br> fazer parte da comunidade de<br> jogadores e desenvolvedores. | Mateus às vezes fica desapontado<br> com a falta de inovação em certos<br> gêneros de jogos. | Prática de Instrumento Musical <br> e leitura.|



| Alex Sandro | INFORMAÇÕES | APLICATIVOS MAIS UTILIZADOS |
| ------------- | ----------- | --------------------------- |
| ![Rectangle 2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/114627827/8870dd9a-3291-48ba-8b9c-608e43c263f6) | **Idade:** 25 anos <br> **Ocupação:** Como fotógrafo de viagens,<br> ele adora  explorar mundos virtuais e reais<br> para capturar momentos e cenários únicos. | <ul> <li> Jogos de plataforma  <li> Jogos de sobrevivência <li> Corrida </ul> |
| **MOTIVAÇÕES** | **FRUSTRAÇÕES** | **HOBBIES** |
|Alex é motivado pela busca <br>constante por aventura e<br> novas paisagens. Ele busca <br>capturar momentos únicos e <br>compartilhá-los com o mundo. | Alex fica frustrado quando se sente <br> limitado em sua exploração, seja por restrições <br>financeiras ou falta de tempo. |  Alex gosta de acampar e <br>praticar fotografia analógica.|


| Emily Paz | INFORMAÇÕES | APLICATIVOS MAIS UTILIZADOS |
| ------------- | ----------- | --------------------------- |
| ![1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/114627827/f3fb4158-20ee-46b3-992c-9487f22ddeaf) | **Idade:** 41 anos <br> **Ocupação:** Analista de Dados | <ul> <li> Quebra-Cabeças  <li> Multijogador Online (MMO) <li> RPGs de mundo aberto </ul> |
| **MOTIVAÇÕES** | **FRUSTRAÇÕES** | **HOBBIES** |
|Emily é motivada pelo desejo<br> de resolver problemas<br> complexos e tomar decisões<br> estratégicas bem informadas. | Emily fica frustrada quando<br> as decisões são tomadas com base<br>  em intuição em vez de<br>  dados concretos. | Além de jogar, Emily<br> gosta de resolver quebra-cabeças.|


| Samira Silva | INFORMAÇÕES | APLICATIVOS MAIS UTILIZADOS |
| ------------- | ----------- | --------------------------- |
| ![Rectangle 1111](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/114627827/108d9d4f-63f7-456c-9dff-9aeddb8ec64d) | **Idade:** 28 anos <br> **Ocupação:** Coordenadora de Eventos | <ul> <li> Multijogador  <li>Jogos de Festa <li> Simulação Social </ul> |
| **MOTIVAÇÕES** | **FRUSTRAÇÕES** | **HOBBIES** |
|Samira é motivada pela <br>conexão com outras pessoas. | Samira fica frustrada <br>quando os eventos não saem como planejado.  | Organizar encontros com amigos.|



## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|`PERSONA`|  `FUNCIONALIDADE` |`MOTIVO/VALOR` |
|--------------------|------------------------------------|----------------------------------------|
|Usuário (Mateus) |  Quero conseguir logar na aplicação. | Para possuir minha própria conta.  |
|Usuário (Samira) | Quero conseguir me cadastrar na aplicação.| Para que eu tenha meu perfil.   |
|Usuário <br>(Alex) |Quero conseguir marcar jogos como meus favoritos. | Para que eu me lembre de quais jogos eu deva jogar depois.  |
|Usuário <br>(Emily) |  Quero que ao fim das perguntas a aplicação me recomende jogos. | Para que eu possa escolher qual jogo jogar. |
|Usuário (Mateus) |  Quero conseguir ver uma lista de jogos favoritos.| Para conseguir ver quais jogos eu já favoritei.  |
|Usuário (Samira) | Quero conseguir ver uma lista de jogos recomendados.| Para conseguir ver quais jogos eu já recomendei. |
|Usuário <br>(Emily) | Quero conseguir ver informações dos jogos recomendados| Para conseguir me informar melhor sobre cada jogo. |
## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|--------|-----------------------------------------|----|
|RF-01| A aplicação deve incluir uma página de cadastro para os novos usuários  | ALTA | 
|RF-02| A aplicação deve incluir uma página de login para os usuários  | ALTA |
|RF-03| A aplicação deve possuir um sistema de escolhas para o usuário identificar seus interesses acerca dos jogos | ALTA |
|RF-04| A aplicação deve recomendar jogos de acordo com o interesse escolhido pelos usuários | ALTA |
|RF-05| A aplicação deve conter informações sobre os jogos recomendados aos usuários | ALTA |
|RF-06| A aplicação deve permitir que o usuário marque como "favorito" os jogos de sua escolha | ALTA |
|RF-07| A aplicação deve incluir uma lista de jogos marcados como "favorito" | ALTA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| A aplicação deve ser responsiva permitindo a visualização em diferentes dispositivos | ALTA | 
|RNF-02| A aplicação deve ser compatível com os principais navegadores presentes no mercado (Google Chrome, Firefox, Microsoft Edge) |  MÉDIA | 
|RNF-03| A aplicação deve ser implementada com HTML semântico | ALTA |
|RNF-04| A aplicação deve ser hospedada na nuvem | ALTA |
|RNF-05| A aplicação deve conter bom nível de contraste entre os elementos | MÉDIA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue até o final do semestre - 06/12/2023 |
|RE-02| Proibida a terceirização de desenvolvimento do sistema em sua totalidade ou de módulos isolados |
|RE-03| O código de desenvolvimento da aplicação não pode ser obtido através de sistemas de IA generativa |
|RE-04| O código do Back-end deverá ser feito em C# |
|RE-05| O código do Front-end deverá ser feito em HTML, CSS e JavaScript |
|RE-06| Caso seja usado algum framework Front-end, optar pelo Bootstrap |

## Diagrama de Casos de Uso

A seguir, é possível visualizar o Diagrama de Casos de Uso de acordo com os requisitos estabelecidos. 

![Image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-match-game/assets/116499898/86bba040-dec0-4033-94c0-349f976dae21)
