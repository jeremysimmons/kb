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
	//	string blah = @"{""id"":460179999,""url"":""https://disciplr.zendesk.com/api/v2/users/460179999.json"",""name"":""Paul Parson"",""email"":""paul@disciplr.com"",""created_at"":""2015-01-14T16:18:49.000Z"",""updated_at"":""2016-12-16T23:29:46.000Z"",""time_zone"":""Mountain Time (US \u0026 Canada)"",""phone"":null,""shared_phone_number"":null,""photo"":null,""locale_id"":1,""locale"":""en-US"",""role"":""end-user"",""verified"":true,""external_id"":""auth0|556c7124469e01537c4c8837"",""tags"":[],""alias"":"""",""active"":true,""shared"":false,""shared_agent"":false,""last_login_at"":""2016-12-16T23:29:46.000Z"",""two_factor_auth_enabled"":false,""signature"":"""",""details"":"""",""notes"":"""",""role_type"":null,""custom_role_id"":null,""moderator"":false,""ticket_restriction"":""requested"",""only_private_comments"":false,""restricted_agent"":true,""suspended"":false,""chat_only"":false,""default_group_id"":null,""user_fields"":{""system::embeddable_last_seen"":""2016-01-18T00:00:00+00:00"",""system::last_nps_survey_date"":null,""system::nps_comment"":null,""system::nps_rating"":null},""abilities"":{""url"":""https://disciplr.zendesk.com/api/v2/users/460179999.json"",""user_id"":460179999,""can_edit"":true,""can_edit_password"":true,""can_manage_identities_of"":true,""can_verify_identities"":true,""can_reset_password"":true,""can_set_password"":true,""can_create_password"":true,""can_change_password"":true,""can_set_alias"":true,""can_send_verification_email"":true,""can_verify_now"":true,""can_make_comment_private"":true,""can_edit_agent_forwarding"":true,""can_modify_user_tags"":true,""can_assume"":true,""can_delete"":true,""can_view_views"":false,""can_view_reports"":true,""can_export"":true,""can_use_voice_console"":false,""can_use_voice"":false,""can_view_voice_dashboard"":false},""organization"":{""url"":""https://disciplr.zendesk.com/api/v2/organizations/35022629.json"",""id"":35022629,""name"":""Disciplr"",""shared_tickets"":false,""shared_comments"":false,""external_id"":null,""created_at"":""2015-01-14T16:18:48.000Z"",""updated_at"":""2015-01-14T16:18:48.000Z"",""domain_names"":[],""details"":null,""notes"":null,""group_id"":null,""tags"":[],""organization_fields"":{}}}";
	StreamWriter textWriter = File.CreateText(@"C:\temp\comments.csv");
	var csv = new CsvWriter(textWriter);
	//		string[] lines = File.ReadAllLines(@"C:\kb\zendesk\export\users.json");
	string line;
	FileStream stream = File.OpenRead(@"C:\kb\zendesk\export\tickets.json");
	using (var reader = new StreamReader(stream))
	//	foreach (string line in lines)
	{
		while ((line = reader.ReadLine()) != null)
		{
			var obj = JObject.Parse(line);
			dynamic row = new ExpandoObject();
			
			AddValue(row, "url", obj.Value<string>("url"));
			JArray arr = obj.Value<JArray>("comments");
			foreach (JObject element in arr.Children<JObject>())
			{
				PushValues(element, row);
			}
			csv.WriteRecord(row);
			csv.NextRecord();
		}
	}
	csv.Flush();
	textWriter.Close();
}

// Define other methods and classes here
void PushValues(JObject obj, IDictionary<string, object> container)
{
	foreach (var element in obj)
	{
		string propertyName = element.Key;
		JToken token = element.Value;
		JTokenType type = token.Type;
		if (type == JTokenType.Object)
			PushValues((JObject)token, container);
		else if (type == JTokenType.Array)
			PushValues((JArray)token, container);
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
	if(Name(arr) == "comments") return;
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