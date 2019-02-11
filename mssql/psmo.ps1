################################################################################################################################
#
# Script Name : SmoDb
# Version     : 1.0
# Author      : Vince Panuccio
# Purpose     :
#			  This script generates one SQL script per database object including Stored Procedures,Tables,Views, 
#			  User Defined Functions and User Defined Table Types. Useful for versionining a databsae in a CVS.
#
# Usage       : 
#			  Set variables at the top of the script then execute.
#
# Note        :
#			  Only tested on SQL Server 2008r2
#                 
################################################################################################################################
$watch = [System.Diagnostics.Stopwatch]::StartNew()
Write-Host "Started at" (Get-Date)
$dev                = "GOGDEVSQLAPP14.hammer.local"
$qa                 = "USHM1QABSQL01.hammer.local\App"
$server 		    = $dev
$database 		    = "Premiere"
$username           = "hammerDev"
$password           = "H@mm3rD"
$output_path 		= "C:\dev\Schema\$($server -Replace "\\", "_")\$database"

$schema             = "dbo"
$table_path 		= "$output_path\Table\"
$storedProcs_path 	= "$output_path\StoredProcedure\"
$triggers_path 		= "$output_path\Triggers\"
$views_path 		= "$output_path\View\"
$udfs_path          = "$output_path\UserDefinedFunction\"
$textCatalog_path 	= "$output_path\FullTextCatalog\"
$udtts_path 		= "$output_path\UserDefinedTableTypes\"

[System.Reflection.Assembly]::LoadWithPartialName("Microsoft.SqlServer.SMO") | out-null
[System.Reflection.Assembly]::LoadWithPartialName("Microsoft.SqlServer.ConnectionInfo") | out-null

$srvconn    = New-Object ("Microsoft.SqlServer.Management.Common.ServerConnection") $server
$srvconn.LoginSecure = $false
$srvconn.Login = $username
$srvconn.Password = $password
$srv        = New-Object -TypeName "Microsoft.SqlServer.Management.SMO.Server" -ArgumentList $srvconn
$db         = New-Object -TypeName "Microsoft.SqlServer.Management.SMO.Database"
$scripter   = New-Object -TypeName "Microsoft.SqlServer.Management.SMO.Scripter" -ArgumentList $srv

# Get the database and table objects
$db = $srv.Databases[$database]

# todo, split this into multiple jobs
#$tbl            = $db.Tables | Where-object { $_.schema -eq $schema  -and -not $_.IsSystemObject } 
$storedProcs    = $db.StoredProcedures | Where-object { $_.schema -eq $schema -and -not $_.IsSystemObject -and $_.name -eq "AbmBulkProvisioningQueue_ProtonInsertBulkFromTempTable" } 
#$triggers       = $db.Triggers + ($tbl | % { $_.Triggers })
#$views          = $db.Views | Where-object { $_.schema -eq $schema } 
#$udfs		 	= $db.UserDefinedFunctions | Where-object { $_.schema -eq $schema -and -not $_.IsSystemObject } 
#$catlog		 	= $db.FullTextCatalogs
#$udtts		 	= $db.UserDefinedTableTypes | Where-object { $_.schema -eq $schema }
	
# Set scripter options to ensure only data is scripted
$scripter.Options.ScriptSchema 	= $true;
$scripter.Options.ScriptData 	= $false;

#Exclude GOs after every line
$scripter.Options.NoCommandTerminator 	= $false;
$scripter.Options.ToFileOnly 			= $true
$scripter.Options.AllowSystemObjects 	= $false
$scripter.Options.Permissions 			= $true
$scripter.Options.DriAllConstraints 	= $true
$scripter.Options.SchemaQualify 		= $true
$scripter.Options.AnsiFile 				= $true

$scripter.Options.SchemaQualifyForeignKeysReferences = $true

$scripter.Options.Indexes               = $true
$scripter.Options.DriIndexes            = $true
$scripter.Options.DriClustered          = $true
$scripter.Options.DriNonClustered       = $true
$scripter.Options.NonClusteredIndexes   = $true
$scripter.Options.ClusteredIndexes      = $true
$scripter.Options.FullTextIndexes       = $true

$scripter.Options.EnforceScriptingOptions = $true

function CopyObjectsToFiles($objects, $outDir) {
	
	if (-not (Test-Path $outDir)) {
		[System.IO.Directory]::CreateDirectory($outDir)
	}

	ForEach ($o in $objects) {
	
            $schemaPrefix = ""
		    	
		    if ($o.Schema -ne $null -and $o.Schema -ne "") {
			    $schemaPrefix = $o.Schema + "."
		    }
			$scripter.Options.FileName = $outDir + $schemaPrefix + $o.Name + ".sql"
			Write-Host "Writing " $scripter.Options.FileName
			$scripter.EnumScript($o)
	}
}



# Output the scripts
#CopyObjectsToFiles $tbl $table_path
CopyObjectsToFiles $storedProcs $storedProcs_path
#CopyObjectsToFiles $triggers $triggers_path
#CopyObjectsToFiles $views $views_path
#CopyObjectsToFiles $catlog $textCatalog_path
#CopyObjectsToFiles $udtts $udtts_path
#CopyObjectsToFiles $udfs $udfs_path
Write-Host "Finished at" (Get-Date)
$watch.Stop()
Write-Host $watch.Elapsed