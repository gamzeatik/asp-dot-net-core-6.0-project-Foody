FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Foody.PresentationLayer/Foody.PresentationLayer.csproj", "Foody.PresentationLayer/"]
COPY ["Foody.EntityLayer/Foody.EntityLayer.csproj", "Foody.EntityLayer/"]
COPY ["Foody.DataAccessLayer/Foody.DataAccessLayer.csproj", "Foody.DataAccessLayer/"]
COPY ["Foody.BusinessLayer/Foody.BusinessLayer.csproj", "Foody.BusinessLayer/"]
RUN dotnet restore "Foody.PresentationLayer/Foody.PresentationLayer.csproj"
COPY . .
WORKDIR "/src/Foody.PresentationLayer"
RUN dotnet build "Foody.PresentationLayer.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Foody.PresentationLayer.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Foody.PresentationLayer.dll"]
