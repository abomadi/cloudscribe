FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /cs

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src

COPY ./CloudscribeDocker.csproj .

RUN dotnet restore ./CloudscribeDocker.csproj
COPY . .
WORKDIR /src/
RUN dotnet build ./CloudscribeDocker.csproj -c Release -o /cs

FROM build AS publish
RUN dotnet publish ./CloudscribeDocker.csproj -c Release -o /cs

FROM base AS final
WORKDIR /cs
COPY --from=publish /cs .
ENTRYPOINT ["dotnet", "CloudscribeDocker.dll"]
