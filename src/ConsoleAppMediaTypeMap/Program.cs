using System.Net.Mime;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 11 | O tipo System.Net.Mime.MediaTypeMap *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

Console.WriteLine($"MediaTypeMap.GetMediaType(\".mp3\") = {MediaTypeMap.GetMediaType(".mp3")}");
Console.WriteLine($"MediaTypeMap.GetMediaType(\"logo.svg\") = {MediaTypeMap.GetMediaType("logo.svg")}");
Console.WriteLine($"MediaTypeMap.GetExtension(\"text/plain\") = {MediaTypeMap.GetExtension("text/plain")}");

ReadOnlySpan<char> path = "/c/temp/document.docx";
Console.WriteLine($"MediaTypeMap.GetMediaType(ReadOnlySpan<char>) = {MediaTypeMap.GetMediaType(path)}");