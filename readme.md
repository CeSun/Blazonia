# 🪢 Blazonia

[![Nuget](https://img.shields.io/nuget/v/Blazonia)](https://www.nuget.org/packages/Blazonia/)

## 🤔 What is this?

Blazonia enables developers to use the **<a href="https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor">Blazor</a> syntax** to build **<a href="https://avaloniaui.net/">Avalonia</a> applications**. Compared to Avalonia’s original XAML syntax, Blazonia’s Blazor-based approach is more concise and straightforward, allowing you to develop pages using a **single file**. It is particularly suitable for **small to medium-sized** client applications.

✨ **Note**

- 🚫 After using Blazonia, there will be **no HTML code or WebView components** involved.
- 🤩 **Fully utilizes** native Avalonia controls

Thanks to Avalonia's cross-platform capabilities, Blazonia enables developers to rapidly build **beautiful**, **pixel-perfect** applications for 💻 **desktop**, 📱 **mobile**, and 🌐 **web** platforms.

## 🌰 A Simple Example

```razor
@page "/"

<Window Title="Counter" Width="600" Height="400">
    <StackPanel>
        <Label FontSize="30">You pressed @_count times </Label>
        <CheckBox @bind-IsChecked="_showButton">Button visible</CheckBox>
        @if (_showButton! == true)
        {
            <Button OnClick="OnButtonClick">+1</Button>
        }
    </StackPanel>
</Window>

@code {

    int _count;
    
    bool? _showButton = true;
    
    void OnButtonClick() => _count++;
}
```

![Counter](/images/Blazonia.png "Counter")

## 🛫 Start

1. Install project template

```powershell
dotnet new install BlazoniaTemplate

```

2. Create a new project

```powershell
dotnet new blazonia -o BlazoniaApp
```

Please use Rider to edit the project, because the code hints of razor files in Visual Studio 2022 and VS Code may fail.

## 📄 Acknowledge

Blazonia is a fork of the [https://github.com/Epictek/Avalonia-Blazor-Bindings](https://github.com/Epictek/Avalonia-Blazor-Bindings) branch, maintained by developers including Microsoft, Dreamescaper, warappa, and Epictek.

Blazor's syntax is highly approachable and beginner-friendly. However, since the original repository appears to be inactive, I will continue to maintain this project. As the original name is already taken on NuGet, I have renamed it to Blazonia (Blazor + Avalonia) to facilitate publishing the NuGet package and project template.
