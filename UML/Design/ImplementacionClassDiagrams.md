```mermaid
classDiagram

class Score{
    +string? PlayerName
    +int Score
    +Add(int addition)
    +EnterPlayerName(string? PlayerName)
}

class ScoreRecord{
    +Capacity
    +Score[] Scores
    +AddNewScore(Score score)
}

class NumberManager{
    +List< RainingNumber > RainingNumbers
    +int Multiplied
    +int LowestPosition
    +Move(double speed)
    +AddRandomNumber(Random random)
    +Clear()
}

class RainingNumber{
    +int Number
    +int Position
    +Move(double Speed)
}

class Game{
    +StartNewGame()
    +TurnGameOver()
    +EnterPlayerName(string Name)
    +EnterAnswer(int answer)
    +DataCenter DataCenter
}

class DataCenter{
    +List< RainingNumberData > RainingNumbers
    +bool IsGameOn
    +bool IsGameOverDisplayOn
    +Score[] Scores
    +GuardLine GuradLine
    +int TimeLeft
}


class MoveTimer{
    -Timer Timer
    +RegisterMoveMethod(Delegate gameMoveMethod)
    +double Interval
    +StartTimer()
    +StopTimer()
}

class NumberCallTimer{
    -Timer Timer
    +double[] Intervals
    +double Interval
    +double TimeLeft
    +ChangeInterval(Random rnd)
    +ChangeInterval(int index)
    +StartTimer()
    +StopTimer()
}


class GuardLine{
    +int GuardLinePosition
    +CheckTouched(NumberManager numberManager) bool
}

class Solver{
    +TrySolve(NumberManager numberManager, int Answer) bool
}

class WPFUI{
    +EnterPlayerName(string playerName)
    +EnterAnswer(int answer)
    +StartNewGame(Game game)

}

class WPFDisplayer{
    +AddNumberObj(RainingNumber newNumber)
    +PopUpGameOver()
    +ClearGameOver()
    +AddScoreRecordObj(ScoreRecord scoreRecord)
    +ClearNumbers()
    +AddTimerObj(NumberCallTimer timer)
    +AddGuardLineObj(GuardLine guardLine)
}

WPF --> WPFUI
WPF --> WPFDisplayer
WPFUI --> Game
WPFDisplayer --> DataCenter
Game *-- DataCenter
Game --> NumberCallTimer
NumberCallTimer --> Game
Game --> ScoreRecord
Game --> Solver
Game --> MoveTimer
MoveTimer --> NumberManager
Solver --> NumberManager
NumberManager "1" *--> "*" RainingNumber
ScoreRecord "1" *--> "*" Score
DataCenter --> GuardLine
DataCenter --> ScoreRecord
DataCenter --> NumberCallTimer
DataCenter --> NumberManager

```