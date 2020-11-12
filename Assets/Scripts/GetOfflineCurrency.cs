using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOfflineCurrency : MonoBehaviour
{
    
    //Placeholders, replace with currency-hook-in-references later
    //public int placeholderSouls;

    public DateTime OfflineTime
    {
        get => Convert.ToDateTime(PlayerPrefs.GetString("SoulsEarnedOffline", "0"));
        private set => PlayerPrefs.SetString("SoulsEarnedOffline", value.ToString());
    }
    
    
    private void Awake()
    {
        var currentTime = DateTime.Now;
        

    }

    private void OnApplicationQuit()
    {
        OfflineTime = DateTime.Now;
    }
}
