<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    主页
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        若要了解作者的更多信息，请访问 <a href="http://www.baidu.com" title="baidu 网站">http://www.baidu.com</a>搜索Wu Zhenquan。
    </p>
</asp:Content>
