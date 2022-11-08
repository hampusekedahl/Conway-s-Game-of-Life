module Main 
open System.Drawing
open System
open System.IO
open Gui
open Renderer
open GameTypes
open Game

type UserAction = | Start | Stop

let buttons = [startBtn;pauseBtn]

let userAction = [Start;Stop]

let rec mergeobservables (xs:Windows.Forms.Button list) ys =
            match xs, ys with
            | head::[], head1::[] -> (Observable.map (fun _-> head1) head.Click)
            | head::tail, head1::tail2 ->  (Observable.merge
                             <| (Observable.map (fun _-> head1) head.Click)
                             <| mergeobservables tail tail2)
            | _ -> failwith("List are not same length!")


let observables = mergeobservables buttons userAction

let rec main gameContext observable = async {
    renderMap(gameContext.Map.Grid)
   
    do! Async.Sleep(200)


    match observable with 
        | Start -> return! main gameContext observable
        | Stop -> return! main gameContext observable
        | _ -> return! main gameContext observable

    if gameContext.Pause then 
        return! main gameContext observable
    else
        return! main {gameContext with Map = Cycle(gameContext.Map)} observable
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



Async.StartImmediate(main Game.createGameContext observables) 

System.Windows.Forms.Application.Run(windowForm)


    


