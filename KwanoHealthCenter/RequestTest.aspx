<%@ Page Title="" Language="C#" MasterPageFile="~/MemberIndex.Master" AutoEventWireup="true" CodeBehind="RequestTest.aspx.cs" Inherits="KwanoHealthCenter.RequestTest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <header>
        <div id="nav" style="background-color:#3badf5; height: 95px; background-color: #3badf5; height: 175px; width: 100%; background-size: cover; background-repeat: no-repeat; background-position: 50% 50%;" class="transNav">
         <div class="text-center">
                                <img src="/Assets/healthLogo2.png"  width="95" height="74" />
                                <h2 style="color:white; margin-top: 15px;">Request Test</h2>
                                <br/>
         </div>
     </div>
    </header>

    <section>
        <div class="container pt-2">
            <div class="jumbotron">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>

                        <div class="row pt-1">
                            <div class="col">
                                <strong><label for="cmbAddress">Are you requesting the test for you?</label></strong>
                <asp:DropDownList class="form-control" ID="cmbChoice" runat="server" AutoPostBack="true" OnSelectedIndexChanged="OnSelectedIndexChanged4">
                        <asp:ListItem Text="--Select Option--"  Value="0" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Yes, for me" Value="Y"></asp:ListItem>
                        <asp:ListItem Text="No, for my dependant" Value="N"></asp:ListItem>
                    </asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Information is required" ControlToValidate="cmbChoice" InitialValue="0" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>

                            </div>

                            <div class="col">
                    <asp:Panel ID="pnlDep" runat="server">
                 <strong><label for="cmbDependantID">Depandant</label></strong>
                <asp:DropDownList ID="cmbDependantID" class="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="True">
               <asp:ListItem Text="--Select Dependant--"  Value="0"></asp:ListItem>                     
            </asp:DropDownList>
                   </asp:Panel>

                                
                        </div>
                         </div>

                        

                        
                    </ContentTemplate>
                </asp:UpdatePanel>


                <div class="row">
                    <div class="col text-center pt-2">
                        <asp:Button ID="txtSubmit" runat="server" Text="Request Test" class="btn btn-warning" OnClick="txtSubmit_Click"  />
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
