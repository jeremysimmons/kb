<Query Kind="Statements">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
</Query>

JsonTextReader reader = new JsonTextReader(File.OpenText(@"C:\Users\jeremy.simmons\Desktop\disciplr\example-lesson-with-materials.json"));
while (reader.Read())
{
	if (reader.Value != null)
	{
		Console.WriteLine(reader.Path);
		if (reader.Path.EndsWith("composition-template"))
		{
			Console.WriteLine(reader.Value);
		}
	}
	//        Console.WriteLine("Token: {0}, Value: {1}, Path: {2}", reader.TokenType, reader.Value, reader.Path);
}