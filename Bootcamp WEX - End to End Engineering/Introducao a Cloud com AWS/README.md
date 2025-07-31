# dio-farmacia-aws
#RELATORIO DE IMPLEMENTAÇAO DE SERVIÇOS AWS
Empresa: Abstergo Industries

## Introdução
Com o objetivo de modernizar a infraestrutura tecnológica da Abstergo Industries, empresa do setor farmacêutico com atuação também como distribuidora, este relatório propõe a adoção de três ferramentas da Amazon Web Services (AWS) como parte da transição para a nuvem. A iniciativa visa aumentar a escalabilidade, melhorar a segurança, reduzir custos operacionais e garantir maior confiabilidade no armazenamento e tratamento de dados.

## Descrição do Projeto
O projeto de implementação de ferramentas foi dividido em 3 etapas, cada uma com seus objetivos específicos. A seguir, serão descritas as etapas do projeto:

### Etapa 1:
- Amazon S3
- Foco da ferramenta: Armazenamento de objetos na nuvem.
- Descrição de caso de uso: Será utilizado para centralizar o armazenamento de documentos como: receitas digitais, notas fiscais, relatórios logísticos, catálogos de produtos e backups de sistemas internos.

### Etapa 2:
- AWS Lambda
- Foco da ferramenta: Processamento de dados sob demanda (serverless)
- Descrição de caso de uso: A ferramenta será usada para automatizar tarefas operacionais como: validação de dados de pedidos, geração de relatórios de vendas e integração entre sistemas internos e plataformas de distribuição. Por ser serverless, elimina a necessidade de gerenciar servidores, otimizando custos com uso sob demanda.

### Etapa 3:
Amazon RDS (Relational Database Service)
- Foco da ferramenta: Banco de dados.
- Descrição de caso de uso: Hospedar os bancos de dados transacionais dos sistemas ERP e CRM da empresa. O RDS oferece alta disponibilidade, backups automáticos e escalabilidade vertical, facilitando o crescimento da operação conforme a demanda aumentar.

## Conclusão

## Anexos
Documentação:
- Amazon S3: https://docs.aws.amazon.com/s3/
- Amazon Lambda: https://docs.aws.amazon.com/lambda 
- Amazon RDS: https://docs.aws.amazon.com/rds