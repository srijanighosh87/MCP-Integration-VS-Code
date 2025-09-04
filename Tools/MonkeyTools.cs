using System;
using System.ComponentModel;
using System.Text.Json;
using MCP_with_CSharp.Services;
using ModelContextProtocol.Server;

namespace MCP_with_CSharp.Tools;

/// <summary>
/// Monkey Tools
/// </summary>
[McpServerToolType]
public class MonkeyTools
{
    /// <summary>
    /// Monkey Service
    /// </summary>
    /// <param name="monkeyService"><see cref="MonkeyService"/> to be used for tools.</param>
    [McpServerTool, Description("Get all monkeys")]
    public static async Task<string> GetMonkeyList(MonkeyService monkeyService)
    {
        var monkeys = await monkeyService.GetMonkeys();
        if (monkeys == null || monkeys.Count == 0)
        {
            return "No monkeys found.";
        }
        return JsonSerializer.Serialize(monkeys);
    }

    /// <summary>
    /// Get a monkey by name 
    /// </summary>
    /// <param name="name">Name of the monkey to be fetched.</param>
    [McpServerTool, Description("Get monkey by name")]
    public static async Task<string> GetMonkeyByName(string name, MonkeyService monkeyService)
    {
        var monkey = await monkeyService.GetMonkey(name);
        if (monkey == null)
        {
            return $"No monkey found with name: {name}";
        }
        return JsonSerializer.Serialize(monkey);
    }
}
