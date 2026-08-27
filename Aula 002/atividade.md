# 1. A genealogia das linguagens não é uma escada de progresso. Explique essa afirmação e apresente dois fatores históricos que fazemuma linguagem influenciar outra sem necessariamente substituí-la.
A genealogia das linguagens não é uma escada de progresso porque uma linguagem nova não precisa substituir uma antiga. Muitas vezes, ela apenas aproveita ideias de outras linguagens e cria novos recursos.
Dois fatores que explicam isso são:
Diferentes necessidades: cada linguagem foi criada para um tipo de uso. Por exemplo, Fortran era mais usada em cálculos científicos, enquanto COBOL era voltada para aplicações comerciais.
Influência entre linguagens: uma linguagem pode pegar ideias de outra e acrescentar novos recursos. Por exemplo, ALGOL influenciou Pascal e C, que depois influenciaram outras linguagens.
Assim, as linguagens foram evoluindo e influenciando umas às outras, como mostra a imagem, em vez de simplesmente uma substituir a outra.

# 3. Compare Short Code, Speedcoding e os sistemas A-0/A-1/A-2 quantoao problema enfrentado e à estratégia adotada. Por que chamá-los simplesmente de compiladores modernos seria impreciso?
O Short Code usava  um linguagem simbólic codificada como se fosse expressões matemáicas que eram executadas por um interpretador, sem ter tradução prévia para código do hardware
O Speeding Code criava um tipo de maquina virtual sobre o IBM, um interpretador executava pseudoinstruções como espressões matemáticas
A-0/A-1/A-2 Utilizavam um pseudocódigo que era expandido em subprogramas de código de máquina
O Short Code e Speeding Code eram interpretadores, ou seja o programas eram executados por um  interpretador, em vez de ser previamente traduzido para um programa independente em código de máquina.
Enquanto o A-0/A-1/A-2 substituíam ou expandiam referências a subprogramas já existentes em código de máquina.

# 4. Explique por que o projeto Fortran precisou convencer programadores de que código traduzido podia competir com código de máquina escrito à mão. Relacione desempenho, custo de programação e adoção.
O projeto do Fortran precisava convencer os programadores porque, naquela época, eles acreditavam que código escrito à mão em linguagem de máquina era mais rápido do que qualquer código produzido automaticamente por um compilador.
A equipe do Fortran tinha que mostrar que o compilador conseguia gerar um código quase tão eficiente quanto o código de máquina feito a mão. 
Isso era importante porque os computadores eram caros e lentos, então o desempenho do programa tinha muito peso.
Ao mesmo tempo, programar em linguagem de máquina era muito trabalhoso e demorado. Com Fortran, o programador podia escrever de uma forma muito mais simples e rápida, deixando o compilador fazer a tradução para código de máquina.
Código de máquina: maior trabalho e custo de programação, mas bom desempenho.
Fortran: programação muito mais rápida e fácil, mas havia o medo de perder desempenho.
O sucesso do Fortran veio justamente de mostrar que era possível reduzir bastante o tempo e o custo de programação sem perder muito desempenho. 
O compilador chegou perto da eficiência do código escrito à mão, o que ajudou os programadores a aceitarem a linguagem e fez com que ela fosse amplamente adotada.

# 8. Compare Basic e PL/I como respostas ao desejo de ampliar o acesso ou o alcance da programação. Qual compromisso de projeto aparece em cada caso?
Basic: foi criada para ser fácil de aprender, principalmente para pessoas que não eram programadores experientes. Por isso, tinha poucos comandos e poucos tipos de dados. O problema é que essa simplicidade também fazia a linguagem ser limitada para programas grandes e complexos.
PL/I: tentou criar uma linguagem que pudesse ser usada para vários tipos de programas, tanto científicos quanto comerciais. Para conseguir isso, adicionou muitos recursos. O resultado foi uma linguagem mais completa, mas também mais complexa e difícil de aprender.

# 10. Defina ortogonalidade no projeto de linguagens e use ALGOL 68 para discutir a diferença entre regularidade e simplicidade. Uma linguagem muito ortogonal é automaticamente fácil de usar?
Ortogonalidade é quando uma linguagem possui regras que funcionam de maneira uniforme e podem ser combinadas facilmente, sem muitas exceções.
No ALGOL 68, isso permitia combinar tipos básicos para criar novos tipos de dados, de acordo com a necessidade do programador.
Regularidade significa que as regras seguem um padrão consistente, enquanto simplicidade significa que a linguagem é fácil de aprender e compreender.
O ALGOL 68 era bastante regular e ortogonal, mas isso não o tornava simples. A linguagem tinha muitos recursos e uma forma complicada de ser descrita, o que dificultava seu aprendizado.
Assim, ser uma linguagem ortogonal não significa necessariamente ser fácil de usar. A ortogonalidade pode trazer mais organização e flexibilidade, mas também pode deixar a linguagem mais complexa.


# 11. Construa uma cadeia de influência que passe por ALGOL, Pascal e C. Depois contraste essa linhagem imperativa com a proposta declarativa de Prolog.
ALGOL 68 trouxe importantes inovações para o projeto de linguagens, principalmente a ortogonalidade, que permite combinar recursos de forma independente e previsível, além de tipos definidos pelo usuário e vetores dinâmicos.
Seu principal sucessor, Pascal, foi criado para o ensino e teve grande impacto nas universidades nos anos 70, destacando-se pela simplicidade e expressividade.

# 12. Modele em linguagem natural uma pequena base Prolog com dois fatos, uma regra e uma consulta. Explique por que isso representa programação lógica, não apenas armazenamento de dados.
Prolog é uma linguagem de programação lógica em que os programas são formados por fatos, regras e consultas. Por exemplo, dois fatos podem ser pai(Carlos, João) e pai(Maria, Ana), uma regra pode ser avo(X, Z):- pai(X, Y), pai(Y, Z) e uma consulta pode ser pai(Joao, Maria).
Isso representa programação lógica porque o programa não descreve exatamente como o resultado deve ser calculado, mas fornece informações e regras para que o computador faça inferências. Assim, ao receber uma consulta, o Prolog utiliza o processo de resolução para verificar se ela pode ser provada.

# 13. Ada resultou de requisitos e projeto em grande escala. Analise como
confiabilidade, tipos, pacotes e concorrência se relacionam ao domínio
de sistemas críticos.
A Ada foi criada a partir de um grande projeto para atender principalmente a sistemas em que a confiabilidade é crítica, como aviônica, controle de tráfego aéreo e transportes. Sua estrutura busca aumentar a segurança por meio de tipos fortes, que ajudam a detectar erros, e pacotes, que organizam e protegem dados e operações. Além disso, possui recursos de concorrência, importantes para sistemas que precisam executar várias tarefas ao mesmo tempo de forma controlada. Apesar de ser considerada extensa e complexa, essas características fazem Ada ser adequada para sistemas críticos, nos quais falhas podem causar grandes prejuízos. A partir do Ada 95, também foram adicionados recursos de orientação a objetos, como herança e polimorfismo.

# 15. A primeira aplicação de Java não foi a Web, mas a Web impulsionou
sua adoção. Explique como mudanças de contexto podem reposicionar
uma linguagem.
Java foi criada para atender a uma necessidade que outras linguagens não supriam, tendo como um de seus principais objetivos a confiabilidade, especialmente para produtos eletrônicos de consumo. Porém, os produtos que utilizariam Java inicialmente não chegaram a ser comercializados. A partir de 1993, com o crescimento da World Wide Web e dos navegadores gráficos, Java passou a ser muito utilizada na Web. Os applets Java, pequenos programas executados dentro dos navegadores e exibidos em páginas Web, tornaram-se populares durante a década de 1990. Assim, nos primeiros anos de sua popularidade, a Web foi a principal aplicação de Java.
Mudanças de contexto podem fazer com que uma linguagem passe a ser utilizada em uma área diferente daquela para a qual foi originalmente criada.

# 18. Diferencie XSLT e JSP quanto a entrada, processamento e saída. Por
que ambas podem ser chamadas de linguagens híbridas de marcação e
programação?  
XSLT é uma linguagem híbrida de marcação e programação, criada pelo W3C para transformar documentos XML em outros documentos, como HTML. Ela utiliza templates e instruções de transformação para definir como os dados serão processados. Sua entrada é um documento XML junto com um documento XSLT, o processamento é feito pelo processador XSLT e a saída é outro documento, como XML ou HTML.
JSTL também é uma linguagem híbrida, usada em conjunto com JSP para criar páginas Web dinâmicas. Seus elementos controlam o processamento no servidor e ajudam a definir como o conteúdo de saída será gerado. No JSP, a entrada é um documento JSP, normalmente misturando HTML e Java; o servidor processa esse documento, convertendo-o em um servlet, e a saída é o conteúdo Web gerado para o navegador.
Ambas também possuem recursos de programação, por isso são consideradas linguagens híbridas de marcação-programação.
