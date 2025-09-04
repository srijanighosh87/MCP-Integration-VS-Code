using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ModelContextProtocol.Server;
using System.ComponentModel;

var builder = Host.CreateApplicationBuilder(args);
builder.Logging.AddConsole(consoleLogOptions =>
{
    // Configure all logs to go to stderr
    consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace;
});
builder.Services
    .AddMcpServer() // adds MCP server support
    .WithStdioServerTransport()
    .WithToolsFromAssembly() // automatically registers all tools in the current assembly
    ;

await builder.Build().RunAsync();

[McpServerToolType]
public static class EchoTool
{
    // This method is automatically registered as an MCP tool 
    // because of the McpServerToolType attribute on the class
    // and the McpServerTool attribute on the method.

    /// <summary>
    /// Echoes the message back to the client.
    /// </summary>
    /// <param name="message">The message.</param>
    [McpServerTool, Description("Echoes the message back to the client.")]
    public static string Echo(string message) => $"Hello from C# : {message}";

    /// <summary>
    /// Reverses the message.
    /// </summary>
    /// <param name="message">The message to be reversed.</param>
    [McpServerTool, Description("Reverses the message.")]
    public static string Reverse(string message) => $"Reverse message : {message.Reverse().ToString()}";

    /// <summary>
    /// Returns the length of the message.
    /// </summary>
    /// <param name="message">The message for which the length has to be calculated.</param>
    [McpServerTool, Description("Calculate the length of the message.")]
    public static string Length(string message) => $"Message length : {message.Length}";
}