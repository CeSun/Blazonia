# 🪢 BlazorBindings.AvaloniaBindings

[![Nuget](https://img.shields.io/nuget/v/BlazorBindings.AvaloniaBindings)](https://www.nuget.org/packages/BlazorBindings.AvaloniaBindings/)

## ⏱️ TL;DR
- Use <a href="https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor">⚡ Blazor</a> syntax for <a href="https://avaloniaui.net/">Avalonia</a> apps
- 😎 Simpler syntax than XAML
- 🪄 IntelliSense support
- Get free <a href="https://devblogs.microsoft.com/dotnet/introducing-net-hot-reload/">🔥 Hot Reload</a> support on-top
- Still  🧪 experimental

## 🤔 What Is It?

This library enables developers to build **native <a href="https://avaloniaui.net/">Avalonia</a> apps** using the .NET's **<a href="https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor">Blazor</a> UI model**.  
This means you can use the **Blazor syntax** to write and use Avalonia UI components and pages. If you used Blazor or Razor in the past, this will look very familiar.

This library **wraps native Avalonia's UI controls** and exposes them as **regular Blazor components**, so
- 🚫 ***no* hybrid HTML stuff**, but 
- 🤩 **real Avalonia UI controls**

As Avalonia is cross-platform, this 
- enables you to write beautiful 💻 **desktop, 📱 mobile and 🌐 web apps**
- **for every major platform** out there (yes, also 🐧 Linux)
- with the **same 🏁 pixel-perfect look on every platform**

And as this library builds on-top of the same foundation as the regular Blazor implementation, **Visual Studio's 🪄 IntelliSense works out-of-the-box**!

## 🔬 Example: Counter
This is an example on how you use the Blazor UI model.

This is `Counter.razor`, a **Counter** Blazor UI component that **renders native Avalonia UI controls**.  
This component
- shows a `Label` stating how often the `Button` was pressed, and
- the `Button` increments the value on each button press.

```xml
<StackPanel>
    <Label FontSize="30">You pressed @count times </Label>
    <Button Text="+1" OnClick="@HandleClick" />
</StackPanel>

@code {
    int count;

    void HandleClick()
    {
        count++;
    }
}
```

The UI markup uses the **Blazor/Razor syntax** with **Avalonia specific wrapper components** `StackPanel`, `Label` and `Button`. This is followed by **C# code** in the **`@code` section** which defines the click-handler method that increments the counter [^1].  

Please note:  
Unlike `XAML`, there is ***no* verbose and complex data-binding syntax** but just a **straight-forward use of variables and methods**. And magically, it still automatically updates `Label`'s text on every counter update.

## ⚡ Blazor
Blazor was originally a technology for interactive web apps. But the authors imagined from the start that it could also be used on-top of any UI framework. This architecture allows us to use Blazor to drive Avalonia controls.

### 🔥 Sweet Extra: Hot Reload
As this library builds on the standard Blazor building blocks, this comes with free support of Hot Reload. This means you can make code or UI changes while your app is running.

To see how Hot Reload in action, here's a video of how well Hot Reload integrates in .NET applications in general which also in essence applies to the support in this library:  

<a href="https://www.youtube.com/watch?v=H5vVVyrqdH8">📺 Hot Reload in .NET 6 In 10 Minutes or Less</a>

## ℹ️ About this repository

This repository is a fork of Deamescapers's [Experimental MobileBlazorBindings](https://github.com/DreamEscaper/MobileBlazorBindings), which I decided to fork and maintain separately. If at any point of time Avalonia developers decide to push that repository moving forward, I'll gladly contribute all of my changes to the original repository. 

### 🛠️ Build
- Open `BlazorBindings.AvaloniaBindings.sln` in Visual Studio 2022
- Build solution

#### 🪛 (Re-)Generate Blazor Wrappers
Just run `BlazorBindings.AvaloniaBindings.ComponentGenerator` - all wrapper classes in `BlazorBindings.AvaloniaBindings` get updated.

##### 🌟 Register A New Avalonia Control With The Generator
- Open `src/BlazorBindings.AvaloniaBindings/AttributeInfo.cs`
- Add new `GenerateComponent` attribute for new UI controls that are not yet supported
- Run the generator

```csharp
// Generate `Button` wrapper without further special customizations
[assembly: GenerateComponent(typeof(Button))]

// Generate `ContentControl` wrapper with 2 properties marked as accepting Blazor templates aka. `RenderFragment`s.
[assembly: GenerateComponent(typeof(ContentControl),
    ContentProperties = new[]
    {
        nameof(ContentControl.Content),
        nameof(ContentControl.ContentTemplate)
    })]
```

##### ✍️ Blazorize Your Own Avalonia Controls
If you use **3rd party Avalonia controls** or have **self-made Avalonia controls**, you can write a Blazor wrapper class yourself **by hand** - you don't need the generator for this.

1) Ensure the **Avalonia base class** of your component is **already blazorized** - if not, handle that one first following these steps
2) Create a class **named like your Avalonia control**, eg. `Button`
3) **Inherit** it from the ***Blazor* component equivalent** your Avalonia control inherits from
4) **Add properties** for each Avalonia property named as in Avalonia
5) Add the **`[Parameter]` attribute** to the property
6) Use the **actual property type** like `Thickness` but not `StyledProperty<Thickness>` - although if it is a **template property** like `ContentControl`'s `Content` property then use **`RenderFragment`** as its type
7) Add a `CreateNativeElement()` method that returns a new Avalonia control that this Blazor component should wrap
8) Override `HandleParameter(string name, object value)` to map the native value of a property to its Blazor counterpart and also set it on the native control
9) If you have a `RenderFragment` property, you also must override `RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)` - please refer to this library's wrapper sourcecode files to see what `RenderTreeBuilderHelper` method you should call.


# 🤝 Code of Conduct

This project has adopted the code of conduct defined by the Contributor Covenant
to clarify expected behavior in our community.

For more information, see the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

Thank you!

[^1]: You can also use a code-behind file, eg. for Blazor component `Foo.razor` you can add a `Foo.razor.cs` file. More details can be found in <a href="https://learn.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-8.0#partial-class-support">Blazor documentation</a>.