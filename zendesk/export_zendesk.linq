<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Core.dll</Reference>
  <NuGetReference>CsvHelper</NuGetReference>
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>System.Dynamic</Namespace>
  <Namespace>CsvHelper</Namespace>
</Query>

void Main()
{
	CreateUsers(@"C:\kb\zendesk\export\users.json", @"C:\temp\users.csv");
	CreateTickets(@"C:\kb\zendesk\export\tickets.json", @"C:\temp\tickets.csv");
	CreateTicketComments(@"C:\kb\zendesk\export\tickets.json", @"C:\temp\ticket_comments.csv");
}

void CreateUsers(string input, string output)
{
	string[] lines = File.ReadAllLines(input);
	using (StreamWriter textWriter = File.CreateText(output))
	using (var csv = new CsvWriter(textWriter))
	{
		foreach (string line in lines)
		{
			var obj = JObject.Parse(line);
			dynamic row = new ExpandoObject();
			PushValues(obj, row);
			csv.WriteRecord(row);
			csv.NextRecord();
		}
		csv.Flush();
	}
}
void CreateTickets(string input, string output)
{
	string line;
	using (StreamWriter textWriter = File.CreateText(output))
	using (var csv = new CsvWriter(textWriter))
	using (FileStream stream = File.OpenRead(input))
	using (var reader = new StreamReader(stream))
	{
		while ((line = reader.ReadLine()) != null)
		{
			var obj = JObject.Parse(line);
			dynamic row = new ExpandoObject();
			PushValues(obj, row);
			csv.WriteRecord(row);
			csv.NextRecord();
		}
		csv.Flush();
	}
}
void CreateTicketComments(string input, string output)
{
	string line;
	using (StreamWriter textWriter = File.CreateText(output))
	using (var csv = new CsvWriter(textWriter))
	using (FileStream stream = File.OpenRead(input))
	using (var reader = new StreamReader(stream))
	{
		while ((line = reader.ReadLine()) != null)
		{
			var obj = JObject.Parse(line);
			dynamic row = new ExpandoObject();

			AddValue(row, "url", obj.Value<string>("url"));
			JArray arr = obj.Value<JArray>("comments");
			foreach (JObject comment in arr.Children<JObject>())
				PushValues(comment, row);

			csv.WriteRecord(row);
			csv.NextRecord();
		}
		csv.Flush();
	}
}
void PushValues(JObject obj, IDictionary<string, object> container)
{
	foreach (var element in obj)
	{
		string propertyName = element.Key;
		JToken token = element.Value;
		JTokenType type = token.Type;
		if (type == JTokenType.Object)
		{
			PushValues((JObject)token, container);
		}
		else if (type == JTokenType.Array)
		{
			PushValues((JArray)token, container);
		}
		else
		{
			var buffer = new StringBuilder(element.Value.ToString());
			buffer.Replace(Environment.NewLine, "\\n");
			buffer.Replace("\n", "\\n");
			container[Name(token)] = buffer.ToString();
		}
	}
}
void PushValues(JArray arr, IDictionary<string, object> container)
{
	if (Name(arr) == "comments") return;
	if (arr.Children().All(c => c.Type == JTokenType.String))
		container[Name(arr)] = String.Join(",", arr.Values<string>());
}
string Name(JToken token)
{
	return Regex.Replace(token.Path.Replace(".", "_"), @"\[\d+\]", "");
}
void AddValue(IDictionary<string, object> container, string key, object value)
{
	container[key] = value.ToString();
}