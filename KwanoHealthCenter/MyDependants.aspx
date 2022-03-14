<%@ Page Title="" Language="C#" MasterPageFile="~/MemberIndex.Master" AutoEventWireup="true" CodeBehind="MyDependants.aspx.cs" Inherits="KwanoHealthCenter.MyDependants" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <header>
        <div id="nav" style="background-color:#0f4166; height: 95px; background-color: #0f4166; height: 175px; width: 100%; background-size: cover; background-repeat: no-repeat; background-position: 50% 50%;" class="transNav">
         <div class="text-center">
                                <img src="/Assets/healthLogo2.png"  width="95" height="74" />
                                <h2 style="color:white; margin-top: 15px;">My Dependants</h2>
                                <br/>
         </div>
     </div>
        
    </header>
    <section>
        <div class="container pt-2">
            <div class="jumbotron">
                
                    <div class="text-right pt-2">
                     
                        <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-info" Text="Add Dependant" OnClick="btnAdd_Click" />                       

                    </div>
                    <div class="pt-2">
                        <asp:GridView ID="dgvDependants" runat="server" AutoGenerateColumns="false" CssClass="table" OnRowDeleting="dgvDependants_RowDeleting" DataKeyNames="ID Number">
                            <Columns>
                                <asp:TemplateField>

                                    <ItemTemplate>
                                        <asp:LinkButton ID="btnViewDep" CssClass="btn btn-success form-control" runat="server" OnClick="btnViewDep_Click"><i class="fa fa-eye" aria-hidden="true">View</i></asp:LinkButton>
                                       
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="ID Number" DataField="ID Number" />
                                <asp:BoundField HeaderText="Name" DataField="Name" />
                                <asp:BoundField HeaderText="Cellphone Number" DataField="Cell Number" />
                                <asp:BoundField HeaderText="Email Address" DataField="Email Address" />
                                <asp:BoundField HeaderText="Medical Aid" DataField="Medical Aid" />
                                <asp:TemplateField HeaderText="Action">

                                    <ItemTemplate>
                                        <asp:LinkButton CommandName="Delete" CssClass="btn btn-danger form-control" runat="server"><i class="fa fa-minus-circle" aria-hidden="true"></i>Remove</asp:LinkButton>
                                       
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                    
                
            </div>
        </div>
    </section>
</asp:Content>
