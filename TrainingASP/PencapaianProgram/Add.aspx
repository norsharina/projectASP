<%@ Page Title="" Language="C#" MasterPageFile="~/Metronic.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="TrainingASP.PencapaianProgram.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- BEGIN: Subheader -->
    <div class="m-subheader ">
        <div class="d-flex align-items-center">
            <div class="mr-auto">
                <h3 class="m-subheader__title ">Tambah Pencapaian Program
                </h3>
            </div>
        </div>
    </div>
    <!-- END: Subheader -->

   <div class ="form-group">
       <label>Program </label>
       <asp:TextBox ID="txtKodProgam" runat="server" CssClass="form-control"></asp:TextBox>
   </div>
   <div class ="form-group">
       <label>Tarikh Program </label>
        <asp:TextBox ID="txtTkhProgram" runat="server" CssClass="form-control"></asp:TextBox>
   </div>
   <div class ="form-group">
       <label>Bilangan Hari </label>
        <asp:TextBox ID="txtBilHari" runat="server" CssClass="form-control"></asp:TextBox>
   </div>

  <div class="form-check">
    <label class="form-check-label">
      <asp:CheckBox ID="chckLulus" CssClass="form-check-input" runat="server" />
      Lulus
    </label>
  </div>

  
   <asp:Button ID="btnSubmit" runat="server" Text="Simpan" class="btn btn-primary" OnClick="btnSubmit_Click" />

</asp:Content>

