FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln ./
COPY ./Atlas/Atlas.csproj ./Atlas/
COPY ./Atlas.Test/Atlas.Test.csproj ./Atlas.Test/
COPY ./Atlas.Lib/Atlas.Lib.csproj ./Atlas.Lib/
RUN dotnet restore

# copy and publish app and libraries
COPY . .
RUN dotnet build -c Release -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/core/runtime:3.1
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Atlas.dll"]