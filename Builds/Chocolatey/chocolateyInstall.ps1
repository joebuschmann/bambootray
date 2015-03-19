$scriptDir = $(Split-Path -parent $MyInvocation.MyCommand.Definition)

Install-ChocolateyDesktopLink "$scriptDir\BambooTray.exe"