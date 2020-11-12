using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOfflineCurrency : MonoBehaviour
{
    
    //Placeholders, replace with currency-hook-in-references later
    public int placeholderSouls;

    public int PlaceholderSouls
    {
        get => PlayerPrefs.GetInt("SoulsEarned", 0);
        private set => PlayerPrefs.SetInt("SoulsEarned", value);
    }
    
    
    private void Awake()
    {
        
    }

    private void OnApplicationQuit()
    {
        
    }
}
