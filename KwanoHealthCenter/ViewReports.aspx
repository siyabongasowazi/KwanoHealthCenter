<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerIndex.Master" AutoEventWireup="true" CodeBehind="ViewReports.aspx.cs" Inherits="KwanoHealthCenter.ViewReports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <header>
        <div id="nav" style="background-color:#3badf5; height: 95px; background-color: #3badf5; height: 175px; width: 100%; background-size: cover; background-repeat: no-repeat; background-position: 50% 50%;" class="transNav">
         <div class="text-center">
                                <img src="/Assets/healthLogo2.png"  width="95" height="74" />
                                <h2 style="color:white; margin-top: 15px;">Reports</h2>
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
                                  <strong><label for="cmbNurse">Nurse</label></strong>
                                 <asp:DropDownList ID="cmbNurse" class="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="cmbNurse_SelectedIndexChanged">
                                 <asp:ListItem Text="--Select Nurse--"  Value="0"></asp:ListItem>                     
                                </asp:DropDownList>
                             </div>
                           </div>

                          <div class="pt-2">
                        <asp:GridView ID="dgvResults" runat="server" AutoGenerateColumns="false" CssClass="table" OnPageIndexChanging="dgvResults_PageIndexChanging">
                            <Columns>
                                
                                
                                <asp:BoundField HeaderText="Request Status" DataField="RequestStatus" />
                                <asp:BoundField HeaderText="Test Results" DataField="TestResults" />
                                <asp:BoundField HeaderText="Booking Date" DataField="BookingDate" />
                                <asp:BoundField HeaderText="SuburbName" DataField="SuburbName" />
                                
                            </Columns>
                        </asp:GridView>

                              <div class="row pt-1">
                                  <div class="col text-right">
                                      <asp:Button ID="btnExport" CssClass="btn btn-danger" runat="server" Text="Export To PDF" OnClick = "ExportToPDF" />
                                  </div>
                              </div>
                    </div>

                         </ContentTemplate>
                    </asp:UpdatePanel>
            </div>
        </div>
    </section>
</asp:Content>
