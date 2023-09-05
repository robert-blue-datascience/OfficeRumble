using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
   
    private void Awake() 
    {
        // If the singleton value is empty, assign this scrpt as the singleton
        // otherwise, destroy this as it was create in duplicate fashion
        if (instance == null) instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
