module Renderer
open GameTypes
open Gui
open System.Drawing
//Render Buttons

let renderMap a = 
    a |> List.iteri (fun y item -> if item = Dead then gameButtons1.[y].BackColor <- Color.Red else gameButtons1.[y].BackColor <- Color.Blue;)