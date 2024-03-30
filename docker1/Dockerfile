FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["docker1/docker1.csproj", "docker1/"]
RUN dotnet restore "docker1/docker1.csproj"
COPY . .
WORKDIR "/src/docker1"
RUN dotnet build "docker1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "docker1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "docker1.dll"]
