FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
<<<<<<< HEAD
COPY ["ToriFirstApp/ToriFirstApp.csproj", "ToriFirstApp/"]
RUN dotnet restore "ToriFirstApp/ToriFirstApp.csproj"
COPY . .
WORKDIR "/src/ToriFirstApp"
RUN dotnet build "ToriFirstApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ToriFirstApp.csproj" -c Release -o /app
=======
COPY ToriFirstApp/ToriFirstApp.csproj ToriFirstApp/
RUN dotnet restore ToriFirstApp/ToriFirstApp.csproj
COPY . .
WORKDIR /src/ToriFirstApp
RUN dotnet build ToriFirstApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ToriFirstApp.csproj -c Release -o /app
>>>>>>> d71b99d71701803872a37c7748c64e03e651d948

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
<<<<<<< HEAD
ENTRYPOINT ["dotnet", "ToriFirstApp.dll"]
=======
ENTRYPOINT ["dotnet", "ToriFirstApp.dll"]
>>>>>>> d71b99d71701803872a37c7748c64e03e651d948
