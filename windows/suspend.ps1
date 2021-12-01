#https://superuser.com/questions/39584/what-is-the-command-to-use-to-put-your-computer-to-sleep-not-hibernate
Add-Type -Assembly System.Windows.Forms
[System.Windows.Forms.Application]::SetSuspendState("Suspend", $false, $true)
