-- 1.	Apresentar os dados dos itens cadastrados. 
-- ID, Nome do Item, Se Registra Num Role, Quantidade Mínima, Nome do Fornecedor, Local de Armazenagem

-- Inserindo coluna descricao na tabela categoria
alter table categoria add descricao varchar(255)


select * from categoria

-- Iserindo dados na Categoria do Item
update item set categoriaid = 1 where quantidadeMinima = 0
update item set categoriaid = 2 where numeroLoteRequerido = 0
update item set categoriaid = 3 where quantidadeMinima = 1
update item set categoriaid = 4 where quantidadeMinima > 10
update item set categoriaid = 5 where CategoriaID is null

select * from item

-- -- Iserindo dados na Loja do Item

-- Cadastrando loja 1 e loja 2 na tabela Armazem
Insert into Armazem(nome) values ('Loja 1')
Insert into Armazem (nome) values ('Loja 2')

-- Alterar texto de Corp para Corporation
Update Prestador set nome = REPLACE (nome, 'Corp', 'Corporation') where nome like '%Corp'

select * from Armazem


-- alterar dados da loja Loja 1 para id pares e Loja 2 para ids impares
update item set localID = (select id from Armazem where nome = 'Loja 1') where id % 2 = 0
update item set localID = (select id from Armazem where nome = 'Loja 2') where id % 2 <> 0

select * from item
-- 1.	Apresentar os dados dos itens cadastrados. 
-- ID, Nome do Item, Se Registra Num Role, Quantidade Mínima, Nome do Fornecedor, Local de Armazenagem

select i.id, i.nome, numeroLoteRequerido,quantidadeMinima,p.nome 'Fornecedor',a.nome 'Loja'
from item I, Armazem A, Prestador P
where i.FornecedorID = p.id and i.localID = a.id

-- Mudando a apresentação de numeroLoteRequerido

select i.id, i.nome, iif(numeroLoteRequerido=0,'Não','Sim') 'Lote Requerido',quantidadeMinima,p.nome 'Fornecedor',a.nome 'Loja'
from item I, Armazem A, Prestador P
where i.FornecedorID = p.id and i.localID = a.ID

--2.	Apresentar o Nome do Fornecedor e seus itens
-- Requisito: Cada item terá um fornecedor relacionado a ele, sendo possível controlar os itens divididos por fornecedores.

select * from item
select * from prestador
-- Mostra os fornecedores e seus Itens
select FornecedorID,p.nome, i.id,i.nome
from item I, prestador P
where i.FornecedorID=p.id

-- Mostra a quantidade de itens por Fornecedor
select FornecedorID,p.nome, count(i.id) as 'Qtd itens'
from item I, prestador P
where i.FornecedorID=p.id
group by  FornecedorID,p.nome 


--******* explicação do Group By
select * from Item
select count(id) from Item

-- Funções Count, Max, Min, Avg, Sum

select FornecedorID,count(id) from item
group by FornecedorID

--3.	Apresentar o Nome do Transportadora e seus itens (ok)
-- Apresentar a transportadora e a Qtd de itens Entrada
-- Apresentar a transportadora e a Qtd de itens Saída
-- Requisito: A transportadora será outro item importante na análise, pois devemos saber qual transportadora é mais utilizada 
-- para fazer a entrega dos produtos e qual é a mais utilizada para fazer a saída.

-- Inserir dados da Loja para as transações de Venda

select * from armazem

update pedido set lojaId = 3  where id between 27 and 33
update pedido set lojaId = 4  where id > 33

-- Insere dados nas transportadoras que estão sem registro (=null)
select * from prestador

select * from item
select * from Pedido
select * from ItemPedido

--Nome da transportadoras que fizeram os transportes
select distinct transportadoraID, pr.nome
from pedido P, Prestador Pr
where p.transportadoraID = pr.ID

-- Mostra os itens que foram transportados
select transportadoraID, pr.nome, p.id, i.nome, ip.quantidade
from pedido P, Prestador Pr, itemPedido ip, item i
where p.transportadoraID = pr.ID and p.id = ip.pedidoID and i.id = ip.itemID

-- Apresentar a transportadora e a Qtd de itens Entrada

select * from TipoTransacao

select transportadoraID, pr.nome, p.id, i.nome, ip.quantidade
from pedido P, Prestador Pr, itemPedido ip, item i, TipoTransacao tt
where p.transportadoraID = pr.ID and p.id = ip.pedidoID and i.id = ip.itemID and p.tipoTransacaoID = tt.ID
      and tt.nome = 'Ordem de Compra'

-- Apresentar a transportadora e a Qtd de itens Saída
select transportadoraID, pr.nome, p.id, i.nome, ip.quantidade
from pedido P, Prestador Pr, itemPedido ip, item i, TipoTransacao tt
where p.transportadoraID = pr.ID and p.id = ip.pedidoID and i.id = ip.itemID and p.tipoTransacaoID = tt.ID
      and tt.nome = 'Ordem de Venda'


-- 4. Apresentar a categoria e os itens relacionados a ela
-- Apresentar a categoria e a quantidade de itens relacionados a ela
-- Requisito 1: Os itens devem ser divididos por categoria, ou seja, cada item terá uma categoria.
-- Requisito 2: Uma questão que o cliente deseja observar é em qual categoria possui mais item no local.

select * from Item
select * from Categoria

select i.* ,c.nome
from item i, categoria c
where i.CategoriaID = c.id


select c.nome, count(i.id)
from item i, categoria c
where i.CategoriaID = c.id
group by c.nome

select * from Pedido
select * from TipoTransacao

--5. Mostrar as entradas e saídas dos itens
--Tipo Transação, Id item, Nome Item, Nome Transportadora, Qtd, Data , Data Entrega
--Requisito: As entradas e saídas dos produtos deverão ser registradas no programa, para
--futuramente obtermos um histórico completo de todo o trajeto do item dentro do centro de distribuição.

SELECT TT.nome AS TipoTransacao, I.itemID AS IdItem,IT.nome AS NomeItem,PRE.nome AS Transportadora,
I.quantidade,P.dataEntrega AS DataEntrega FROM Pedido P
INNER JOIN ItemPedido AS I ON P.ID = I.pedidoID
INNER JOIN TipoTransacao AS TT ON P.tipoTransacaoID = TT.ID 
INNER JOIN Item AS IT ON IT.ID = I.itemID
INNER JOIN Prestador AS PRE ON PRE.ID = P.transportadoraID
WHERE P.tipoTransacaoID IN (1,3)

--6. Mostrar as entradas e saídas dos itens
--Tipo Transação, Id item, Nome Item, Nome Transportadora, Qtd, Data , Data Entrega
--Requisito: As entradas e saídas dos produtos deverão ser registradas no programa, para
--futuramente obtermos um histórico completo de todo o trajeto do item dentro do centro de distribuição.

SELECT TT.nome AS TipoTransacao,IT.nome AS NomeItem,PRE.nome as Transportadora,
DATEDIFF(DAY, P.dataPedido, P.dataEntrega) AS DiasParaEntrega FROM Pedido AS P
INNER JOIN ItemPedido AS I ON P.ID = I.pedidoID
INNER JOIN TipoTransacao AS TT ON P.tipoTransacaoID = TT.ID 
INNER JOIN Item AS IT ON IT.ID = I.itemID
INNER JOIN Prestador AS PRE ON PRE.ID = P.transportadoraID
WHERE P.tipoTransacaoID = 1;

--7. Na entrada dos itens é necessário identificar o número do lote. É necessário
--identificar quais itens essa informação é obrigatória. Nem todos os itens
--necessitam de número de lote.

SELECT I.ID AS IdItem,I.nome as NomeItem,
CASE WHEN I.numeroLoteRequerido = 0 THEN 'Número de lote não requerido' ELSE IT.numeroLote END
FROM Item AS I INNER JOIN ItemPedido AS IT ON I.ID = IT.itemID

--8. Na saída, obrigatoriamente será informada a loja para a qual a mercadoria foi
--enviada, pois ao final do mês devemos fazer o fechamento do faturamento para
--saber qual é a loja que mais obteve vendas.

SELECT Tipo.nome,P.transportadoraID,p.dataEntrega AS DataSaida,PRE.nome AS lojaEnviada FROM Pedido AS P
INNER JOIN TipoTransacao AS Tipo ON P.tipoTransacaoID = Tipo.ID
INNER JOIN Prestador AS PRE ON PRE.ID = P.lojaID 
WHERE P.tipoTransacaoID = 3

--9. No programa, devem-se apresentar os produtos nos quais a sua quantidade total
--em estoque é menor ou igual à quantidade mínima requerida em estoque
--definida previamente.

--NÃO CONSEGUI COMPLETA
--NÃO CONSEGUI COMPLETA
--NÃO CONSEGUI COMPLETA
SELECT DISTINCT I.nome, (SUM(IT.quantidade) - (select TI.quantidade from ItemPedido TI  --NÃO CONSEGUI COMPLETA
INNER JOIN Pedido AS P ON P.ID = TI.pedidoID WHERE P.ID = 3))AS Quantidade --NÃO CONSEGUI COMPLETA
FROM ItemPedido AS IT --NÃO CONSEGUI COMPLETA
INNER JOIN Item AS I ON I.ID = IT.itemID --NÃO CONSEGUI COMPLETA
GROUP BY I.nome --NÃO CONSEGUI COMPLETA
--NÃO CONSEGUI COMPLETA
--NÃO CONSEGUI COMPLETA
--NÃO CONSEGUI COMPLETA


--10. Para balanceamento de estoque, será necessário prever a transferência itens entre
--armazéns. Para isso, deve especificar o item, a origem e o destino.

SELECT P.ID,Tipo.ID as IdArmazemDeOrigem,run.ID as IdArmazemDestino, 
Tipo.nome as armazemOrigem,run.nome AS armazemDestino FROM Pedido AS P
INNER JOIN Armazem AS Tipo ON Tipo.ID = P.armazemOrigemID
INNER JOIN Armazem AS run ON run.ID = P.armazemDestinoID
WHERE (P.tipoTransacaoID = 2) 


