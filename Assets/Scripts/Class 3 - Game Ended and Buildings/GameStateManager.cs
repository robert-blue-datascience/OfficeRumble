using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager instance;
    [SerializeField] GameEndedPanel gameEndedPanel;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void PlayerWon()
    {
        gameEndedPanel.PlayerWon();
        // Play won audio
        // Play won fireworks
    }

    public void PlayerLost()
    {
        gameEndedPanel.PlayerLost();
        // Play lost audio
        // Play lost SFX
    }
    
}
