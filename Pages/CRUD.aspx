<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site1.Master" AutoEventWireup="true" CodeBehind="CRUD.aspx.cs" Inherits="prueba_tecnica_net.Pages.CRUD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <br />
    <div class="mx-auto mb-5" style="width: 970px">
        <asp:Label runat="server" CssClass="h2" ID="lbltitulo">Registrar</asp:Label>
    </div>
    <form runat="server">
        <div class="d-flex justify-content-center">
            <div class="mr-3 w-25">
                <div class="mb-3 w-50">
                    <label class="form-label">Usuario</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="tbusuario"></asp:TextBox>
                </div>
                <div class="mb-3 w-75">
                    <label class="form-label">Contraseña</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="tbpass" TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <div class="ml-3 w-25">
                <div class="mb-3">
                    <label class="form-label">Nombres</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="tbnombres"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">Apellidos</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="tbapellidos"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">Email</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="tbemail"></asp:TextBox>
                </div>
                <div class="mb-3 w-50">
                    <label class="form-label">Tipo de Identificación</label>
                    <div class="d-flex">
                        <asp:DropDownList runat="server" CssClass="form-control flex-grow-1" ID="tbtipoidentificacion">
                            <asp:ListItem Text="CC" Value="CC" />
                            <asp:ListItem Text="TI" Value="TI" />
                            <asp:ListItem Text="Nit" Value="Nit" />
                            <asp:ListItem Text="Pasaporte" Value="Pasaporte" />
                            <asp:ListItem Text="Fideicomiso" Value="Fideicomiso" />
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="mb-3">
                    <label class="form-label">Numero de Identificación</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="tbnumeroidentificacion"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="d-flex justify-content-center mt-5 mb-5">
              <asp:Button runat="server" CssClass="btn btn-primary w-25" ID="BtnCreate" Text="Create" OnClick="BtnCreate_Click"/>
        </div>
    </form>
</asp:Content>
