<%@ Page Title="" Language="C#" MasterPageFile="~/NurseIndex.Master" AutoEventWireup="true" CodeBehind="PerfomTest.aspx.cs" Inherits="KwanoHealthCenter.PerfomTest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <header>
        <div id="nav" style="background-color:#0f4166; height: 95px; background-color: #0f4166; height: 175px; width: 100%; background-size: cover; background-repeat: no-repeat; background-position: 50% 50%;" class="transNav">
         <div class="text-center">
                                <img src="/Assets/healthLogo2.png"  width="95" height="74" />
                                <h2 style="color:white; margin-top: 15px;">Perfom Test</h2>
                                <br/>
         </div>
     </div>
        
    </header>

    <section>
        <div class="container pt-2">
            <div class="jumbotron">

                <div class="row">
                    <div class="col text-center">
                        <h4>Capture Test Details</h4>
                    </div>
                </div>

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


                <div class="row pt-1">
                <div class="col">
                 <strong><label for="txtBarcode">Test Swab Barcode</label></strong>
                <asp:TextBox class="form-control" ID="txtBarcode" runat="server" placeholder="Barcode.."></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Barcode is required" ControlToValidate="txtBarcode" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>

                <div class="col">
                <strong> <label for="txtTemperature">Patient Temperature</label></strong>
                <asp:TextBox class="form-control" ID="txtTemperature" runat="server" placeholder="Patient Temperature.."></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ErrorMessage="Temperature is required" ControlToValidate="txtTemperature" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator runat="server" ErrorMessage="Invalid Temperature" ForeColor="Red" ControlToValidate="txtTemperature" ValidationExpression="^[1-9]\d*(\.\d+)?$" SetFocusOnError="True" Display="Dynamic"></asp:RegularExpressionValidator>
                </div>
                 </div>

                <div class="row pt-1">
                <div class="col">
                 <strong><label for="txtBloodPressure">Blood Pressure</label></strong>
                <asp:TextBox class="form-control" ID="txtBloodPressure" runat="server" placeholder="Blood pressure.."></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Blood Pressure is required" ControlToValidate="txtBloodPressure" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>

                <div class="col">
                <strong> <label for="txtOxygenLevel">Oxygen Level</label></strong>
                <asp:TextBox class="form-control" ID="txtOxygenLevel" runat="server" placeholder="Oxygen Level.."></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ErrorMessage="Oxygen level is required" ControlToValidate="txtOxygenLevel" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator runat="server" ErrorMessage="Invalid Oxygen Level" ForeColor="Red" ControlToValidate="txtOxygenLevel" ValidationExpression="^[1-9]\d*$" SetFocusOnError="True" Display="Dynamic"></asp:RegularExpressionValidator>

                </div>
                 </div>

                <div class="row">
                    <div class="col text-center pt-2">
                        <asp:Button ID="txtSubmit" runat="server" Text="Perfom Test" class="btn btn-warning"  OnClick="txtSubmit_Click"  />
                    </div>
                </div>


            </div>
        </div>
    </section>
</asp:Content>
