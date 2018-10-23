FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Todo/Todo.csproj Todo/
RUN dotnet restore Todo/Todo.csproj
COPY . .
WORKDIR /src/Todo
RUN dotnet build Todo.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Todo.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Todo.dll"]
