Create extensions for the code generation tool
https://msdn.microsoft.com/en-us/library/hh547384.aspx

CrmSvcUtil.exe /url:https://dccsandbox.crm.dynamics.com/XRMServices/2011/Organization.svc /out:MyOrganizationCrmSdkTypes.cs /username:crmdeveloper@davidccook.com /password:CRM$D3v3l0p3r!

filter.xml
<filter>
  <entities>
    <entity>contact</entity>
    <entity>incident</entity>
    <entity>incidentresolution</entity>
    <entity>annotation</entity>
    <entity>systemuser</entity>
    <entity>systemuserroles</entity>
    <entity>role</entity>
    <entity>opportunity</entity>
    <entity>workflow</entity>
    <entity>processstage</entity>
  </entities>
</filter>
The command
CrmSvcUtil.exe /out:Dyn365Apps_Xrm_Classes.cs /namespace:"Dyn365Apps.Xrm" /serviceContextName:XrmServiceContext /codewriterfilter:"Microsoft.Crm.Sdk.Samples.BasicFilteringService, CrmSvcUtilExtensions" /url:https://dccsandbox.crm.dynamics.com/XRMServices/2011/Organization.svc /username:crmdeveloper@davidccook.com /password:CRM$D3v3l0p3r!