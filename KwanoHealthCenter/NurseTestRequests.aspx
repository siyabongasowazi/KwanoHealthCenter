<%@ Page Title="" Language="C#" MasterPageFile="~/NurseIndex.Master" AutoEventWireup="true" CodeBehind="NurseTestRequests.aspx.cs" Inherits="KwanoHealthCenter.NurseTestRequests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <header>
        <div id="nav" style="background-color:#0f4166; height: 95px; background-color: #0f4166; height: 175px; width: 100%; background-size: cover; background-repeat: no-repeat; background-position: 50% 50%;" class="transNav">
         <div class="text-center">
                                <img src="/Assets/healthLogo2.png"  width="95" height="74" />
                                <h2 style="color:white; margin-top: 15px;">Test Requests</h2>
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
                         <div class="row">
                    <div class="col-5 text-right">
                        <strong>   <label for="cmbChoice">Sort Requests By</label></strong>
                    <asp:DropDownList class="form-control" ID="cmbChoice" runat="server" AutoPostBack="true" OnSelectedIndexChanged="cmbChoice_SelectedIndexChanged">
                        <asp:ListItem Text="--Select Option--"  Value="0" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="View By My Favourite Suburbs" Value="1"></asp:ListItem>
                        <asp:ListItem Text="View All Tests Request" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                    </div>
                </div>

                <div class="pt-2">
                        <asp:GridView ID="dgvRequests" runat="server" AutoGenerateColumns="false" CssClass="table" DataKeyNames="RequestID" OnRowCommand="dgvRequests_RowCommand">
                            <Columns>
                                
                                <asp:BoundField DataField="RequestID" />
                                <asp:BoundField HeaderText="Request Date" DataField="Request Date" />
                                <asp:BoundField HeaderText="Request Time" DataField="Request Time" />
                                <asp:BoundField HeaderText="Requestor" DataField="Requestor" />
                                <asp:BoundField HeaderText="Address Line 1" DataField="AddressLine1" />
                                <asp:BoundField HeaderText="Address Line 2" DataField="AddressLine2" />
                                <asp:BoundField HeaderText="Suburb Name" DataField="SuburbName" />
                                <asp:TemplateField HeaderText="Action">

                                    <ItemTemplate>
                                        <%--<asp:LinkButton CommandName="Delete" CssClass="btn btn-danger form-control" runat="server"><i class="fa fa-minus-circle" aria-hidden="true"></i>Remove</asp:LinkButton>--%>
                                       <asp:Button ID="btnSchedule" runat="server" Text="Schdedule" CssClass="btn btn-info" CommandName="SendRequestID" CommandArgument='<%# Eval("RequestID")  %>' />

                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                    </ContentTemplate>
                </asp:UpdatePanel>

               

               
                    
               
            </div>
        </div>
    </section>






   </asp:Content>

