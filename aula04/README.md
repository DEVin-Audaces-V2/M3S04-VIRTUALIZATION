## Subindo nossa primeira imagem Docker para a Cloud (AWS)

### Subir imagem docker para AWS ECR

- criar repositório: aws ecr create-repository --repository-name hello --region us-east-1

- Executar comando de login no ECR:
    
    aws ecr get-login-password --region <regiao> | docker login --username AWS --password-stdin <aws_account>.dkr.ecr.<regiao>.amazonaws.com

- Executar build:
    
    docker build -t <nome_da_imagem> .

- Executar tag:

    docker tag <nome_da_imagem>:latest <aws_account>.dkr.ecr.<regiao>.amazonaws.com/<nome_da_imagem>:latest


- Executar push:

    docker push <aws_account>.dkr.ecr.<regiao>.amazonaws.com/<nome_da_imagem>:latest

## Baixar e executar a imagem do repositório no ECR em instância EC2

    - Crie uma nova IAM Role(Função) para sua instância EC2 acessar o ECR;

            - no console da AWS vá em IAM;
            - Acesse o menu "Políticas;
            - Clique em "criar política";
            - Clique em JSON;
            - Cole a seguinte política no editor de políticas:

                        {
                            "Version": "2012-10-17",
                            "Statement": [
                                {
                                    "Effect": "Allow",
                                    "Action": [
                                        "ecr:*",
                                        "cloudtrail:LookupEvents"           
                                    ],
                                    "Resource": "*"
                                }
                            ]
                        }


            - Clique em "Próximo";
            - Nomeie sua política como "EC2PoliticaECR";
            - Clique em "Criar política";

            - Acesse o menu "Funções";
            - Clique em "Criar Função";
            - Em "Tipo de entidade confiável" Selecione "Serviço da AWS;
            - Em "Caso de uso" selecione "EC2" 
            - Clique em Próximo;
            - Busque em "políticas de permissões" pela política criada anteriormente
                "EC2PoliticaECR"
            - Adicione a política "EC2PoliticaECR" a sua Função clicando no "[+]";
            - Clique em Próximo;
            - Nomeie sua Função "Ec2Funcao";
            - Clique em Criar função.                       
    
    Agora precisamos vincular a nova função à instância EC2:

            - Vá até o painel de instâncias EC2;
            - Selecione a sua instância;
            - Clique em "Ações" -> "Segurança" -> "Modificar função do IAM";
            - Em Função do IAM selecione "Ec2Funcao";
            - Clique em "Atualizar função do IAM";

    Agora para executarmos a imagem docker que está armazenada no ECR:
    
    - Inicie sua instância EC2;

    - conecte na sua instância EC2 via SSH;

    - faça o login no ECR;

        aws ecr get-login-password --region <regiao> | docker login --username AWS --password-stdin <aws_account>.dkr.ecr.<regiao>.amazonaws.com

    - realize o PULL da imagem no ECR

        docker pull aws_account_id.dkr.ecr.region.amazonaws.com/<nome_da_imagem>:latest

    - Execute a imagem

        docker run aws_account_id.dkr.ecr.region.amazonaws.com/<nome_da_imagem>

    ps: Lembre-se de desligar sua máquina EC2 (stop/parar).


