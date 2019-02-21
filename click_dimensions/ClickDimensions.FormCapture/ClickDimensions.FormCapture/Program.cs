using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace ClickDimensions.FormCapture
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * This sample demonstrates form capture data submission to ClickDimensions.
             * Before executing the example, please change the parameters:
             * 1) formCaptureUrl: should be taken from the form capture record
             * 2) referer: should be a valis tracking domain
             * 3) visitorKey: should be taken from a cookie on the visitor browser by using javascript. The cookie name is cuvid and here is how to read a cookie value using http://www.w3schools.com/JS/js_cookies.asp
             * 4) postData: the data that should be posted together with the visitor key value
             */
            string formCaptureUrl = "http://analytics.clickdimensions.com/forms/h/ajjlBiT7rq0yR5QuELq6km";
            string referer = "http://clickdimensionsdemo.com";
            string visitorKey = "v2294610734264_71186AF55E674FE78A5CEEF96E0FB1A2";
            string postData = string.Format("txtFormEmail=someone@example.com&cd_visitorkey={0}",visitorKey);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(formCaptureUrl);
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // set referer
            request.Referer = referer;
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();

            Console.Read();
        }
    }
}
