<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Portfolio.aspx.cs" Inherits="LojaVirtualWebUI.Portfolio" %>
 
<!DOCTYPE html>

<html lang="pt-br" xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Galeria</title>
    <link rel="stylesheet" href="CSS/StyleSheet.css" />
    <script src="JavaScript.js"></script>
    <style>
    .button {
       
        display:flex;
        justify-content:center;
    }

    .button button {
        padding: 0;
        border: unset;
        border-radius: 5px;
        color: #212121;
        z-index: 1;
        background: #e8e8e8;
        position: relative;
        font-size: 17px;
        -webkit-box-shadow: 4px 8px 19px -3px rgba(0,0,0,0.27);
        box-shadow: 4px 8px 19px -3px rgba(0,0,0,0.27);
        transition: all 250ms;
        overflow: hidden;
        display: block;
        width: 150px;
        line-height: 63.75px;
    }

    .button button::before {
        content: "";
        position: absolute;
        top: 0;
        left: 0;
        height: 100%;
        width: 0;
        border-radius: 15px;
        background-color: #212121;
        z-index: -1;
        -webkit-box-shadow: 4px 8px 19px -3px rgba(0,0,0,0.27);
        box-shadow: 4px 8px 19px -3px rgba(0,0,0,0.27);
        transition: all 250ms
    }

    .button button:hover {
        color: #e8e8e8;
    }

    .button button:hover::before {
        width: 100%;
    }

    .button button a {
        display: block;
        text-decoration: none;
        color: black;
        font-size: 16px;
    }

    .button button a:hover {
        color:white;
    }

    .btn-login a {
    position: relative;
    padding: 0.5rem;
    border-radius: 7px;
    border: 1px solid transparent;
    font-size: 14px;
    text-transform: uppercase;
    font-weight: 600;
    letter-spacing: 2px;
    background: transparent;
    overflow: hidden;
    box-shadow: 0 0 0 0 transparent;
    transition: all 0.2s ease-in;
}

    .btn-login a:hover {
        background: rgba(0, 0, 0, 0.288);
        transition: all 0.2s ease-out;
    }

    .btn-login a::before {
        content: "";
        display: block;
        width: 0px;
        height: 86%;
        position: absolute;
        top: 7%;
        left: 0%;
        opacity: 0;
        background: #fff;
        box-shadow: 0 0 50px 30px #fff;
        transform: skewX(-20deg);
    }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="centro">
            <div class="header">
                <div class="logo">
                    <a href="Default.aspx"><img class="meio imagem-logo" src="CSS/logoNova.png" alt="Logo" /></a>
                </div>
                <div class="container">
                    <input type="checkbox" id="check" />
                    <label class="bar" for="check">
                        <span class="top"></span>
                        <span class="middle"></span>
                        <span class="bottom"></span>
                    </label>

                    <div class="elemento-topo">
                        <input type="checkbox" id="check" />
                        <nav>
                            <ul id="btn-topo">
                                <li><a href="Default.aspx">Home</a></li>
                                <li><a href="Default.aspx#fundo-servicos">Serviços</a></li>
                                <li><a href="Portfolio.aspx">Galeria</a></li>
                                <li><a href="SobreNos.aspx">Sobre nós</a></li>
                                <li>
                                    <a href="https://api.whatsapp.com/message/WL5TXEEFXFA4G1?autoload=1&app_absent=0"
                                        target="_blank">Conversa</a>
                                </li>
                                <li class="btn-login"><asp:LinkButton ID="btnLogin" runat="server" OnClick="btnLogin_Click">Login</asp:LinkButton></li>
                            </ul>
                        </nav>
                        <div id="meio-topo"></div>
                    </div>
                </div>
            </div>

            <h2 class="meio titulo">Galeria</h2>
            <asp:Literal ID="h3TituloLiteral" runat="server" Text="<h3 class='meio sub-titulo'>Agradecimento Especial</h3>" />
            <asp:Literal ID="pTextoLiteral" runat="server" Text="<p class='meio texto'>A Click Produções agradece a confiança no nosso trabalho. Cada imagem reflete a confiança depositada em nós. Agradecemos por permitirem que sejamos parte de suas histórias. Continuaremos transformando instantes em memórias eternas com paixão e excelência.</p>" />
            <div>
                <ul class="photoList">
                    <asp:Literal  ID="divImagemLiteral" runat="server"></asp:Literal>
                </ul>
                <asp:Literal  ID="divButtonLiteral" runat="server"></asp:Literal>
                <ul id="photoList" runat="server"></ul>
            </div>
        </div>
    </form>
    <button onclick="voltarAoTopo()" id="btnTopo" title="Voltar ao Topo">
        <svg class="svgIcon" viewBox="0 0 384 512">
            <path
                d="M214.6 41.4c-12.5-12.5-32.8-12.5-45.3 0l-160 160c-12.5 12.5-12.5 32.8 0 45.3s32.8 12.5 45.3 0L160 141.2V448c0 17.7 14.3 32 32 32s32-14.3 32-32V141.2L329.4 246.6c12.5 12.5 32.8 12.5 45.3 0s12.5-32.8 0-45.3l-160-160z">
            </path>
        </svg>
    </button>
    <footer>
        <div class="footer-portfolio">
            <div class="redes-sociais">
               <a href="https://www.instagram.com/naldo.santos_/" target="_blank"><img src="imagens/instagram.png"
                        alt="Instagram" /></a>
                <a href="https://www.facebook.com/clickproducoesnaldosantos/" target="_blank"><img
                        src="imagens/facebook.png" alt="Facebook" /></a>
                <a href="https://api.whatsapp.com/message/WL5TXEEFXFA4G1?autoload=1&app_absent=0" target="_blank"><img
                        src="imagens/whatsapp.png" alt="Whatsapp" /></a>
            </div>
            <div id="elemento-topo">
                <nav>
                    <div id="btn-topo">
                         <li><a href="Default.aspx">Home</a></li>
                        <li><a href="Default.aspx#fundo-servicos">Serviços</a></li>
                        <li><a href="Portfolio.aspx">Galeria</a></li>
                        <li><a href="SobreNos.aspx">Sobre nós</a></li>
                        <li>
                            <a href="https://api.whatsapp.com/message/WL5TXEEFXFA4G1?autoload=1&app_absent=0"
                                target="_blank">Conversa</a>
                        </li>
                    </div>
                </nav>
                <div id="meio-topo"></div>
            </div>
            <div class="footer-bottom">
                <p>&copy; 2024 Click Produções. Todos os direitos reservados.</p>
            </div>
        </div>
    </footer>
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            var images = document.querySelectorAll(".gallery-image");
            images.forEach(function (image) {
                image.addEventListener("click", function () {
                    exibirImagemAmpliada(image.src);
                });
            });
        });

        function exibirImagemAmpliada(imagemSrc) {
            var modal = document.createElement("div");
            modal.className = "custom-modal";
            var imagemAmpliada = document.createElement("img");
            imagemAmpliada.className = "modal-image";
            imagemAmpliada.src = imagemSrc;

            var closeButton = document.createElement("button");
            closeButton.className = "close-button";
            closeButton.innerHTML = "";
            closeButton.addEventListener("click", function () {
                modal.parentNode.removeChild(modal);
            });

            modal.appendChild(imagemAmpliada);
            modal.appendChild(closeButton);

            modal.addEventListener("click", function () {
                modal.parentNode.removeChild(modal);
            });

            document.body.appendChild(modal);
        }

        function voltarAoTopo() {
            window.scrollTo({
                top: 0,
                behavior: "smooth",
            });
        }

        function toggleButtonDisplay() {
            const btnTopo = document.getElementById("btnTopo");
            const scrollTop =
                document.documentElement.scrollTop || document.body.scrollTop;

            if (scrollTop > 20) {
                btnTopo.style.display = "block";
                btnTopo.style.opacity = "1";
            } else {
                btnTopo.style.opacity = "0";
                setTimeout(() => {
                    if (btnTopo.style.opacity === "0") {
                        btnTopo.style.display = "none";
                    }
                }, 300);
            }
        }

        window.addEventListener("scroll", toggleButtonDisplay);
    </script>
</body>

</html>