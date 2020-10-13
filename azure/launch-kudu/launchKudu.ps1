$XmlDocument = [xml](Get-Content -Path $args[0]);
$publishProfile = $XmlDocument.SelectSingleNode("/publishData/publishProfile[@publishMethod='MSDeploy']");
$publishUrl = $publishProfile.Attributes['publishUrl'].Value
$userName = $publishProfile.Attributes['userName'].Value
$userPWD = $publishProfile.Attributes['userPWD'].Value
Start-Process -FilePath "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe" -ArgumentList "--incognito `"https://$($userName):$($userPWD)@$($publishUrl)/basicauth`"" -WindowStyle Hidden
