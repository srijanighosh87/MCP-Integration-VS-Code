# MCP-with-CSharp

This is a .NET 9.0 project for working with monkeys using Model Context Protocol.

## Features

## Project Structure
- `Models/`
	- `Monkey.cs`: Defines the Monkey model.
- `Services/`
	- `MonkeyService.cs`: Provides services related which fetches monkey data from remote service.
- `Tools/`
	- `MonkeyTools.cs`: MCP tools for monkey operations.
- `Program.cs`: Main entry point for the application.
- `MCP-with-CSharp.csproj`: Project configuration file.
- `MCP-with-CSharp.sln`: Solution file.
- `bin/` and `obj/`: Build output and intermediate files.
 - `.vscode/mcp.json`: MCP configuration file for the project.

## Requirements

This project is a demo for the MCP (Model Context Protocol) model context protocol. It demonstrates how to use MCP server to interact with a remote service that provides information as JSON.

## MCP Model Context Protocol
The project uses MCP to query a remote service and retrieve monkey data in JSON format. This showcases how MCP can be used for model-driven APIs and remote data access.

## Required Libraries for MCP Server
To implement the MCP server, the following nuget packages are used:
- `ModelContextProtocol`
- `Microsoft.Extensions.Hosting`
- `System.Text.Json`
