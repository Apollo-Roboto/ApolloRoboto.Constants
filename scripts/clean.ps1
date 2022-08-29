$generated_path = ".\generated\"
if(-not (Test-Path $generated_path)) {
	Write-Host "$generated_path could not be fund. Already clean?" -ForegroundColor Red
	exit 0
}
Write-Host "Deleting $generated_path"
Remove-Item $generated_path -Recurse
Write-Host "Done!" -ForegroundColor Green