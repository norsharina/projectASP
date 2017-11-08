<%@ Page Title="" Language="C#" MasterPageFile="~/Metronic.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TrainingASP.PencapaianProgram.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- BEGIN: Subheader -->
    <div class="m-subheader ">
        <div class="d-flex align-items-center">
            <div class="mr-auto">
                <h3 class="m-subheader__title ">Pencapaian Program
                </h3>
            </div>
        </div>
    </div>
    <!-- END: Subheader -->
    <div class="m-content">
        <div class="form-group" >
        <asp:HyperLink ID="BtnTambah" CssClass="btn btn-primary" runat="server" NavigateUrl="~/PencapaianProgram/Add.aspx">Tambah</asp:HyperLink>
        </div>
        <asp:Repeater ID="ProgramRepeater" runat="server">
            <HeaderTemplate>
                <table class="table">
                    <thead>
                        <tr>
                            <th>Kod Program</th>
                            <th>Tarikh Program</th>
                            <th>Bil Hari</th>
                            <th>Lulus</th>
                        </tr>
                    </thead>
                    <tbody>


            </HeaderTemplate>

            <ItemTemplate>
                        <tr>
                            <td>
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl=<%# "Edit.aspx?id="+ Eval("Id") %>><%# Eval("KodProgram") %></asp:HyperLink>                           
                            </td>
                            <td><%# Eval("TarikhProgram") %></td>
                            <td><%# Eval("BilanganHari") %></td>
                            <td><%# Eval("Lulus") %></td>
                        </tr>
            </ItemTemplate>
            <FooterTemplate>                    
           </tbody></table>
           </FooterTemplate>
        </asp:Repeater>

    </div>
    
</asp:Content>
