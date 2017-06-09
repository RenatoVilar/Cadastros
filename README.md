## Cadastros
### Sistema de Apoio ao Cadastros

Sistema criado para auxiliar usuario  no cadastro de Produtos e Clientes em um ERP.

Nos sistemas ERP o Cadastros de Produtos e o de Clientes têm suma importância, devido ao fato que as informaçoes inseridas nesses cadastros
são utilizadas para a tributação e porque possuem diversas variações. 

No meu entendimento um bom ERP deve impedir que o usuário inclua no sistema, cadastros inconsistentes tanto quanto a falta de informações quanto 
a qualidade dessas informações. 

O ERP que utilizo em minha empresa permitem que o usuário inclua um novo registro sem avaliar as situações que tornam
esses cadastros inconsistentes, apenas avaliando se o campo foi preenchido ou não. Como exemplo cito as seguintes situações: 

1. Permite cadastrar um cliente cuja UF é EX (Exterior), mas com uma cidade que fica localizado no Brasil;
2. Permite cadastrar uma pessoa física com Inscrição Estadual, o que só faz sentido em casos em que o cliente é Produtor Rural;
3. Permite que um produto cuja NCM tenha Substituição Tributária a CST seja diferente de 10 ou 60.

Para resolver esses questões criei esse sistema que auxilia o usuário a preecher o cadastro com informações consistentes.

Esse é o primeiro sistema que desenvolvi. Portanto está aberto a crítica e sugestões. 
