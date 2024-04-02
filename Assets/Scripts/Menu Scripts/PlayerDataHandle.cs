using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDataHandle : MonoBehaviour
{
    //Static Class for save the current player data;
    //Singleton pattern

    public static PlayerDataHandle Instance;

    public string PlayerName;
    
    public int Score;

    private void Awake()
    {
        if (Instance != null)
    {
        Destroy(gameObject);
        return;
    }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
