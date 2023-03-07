FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/TestCache.Web.Host/TestCache.Web.Host.csproj", "src/TestCache.Web.Host/"]
COPY ["src/TestCache.Web.Core/TestCache.Web.Core.csproj", "src/TestCache.Web.Core/"]
COPY ["src/TestCache.Application/TestCache.Application.csproj", "src/TestCache.Application/"]
COPY ["src/TestCache.Core/TestCache.Core.csproj", "src/TestCache.Core/"]
COPY ["src/TestCache.EntityFrameworkCore/TestCache.EntityFrameworkCore.csproj", "src/TestCache.EntityFrameworkCore/"]
WORKDIR "/src/src/TestCache.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/TestCache.Web.Host", "src/TestCache.Web.Host"]
COPY ["src/TestCache.Web.Core", "src/TestCache.Web.Core"]
COPY ["src/TestCache.Application", "src/TestCache.Application"]
COPY ["src/TestCache.Core", "src/TestCache.Core"]
COPY ["src/TestCache.EntityFrameworkCore", "src/TestCache.EntityFrameworkCore"]
WORKDIR "/src/src/TestCache.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TestCache.Web.Host.dll"]
