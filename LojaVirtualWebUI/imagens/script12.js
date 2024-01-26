//Array com URLs das imagens de fundo e degradês
let imagensDeFundoComDegradê = [
    'linear-gradient(to bottom, rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0)), url(imagens/foto-casal1.jpg)',
    'linear-gradient(to bottom, rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0)), url(imagens/foto-casal2.jpg)',
    'linear-gradient(to bottom, rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0)), url(imagens/foto-casal3.jpg)'
];

let indexAtual = 0;
let tempoTroca = 3000; // Tempo em milissegundos (3 segundos)

// Pré-carregar imagens
function preCarregarImagens() {
    for (let i = 0; i < imagensDeFundoComDegradê.length; i++) {
        let img = new Image();
        img.src = imagensDeFundoComDegradê[i].replace('url(', '').replace(')', '');
    }
}
preCarregarImagens();

function trocarImagemDeFundo() {
    // Altera a propriedade background-image com degradê e imagem de fundo
    document.getElementById('img-topo').style.background = imagensDeFundoComDegradê[indexAtual];
    document.getElementById('img-topo').style.backgroundSize = 'cover';
    document.getElementById('img-topo').style.backgroundPosition = 'center';
    document.getElementById('img-topo').style.backgroundRepeat = 'no-repeat';
    // Atualiza o índice para a próxima imagem
    indexAtual = (indexAtual + 1) % imagensDeFundoComDegradê.length;
}

// Executa a função de troca de imagem a cada tempoTroca milissegundos
setInterval(trocarImagemDeFundo, tempoTroca);
