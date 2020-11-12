using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOfflineCurrency : MonoBehaviour
{
    
    //Placeholders, replace with currency-hook-in-references later
    public int placeholderSouls = 5;

    
    
    
    public string OfflineTime
    {
        get => PlayerPrefs.GetString("SoulsEarnedOffline", "0000-00-00");
        private set => PlayerPrefs.SetString("SoulsEarnedOffline", value.ToString());
    }
    
    
    private void Awake()
    {
        var currentTime = DateTime.Now;
        var offlineTime = Convert.ToDateTime(OfflineTime);
        var interval = currentTime - offlineTime;

        Debug.Log(currentTime);
        Debug.Log(offlineTime);
        Debug.Log(interval);
        
        Debug.Log(interval.TotalSeconds * placeholderSouls);
    }

    private void OnApplicationQuit()
    {
        OfflineTime = DateTime.Now.ToString();
    }
}
