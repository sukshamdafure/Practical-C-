az login
az group create --name MyRG --location centralindia
az appservice plan create --name MyPlan --resource-group MyRG --sku FREE
az webapp create --resource-group MyRG --plan MyPlan --name mydotnetapp --runtime "DOTNET:7.0"
az webapp up --name mydotnetapp