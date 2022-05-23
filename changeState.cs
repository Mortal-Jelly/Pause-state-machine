GameState CurrentGameState = GameStateManager.Instance.CurrentGameState;
GameState newGameState = CurrentGameState == GameState.Gameplay
    ? GameState.paused
    : GameState.Gameplay;



//Example of how it can be used.

if(Input.GetKeyDown(KeyCode.Escape))
        {
            GameState CurrentGameState = GameStateManager.Instance.CurrentGameState;
            GameState newGameState = CurrentGameState == GameState.Gameplay
                ? GameState.paused
                : GameState.Gameplay;
         }
         
