namespace ApiServer.Controllers

open System
open Microsoft.AspNetCore.Mvc

(* 
    SDK (dotnet.exe): dotnet-sdk-2.1.302-win-x64
    Created with: dotnet new webapi -lang F# -o ApiServer
*)

type FrontEndResult = {
    Status: string
    Message: string
    Data: Object
}

[<Route("api/[controller]")>]
[<ApiController>]
type ValuesController () =
    inherit ControllerBase()

    [<HttpGet>]
    member this.Get() =
        let values = [|"value1"; "value2"|]
        ActionResult<string[]>(values)

    (*
        Tested with Fiddler:
        GET http://localhost:5000/api/values/9
        Accept: application/json; text/plain
    *)
    [<HttpGet("{id}")>]
    member this.Get(id:int) =

        (*
            All possible inherited classes of ActionResult.
            https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.actionresult?view=aspnetcore-2.1
        *)
        let res = ObjectResult()

        match id with
        | id when id < 10 -> 
            res.StatusCode <- (Nullable)400
            res.Value <- "Wrong id"         // Return a simple text
        | _ ->
            res.StatusCode <- (Nullable)200
            res.Value <-
                {
                    Status = "ok"
                    Message = "Here is your id"
                    Data = id
                }                           // Return a JSON-formmated text.
        res

    [<HttpPost>]
    member this.Post([<FromBody>] value:string) =
        ()

    [<HttpPut("{id}")>]
    member this.Put(id:int, [<FromBody>] value:string ) =
        ()

    [<HttpDelete("{id}")>]
    member this.Delete(id:int) =
        ()
