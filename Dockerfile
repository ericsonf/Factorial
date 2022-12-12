FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Factorial.csproj", "./"]
RUN dotnet restore "./Factorial.csproj"
COPY . .
RUN dotnet build "Factorial.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Factorial.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Factorial.dll"]