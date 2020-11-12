using System;
using UnityEngine;
using UnityEngine.UI;

public class GetOfflineCurrency : MonoBehaviour
{
    
    //Placeholders, replace with currency-hook-in-references later
    public int placeholderSouls = 5;

    public Text offlineTimeText;
    public string offlineTimeTextString;
    public Text offlineProductionText;
    public string offlineProductionTextString;
    
    
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
        
        int totalOfflineProduction = Mathf.RoundToInt((float) interval.TotalSeconds) * placeholderSouls;
        
        offlineTimeText.text = $"{offlineTimeTextString} {interval.Days}d, {interval.Hours}h, {interval.Minutes}m, {interval.Seconds}s!";
        offlineProductionText.text = $"{offlineProductionTextString} {totalOfflineProduction}!";

    }

    private void OnApplicationQuit()
    {
        OfflineTime = DateTime.Now.ToString();
    }
}
