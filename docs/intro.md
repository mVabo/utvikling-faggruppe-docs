---
sidebar_position: 1
---

# Spaceships Intro

Let's get you up and running with **Blazor in less than 5 minutes**.

## Getting Started

This intro guide will cover all the basics you need to set up your first project

### What you'll need

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0):
- An IDE:
  - Windows: using Microsoft's Visual Studio or Visual Studio Code is recommended.
  - MacOS/Linux: JetBrain's Rider or Visual Studio Code is recommended (as Visual Studio lacks some core features).

After downloading the SDK you can check that everything is installed correctly by opening a **new** terminal and enter the following:

```bash
~$ dotnet
```

If installed correctly, you should see the following:

```bash
Usage: dotnet [options]
Usage: dotnet [path-to-application]

Options:
-h|--help         Display help.
--info            Display .NET information.
--list-sdks       Display the installed SDKs.
--list-runtimes   Display the installed runtimes.

path-to-application:
The path to an application .dll file to execute.
```

## Creating a new project

### With a terminal

Run the following in your terminal:

```bash
~$ dotnet new blazorserver -o BlazorApp --no-https -f net7.0
```

This command creates your new Blazor app and places it in a new directory called `BlazorApp`

Navigate to the new application with this command:

```bash
~$ cd BlazorApp
```

### With Visual Studio

[This site](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/create) will show you how to create a project with nice illustrations.

## Start your site

When the project is created you can start it with this command:

```bash
~$ dotnet watch
```

The `watch` command tells dotnet to always reload the site when a change is detected, this way you dont have
to restart the project for every change.

## A possible route

This is just an example of a sequence of doing things.

1. Set up project
2. Add dependencies
3. Start making menu/start screen(html/css)
4. Implement solar system service (list planets)
5. Implement database service (get/add player(s))
6. Link database functionality to start screen
7. Make game screen (html/css)
8. Implement database functionality for game screen (get/add ships)
9. Finishing touches to css/styling
