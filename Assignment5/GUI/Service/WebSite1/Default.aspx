<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

 

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    
 

</head>
<body>
    <form id="Form1" runat="server"  >
     
    <h2>register challange </h2>
    <p>Input the user name and passward to sign in, if the system don't exist the user, it will sucess, otherwise fail</p>
    <p>wsdl: http://10.0.2.137/DataMangement/Service.svc?wsdl</p>
    <p>Svc: http://10.0.2.137/DataMangement/Service.svc</p>
      <asp:Label Text ="Input user name" runat="server" ID="username" />

      <asp:TextBox Text="" runat="server" ID="nam" />
      <asp:Label Text ="Input passward " runat="server" ID="passward" />
       <asp:TextBox Text="" runat="server" ID="pw" />

      
    <asp:Button Text="Click" ID="btn_Go" UseSubmitBehavior="false" runat="server" 
        onclick="btn_Go_Click" />
        <asp:Label Text="" runat="server" ID="ret"></asp:Label>
     
      <h2>login in challange</h2>
    <p>Input the user name and passward to login in , if the passward is right, it will sucess, otherwise fail</p>
        <p>wsdl:http://10.0.2.137/DataMangement/Service.svc?wsdl </p>
    <p>Svc: http://10.0.2.137/DataMangement/Service.svc </p>
      <asp:Label Text ="Input user name" runat="server" ID="Label1" />

      <asp:TextBox Text="" runat="server" ID="TextBox1" />
      <asp:Label Text ="Input passward " runat="server" ID="Label2" />
       <asp:TextBox Text="" runat="server" ID="TextBox2" />

      
    <asp:Button Text="Click" ID="Button1" UseSubmitBehavior="false" runat="server" 
        onclick="btn" />
        <asp:Label Text="" runat="server" ID="Label3"></asp:Label>

        <h2>save data challange</h2>
    <p>the users can save their data. In next time, they can read their data.</p>
        <p>wsdl:http://10.0.2.137/DataMangement/Service.svc?wsdl</p>
    <p>Svc: http://10.0.2.137/DataMangement/Service.svc</p>
      <asp:Label Text ="Input the data to save  " runat="server" ID="Label4" />

      <asp:TextBox Text="" runat="server" ID="TextBox3" />


      
    <asp:Button Text="Click" ID="Button2" UseSubmitBehavior="false" runat="server" 
        onclick="btn2" />
        <asp:Label Text="" runat="server" ID="Label6"></asp:Label>
                
                <h2>get data challange</h2>
    <p>the users can get their data stored in the last time action.</p>
    <p>wsdl: http://10.0.2.137/DataMangement/Service.svc?wsdl.</p>
      
    <p>Svc:http://10.0.2.137/DataMangement/Service.svc</p>
      <asp:Label Text ="Input the data to save  " runat="server" ID="Label5" />

      


      
    <asp:Button Text="Click" ID="Button3" UseSubmitBehavior="false" runat="server" 
        onclick="btn3" />
        <asp:Label Text="" runat="server" ID="Label7"></asp:Label>
     
     <h2>Encoding  </h2>
     <p>wsdl:http://10.0.2.137/Encoding/Service.svc?wsdl</p>
      <p>Svc:http://10.0.2.137/Encoding/Service.svc</p>
    <p>Encoding the passward.</p>
      <asp:Label Text ="Input the data to encoding  " runat="server" ID="Label8" />
      
      <asp:TextBox Text="" runat="server" ID="TextBox5" 
        />
      


      
    <asp:Button Text="Click" ID="Button4" UseSubmitBehavior="false" runat="server" 
        onclick="btn4" />
        <asp:Label Text="" runat="server" ID="Label9"></asp:Label>

         <h2>decoding  </h2>
    <p>decoding the passward.</p>
        <p>wsdl: http://10.0.2.137/decoding/Service.svc?wsdl</p>
      <p>Svc:http://10.0.2.137/decoding/Service.svc</p>
      <asp:Label Text ="Input the data to encoding  " runat="server" ID="Label10" />
      
      <asp:TextBox Text="" runat="server" ID="TextBox14"  />
      


      
    <asp:Button Text="Click" ID="Button5" UseSubmitBehavior="false" runat="server" 
        onclick="btn5" />
        <asp:Label Text="" runat="server" ID="Label11"></asp:Label>

        <h2>. Stemming </h2>
    <p>require service 3.</p>
            <p>wsdl:http://10.0.2.137/stemservice/Service.svc?wsdl</p>
      <p>Svc:http://10.0.2.137/stemservice/Service.svc</p>
      <asp:Label Text ="Input the word " runat="server" ID="Label12" />
      
      <asp:TextBox Text="" runat="server" ID="TextBox4"  />   
    <asp:Button Text="Click" ID="Button6" UseSubmitBehavior="false" runat="server" 
        onclick="btn6" />
        <asp:Label Text="" runat="server" ID="Label13"></asp:Label>
       

        <h2>. weather information </h2>
    <p>require service 13.</p>
    <p>wsdl:http://10.0.2.137/weather(require13)/Service.svc?wsdl</p>
      <p>Svc:http://10.0.2.137/weather(require13)/Service.svc</p>
      <asp:Label Text ="Input the zip " runat="server" ID="Label14" />
      
      <asp:TextBox Text="" runat="server" ID="TextBox6"  />
      


      
    <asp:Button Text="Click" ID="Button7" UseSubmitBehavior="false" runat="server" 
        onclick="btn7" />
        <asp:Label Text="" runat="server" ID="Label15"></asp:Label>
    </form>
</body>
</html>