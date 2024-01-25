using System;
using System.IO;
using System.Linq;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace LojaVirtualWebUI
{
    public partial class Portfolio : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ClienteId"] != null)
            {
                btnLogin.Text = "Sair";
            }
            else
            {
                btnLogin.Text = "Login";
            }

            if (!IsPostBack)
            {
                ListarImagens();
            }

            if (Session["ClienteId"] == null)
            {
                h3TituloLiteral.Text = "<h3 class='meio sub-titulo'>Crie memórias para toda a vida</h3>";
                pTextoLiteral.Text = "<p class='meio texto'>Desvendar uma história de amor é como bordar emoções únicas, cada ponto representa um momento precioso. Eternizar esses instantes em imagens é a magia, capturando a essência da paixão. Ter um registro tangível desses momentos? Crie seu portfolio conosco pela aba de conversa. Estamos aqui para transformar seus momentos em obras de arte, testemunhas da beleza efêmera e eterna do amor.</p>";

                string[] caminhosDasImagens = new string[]
                {
                    "CSS/pexels-asad-photo-maldives-1024993.jpg",
                    "CSS/pexels-glauber-torquato-2219195.jpg",
                    "CSS/pexels-pixabay-219776.jpg",
                    "CSS/pexels-jonathan-borba-3397026.jpg",
                    "CSS/pexels-ihsan-adityawarman-1445697.jpg",
                    "CSS/pexels-pixabay-265893.jpg",
                };

                string tagsDasImagens = "";

                foreach (string caminhoDaImagem in caminhosDasImagens)
                {
                    string tagImagem = $"<img src='{caminhoDaImagem}' alt='Imagem'/>";
                    tagsDasImagens += tagImagem;
                }

                string botao = "<div class='button'><button><a href='https://api.whatsapp.com/message/WL5TXEEFXFA4G1?autoload=1&app_absent=0' target='_blank'>Conversa</a></button></div>";

                divImagemLiteral.Text = tagsDasImagens;
                divButtonLiteral.Text = botao;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "Sair")
            {
                Session["ClienteId"] = null;
                Session["ClienteAlbum"] = null;
                btnLogin.Text = "Login";
                Response.Redirect("Portfolio.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        private void ListarImagens()
        {
            var service = Autenticar();

            string nomeAlbum = Session["ClienteAlbum"] as string;

            string folderName = nomeAlbum;
            string folderId = ObterIdDaPasta(service, folderName);

            if (!string.IsNullOrEmpty(folderId))
            {
                ListarArquivos(service, folderId);
            }
            else
            {
                Console.WriteLine($"Pasta '{folderName}' não encontrada.");
            }
        }

        private DriveService Autenticar()
        {
            UserCredential credential;

            using (var stream = new FileStream(Server.MapPath("~/App_Data/credentials.json"), FileMode.Open, FileAccess.Read))
            {
                string credPath = Server.MapPath("~/App_Data/token.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                  GoogleClientSecrets.Load(stream).Secrets,
                  new[] { DriveService.Scope.Drive },
                  "user",
                  CancellationToken.None,
                  new FileDataStore(credPath, true)).Result;
            }

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Fotos"
            });

            return service;
        }

        private string ObterIdDaPasta(DriveService service, string folderName)
        {
            var request = service.Files.List();
            request.Q = $"name = '{folderName}' and mimeType = 'application/vnd.google-apps.folder'";
            var result = request.Execute();

            if (result.Files != null && result.Files.Count > 0)
            {
                return result.Files.First().Id;
            }

            return null;
        }

        private void ListarArquivos(DriveService service, string folderId)
        {
            var request = service.Files.List();
            request.PageSize = 1000;
            request.Q = $"'{folderId}' in parents";
            string pageToken = null;

            do
            {
                request.PageToken = pageToken;
                var result = request.Execute();

                foreach (var file in result.Files)
                {
                    var imageUrl = $"https://lh3.google.com/u/0/d/{file.Id}";
                    photoList.InnerHtml += $"<li><img class='gallery-image' src='{imageUrl}' alt='{file.Name}' referrerpolicy='no-referrer' /></li>";
                }

                pageToken = result.NextPageToken;
            } while (!string.IsNullOrEmpty(pageToken));
        }
    }
}