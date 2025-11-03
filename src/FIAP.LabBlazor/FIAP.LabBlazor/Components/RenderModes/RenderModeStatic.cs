@page "/render-static"

<PageTitle>Static SSR</PageTitle>

<div class= "card mb-4" >
    < div class= "card-header bg-secondary text-white" >
        < h3 >🔵 Static SSR(Padrão)</ h3 >
    </ div >
    < div class= "card-body" >
        < p >< strong > Renderizado:</ strong > Servidor </ p >
        < p >< strong > Interatividade:</ strong > ❌ Nenhuma </ p >
        < p >< strong > Quando usar:</ strong > Páginas estáticas, sem necessidade de interação</p>
        
        <hr />
        
        <p>Hora do servidor: @DateTime.Now.ToString("HH:mm:ss") </ p >


        < button class= "btn btn-danger" @onclick = "Incrementar" >
            ⚠️ Este botão NÃO funciona (sem rendermode)
        </button>
        
        <p class= "mt-3 text-muted" >
            < small > Este componente é renderizado uma vez no servidor e enviado como HTML estático.</small>
        </p>
    </div>
</div>

@code {
    private int contador = 0;

private void Incrementar()
{
    contador++; // Não funciona porque não há rendermode definido
}
}