# CurriculoAPI - Setup de Conteinerização

## 📋 Pré-requisitos

- Docker Desktop instalado (Windows, Mac ou Linux)
- Docker Compose instalado

## 🚀 Como executar

### 1. Usando Docker Compose (Recomendado)

```bash
# Iniciar todos os serviços (API + PostgreSQL)
docker-compose up -d

# Ver logs
docker-compose logs -f

# Parar os serviços
docker-compose down

# Parar e remover volumes (limpa o banco de dados)
docker-compose down -v
```

### 2. Usando apenas Docker

```bash
# Construir a imagem
docker build -t curriculo-api .

# Criar uma rede
docker network create curriculo-network

# Executar PostgreSQL
docker run -d \
  --name curriculo-postgres \
  --network curriculo-network \
  -e POSTGRES_DB=curriculo \
  -e POSTGRES_USER=dev \
  -e POSTGRES_PASSWORD=dev123 \
  -p 5432:5432 \
  postgres:16-alpine

# Executar a API
docker run -d \
  --name curriculo-api \
  --network curriculo-network \
  -e ASPNETCORE_ENVIRONMENT=Development \
  -e ASPNETCORE_URLS=http://+:8080 \
  -e ConnectionStrings__DefaultConnection="Host=curriculo-postgres;Database=curriculo;Username=dev;Password=dev123" \
  -p 8080:8080 \
  curriculo-api
```

## 🔧 Executar Migrations

Após subir os containers, execute as migrations:

```bash
# Acessar o container da API
docker exec -it curriculo-api bash

# Executar migrations (dentro do container)
dotnet ef database update

# Ou execute diretamente do host (se tiver o dotnet CLI instalado)
dotnet ef database update
```

## 🌐 Acessar a aplicação

- **API**: http://localhost:8080
- **Swagger**: http://localhost:8080/swagger
- **PostgreSQL**: localhost:5432
  - Database: curriculo
  - User: dev
  - Password: dev123

## 📂 Estrutura de arquivos criados

```
.
├── Dockerfile              # Já existente
├── docker-compose.yml      # Orquestração de serviços
├── .dockerignore          # Arquivos ignorados no build
├── .env.example           # Exemplo de variáveis de ambiente
└── DOCKER-README.md       # Este arquivo
```

## 🔐 Variáveis de Ambiente

Você pode criar um arquivo `.env` baseado no `.env.example`:

```bash
cp .env.example .env
```

E editar as variáveis conforme necessário.

## 🛠️ Comandos úteis

```bash
# Reconstruir imagens
docker-compose build

# Reconstruir sem cache
docker-compose build --no-cache

# Ver status dos containers
docker-compose ps

# Acessar logs de um serviço específico
docker-compose logs -f api
docker-compose logs -f postgres

# Executar comandos dentro do container da API
docker-compose exec api bash

# Executar comandos dentro do container do PostgreSQL
docker-compose exec postgres psql -U dev -d curriculo
```

## 🧹 Limpeza

```bash
# Remover containers, redes e volumes
docker-compose down -v

# Remover imagens
docker rmi curriculo-api

# Limpar tudo do Docker (cuidado!)
docker system prune -a --volumes
```

## 📝 Notas

- O banco de dados usa um volume nomeado `postgres_data` para persistir dados
- A API aguarda o PostgreSQL estar saudável antes de iniciar
- As portas padrão são 8080 (API) e 5432 (PostgreSQL)
- Para produção, altere as credenciais do banco de dados!
