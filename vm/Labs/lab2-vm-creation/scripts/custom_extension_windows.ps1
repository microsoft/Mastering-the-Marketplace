install-windowsfeature -Name Web-Server -IncludeManagementTools

Set-Location -Path c:\inetpub\wwwroot

Add-Content iisstart.htm `
	"<H1><center>Welcome to your Server for the Virtual Machine Offers Workshop! It works!</center></H1>"

Invoke-command -ScriptBlock{iisreset}