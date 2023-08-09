#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SellTech.Api/SellTech.Api.csproj", "SellTech.Api/"]
COPY ["SellTech.Application/SellTech.Application.csproj", "SellTech.Application/"]
COPY ["SellTech.Domain/SellTech.Domain.csproj", "SellTech.Domain/"]
COPY ["SellTech.Infrastructure/SellTech.Infrastructure.csproj", "SellTech.Infrastructure/"]
COPY ["SellTech.Utilities/SellTech.Utilities.csproj", "SellTech.Utilities/"]
RUN dotnet restore "SellTech.Api/SellTech.Api.csproj"
COPY . .
WORKDIR "/src/SellTech.Api"
RUN dotnet build "SellTech.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SellTech.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN ln -fs /usr/share/zoneinfo/America/Costa_Rica /etc/localtime
RUN dpkg-reconfigure --frontend nointeractive tzdata

ENTRYPOINT ["dotnet", "SellTech.Api.dll"]