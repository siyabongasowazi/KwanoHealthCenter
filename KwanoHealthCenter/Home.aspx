<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KwanoHealthCenter.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Kwano Health-Center | Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header class="py-5">
            <div class="container px-lg-5">
                <div class="p-4 p-lg-5 bg-light rounded-3 text-center">
                    <div class="m-4 m-lg-5">
                        <h1 class="display-5 fw-bold">Kwano Health-Centre</h1>
                        <p class="fs-4">From primary health care to minor surgical procedures, we offer many services. We now also offer Covid-19 testing where our dedicated nurses comes to the comfort of your home to test. <br /> Would you like to book a Covid-19 test?</p>
                        <a class="btn btn-warning btn-lg" href="Registration.aspx">Register</a>
                    </div>
                </div>
               
            </div>
        
        </header>
    <section class="pt-4">
        <div class="container">
             <hr />
            <div class="text-center">
               <h3 class="display-6 fw-bol">SOME OF OUR SERVICES</h3>
            </div>
            <div>
                <div class="row row-cols-1 row-cols-md-3 g-4 pb-3">
  <div class="col">
    <div class="card h-100">
      <img src="/Assets/primary.jpg" class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title text-center">Primary Health Care</h5>
        <p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
      </div>
    </div>
  </div>
  <div class="col">
    <div class="card h-100">
      <img src="/Assets/dentist.jpg" class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title text-center">Tooth Extraction</h5>
        <p class="card-text">This is a short card.</p>
      </div>
    </div>
  </div>
  <div class="col">
    <div class="card h-100">
      <img src="/Assets/cov19.jpg" class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title text-center">Covid-19 Testing</h5>
        <p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content.</p>
      </div>
    </div>
  </div>  
</div>
            </div>
        </div>

    </section>
</asp:Content>
