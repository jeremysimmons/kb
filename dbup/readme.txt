https://github.com/bradymholt/dbup-sqlserver-scripting

    static int Main(string[] args)
    {
        var connectionString = "Server=(localdb)\\v11.0;Integrated Security=true;AttachDbFileName=C:\\Users\\johndoe\\DbUpTest.mdf;";
        var upgrader =
            DeployChanges.To
                .SqlDatabase(connectionString)
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .LogToConsole()
                .Build();

        //var result = upgrader.PerformUpgrade(); //Don't do this!  Do the following instead.

        ScriptingUpgrader upgradeScriptingEngine = new ScriptingUpgrader(connectionString, upgrader);
        var result = upgradeScriptingEngine.Run(args);

        if (!result.Successful)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(result.Error);
            Console.ResetColor();
            return -1;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Success!");
        Console.ResetColor();
        return 0;
    }

New-Migration
Start-Migrations
Start-DatabaseScript