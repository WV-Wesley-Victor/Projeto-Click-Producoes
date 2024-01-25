<%@ Page Title="" Language="C#" MasterPageFile="~/Click.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LojaVirtualWebUI.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Login</title>
    <link href="CSS/login.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
        <div class="centro">
            <div class="left-side">
                <asp:Button ID="btnVoltar" runat="server" CssClass="btn-voltar" OnClientClick="voltar(); return false;" />
            </div>
            <section class="right-side">
                <div>
                    <div class="welcome-lines">
                        <div>
                            <h1 class="titulo-login">Login</h1>
                        </div>
                        <div class="welcome-line-2">
                            <p>Por favor, informe seu e-mail e senha.</p>
                        </div>
                    </div>
                    <div class="input-area">
                        <div class="form-inp">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="txtEmail" placeholder="Digite seu e-mail"></asp:TextBox>
                        </div>
                        <div class="form-inp">
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="txtPassword" placeholder="Digite sua senha"></asp:TextBox>
                        </div>
                    </div>
                    <div class="div-btn">
                        <asp:Button ID="Button1" runat="server" CssClass="buttonLogin" Text="Entrar" OnClick="Button1_Click" />
                    </div>
                    <div>
                        <asp:Label ID="LblResposta" runat="server" CssClass="LblResposta"></asp:Label>
                    </div>
                </div>
            </section>
        </div>
    </header>
    <script src="Javascript/login.js"></script>
</asp:Content>
