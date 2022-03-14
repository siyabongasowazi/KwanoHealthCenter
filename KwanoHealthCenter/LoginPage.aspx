<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="KwanoHealthCenter.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
     Kwano Health-Center | Login
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <header>
        <div id="nav" style="background-color:#0f4166; height: 95px; background-color: #0f4166; height: 175px; width: 100%; background-size: cover; background-repeat: no-repeat; background-position: 50% 50%;" class="transNav">
         <div class="text-center">
                                <img src="/Assets/healthLogo2.png"  width="95" height="74" />
                                <h2 style="color:white; margin-top: 15px;">User Login</h2>
                                <br/>
         </div>
     </div>
         <section class="page-holder d-flex align-items-center">
             <div class="container">
                  <div class="row align-items-center py-5">
                    <div class="col-5 col-lg-7 mx-auto mb-5 mb-lg-0">
                    
                        <div class="pr-lg-5">
                            <img src="/Assets/illustration.svg" alt="" class="img-fluid" />     
                        </div>
                    </div>
                    <div class="col-lg-5 px-lg-4">
                        <h1 class="text-base text-primary text-uppercase mb-4">Login Details</h1>
                        <h2 class="mb-4">Welcome Back!</h2>
                        <asp:Panel ID="errorMessage" runat="server">
                            <div class="alert alert-danger" role="alert">
                                Invalid Login Details. Try Again!
                            </div>
                        </asp:Panel>
                        <div class ="form-group mb-4">
                            <asp:TextBox required= "true" ID="txtEmail" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="Email" runat="server" ></asp:TextBox>

                        </div>

                             <div class ="form-group mb-4">
                            <asp:TextBox required= "true" ID="txtPassword" TextMode="Password" CssClass="form-control border-0 shadow form-control-lg text-base" placeholder="Password" runat="server" ></asp:TextBox>

                        </div>
                        <div class="form-group mb-4">
                            <div class="custom-control custom-checkbox">
                                <asp:CheckBox Text="&nbsp&nbsp&nbspRemember Me" runat="server" />
                            </div>
                        </div>
                        <asp:Button Text="LOGIN" CssClass="btn btn-primary" Height="50px" Width="400px" runat="server" OnClick="Unnamed_Click" />
                    </div>
                </div>
             </div>
         </section>
        
    </header>
</asp:Content>
