// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Test World! Welcome to Testing");
Console.WriteLine("New Test Message!");

internal static class Defaults
{
    public static string SdkVersion => "Dotnet.Measurement {{ SDKVERSION }}";
    public static string SdkBuildDate => "{{ SDKBUILDDATE }}";
}
