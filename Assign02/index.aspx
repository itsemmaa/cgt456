<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Assign02.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #container {
            background-color: #ccffff;
            width: 800px;
            height: 600px;
        }
        #Label1 {
            position: absolute;
            top: 55px;
            left: 333px;
            font-size: 20pt;
        }
        #Label2 {
            position: absolute;
            font-size: 14pt;
            top: 100px;
            left: 241px;
        }
        #HyperLink1 {
            position: absolute;
            top: 67px;
            left: 604px;
        }
        #lblfName {
            position: absolute;
            top: 207px;
            left: 197px;
        }
        #lbllName {
            position: absolute;
            top: 272px;
            left: 200px;
        }
        #lblcity {
            position: absolute;
            top: 333px;
            left: 280px;
        }
        #lblState {
            position: absolute;
            top: 393px;
            left: 267px;
            margin-bottom: 2px;
        }
        #lblzip {
            position: absolute;
            top: 453px;
            left: 284px;
        }
        #fName {
            position: absolute;
            top: 205px;
            left: 365px;
        }
        #lName {
           position: absolute;
           top: 267px;
           left: 365px;
        }
        #city {
           position: absolute;
           top: 323px;
           left: 365px;
        }
        #state {
            position: absolute;
            top: 389px;
            left: 365px;
        }
        #zip {
           position: absolute;
           top: 450px;
           left: 365px;
        }
        #Button1 {
            position: absolute;
            top: 528px;
            left: 390px;
        }
        #myName {
            position: absolute;
            top: 30px;
            left: 635px;
        }
        #results {
            position: absolute;
            width: 400px;
            height: 300px;
            background-color: #ffffff;
            top: 180px;
            left: 195px;
            display: none;
        }

    </style>
</head>
<body>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/table.aspx">Link to Index</asp:HyperLink>

    <form id="form1" runat="server">
        <div id="container">
            <asp:Label ID="Label1" runat="server" Text="Assign02" Font-Bold="true" Font-Size="30px"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="IDE Usage and Intro"></asp:Label>

            <asp:Label ID="lblfName" runat="server" Text="First Name:"></asp:Label>
            <asp:Label ID="lbllName" runat="server" Text="Last Name:"></asp:Label>
            <asp:Label ID="lblcity" runat="server" Text="City:"></asp:Label>
            <asp:Label ID="lblzip" runat="server" Text="Zip:"></asp:Label>

            <asp:TextBox ID="fName" runat="server" Width="195px"></asp:TextBox>
            <asp:TextBox ID="lName" runat="server" Width="195px"></asp:TextBox>
            <asp:TextBox ID="city" runat="server" Width="195px"></asp:TextBox>
            <asp:TextBox ID="zip" runat="server" Width="195px"></asp:TextBox>

            <asp:Label ID="lblState" runat="server" Text="State: "></asp:Label>
            <asp:DropDownList ID="state" runat="server">
                <asp:ListItem Value="--" Text="None - not in U.S."></asp:ListItem>
                <asp:ListItem Value="AL" Text="Alabama"></asp:ListItem>
                <asp:ListItem Value="AK" Text="Alaska"></asp:ListItem>
                <asp:ListItem Value="AS" Text="American Samoa"></asp:ListItem>
                <asp:ListItem Value="AZ" Text="Arizona"></asp:ListItem>
                <asp:ListItem Value="AR" Text="Arkansas"></asp:ListItem>
                <asp:ListItem Value="CA" Text="California"></asp:ListItem>
                <asp:ListItem Value="CO" Text="Colorado"></asp:ListItem>
                <asp:ListItem Value="CT" Text="Connecticut"></asp:ListItem>
                <asp:ListItem Value="DE" Text="Delaware"></asp:ListItem>
                <asp:ListItem Value="DC" Text="District of Columbia"></asp:ListItem>
                <asp:ListItem Value="FM" Text="Federated States of Micronesia"></asp:ListItem>
                <asp:ListItem Value="FL" Text="Florida"></asp:ListItem>
                <asp:ListItem Value="GA" Text="Georgia"></asp:ListItem>
                <asp:ListItem Value="GU" Text="Guam"></asp:ListItem>
                <asp:ListItem Value="HI" Text="Hawaii"></asp:ListItem>
                <asp:ListItem Value="ID" Text="Idaho"></asp:ListItem>
                <asp:ListItem Value="IL" Text="Illinois"></asp:ListItem>
                <asp:ListItem Value="IN" Text="Indiana"></asp:ListItem>
                <asp:ListItem Value="IA" Text="Iowa"></asp:ListItem>
                <asp:ListItem Value="KS" Text="Kansas"></asp:ListItem>
                <asp:ListItem Value="KY" Text="Kentucky"></asp:ListItem>
                <asp:ListItem Value="LA" Text="Louisiana"></asp:ListItem>
                <asp:ListItem Value="ME" Text="Maine"></asp:ListItem>
                <asp:ListItem Value="MH" Text="Marshall Islands"></asp:ListItem>
                <asp:ListItem Value="MD" Text="Maryland"></asp:ListItem>
                <asp:ListItem Value="MA" Text="Massachusetts"></asp:ListItem>
                <asp:ListItem Value="MI" Text="Michigan"></asp:ListItem>
                <asp:ListItem Value="MN" Text="Minnesota"></asp:ListItem>
                <asp:ListItem Value="MS" Text="Mississippi"></asp:ListItem>
                <asp:ListItem Value="MO" Text="Missouri"></asp:ListItem>
                <asp:ListItem Value="MT" Text="Montana"></asp:ListItem>
                <asp:ListItem Value="NE" Text="Nebraska"></asp:ListItem>
                <asp:ListItem Value="NV" Text="Nevada"></asp:ListItem>
                <asp:ListItem Value="NH" Text="New Hampshire"></asp:ListItem>
                <asp:ListItem Value="NJ" Text="New Jersey"></asp:ListItem>
                <asp:ListItem Value="NM" Text="New Mexico"></asp:ListItem>
                <asp:ListItem Value="NY" Text="New York"></asp:ListItem>
                <asp:ListItem Value="NC" Text="North Carolina"></asp:ListItem>
                <asp:ListItem Value="ND" Text="North Dakota"></asp:ListItem>
                <asp:ListItem Value="MP" Text="Northern Mariana Islands"></asp:ListItem>
                <asp:ListItem Value="OH" Text="Ohio"></asp:ListItem>
                <asp:ListItem Value="OK" Text="Oklahoma"></asp:ListItem>
                <asp:ListItem Value="OR" Text="Oregon"></asp:ListItem>
                <asp:ListItem Value="PW" Text="Palau"></asp:ListItem>
                <asp:ListItem Value="PA" Text="Pennsylvania"></asp:ListItem>
                <asp:ListItem Value="PR" Text="Puerto Rico"></asp:ListItem>
                <asp:ListItem Value="RI" Text="Rhode Island"></asp:ListItem>
                <asp:ListItem Value="SC" Text="South Carolina"></asp:ListItem>
                <asp:ListItem Value="SD" Text="South Dakota"></asp:ListItem>
                <asp:ListItem Value="TN" Text="Tennessee"></asp:ListItem>
                <asp:ListItem Value="TX" Text="Texas"></asp:ListItem>
                <asp:ListItem Value="UT" Text="Utah"></asp:ListItem>
                <asp:ListItem Value="VT" Text="Vermont"></asp:ListItem>
                <asp:ListItem Value="VI" Text="Virgin Islands"></asp:ListItem>
                <asp:ListItem Value="VA" Text="Virginia"></asp:ListItem>
                <asp:ListItem Value="WA" Text="Washington"></asp:ListItem>
                <asp:ListItem Value="WV" Text="West Virginia"></asp:ListItem>
                <asp:ListItem Value="WI" Text="Wisconsin"></asp:ListItem>
                <asp:ListItem Value="WY" Text="Wyoming"></asp:ListItem>
            </asp:DropDownList>
                




            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />

            <asp:Label ID="myName" runat="server" Text="Label"></asp:Label>

            <asp:Label ID="results" runat="server" Text="Label"></asp:Label>

        </div>
    </form>

</body>
</html>
