<%@ Page Title="" Language="C#" MasterPageFile="~/MemberIndex.Master" AutoEventWireup="true" CodeBehind="MainMemberProfile.aspx.cs" Inherits="KwanoHealthCenter.MainMemberProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <header>
        <div id="nav" style="background-color:#3badf5; height: 95px; background-color: #3badf5; height: 175px; width: 100%; background-size: cover; background-repeat: no-repeat; background-position: 50% 50%;" class="transNav">
         <div class="text-center">
                                <img src="/Assets/healthLogo2.png"  width="95" height="74" />
                                <h2 style="color:white; margin-top: 15px;">My Details</h2>
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
                     <strong>  <label for="txtEmail">Email Address</label></strong>
                <asp:TextBox class="form-control" ID="txtEmail" runat="server" placeholder="Your email address.."></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Email is required" ControlToValidate="txtEmail" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator runat="server" ErrorMessage="Invalid Email Address" ForeColor="Red" ControlToValidate="txtEmail" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
                    
                </div>

                <div class="col">
              <strong>   <label for="txtCellNumber">Cellphone Number</label></strong>
                <asp:TextBox class="form-control" ID="txtCellNumber" runat="server" placeholder="Your Cellnumber.."></asp:TextBox>
                      <asp:RequiredFieldValidator runat="server" ErrorMessage="Cellnumber is required" ControlToValidate="txtCellNumber" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator runat="server" ErrorMessage="Invalid Phone number" ForeColor="Red" ControlToValidate="txtCellNumber" ValidationExpression="^((?:\+27|27)|0)(\d{2})-?(\d{3})-?(\d{4})$" SetFocusOnError="True" Display="Dynamic"></asp:RegularExpressionValidator>
                </div>
                 </div>

              

              
                 <%--<div class="row pt-1">
                <div class="col-md-3">
              <strong>   <label for="cmbIsMedicalAid">Do you have medical aid?</label></strong>
                 
                   
                       <asp:DropDownList ID="cmbIsMedicalAid" class="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="cmbIsMedicalAid_SelectedIndexChanged">
               <asp:ListItem Text="--Select Option--"  Value="0" Selected="True"></asp:ListItem>
                <asp:ListItem Text="Yes" Value="True"></asp:ListItem>
                <asp:ListItem Text="No" Value="False"></asp:ListItem>              
            </asp:DropDownList>                 
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Please choose an option" InitialValue="0" ControlToValidate="cmbIsMedicalAid" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                     <div class="col-md-3">
                <strong> <label for="cmbMedicalAidID">Medical Aid</label></strong>
                <asp:DropDownList ID="cmbMedicalAidID" class="form-control" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="MedicalAidName" DataValueField="MedicalAidID">
               <asp:ListItem Text="--Select Your Medical Aid--"  Value="0"></asp:ListItem>       
            </asp:DropDownList>
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbConn %>" SelectCommand="sp_GetAllMedicalAids" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                    </div>

                     <div class="col-md-3">
                <strong> <label for="cmbMedicalAidPlanID">Medical Plan</label></strong>
                <asp:DropDownList ID="cmbMedicalAidPlanID" class="form-control" runat="server" EnableViewState="True" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="MedicalPlanName" DataValueField="MedicalAidPlanID">
               <asp:ListItem Text="--Select Your Medical Aid Plan--"  Value="0"></asp:ListItem>
            </asp:DropDownList>
                         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:dbConn %>" SelectCommand="SELECT * FROM [tblMedicalAidPlan] WHERE ([MedicalAidID] = @MedicalAidID)">
                             <SelectParameters>
                                 <asp:ControlParameter ControlID="cmbMedicalAidID" Name="MedicalAidID" PropertyName="SelectedValue" Type="Int32" />
                             </SelectParameters>
                         </asp:SqlDataSource>
                    </div>

                <div class="col">
                 <strong><label for="txtMedicalAidNo">Medical Aid Number</label></strong>
                <asp:TextBox class="form-control" ID="txtMedicalAidNo" runat="server" placeholder="Medical aid number.."></asp:TextBox>
                     <asp:RegularExpressionValidator runat="server" ErrorMessage="Invalid medical aid number" ForeColor="Red" ControlToValidate="txtMedicalAidNo" ValidationExpression="^[0-9]{9}$" SetFocusOnError="True" Display="Dynamic"></asp:RegularExpressionValidator>
                </div>
                 </div>--%>

                 <div class="row pt-1">
                <div class="col">
                 <strong><label for="txtAddress1">Address Line 1</label></strong>
                <asp:TextBox class="form-control" ID="txtAddress1" runat="server" placeholder="Address Line 1.."></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Address is required" ControlToValidate="txtAddress1" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>

                <div class="col">
                 <strong><label for="txtAddress2">Address Line 2</label></strong>
                <asp:TextBox class="form-control" ID="txtAddress2" runat="server" placeholder="Address Line 2.."></asp:TextBox>
                </div>
                 </div>

                  <div class="row pt-1">
                <div class="col">
                 <strong><label for="cmbCityID">City</label></strong>
                <asp:DropDownList ID="cmbCityID" class="form-control" runat="server" EnableViewState="True" AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="CityName" DataValueField="CityID">
               <asp:ListItem Text="--Select Your City--"  Value="0"></asp:ListItem>                     
            </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:dbConn %>" SelectCommand="sp_GetCities" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Please choose an option" InitialValue="0" ControlToValidate="cmbCityID" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                     <div class="col">
                 <strong><label for="cmbSuburbID">Suburb</label></strong>
                <asp:DropDownList ID="cmbSuburbID" class="form-control" runat="server" EnableViewState="True" AutoPostBack="True" DataSourceID="SqlDataSource4" DataTextField="SuburbName" DataValueField="SuburbID" OnSelectedIndexChanged="cmbSuburbID_SelectedIndexChanged">
               <asp:ListItem Text="--Select Your Suburb--"  Value="0"></asp:ListItem>                          
            </asp:DropDownList>
                         <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:dbConn %>" SelectCommand="sp_GetSuburbs" SelectCommandType="StoredProcedure">
                             <SelectParameters>
                                 <asp:ControlParameter ControlID="cmbCityID" Name="CityID" PropertyName="SelectedValue" Type="Int32" />
                             </SelectParameters>
                         </asp:SqlDataSource>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Please choose an option" InitialValue="0" ControlToValidate="cmbSuburbID" ForeColor="Red" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                   
                   <%--    <script runat="server">
                           protected void cmbSuburbID_SelectedIndexChanged(object sender, EventArgs e)
                           {
                               Session["SuburbID"] = cmbSuburbID.SelectedValue;
                           }
                       </script>  --%>
                     
                     </div>                   
                
                 </div>

                <%--<div class="row">
                    <div class="col text-center pt-2">
                        <asp:Button ID="txtSubmit" runat="server" Text="Submit" class="btn btn-warning"  OnClick="txtSubmit_Click"  />
                    </div>
                </div>--%>
                
			
            </div>
                 <div style="text-align:center; margin-top:2em">
                <asp:Button ID="btnEdit" runat="server" Text="Edit" class="btn btn-sm btn-warning" OnClick="btnEdit_Click"  />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-sm btn-danger" OnClick="btnUpdate_Click"  />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="btn btn-primary"  />
			</div>
                </div>
            </div>
    </section>
</asp:Content>
