http://ashfordsoftware.com/hello-rhino-etl/

using System.Configuration;
using HelloRhinoETL.Operations;
using Rhino.Etl.Core;
using Rhino.Etl.Core.Operations;

namespace HelloRhinoETL
{
    [DelimitedRecord(","), IgnoreFirst]
    public class EmployeeInputRecord
    {
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForRead)]
        public string Name;
        public string LastName { get { return Name.Split(',')[0].Substring(0, Math.Min(Name.Split(',')[0].Length, 20)); } }
        public string FirstName { get { return Name.Split(',')[1].Split(' ')[0].Substring(0, Math.Min(Name.Split(',')[1].Split(' ')[0].Length, 10)); } }
        public string JobTitle;
        public string Title { get { return JobTitle.Substring(0, Math.Min(JobTitle.Length, 30)); } }
        public string AgencyId;
        public string Agency;
        public string HireDate;
        public string AnnualSalary;
        public string GrossPay;
    }
public class EmployeeRead : AbstractOperation
    {
        private readonly string _filePath = string.Empty;
  
        public EmployeeRead(string filePath)
        {
            _filePath = filePath;
        }
  
        public override IEnumerable<Row> Execute(IEnumerable<Row> rows)
        {
            using (var file = FluentFile.For<EmployeeInputRecord>().From(_filePath))
            {
                foreach (var obj in file)
                {
                    yield return Row.FromObject(obj);
                }
            }
        }
    }
}

public class EmployeeWriteToDB : SqlBulkInsertOperation
    {
        public EmployeeWriteToDB(string connectionStringName, string targetTable) : base(connectionStringName, targetTable)
        {
        }
  
  
        protected override void PrepareSchema()
        {
            Schema["FirstName"] = typeof(string);
            Schema["LastName"] = typeof(string);
            Schema["Title"] = typeof(string);
        }
  
        protected override void onSqlRowsCopied(object sender, SqlRowsCopiedEventArgs e)
        {
            base.onSqlRowsCopied(sender, e);
        }
    }

    public class MainProcess : EtlProcess
    {
        protected override void Initialize()
        {
            Register(new EmployeeRead(ConfigurationManager.AppSettings["InputFilePath"]));
            Register(new BranchingOperation().Add(new EmployeeWriteToDB("NorthWindConnection", "Employees")));
        }
  
        protected override void PostProcessing()
        {
            base.PostProcessing();
  
            foreach (var error in GetAllErrors())
            {
                throw error;
            }
        }
    }
}