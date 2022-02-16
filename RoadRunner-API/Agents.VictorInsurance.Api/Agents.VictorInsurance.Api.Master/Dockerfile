FROM mcr.microsoft.com/dotnet/sdk:5.0 as build-env

WORKDIR /agents-victorinsurance-master

COPY . /agents-victorinsurance-master

RUN dotnet restore
RUN dotnet build

WORKDIR /agents-victorinsurance-master
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /agents-victorinsurance-master
EXPOSE 80

COPY --from=build-env /agents-victorinsurance-master/publish .
ENTRYPOINT ["dotnet","Agents.VictorInsurance.Api.Master.dll"]