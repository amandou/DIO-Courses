# Tarefas automatizadas com AWS Lambda e S3

## Amazon S3

O **Amazon S3 (Simple Storage Service)** é um serviço de armazenamento de objetos na nuvem da AWS. Ele permite guardar qualquer tipo de arquivo de forma segura, durável e escalável. Os arquivos são organizados em **buckets**, que funcionam como pastas virtuais. Cada arquivo armazenado é chamado de objeto e possui uma chave única para identificação.

### Vantagens do S3:
- **Alta durabilidade:** Garante que seus dados não sejam perdidos com redundância automática.  
- **Alta disponibilidade:** Seus arquivos ficam acessíveis o tempo todo, sem interrupções.  
- **Escalabilidade automática:** Pode armazenar desde poucos até bilhões de arquivos sem ajuste manual.  
- **Segurança:** Permite controlar o acesso a arquivos por meio de permissões detalhadas.

## AWS Lambda

O **AWS Lambda** é um serviço de computação serverless que permite executar código em resposta a eventos, sem necessidade de provisionar ou gerenciar servidores. Ele automaticamente escala a execução conforme a demanda.

### Vantagens do Lambda:
- **Execução sob demanda:** O código só roda quando necessário, evitando custos com recursos ociosos.  
- **Escalabilidade automática:** Suporta desde poucas até milhares de execuções simultâneas.  
- **Integração nativa com AWS:** Fácil conexão com outros serviços como S3, DynamoDB e API Gateway.  
- **Baixo custo:** Paga-se apenas pelo tempo de execução do código, em milissegundos.

## Amazon API Gateway

O **Amazon API Gateway** permite criar, publicar e gerenciar APIs REST e HTTP que atuam como uma ponte entre os clientes e os serviços backend da AWS.

### Vantagens do API Gateway:
- **Integração facilitada:** Conecta APIs diretamente com funções Lambda, serviços HTTP e outros.  
- **Controle de tráfego:** Gerencia autenticação, limites e autorização das requisições.  
- **Documentação e SDKs automáticos:** Gera documentação e kits de desenvolvimento para facilitar o uso das APIs.

## Amazon DynamoDB

O **Amazon DynamoDB** é um banco de dados NoSQL gerenciado, que oferece alta performance, baixa latência e escalabilidade automática. É ideal para aplicações que demandam grande volume de acessos simultâneos e respostas rápidas.

### Vantagens do DynamoDB:
- **Gerenciado e sem servidores:** Não é preciso se preocupar com manutenção ou escalabilidade manual.  
- **Escala automaticamente:** Ajusta capacidade conforme a demanda de leitura e escrita.  
- **Baixa latência:** Respostas rápidas, geralmente em milissegundos.  
- **Triggers com DynamoDB Streams:** Permite executar ações em resposta a alterações no banco.