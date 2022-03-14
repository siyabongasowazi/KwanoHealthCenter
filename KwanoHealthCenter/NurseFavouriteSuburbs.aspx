<%@ Page Title="" Language="C#" MasterPageFile="~/NurseIndex.Master" AutoEventWireup="true" CodeBehind="NurseFavouriteSuburbs.aspx.cs" Inherits="KwanoHealthCenter.NurseFavouriteSuburbs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <header>
        <div id="nav" style="background-color:#3badf5; height: 95px; background-color: #3badf5; height: 175px; width: 100%; background-size: cover; background-repeat: no-repeat; background-position: 50% 50%;" class="transNav">
         <div class="text-center">
                                <img src="/Assets/healthLogo2.png"  width="95" height="74" />
                                <h2 style="color:white; margin-top: 15px;">My Favourite Suburbs</h2>
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
                             <div class="col-5">
                                  <strong><label for="cmbCityID">City</label></strong>
                                 <asp:DropDownList ID="cmbCityID" class="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="OnSelectedIndexChanged3">
                                 <asp:ListItem Text="--Select Your City--"  Value="0"></asp:ListItem>                     
                                </asp:DropDownList>
                             </div>
                           </div>
                         <div class="row">
                             <div class="col-5">
                                  <strong><label for="cmbSuburbID">Suburb</label></strong>
                <asp:DropDownList ID="cmbSuburbID" class="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="True" >
               <asp:ListItem Text="--Select Your Suburb--"  Value="0"></asp:ListItem>                          
            </asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Please choose an option" InitialValue="0" ControlToValidate="cmbSuburbID" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                   
                             </div>
                         </div>
                     </ContentTemplate>
                 </asp:UpdatePanel>

                <div class="row col-5">
                    <div class="col text-center pt-2">
                        <asp:Button ID="txtSubmit" runat="server" Text="Add Suburb" class="btn btn-warning"  OnClick="txtSubmit_Click"  />
                    </div>
                </div>

                <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <div class="pt-2">
                        <asp:GridView ID="dgvFavSurbs" runat="server" AutoGenerateColumns="false" CssClass="table">
                            <Columns>
                                <asp:TemplateField>

                                   
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="City" DataField="City" />
                                <asp:BoundField HeaderText="Suburb" DataField="Suburb" />
                                <asp:TemplateField HeaderText="Action">

                                    <ItemTemplate>
                                        <asp:LinkButton CommandName="Delete" CssClass="btn btn-danger form-control" runat="server"><i class="fa fa-minus-circle" aria-hidden="true"></i>Remove</asp:LinkButton>
                                       
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
