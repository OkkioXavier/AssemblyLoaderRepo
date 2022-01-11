// See https://aka.ms/new-console-template for more information
using System.Runtime.Loader;
using System;

Console.WriteLine(Environment.Version);

try
{
	var assembly = AssemblyLoadContext.Default.LoadFromAssemblyName(new System.Reflection.AssemblyName("System.Drawing.Common, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51"));

	Console.WriteLine($"Loaded: {assembly.FullName}");
}
catch (Exception ex)
{
	Console.WriteLine(ex.ToString());
}

Console.Read();
