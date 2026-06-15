using ScreenSound.Modelos;
namespace ScreenSound.Menus;
using OpenAI.Chat;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        ChatClient client = new ChatClient(
            model: "gpt-4o-mini",
            apiKey: "SUA-CHAVE-API"
        );

        ChatCompletion completion = client.CompleteChatAsync(
            new SystemChatMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal.")).GetAwaiter().GetResult();

        banda.Resumo = completion.Content[0].Text;

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}