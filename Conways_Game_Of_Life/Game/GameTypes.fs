module GameTypes

//Game Types

type Dead = Dead of bool
type Live = Live of bool

type Cell = | Dead | Live 

type Map = {
    height: int;
    width: int;
    Grid: Cell List;
}

type Action = Clear | Puase | Start | Next | Save | Load | Increment | Decrement | Infinity | None

type GameContext = {
    Map: Map;
    State: Action;
    StepsLeft: int;
    Pause: bool;
}