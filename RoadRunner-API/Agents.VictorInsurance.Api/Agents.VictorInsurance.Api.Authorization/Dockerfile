FROM mcr.microsoft.com/dotnet/sdk:5.0 as build-env

WORKDIR /agents-victorinsurance-auth

COPY . /agents-victorinsurance-auth

RUN dotnet restore
RUN dotnet build

WORKDIR /agents-victorinsurance-auth
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /agents-victorinsurance-auth
EXPOSE 80

COPY --from=build-env /agents-victorinsurance-auth/publish .
ENTRYPOINT ["dotnet","Agents.VictorInsurance.Api.Authorization.dll"]