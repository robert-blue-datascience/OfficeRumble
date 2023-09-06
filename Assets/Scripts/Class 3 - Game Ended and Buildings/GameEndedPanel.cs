using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameEndedPanel : MonoBehaviour
{   
    [SerializeField] GameObject gameEndedPanel;
    [SerializeField] TextMeshProUGUI panelText;
    [SerializeField] string playerWonText = "Game Over - You Win!";
    [SerializeField] string playerLostText = "Game Over - You Lose!";

    // Start is called before the first frame update
    void Start()
    {   
        gameEndedPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) PlayerWon();
        if(Input.GetKeyDown(KeyCode.Alpha2)) PlayerLost();
        
    }

    public void PlayerWon()
    {
        gameEndedPanel.SetActive(true);
        panelText.text = playerWonText;
    }

    public void PlayerLost()
    {
        gameEndedPanel.SetActive(true);
        panelText.text = playerLostText;
    }
}