# run.ps1
# PowerShell script to print current system date and time
# To run: powershell -File run.ps1

Write-Host "Current system date and time:"
Write-Host (Get-Date -Format "yyyy-MM-dd HH:mm:ss")
