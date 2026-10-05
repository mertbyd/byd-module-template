# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build-env
WORKDIR /app
# Copy csproj and restore as distinct layers
COPY host/MyCompanyName.MyProjectName.HttpApi.Host/MyCompanyName.MyProjectName.HttpApi.Host.csproj ./
COPY NuGet.Config ./
RUN dotnet restore && rm NuGet.Config
# Copy everything else and build
COPY . ./
RUN dotnet publish host/MyCompanyName.MyProjectName.HttpApi.Host/MyCompanyName.MyProjectName.HttpApi.Host.csproj -c Release -o out
# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "MyCompanyName.MyProjectName.HttpApi.Host.dll"]
