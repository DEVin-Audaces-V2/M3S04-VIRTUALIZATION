### Criando instância ec2

    Requisitos:

    - Security Group (como fizemos em aula);
        - inbound rule: protocolo http aberto para qualquer ipv4;
        - inbound rule: protocolo ssh aberto para o IP da sua máquina;

    - Key pair (como fizemos em aula);
        - RES;
        - .pem (OpenSSH)

#### Passo a passo
    -Via console:
        - Configurar e subir a instância EC2 (como fizemos em aula);
        - Lembre-se de selecionar a máquina t2.micro (free tier);
        - Lembre-se de desligar a máquina (stop) depois de estudar para não gastar horas gratuitas a toa!

    -Via Terminal:
        - Conecta na máquina localmente via ssh;
        - Instala o docker : sudo amazon-linux-extras install docker
        - Start docker service: sudo service docker start
        - Permissão para ec2-user: sudo usermod -a -G docker ec2-user
        - Settar inicialização automatica do docker: sudo chkconfig docker on
        - Reinicia servidor: sudo reboot
        - reconecta na máquina via ssh

        - Cria o site
            mkdir site
            cd site
            mkdir html
            cd html
            nano home.html
                - adiciona no html: <h3>Hello Ec2!</h3>
                - ctrl+x
                - y
                - enter

        - Criar dockerfile
            cd ..
            nano Dockerfile
                - adiciona no Dockerfile:

                FROM httpd:2.4

                COPY ./html/ /usr/local/apache2/htdocs/

        -buildar imagem: docker build -t <nome_da_imagem> .

        -rodar imagem: docker run -d --name <nome_do_conteiner> -p 80:80 <nome_da_imagem>

        -Via console:
            - Recupera o valor do Public IPv4 DNS de sua instância EC2: este é o <endereço_da_máquina>;
            - Faça requisição no browser: http://<endereço_da_máquina>/home.html