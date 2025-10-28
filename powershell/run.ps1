# run.ps1
# PowerShell script to print current system date and time
# To run: powershell -File run.ps1

Write-Output "Current system date and time:"
Write-Output (Get-Date -Format "yyyy-MM-dd HH:mm:ss")
