# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

| Isabella Santos | INFORMAÇÕES | TIPOS DE JOGOS PREFERIDOS |
| ------------- | ----------- | --------------------------- |
| ![Rectangle 1](https://github.com/GabrielBruno7/planty/assets/114627827/2117dcd2-5e9c-4299-b82f-331b1f24b811) | **Idade:** 12 anos <br> **Ocupação:** Ela tem interesses <br> e atividades, como  desenhar, pintar, <br> brincar ao ar livre e sonha <br> em se tornar uma veterinária no futuro. | <ul> <li> Jogos de Lógica <li> Jogos de Música e Ritmo  <li> Jogos de Memória </ul> |
| **MOTIVAÇÕES** | **FRUSTRAÇÕES** | **HOBBIES** |
|Isabella pode ser motivada <br> pela oportunidade de explorar<br> e expressar sua criatividade. | Restrições de tempo ou regras <br> que impedem que ela faça o que deseja. | Sempre que possível, Isabela<br> gosta de  participar de eventos<br> e convenções de jogos.|

| Mateus Oliveira | INFORMAÇÕES | APLICATIVOS MAIS UTILIZADOS |
| ------------- | ----------- | --------------------------- |
| ![Rectangle 2](https://github.com/GabrielBruno7/planty/assets/114627827/d0124e53-5e52-452a-b14c-4bb10e75747e) | **Idade:** 25 anos <br> **Ocupação:** Consultor de Marketing Digital, <br> Mateus atua como consultor de marketing <br> digital. Ele trabalha com empresas e marcas<br> para desenvolver estratégias eficazes de<br> marketing online. | <ul> <li> Jogos de Quebra-Cabeça  <li> Jogos de Estratégia <li> RPGs de mundo aberto </ul> |
| **MOTIVAÇÕES** | **FRUSTRAÇÕES** | **HOBBIES** |
|Mateus encontra motivação em<br> fazer parte da comunidade de<br> jogadores e desenvolvedores. | Mateus às vezes fica desapontado<br> com a falta de inovação em certos<br> gêneros de jogos. | Prática de Instrumento Musical <br> e leitura.|


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|`PERSONA`|  `FUNCIONALIDADE` |`MOTIVO/VALOR` |
|--------------------|------------------------------------|----------------------------------------|
|Usuário (Mateus) |  Quero conseguir logar na aplicação. | Para possuir minha própria conta.  |
|Usuário (Isabella) | Quero conseguir recomendar jogos. | Para que outras pessoas possam ver os jogos recomendados. |
|Usuário (Isabella) | Quero conseguir me cadastrar na aplicação.| Para que eu tenha meu perfil.   |
|Usuário (Mateus) | Quero conseguir alterar minha foto de perfil.| Para que eu possa personalizar meu perfil. |
|Usuário (Isabella) |Quero conseguir marcar jogos como meus favoritos. | Para que eu me lembre de quais jogos eu deva jogar depois.  |
|Usuário (Mateus) |  Quero que ao fim das perguntas a aplicação me recomende jogos. | Para que eu possa escolher qual jogo jogar. |
|Usuário (Mateus) |  Quero conseguir ver uma lista de jogos favoritos.| Para conseguir ver quais jogos eu já favoritei.  |
|Usuário (Isabella) | Quero conseguir ver uma lista de jogos recomendados.| Para conseguir ver quais jogos eu já recomendei. |
## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
