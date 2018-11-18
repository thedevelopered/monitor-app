#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["AltenChallengeApp.Web/AltenChallengeApp.Web.csproj", "AltenChallengeApp.Web/"]
COPY ["AltenChallengeApp.Infrastructure/AltenChallengeApp.Infrastructure.csproj", "AltenChallengeApp.Infrastructure/"]
COPY ["AltenChallengeApp.AzureStorage/AltenChallengeApp.AzureStorage.csproj", "AltenChallengeApp.AzureStorage/"]
COPY ["AltenChallengeApp.Core/AltenChallengeApp.Core.csproj", "AltenChallengeApp.Core/"]
RUN dotnet restore "AltenChallengeApp.Web/AltenChallengeApp.Web.csproj"
COPY . .
WORKDIR "/src/AltenChallengeApp.Web"
RUN dotnet build "AltenChallengeApp.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AltenChallengeApp.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AltenChallengeApp.Web.dll"]