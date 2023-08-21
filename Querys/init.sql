/* Utilizando a sintaxe do postgresql
*/

Create DATABASE TASKEN;



/* Questao 5*/
CREATE TABLE CLIENTES (
    CPF VARCHAR(11) PRIMARY KEY,
    NOME VARCHAR(100),
    IDADE INTEGER
);

CREATE TABLE TELEFONES (
    CPF_CLIENTE VARCHAR(11) PRIMARY KEY REFERENCES CLIENTES(CPF),
    DDD VARCHAR(3),
    TELEFONE VARCHAR(20)
);
/********************************************************/



/*Questao 6*/
SELECT NOME FROM CLIENTES WHERE IDADE >= 22 ORDER BY IDADE ASC;
/*************************************************************/


/*Questao 7*/
SELECT c.NOME, COUNT(t.CPF_CLIENTE) AS quantidade_telefones
FROM CLIENTES c
JOIN TELEFONES t ON c.CPF = t.CPF_CLIENTE
GROUP BY c.NOME
HAVING COUNT(t.CPF_CLIENTE) >= 1;
/****************************************************/



/*Questao 8 */
DELETE FROM CLIENTES 
WHERE SUBSTRING(NOME FROM POSITION(' ' IN NOME) + 1) = 'santos';
/****************************************************/