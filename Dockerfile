# syntax=docker/dockerfile:1

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR webapp

COPY ./*.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /webapp
COPY --from=build /webapp/out .

EXPOSE 6068
ENV ASPNETCORE_URLS=http://*:6068

ENTRYPOINT ["dotnet", "dijidom-database-webapi.dll"]
