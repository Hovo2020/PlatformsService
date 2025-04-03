using System;

namespace PlatformService.SyncDataServices.Http;

public class HttpCommandDataClient : ICommandDataClient {
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _config;
    
    public HttpCommandDataClient(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient; 
        _config = config;
    }
    
    public async Task SendPlatformToCommand(PlatformReadDto plat)
    {
        var httpContent = new StringContent(
            JsonSerializer.Serialize(plat),
            Encoding.UTF8,
            "application/json"
        )

        var response = await _httpClient.PostAsync($"{_config["CommandService"]}", httpContent);

        if(response.IsSuccessCode) {
            Console.WriteLine("Sync POST to CommandService was OK!");
        }
        else {
            System.Console.WriteLine("sync POST to CommandService was failed!");
        }
    }
}