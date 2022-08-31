

Write-Host "Starting code generation"
Write-Host "--------------------`n`n`n"
python ".\scripts\generate.py"

Write-Host "`n`n`nBuilding C#"
Write-Host "--------------------`n`n`n"
dotnet build ".\generated\cs\Constants.csproj"
dotnet pack ".\generated\cs\Constants.csproj"

Write-Host "`n`n`nBuilding Python"
Write-Host "--------------------`n`n`n"
python -m build ".\generated\python\"