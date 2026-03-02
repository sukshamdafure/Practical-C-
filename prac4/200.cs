FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY . .
ENTRYPOINT ["dotnet", "YourApp.dll"]
docker build -t myapp .
docker tag myapp myregistry.azurecr.io/myapp
docker push myregistry.azurecr.io/myapp