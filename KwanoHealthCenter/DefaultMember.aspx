<%@ Page Title="" Language="C#" MasterPageFile="~/MemberIndex.Master" AutoEventWireup="true" CodeBehind="DefaultMember.aspx.cs" Inherits="KwanoHealthCenter.DefaultMember" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <header>
        <div id="nav" style="background-color:#3badf5; height: 95px; background-color: #3badf5; height: 175px; width: 100%; background-size: cover; background-repeat: no-repeat; background-position: 50% 50%;" class="transNav">
         <div class="text-center">
                                <img src="/Assets/healthLogo2.png"  width="95" height="74" />
                                <h2 style="color:white; margin-top: 15px;">Main Member Home</h2>
                                <br/>
         </div>
     </div>
    </header>
    <div class="container pt-5">
         
        <div class="jumbotron">
            <div class="text-xl-center">
                <h1>
                    <script>  
                        var welcome;
                        var date = new Date();
                        var hour = date.getHours();
                        var minute = date.getMinutes();
                        var second = date.getSeconds();
                        if (minute < 10) {
                            minute = "0" + minute;
                        }
                        if (second < 10) {
                            second = "0" + second;
                        }
                        if (hour < 12) {
                            welcome = "Good Morning";
                        } else if (hour < 17) {
                            welcome = "Good Afternoon";
                        } else {
                            welcome = "Good Evening";
                        }
                        document.write(welcome);
                                            
                    </script>
                </h1>
                <span>
                    <asp:Label ID="Name" runat="server"></asp:Label>
                </span>
           </div>
        </div>
    </div>
</asp:Content>
