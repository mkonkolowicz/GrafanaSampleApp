FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ToriFirstApp.csproj ToriFirstApp/
RUN dotnet restore ToriFirstApp/ToriFirstApp.csproj
COPY . .
WORKDIR /src/ToriFirstApp
RUN dotnet build ToriFirstApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ToriFirstApp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ToriFirstApp.dll"]
