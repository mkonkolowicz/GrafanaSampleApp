FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 55699
EXPOSE 44331

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["ToriSampleApp/ToriSampleApp.csproj", "ToriSampleApp/"]
RUN dotnet restore "ToriSampleApp/ToriSampleApp.csproj"
COPY . .
WORKDIR "/src/ToriSampleApp"
RUN dotnet build "ToriSampleApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ToriSampleApp.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ToriSampleApp.dll"]
