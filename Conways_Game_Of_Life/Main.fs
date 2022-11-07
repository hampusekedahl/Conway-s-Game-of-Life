module Main 
open System.Drawing
open System
open System.IO
open Gui
open Renderer
open GameTypes
open Game

//Render Form

let rec main gameContext = async {
    renderMap(gameContext.Map.Grid)
   
    do! Async.Sleep(200)

    if gameContext.Pause then 
        return! main gameContext
    else
        return! main ({gameContext with Map = Cycle(gameContext.Map)})
    }
    
    //render Map
    //Threading.Thread.Sleep(200)

    //if ButtonPressed then 
        //match Button with
        //| Action -> main(Game.gameLoop({gameContext with State = Action.Action})
        //| Action -> main(Game.gameLoop({gameContext with State = Action.Action})
        //| Action -> main(Game.gameLoop({gameContext with State = Action.Action})
        //| Action -> main(Game.gameLoop({gameContext with State = Action.Action})
        //| Action -> main(Game.gameLoop({gameContext with State = Action.Action})
        //| Action -> main(Game.gameLoop({gameContext with State = Action.Action})
        //| Action -> main(Game.gameLoop({gameContext with State = Action.Action})
        //| Action -> main(Game.gameLoop({gameContext with State = Action.Action})
        //| _ -> main(Game.gameLoop({gameContext})

    //else 
        //if gameContext = Puause then main(gameContext)
        //else
        //main(Game.gameLoop({gameContext})

//main Game.createGameContext



Async.StartImmediate(main Game.createGameContext)

System.Windows.Forms.Application.Run(windowForm)


    


