FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Repositories/Repositories.csproj", "Repositories/"]
RUN dotnet restore "Repositories/Repositories.csproj"
COPY . .
WORKDIR "/src/Repositories"
RUN dotnet build "Repositories.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Repositories.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app

ENV ASPNETCORE_ENVIRONMENT=Production

# Example adjustment assuming Dockerfile is in /Repositories/
COPY ["../Solution Items/K8S/Repositories/External/id_rsa", "./id_rsa"]
COPY ["../Solution Items/K8S/Repositories/External/id_rsa.pub", "./id_rsa.pub"]
COPY ["../Solution Items/K8S/Repositories/External/key_script.sh", "./key_script.sh"]

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Repositories.dll"]
