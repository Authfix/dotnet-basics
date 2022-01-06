// See https://aka.ms/new-console-template for more information
using DesignPatterns.Proxy.Locked;
using DesignPatterns.Proxy.Models;

Console.WriteLine("Hello, World!");

IFolder c = new MyFolder();
var folderContent = c.Read();

try
{
    IFolder d = new MyFolderProxy(1);
    d.Read();
}
catch (MyAccessException)
{
    throw;
}