<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="prueba_tecnica_net.Pages.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-4">
                <div class="card">
                    <div class="card-header">
                        Validar Inicio de Sesión
                    </div>
                    <div class="card-body">
                        <form runat="server">
                            <div class="mb-3">
                                <label for="tbUsuario" class="form-label">Usuario</label>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbuser"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="tbContraseña" class="form-label">Contraseña</label>
                                <asp:TextBox runat="server" CssClass="form-control" ID="tbpassword" TextMode="Password"></asp:TextBox>
                            </div>
                            <asp:Button runat="server" ID="BtnValidar" CssClass="btn btn-primary" Text="Validar" OnClick="BtnValidar_Click" />
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
