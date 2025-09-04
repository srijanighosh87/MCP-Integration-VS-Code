using System;
using System.Net.Http.Json;
using MCP_with_CSharp.Models;

namespace MCP_with_CSharp.Services;

/// <summary>
/// Monkey Service to fetch monkey data from remote json
/// </summary>
public class MonkeyService
{
    HttpClient _httpClient;
    public MonkeyService()
    {
        _httpClient = new HttpClient();
    }

    /// <summary>
    /// Get all monkeys
    /// </summary>
    public async Task<List<Monkey>> GetMonkeys()
    {
        List<Monkey> monkeyList = new();

        if (monkeyList?.Count > 0)
        {
            return monkeyList;
        }

        var response = await _httpClient.GetAsync("https://montemagno.com/monkeys.json");
        if (!response.IsSuccessStatusCode)
        {
            return [];
        }
        return await response.Content.ReadFromJsonAsync<List<Monkey>>() ?? [];
    }

    /// <summary>
    /// Get a monkey by name
    /// </summary>
    /// <param name="name"></param>
    public async Task<Monkey?> GetMonkey(string name)
    {
        List<Monkey> monkeyList = await GetMonkeys();
        return monkeyList.FirstOrDefault(m => m?.Name != null && m.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ?? null;
    }
}
