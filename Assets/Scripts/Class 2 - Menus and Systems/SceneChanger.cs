using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static SceneChanger instance;

    [SerializeField] string menuSceneName;
    [SerializeField] string gameSceneName;
    [SerializeField] string howToPlaySceneName;
    [SerializeField] string creditSceneName;
   
    private void Awake() 
    {
        // If the singleton value is empty, assign this scrpt as the singleton
        // otherwise, destroy this as it was create in duplicate fashion
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(menuSceneName);
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene(gameSceneName);
    }
    public void LoadHowToPlayScene()
    {
        SceneManager.LoadScene(howToPlaySceneName);
    }
    public void LoadCreditsScene()
    {
        SceneManager.LoadScene(creditSceneName);
    }
}
