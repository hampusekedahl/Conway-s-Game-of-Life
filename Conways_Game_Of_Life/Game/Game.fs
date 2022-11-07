module Game
open System
open GameTypes
//Game Logic

//let gameLoop (gameContext : Gamecontext) = 


    let inline toXY game index =
        let y = index / game.width
        let x = index % game.width
        x,y

    let inline toIndex game x y =
        y * game.width + x

    let inline isCellLive cell =
        match cell with
        | Dead -> 0
        | Live -> 1

    let inline liveAt grid (x,y) =
        let index = toIndex grid x y
        match index with
        | z when x >= grid.width -> Dead
        | z when x < 0 -> Dead
        | z when y < 0 -> Dead
        | z when y >= grid.height -> Dead
        | z -> List.item index grid.Grid   

    let inline calcNeighborsRange game index =
        let (x,y) = toXY game index
    
        [x-1,y+1; x,y+1;x+1,y+1;
        x-1,y; x+1,y;
        x-1,y-1; x,y-1; x+1,y-1]

    let inline cycleElement game index element =
        let neighborRange = calcNeighborsRange game index
        let neighbors = List.mapi (fun x y -> liveAt game y) neighborRange
        let neighborsLive = List.sumBy (fun x -> isCellLive x) neighbors
        match neighborsLive with 
        | x when element = Live && (x = 2 || x = 3) -> Live
        | x when element = Dead && x = 3 -> Live
        | _ -> Dead
 
    let inline Cycle game =
        let cycledGrid = List.mapi (fun x y -> cycleElement game x y) game.Grid
        {game with Grid = cycledGrid}
        
    let inline Clear game =
        List.init (16 * 16) (fun index -> Dead)


    let MakeGameBoard height width =
        let random = Random()
        List.init (height * width) (fun index -> if random.NextDouble() > 0.41 then Live else Dead)

    let createGameContext = 
        let height = 16
        let width = 16
        let map = {Grid = MakeGameBoard height width; height = height; width = width}
        {   
            Map = map
            State = Start
            StepsLeft = 10
            Pause = false
        }