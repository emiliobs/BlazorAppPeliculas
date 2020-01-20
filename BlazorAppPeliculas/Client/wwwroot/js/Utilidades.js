function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("BlazorAppPeliculas.Client", "ObtenerCurrentCount")
        .then(resultado => {

            console.log("Conteo desde javascript " + resultado);
          
        });
}

function pruebaPuntoNetInstancia(dotnetHelper)
{
    dotnetHelper.invokeMethodAsync("IncrementCount");
}