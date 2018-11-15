# Projeto CalcTest
Web Api para calcular juros compostos.

A API foi documentada e modelada utilizando o <b>Swagger</b>. <br />
O projeto foi desenvolvido utilizando <b>ASP NET Core</b> e esta estruturado da seguinte forma:

# CalcTest.API
Nesta API existem 2 endpoints:

1) Calcula Juros <br /> 
Responsável por realizar o cálculo dos juros compostos de acordo com a fórmula: Valor Final = Valor Inicial * (1 + juros) ^ Tempo <br />
Os parâmetros necessários para realizar o cálculo são: Valor Inicial (decimal) e Tempo (inteiro) que representa a quantidade de meses. <br />
Responde pelo path relativo <b>"/calculajuros/{valorInicial}/{meses}"</b> sendo necessário informar os 2 parâmetros: valorInicial (decimal) e meses (inteiro). <br />
Exemplo: <b>"/calculajuros/100/5"</b>.

2) Show me the code <br /> 
Responsável por retornar a URL do Github onde esta o código do projeto. <br />
Responde pelo path relativo <b>"/showmethecode"</b> e não é necessário informar parâmetro. <br />

Observação: A chamada aos métodos da API também pode ser realizada pela interface do <b>Swagger</b> que pode ser acessada usando o caminho relativo <b>"/swagger"</b>.

# CalcTest.Test
Neste projeto encontra-se os testes unitários da API. <br />
Desenvolvido com o framework <b>MSTest</b>. <br />

# CalcTest.IntegrationTest
Neste projeto encontra-se os testes de integração da API. <br />
Os testes validam o resultado da requisição HTTP feita para a API. <br />
Desenvolvido com o framework <b>xUnit</b> e <b>FluentAssertions</b> que ajuda a melhorar a leitura do código. <br />

# Git
Foi criada uma branch chamada "desenvolvimento" onde ficava o código das funcionalidades que ainda estavam sendo desenvolvidas. <br />
Após a funcionalidade estar concluída era realizado o merge para a branch master.
