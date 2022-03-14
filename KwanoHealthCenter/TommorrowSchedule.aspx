<%@ Page Title="" Language="C#" MasterPageFile="~/NurseIndex.Master" AutoEventWireup="true" CodeBehind="TommorrowSchedule.aspx.cs" Inherits="KwanoHealthCenter.TommorrowSchedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <header>
        <div id="nav" style="background-color:#0f4166; height: 95px; background-color: #0f4166; height: 175px; width: 100%; background-size: cover; background-repeat: no-repeat; background-position: 50% 50%;" class="transNav">
         <div class="text-center">
                                <img src="/Assets/healthLogo2.png"  width="95" height="74" />
                                <h2 style="color:white; margin-top: 15px;">Tommorow's Schedule</h2>
                                <br/>
         </div>
     </div>
        
    </header>

    <section>
        <div class="container">
            <div class="jumbotron">
                <div class="pt-2">
                        <asp:GridView ID="dgvSchedule" runat="server" AutoGenerateColumns="false" CssClass="table" DataKeyNames="RequestID">
                            <Columns>
                                
                                <asp:BoundField DataField="RequestID" />
                                <asp:BoundField HeaderText="Request Date" DataField="RequestDate" />
                                <asp:BoundField HeaderText="Time Slot" DataField="BookingTimeSlot" />
                                <asp:BoundField HeaderText="Booking Date" DataField="BookingDate" />
                                <asp:BoundField HeaderText="Main Member" DataField="Main Member" />
                                <asp:BoundField HeaderText="Address Line 1" DataField="TestAddressLine1" />
                                <asp:BoundField HeaderText="Address Line 2" DataField="TestAddressLine2" />
                                
                            </Columns>
                        </asp:GridView>
                    </div>
            </div>
        </div>
    </section>
</asp:Content>
