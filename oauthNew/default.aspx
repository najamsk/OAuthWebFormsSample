<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="oauthNew._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ListView runat="server" ID="providerDetails" ItemType="Microsoft.AspNet.Membership.OpenAuth.ProviderDetails"
             SelectMethod="GetProviderNames" ViewStateMode="Disabled">
             <ItemTemplate>
                 <button type="submit" name="provider" value="<%#: Item.ProviderName %>"
                     title="Log in using your <%#: Item.ProviderDisplayName %> account.">
                     <%#: Item.ProviderDisplayName %>
                 </button>
             </ItemTemplate>
             <EmptyDataTemplate>
                 <p>There are no external authentication services configured. </p>
             </EmptyDataTemplate>
         </asp:ListView>
    </div>
    </form>
</body>
</html>
