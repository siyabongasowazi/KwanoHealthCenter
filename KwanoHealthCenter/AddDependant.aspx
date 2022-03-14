<%@ Page Title="" Language="C#" MasterPageFile="~/MemberIndex.Master" AutoEventWireup="true" CodeBehind="AddDependant.aspx.cs" Inherits="KwanoHealthCenter.AddDependant" %>

   
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-sweetalert/1.0.1/sweetalert.js" integrity="sha512-XVz1P4Cymt04puwm5OITPm5gylyyj5vkahvf64T8xlt/ybeTpz4oHqJVIeDtDoF5kSrXMOUmdYewE4JS/4RWAA==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-sweetalert/1.0.1/sweetalert.css" rel="stylesheet" />


     <header>
        <div id="nav" style="background-color:#3badf5; height: 95px; background-color: #3badf5; height: 175px; width: 100%; background-size: cover; background-repeat: no-repeat; background-position: 50% 50%;" class="transNav">
         <div class="text-center">
                                <img src="/Assets/healthLogo2.png"  width="95" height="74" />
                                <h2 style="color:white; margin-top: 15px;">Add new dependant</h2>
                                <br/>
         </div>
     </div>
    </header>

    <section>
        <div class="container pt-2">
            <div class="jumbotron">
        <div class="form-horizontal pb-4">
                
            <div class="row pt-1">
                <div class="col">
                 <strong><label for="txtName">Name</label></strong>
                <asp:TextBox class="form-control" ID="txtName" runat="server" placeholder="Your name.."></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Name is required" ControlToValidate="txtName" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>

                <div class="col">
                <strong> <label for="txtSurname">Surname</label></strong>
                <asp:TextBox class="form-control" ID="txtSurname" runat="server" placeholder="Your surname.."></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ErrorMessage="Surname is required" ControlToValidate="txtSurname" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>

                </div>
                 </div>

                <div class="row pt-1">
                <div class="col">
                 <strong><label for="txtIDNumber">ID Number</label></strong>
                <asp:TextBox class="form-control" ID="txtIDNumber" runat="server" placeholder="Your ID Number.."></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="ID is required" ControlToValidate="txtIDNumber" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator runat="server" ErrorMessage="Invalid ID number" ForeColor="Red" ControlToValidate="txtIDNumber" ValidationExpression="(((\d{2}((0[13578]|1[02])(0[1-9]|[12]\d|3[01])|(0[13456789]|1[012])(0[1-9]|[12]\d|30)|02(0[1-9]|1\d|2[0-8])))|([02468][048]|[13579][26])0229))(( |-)(\d{4})( |-)(\d{3})|(\d{7}))" SetFocusOnError="True" Display="Dynamic"></asp:RegularExpressionValidator>                        
                    </div>

                <div class="col">
              <strong>   <label for="txtCellNumber">Cellphone Number</label></strong>
                <asp:TextBox class="form-control" ID="txtCellNumber" runat="server" placeholder="Your Cellnumber.."></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ErrorMessage="Cellnumber is required" ControlToValidate="txtCellNumber" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator runat="server" ErrorMessage="Invalid Phone number" ForeColor="Red" ControlToValidate="txtCellNumber" ValidationExpression="^((?:\+27|27)|0)(\d{2})-?(\d{3})-?(\d{4})$" SetFocusOnError="True" Display="Dynamic"></asp:RegularExpressionValidator>
                </div>
                 </div>

                <div class="row pt-1">
                    <div class="col">
                      <strong>  <label for="txtEmail">Email Address</label></strong>
                <asp:TextBox class="form-control" ID="txtEmail" runat="server" placeholder="Your email address.."></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Email is required" ControlToValidate="txtEmail" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator runat="server" ErrorMessage="Invalid Email Address" ForeColor="Red" ControlToValidate="txtEmail" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
                    </div>

                    <div class="col">
                <strong> <label for="cmbPersonResponsible">Person Responsible For Paying</label></strong>
               <asp:DropDownList class="form-control" ID="cmbPersonResponsible" runat="server" AppendDataBoundItems="true">
                        <asp:ListItem Text="--Select Option--"  Value="0" Selected="True"></asp:ListItem>                     
                    </asp:DropDownList>
                      

                </div>

                </div>
            
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="row pt-1">
                    <div class="col-md-3">
                      <strong>   <label for="cmbIsMedicalAid">Do you have medical aid?</label></strong>
                    <asp:DropDownList class="form-control" ID="cmbIsMedicalAid" runat="server" AutoPostBack="true" OnSelectedIndexChanged="OnSelectedIndexChanged">
                        <asp:ListItem Text="--Select Option--"  Value="0" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Yes" Value="Y"></asp:ListItem>
                        <asp:ListItem Text="No" Value="N"></asp:ListItem>
                    </asp:DropDownList>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Information is required" ControlToValidate="cmbIsMedicalAid" InitialValue="0" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                     </div>
                        
                        <div class="col-md-3">
                            <asp:Panel ID="pnl1" runat="server">
                                <strong>   <label for="cmbMedicalAid">Medical Aid</label></strong>
                               <asp:DropDownList class="form-control" ID="cmbMedicalAid" runat="server" AutoPostBack="true" OnSelectedIndexChanged="OnSelectedIndexChanged2">
                                    <asp:ListItem Text="--Select Medical Aid--"  Value="0" Selected="True"></asp:ListItem>
                                   </asp:DropDownList>
                            </asp:Panel>
                        </div>                       

                        <div class="col-md-3">
                            <asp:Panel ID="pnl2" runat="server">
                                <strong>   <label for="cmbMedicalAidPlan">Medical Aid Plan</label></strong>
                               <asp:DropDownList class="form-control" ID="cmbMedicalAidPlan" runat="server" AutoPostBack="true" >
                                    <asp:ListItem Text="--Select Medical Plan--"  Value="0" Selected="True"></asp:ListItem>
                                   </asp:DropDownList>
                            </asp:Panel>
                        </div>

                    <div class="col-md-3">
                            <asp:Panel ID="pnl3" runat="server">
                                <strong>   <label for="txtMedicalAidNo">Medical Aid Number</label></strong>
                                <asp:TextBox CssClass="form-control" ID="txtMedicalAidNo" runat="server"></asp:TextBox>
                            </asp:Panel>
                        </div>    
                                          
                        
            </div>
                </ContentTemplate>
               
            </asp:UpdatePanel>

             

            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>

                    <div class="row pt-1">

                        <div class="col">
                 <strong><label for="cmbAddress">Does the dependant live with you?</label></strong>
                <asp:DropDownList class="form-control" ID="cmbAddress" runat="server" AutoPostBack="true" OnSelectedIndexChanged="OnSelectedIndexChanged4">
                        <asp:ListItem Text="--Select Option--"  Value="0" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Yes" Value="Y"></asp:ListItem>
                        <asp:ListItem Text="No" Value="N"></asp:ListItem>
                    </asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Information is required" ControlToValidate="cmbAddress" InitialValue="0" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>

                        </div>

                <div class="col">
                    <asp:Panel ID="pnlAdd1" runat="server">
                 <strong><label for="txtAddress1">Address Line 1</label></strong>
                <asp:TextBox class="form-control" ID="txtAddress1" runat="server" placeholder="Address Line 1.."></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Address is required" ControlToValidate="txtAddress1" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                </asp:Panel>
                        </div>

                <div class="col">
                    <asp:Panel ID="pnlAdd2" runat="server">
                 <strong><label for="txtAddress2">Address Line 2</label></strong>
                <asp:TextBox class="form-control" ID="txtAddress2" runat="server" placeholder="Address Line 2.."></asp:TextBox>
               </asp:Panel> 
                        </div>
                 </div>

                  <div class="row pt-1">
                <div class="col">
                    <asp:Panel ID="pnlCity" runat="server">
                 <strong><label for="cmbCityID">City</label></strong>
                <asp:DropDownList ID="cmbCityID" class="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="OnSelectedIndexChanged3">
               <asp:ListItem Text="--Select Your City--"  Value="0"></asp:ListItem>                     
            </asp:DropDownList>
                   <%-- <asp:RequiredFieldValidator runat="server" ErrorMessage="Please choose an option" InitialValue="0" ControlToValidate="cmbCityID" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                   </asp:Panel>
                        </div>

                     <div class="col">
                         <asp:Panel ID="pnlSub" runat="server">
                 <strong><label for="cmbSuburbID">Suburb</label></strong>
                <asp:DropDownList ID="cmbSuburbID" class="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="True" >
               <asp:ListItem Text="--Select Your Suburb--"  Value="0"></asp:ListItem>                          
            </asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Please choose an option" InitialValue="0" ControlToValidate="cmbSuburbID" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                    </asp:Panel>
                             </div>                   
                
                 </div>
                     </ContentTemplate>
               
            </asp:UpdatePanel>
                <div class="row">
                    <div class="col text-center pt-2">
                        <asp:Button ID="txtSubmit" runat="server" Text="Add Dependant" class="btn btn-warning"  OnClick="txtSubmit_Click"  />
                    </div>
                </div>
                   


            
            </div>                
            </div>
            </div>
    </section>
</asp:Content>
