## MyASPCoreFSharpServer
Simple Restful API Server, written with F# and ASP.NET Core 2

The project was originally created by:

```bash
dotnet new webapi -lang F# -o ApiServer
```

Some notable modification:

* Support CORS (most tolerant!).
* Disable HTTPS Redirection.
* Return Response with Status Code (Plain Text, JSON).

Run:

```bash
dotnet build
dotnet run
```

```bash
Now listening on: https://localhost:5001
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
```

Test:

Use Fiddler:

```bash
GET http://localhost:5000/api/values/9
Accept: application/json; text/plain
```

Debug:

* In Visual Studio Code, click "Start Debugging" in Debug Tab. NB: No browser is automatically loaded!

Enjoy!

Also, if Java/JRE is prefered, see [1].

## Software Environment:

* .NET Core SDK 2.1 x64 (https://www.microsoft.com/net/download)
* Visual Studio Code x64 1.25.1
* Windows 8.1 x64

## Reference:

[1] https://github.com/ThachNgocTran/MyJettyJerseyServer
