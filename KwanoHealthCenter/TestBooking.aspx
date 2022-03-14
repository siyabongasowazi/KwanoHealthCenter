<%@ Page Title="" Language="C#" MasterPageFile="~/NurseIndex.Master" AutoEventWireup="true" CodeBehind="TestBooking.aspx.cs" Inherits="KwanoHealthCenter.TestBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <header>
        <div id="nav" style="background-color:#0f4166; height: 95px; background-color: #0f4166; height: 175px; width: 100%; background-size: cover; background-repeat: no-repeat; background-position: 50% 50%;" class="transNav">
         <div class="text-center">
                                <img src="/Assets/healthLogo2.png"  width="95" height="74" />
                                <h2 style="color:white; margin-top: 15px;">Test Booking</h2>
                                <br/>
         </div>
     </div>
        
    </header>

    <section>
        <div class="container pt-2">
            <div class="jumbotron">


                <div class="row">
                    
               

               
                    <div class="col">
                         <h5><strong><label for="lblSubject">Test Subject</label></strong></h5>
                        <asp:Label ID="lblSucject" runat="server">ooo</asp:Label>
                    </div>
             

                
                    <div class="col">
                         <h5><strong><label for="lblEmail">Email Address</label></strong></h5>
                        <asp:Label ID="lblEmail" runat="server">www</asp:Label>
                    </div>
                </div>

                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
                    <ContentTemplate>
                        <div class="row pt-2">
                    <div class="col-6">
                        <div>
                             <strong><label for="txtDate">Booking Date</label></strong>
                            <asp:Calendar ID="datepicker" runat="server" Visible="false" OnSelectionChanged="datepicker_SelectionChanged" OnDayRender="datepicker_DayRender"></asp:Calendar>
                            <asp:TextBox ID="txtDate" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:LinkButton ID="lnkPickDate" runat="server" OnClick="lnkPickDate_Click">Get Date</asp:LinkButton>
                        </div>
                    </div>

                            <div class="col">
                                <div class="col">
                 <strong><label for="cmbSlot">Booking slot</label></strong>
                <asp:DropDownList class="form-control" ID="cmbSlot" runat="server" AutoPostBack="true">
                        <asp:ListItem Text="--Select Option--"  Value="0" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="08:00 - 10:00" Value="08:00 - 10:00"></asp:ListItem>
                    <asp:ListItem Text="10:00 - 12:00" Value="10:00 - 12:00"></asp:ListItem>
                    <asp:ListItem Text="12:00 - 14:00" Value="12:00 - 14:00"></asp:ListItem>
                    <asp:ListItem Text="14:00 - 16:00" Value="14:00 - 16:00"></asp:ListItem>                       
                    </asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Information is required" ControlToValidate="cmbSlot" InitialValue="0" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>

                        </div>
                            </div>
                </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                
                <div class="row">
                    <div class="col text-center pt-2">
                        <asp:Button ID="txtSubmit" runat="server" Text="Book Test" class="btn btn-warning"  OnClick="txtSubmit_Click"  />
                    </div>
                </div>

                </div>
            </div>
        <!-- Bootstrap DatePicker -->
    <%--<script>
        document.getElementById('date').value = moment().format('DD-MM-YYYY');
        $(function () {
            var dtToday = new Date();

            var month = dtToday.getMonth() + 1;
            var day = dtToday.getDate();
            var year = dtToday.getFullYear();
            if (month < 10)
                month = '0' + month.toString();
            if (day < 10)
                day = '0' + day.toString();

            var maxDate = year + '-' + month + '-' + day;
            $('#date').attr('max', maxDate);
        });
    </script>--%>
    </section>

</asp:Content>
