<%@ WebHandler Language="C#" Class="showImage" %>

using System;
using System.Web;
/*啟用讀取、寫入Session*/
using System.Web.SessionState;

public class showImage : IHttpHandler,IRequiresSessionState {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        if (context.Session["myFile"]!=null)
        {
            HttpPostedFile myFile = (HttpPostedFile)context.Session["myFile"];
            int nFileLen = myFile.ContentLength;
            // Allocate a buffer for reading of the file

            byte[] myData = new byte[nFileLen];
            myFile.InputStream.Read(myData, 0, nFileLen);
            context.Response.Clear();
            context.Response.ContentType = "image/jpeg";
            context.Response.BinaryWrite(myData);
        }
       
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}