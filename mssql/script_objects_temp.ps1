function global:Script-AnObject([string]$dbname, [string]$server, [string]$objname){
    [System.Reflection.Assembly]::LoadWithPartialName("Microsoft.SqlServer.SMO") | out-null
    $SMOserver = New-Object ('Microsoft.SqlServer.Management.Smo.Server') -argumentlist $server

    $db = $SMOserver.databases[$dbname]
    $Objects = $db.Tables
    $Objects += $db.Views
    $Objects += $db.StoredProcedures
    $Objects += $db.UserDefinedFunctions

    foreach ($ScriptThis in $Objects | where {!($_.IsSystemObject) -and $_.Name -eq "$objname"}) {
        $scriptr = new-object ('Microsoft.SqlServer.Management.Smo.Scripter') ($SMOserver)
        $scriptr.Options.AppendToFile = $False
        $scriptr.Options.AllowSystemObjects = $False
        $scriptr.Options.ClusteredIndexes = $True
        $scriptr.Options.DriAll = $True
        $scriptr.Options.ScriptDrops = $False
        $scriptr.Options.IncludeHeaders = $True
        $scriptr.Options.ToFileOnly = $True
        $scriptr.Options.Indexes = $True
        $scriptr.Options.WithDependencies = $True
        $ScriptFile = $ScriptThis -replace "\[|\]"
        $scriptr.Options.FileName = "C:\TEMP\Databases\" + $($dbname) + "\" + $($ScriptFile) + ".SQL"
        $scriptr.Script($ScriptThis)
    }
}