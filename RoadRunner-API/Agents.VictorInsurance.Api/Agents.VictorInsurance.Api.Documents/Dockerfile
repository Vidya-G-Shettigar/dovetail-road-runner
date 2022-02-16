FROM mcr.microsoft.com/dotnet/sdk:5.0 as build-env

WORKDIR /agents-victorinsurance-documents

COPY . /agents-victorinsurance-documents

RUN dotnet restore
RUN dotnet build

WORKDIR /agents-victorinsurance-documents
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /agents-victorinsurance-documents
EXPOSE 80

COPY --from=build-env /agents-victorinsurance-documents/publish .
ENTRYPOINT ["dotnet","Agents.VictorInsurance.Api.Documents.dll"]