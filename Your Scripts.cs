    void Awake()
    {
        GameStateManager.Instance.OnGameStateChanged += OnGameStateChanged;
        
    }

    void OnDestroy()
    {
        GameStateManager.Instance.OnGameStateChanged -= OnGameStateChanged;
    }

    private void OnGameStateChanged(GameState newGameState)
    {
        enabled = newGameState == GameState.Gameplay;
    }
