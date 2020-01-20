using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorAppPeliculas.Client.Shared.MainLayout;


namespace BlazorAppPeliculas.Client.Pages
{
    public class CaunterBase : ComponentBase
    {
         [Inject] protected ServiciosSingleton Singleton { get; set; }
         [Inject] protected ServicioTransient Transient { get; set; }
       
        [Inject] protected IJSRuntime JS { get; set; }
       
        [CascadingParameter(Name="color")] protected string Color { get; set; }
        [CascadingParameter(Name="size")] protected string Size { get; set; }

        protected int currentCount = 0;
        static int currentCountStatic = 0;


        [JSInvokable]
        public async void IncrementCount()
        {
            currentCount++;

            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
            currentCountStatic ++;

            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");
        }

        protected async Task IncrementcountJavascript()
        {
            await JS.InvokeVoidAsync("pruebaPuntoNetInstancia", DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int>  ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }


    }
}
