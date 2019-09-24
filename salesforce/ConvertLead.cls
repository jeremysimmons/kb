// https://stackoverflow.com/questions/19663119/is-there-any-rest-service-available-in-salesforce-to-convert-leads-into-accounts
@RestResource(urlMapping='/Lead/*')
global with sharing class RestLeadConvert {            

    @HttpGet
    global static String doGet() {
        String ret = 'fail';
        RestRequest req = RestContext.request;
        RestResponse res = RestContext.response;
        String leadId = req.requestURI.substring(req.requestURI.lastIndexOf('/')+1);              
        Database.LeadConvert lc = new Database.LeadConvert();
        lc.setLeadId(leadId);

        LeadStatus convertStatus = [SELECT Id, MasterLabel FROM LeadStatus WHERE IsConverted=true LIMIT 1];
        lc.setConvertedStatus(convertStatus.MasterLabel);
        Database.LeadConvertResult lcr ;
        try{
            lcr = Database.convertLead(lc);
            system.debug('*****lcr.isSuccess()'+lcr.isSuccess());
            ret = 'ok';
        }
        catch(exception ex){
            system.debug('***NOT CONVERTED**');
        }
        return ret;
    }
}

@isTest
public class RestLeadConvertTest{

    static testMethod void testHttpGet() {
        Lead l = new Lead();
        l.FirstName = 'First';
        l.LastName = 'Last';
        insert l;

        Test.startTest();
        RestRequest req = new RestRequest();
        RestResponse res = new RestResponse();
        req.requestURI = '/Lead/' + l.Id;
        req.httpMethod = 'GET';
        RestContext.request = req;
        RestContext.response= res;
        RestLeadConvert.doGet();
        Test.stopTest();
    }
}