FROM mcr.microsoft.com/dotnet/sdk:5.0 as build-env

WORKDIR /agents-victorinsurance-services

COPY . /agents-victorinsurance-services

RUN dotnet restore
RUN dotnet build

WORKDIR /agents-victorinsurance-services
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /agents-victorinsurance-services
EXPOSE 80

COPY --from=build-env /agents-victorinsurance-services/publish .
ENTRYPOINT ["dotnet","Agents.VictorInsurance.Api.Services.dll"]