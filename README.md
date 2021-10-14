# magentoapi

## Build

Call the build target in solution root.

```
dotnet cake --target="Build"
```

## Test

Call the test target in solution root.

```
dotnet cake --target="Test"
```

## Deploy

Call the deploy target in solution root. The argument ```NugetDeployApiKey``` is mandatory.

```
dotnet cake --target="Deploy" --NugetDeployApiKey=ABC1234
```

## GetRemoteServiceList

```
dotnet cake --target="GenerateRemoteService" --BaseEndpoint=http://test.shop.example --User=admin --Password=1234 --Output=src\MagentoApi.SoapClient.Community243\services.txt
```
