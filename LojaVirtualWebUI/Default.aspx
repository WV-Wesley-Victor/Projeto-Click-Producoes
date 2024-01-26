<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LojaVirtualWebUI.Default" %>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Home</title>
    <link rel="stylesheet" href="style.css" />
    <link rel="stylesheet" href="CSS/StyleSheet.css" />
    <link rel="stylesheet" href="styleHome.css" />
    <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
    <link rel="stylesheet" type="text/css" href="https://cdn.jsdelivr.net/npm/slick-carousel@1.8.1/slick/slick.css" />
    <link rel="stylesheet" type="text/css"
        href="https://cdn.jsdelivr.net/npm/slick-carousel@1.8.1/slick/slick-theme.css" />
    <script type="text/javascript" src="https://cdn.jsdelivr.net/npm/slick-carousel@1.8.1/slick/slick.min.js"></script>
    <script src="script12.js"></script>
</head>

<body>
    <form id="form1" runat="server">
    <header>
        <div id="fundo-topo">
            <div id="img-topo" style="background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0)), url('imagem/img-alianca.jpg'); background-position: center; background-size: cover; background-repeat: no-repeat;">
                <div class="centro">
                    <div class="header">
                        <div class="logo">
                            <a href="Default.aspx"><img loading="lazy" class="meio imagem-logo" src="imagem/logo-branca.png"
                                    alt="Logo" /></a>
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
                </div>
            </div>
        </div>
    </header>
    <main>
        <div id="fundo-galeria">
            <div id="txt-galeria">
                <h1 class="h1">Galeria</h1>
            </div>
            <div id="imagem1" class="img-galeria"></div>
            <div id="imagem2" class="img-galeria"></div>
            <div id="imagem3" class="img-galeria"></div>
            <div id="imagem4" class="img-galeria"></div>
            <div id="botao-galeria">
                <a id="btn-ver-mais" href="Portfolio.aspx"><span>Ver mais</span></a>
            </div>
        </div>
        <div id="fundo-servicos">
            <div id="txt-servicos">
                <h1 class="h1">Serviços</h1>
            </div>
            <div id="card1" class="card-servicos">
                <div class="card-front">
                    <p class="title">Imagens no <del></del>Drone</p>
                    <p class="subtitle">Click Produções</p>
                </div>
                <div class="card-back">
                    <p class="texto">Capture a Magia do Seu Casamento com Nossos Serviços Exclusivos de Drone Fotográfico.</p>
                </div>
            </div>
            <div id="card2" class="card-servicos">
                <div class="card-front">
                    <p class="title">Filmagem</p>
                    <p class="subtitle">Click Produções</p>
                </div>
                <div class="card-back">
                    <p class="texto">Transforme Seu Casamento em um Filme Inesquecível com Nossos Serviços de Filmagem Profissional.</p>
                </div>
            </div>
            <div id="card3" class="card-servicos">
                <div class="card-front">
                    <p class="title">Fotografia</p>
                    <p class="subtitle">Click Produções</p>
                </div>
                <div class="card-back">
                    <p class="texto">Memorize Seu Casamento Através das Lentes de Nosso Fotógrafo Especializado.</p>
                </div>
            </div>
            <div id="card4" class="card-servicos">
                <div class="card-front">
                    <p class="title">Plataforma 360</p>
                    <p class="subtitle">Click Produções</p>
                </div>
                <div class="card-back">
                    <p class="texto">Explore Cada Ângulo do Seu Casamento com Nossa Plataforma 360° Exclusiva.</p>
                </div>
            </div>
        </div>
        <div id="fundo-instagram">
            <div id="txt-insta">
                <h1 class="h1">Siga-nos no instagram</h1>
            </div>
            <a target="_blank"
                href="https://www.instagram.com/p/C0shWWut6iq/?utm_source=ig_web_copy_link&igsh=MjM0N2Q2NDBjYg==">
                <div id="insta1" class="img-insta"></div>
            </a>
            <a target="_blank"
                href="https://www.instagram.com/p/C0shQDGtJo9/?utm_source=ig_web_copy_link&igsh=MjM0N2Q2NDBjYg==">
                <div id="insta2" class="img-insta"></div>
            </a>
            <a target="_blank"
                href="https://www.instagram.com/p/C0giCf7umQk/?utm_source=ig_web_copy_link&igsh=MjM0N2Q2NDBjYg==">
                <div id="insta3" class="img-insta"></div>
            </a>
            <a target="_blank"
                href="https://www.instagram.com/p/C0fkVrUt5Uu/?utm_source=ig_web_copy_link&igsh=MjM0N2Q2NDBjYg==">
                <div id="insta4" class="img-insta"></div>
            </a>
        </div>
    </main>
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
        </form>
    <script>
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
    </script>>
</body>

</html>