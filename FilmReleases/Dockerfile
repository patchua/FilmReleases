FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["FilmReleases/FilmReleases.csproj", "FilmReleases/"]
RUN dotnet restore "FilmReleases/FilmReleases.csproj"
COPY . .
WORKDIR "/src/FilmReleases"
RUN dotnet build "FilmReleases.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "FilmReleases.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FilmReleases.dll"]