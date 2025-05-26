// See https://aka.ms/new-console-template for more information
static async Task OperacionConErrorAsync() {
    await Task.Delay(2000);
    throw new InvalidOperationException("Error simulado en operación asincrónica");
}

static async Task ProbarManejoExcepcionesAsync() {
    try{
        await OperacionConErrorAsync();
    }
    catch (Exception error) {
        Console.WriteLine("Se capturó la excepción.\nLa excepción en cuestión es:");
        Console.WriteLine($"{error}\n");
    }
}

//MAIN
//await OperacionConErrorAsync(); SI ESTA LINEA SE LLEGASE A DESCOMENTAR TIRARÍA UN ERROR (NO MUESTRA CONSOLA CASI)
await ProbarManejoExcepcionesAsync();