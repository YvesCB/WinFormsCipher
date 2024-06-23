# Cipher Program

Using the Vigenère-Cipher to encrypt and decrypt plain text. With the `IEcryptDecrypt` Interface, it is possible to change the program to use a different Cipher instead.

## Setup

A MSSQL Server needs to be running and reachable. This program assumes a local server to be running.
The name of the server in `Controller.cs` needs to be adjusted before runing the code!

The program was written in .NET 8.0 and using the following NuGet packages:
* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Tools
* System.Data.DataSetExtensions