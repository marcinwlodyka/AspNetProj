FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["AspNetProject/AspNetProject.csproj", "AspNetProject/"]
RUN dotnet restore "AspNetProject/AspNetProject.csproj"
COPY . .
WORKDIR "/src/AspNetProject"
RUN dotnet build "AspNetProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspNetProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspNetProject.dll"]
