Write-Host "Starting code generation"
Write-Host "--------------------`n`n`n"
python "./scripts/generate.py"

Write-Host "`n`n`nBuilding C#"
Write-Host "--------------------`n`n`n"
dotnet build "./generated/cs/ApolloRoboto.Constants.csproj"