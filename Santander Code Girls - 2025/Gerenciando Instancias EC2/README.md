
# Introdução

## O que é o Amazon EC2?

O Amazon EC2(Elastic Compute Cloud) é um serviço da AWS que permite alugar e gerenciar servidores virtuais na nuvem, conhecidos como instâncias. Esses servidores podem rodar aplicações, sites, bancos de dados, como se fossem um computador remotor. As instâncias virtuais, estão sempre rodando em servidores físicos em algum lugar do mundo, distribuído pelas regiãos e zonas de disponibilidades da AWS. Por ser um servidor em si, a EC2 e suas instâncias não são um serviço serverless.

## Principais características

- Escalável: você pode aumentar ou diminuir a capacidade conforme necessário.
- Paga de acordo com o uso: você só paga pelo tempo em que a instância está ativa (com exceção de alguns recursos como volumes EBS).
- Flexível: escolha o sistema operacional, CPU, memória, armazenamento e rede.
- Integrado com outros serviços AWS: como S3, RDS, IAM, CloudWatch, etc.
- Segurança: controle de acesso com Security Groups e gerenciamento de chaves SSH.

# Métodos de acesso a uma instância EC2

- Console da Amazon
    - É uma interface web, em que pode-se criar e configurar instâncias EC2.
- AWS CLI
    - É possível interagir por meio de um terminal
- SDKs da AWS

# Precificação

- On Demand
    - Preço fixo de acordo com os segundos que usar.
- Spot
    - Uso de instâncias do EC2 não utilizadas, o que pode reduzir os custos do Amazon EC2.
- Reserved Instances
    - Usa-se uma configuração específica de instância, por um período de um ou de três anos.
- Dedicated Hosts
    - Um servidor físico é usado totalmente para o seu uso, ou pode-se compartilhar a capacidade de instância com outras contas.
- Savings Plans
    - É preciso comprometer a usar uma determinada quantidade de tempo consistente. Podendo pagar por hora, período de uso.


# Uso de Imagens

Uma AMI(Amazon Machine Image) é uma imagem de máquina virtual pré-configurada, com informações necessárias para começar uma instância, como o SO, servidor e aplicações.

Características Importantes
- AMIs podem ser criadas a partir de instãncias em execução ou paradas.
- Podemos ter 2 tipos de AMI:
    - AMI pública: são um padrão pre pronto para ser usado.
    - AMI privada: é possível personalizar de acordo com o que for necessário.