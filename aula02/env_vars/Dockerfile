#BASE DA IMAGEM 
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

#Configurar o diretório de trabalho do container. 
WORKDIR /app

# Migração dos arquivos da app para a imagem
COPY hello.csproj .
RUN dotnet restore

#Build 
COPY . /app
RUN dotnet publish -c Release -o out

#Configurar Camada de Runtime
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime

#Configurar o diretório de trabalho do container. 
WORKDIR /app

#Transferência da build para o ambiente de runtime
COPY --from=build /app/out .

# Defino valor de var de ambiente default
ENV AMBIENTE_AUDACES Alunos

# Entrypoint do nosso app
ENTRYPOINT [ "dotnet","hello.dll" ]