<%@ Page Title="" Language="C#" MasterPageFile="~/ClickProd.Master" AutoEventWireup="true" CodeBehind="SobreNos.aspx.cs" Inherits="LojaVirtualWebUI.SobreNos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleAbout.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel>
        <section class="sobre">
            <div class="titulo">
            <h1>Sobre Nós</h1>
            </div>
            <div class="campoSobre">
            <div class="textoSobre">
            <h2>Bem vindo ao site</h2>
            <p>Bem-vindo ao meu mundo visual! Sou [Seu Nome], um contador de histórias apaixonado que utiliza a fotografia como meio de expressão. Minha jornada me proporcionou uma visão única e sensibilidade artística para capturar momentos autênticos e emocionantes. Minha paixão vai além do simples clique; é sobre criar narrativas visuais que transcendem o tempo, explorando a beleza nos detalhes do cotidiano.
Com abordagem criativa e olhar atento, busco ir além do óbvio, proporcionando imagens que contam histórias profundas e genuínas. Meu objetivo é imortalizar emoções e conexões, não apenas documentar. Convido você a explorar meu portfólio e permitir que eu seja o narrador visual dos momentos especiais da sua vida. Juntos, podemos transformar instantes fugazes em memórias inesquecíveis.</p>
            </div>
            <div class="imagem">
            <img src="imagens/Foto-casal1.jpg" alt="fotografo">
            </div>
            </div>
        </section>
    </asp:UpdatePanel>
</asp:Content>
