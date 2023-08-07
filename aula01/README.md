## Docker

1. Execute o Container Padrão de testes hello-world docker

    - Instale o Docker https://docs.docker.com/get-docker/
    - Faça o pull e o run da imagem https://hub.docker.com/_/hello-world

2. Coloque para rodar uma instância do MySQL via Docker Official Image

    - Instale o MySQL CLI para interagir com o MySQL uma vez que esteja executando. 
    (https://dev.mysql.com/doc/mysql-shell/8.0/en/mysql-shell-install.html)

    - Baixar imagem atual mysql

        ```bash
        docker pull mysql:latest
        ```

        - Rodar mysql 

        ```bash
        docker run --name mysql-db -e MYSQL_ROOT_PASSWORD=<password> -p 3306:3306 -d mysql:latest
        ```

        - Conecte no MySQL via CLI

        ```bash
        mysql -u root -p<password> -h 127.0.0.1 -P 3306
        ```

        - Crie uma nova base de dados (schema)

        ```bash
        CREATE DATABASE <nome>;
        ```

        - Selecione a database

        ```bash
        USE <database>;
        ```

        - Crie a tabela de users;

        ```bash
        CREATE TABLE IF NOT EXISTS mytable (nome VARCHAR(255), cidade VARCHAR(255));
        ```

        - Para verificar se sua tabela foi criada execute:

        ```bash
        SHOW TABLES;
        ```


        - Para uma query simples validando se os dados foram registrados pelo webserver

        ```bash
        SELECT * FROM <nome-da-table>
        ```
