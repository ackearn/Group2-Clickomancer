﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.PlayerLoop;

public class Undead : MonoBehaviour
{
    [Header("Drag and Drop references here")]
    public SoulCount soulRef;
    public TextMeshProUGUI TMP_statusText;
    public TextMeshProUGUI TMP_costsText;
    [SerializeField] private Sprite sprite;

    [Header("Configurable values")]
    public int currentCurrency = 250;

    [SerializeField] private string name = "Zombie";
    [SerializeField] private int cost = 100;
    public int productionRate = 1;
    [SerializeField] private int count = 0;
    [SerializeField] private int level = 0;

    
    public float undeadProductionPerSecond = 1f;
    float elapsedTime;

    public int Count
    {
        get => PlayerPrefs.GetInt("Owned"+name, 0);
        set => PlayerPrefs.SetInt("Owned"+name, value);
    }
    
    
    public bool IsAffordable => soulRef.Souls >= this.cost; 
    
    public void DisplayTexts()
    {
        this.TMP_statusText.text = $"{Count}x {name} = {productionRate * Count} souls/second (Level{level})";
        this.TMP_costsText.text = $"Zombie costs: {this.cost} souls";
    }
    
    // Start is called before the first frame update
    void Start()
    {
        DisplayTexts();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayTexts();
        UpdateProduction();
    }

    void UpdateProduction() {
        this.elapsedTime += Time.deltaTime;
        if (this.elapsedTime >= this.undeadProductionPerSecond) {
            UndeadProduction();
            this.elapsedTime -= this.undeadProductionPerSecond;
        }
    }
    
    private void CreateUndead() {
        if (!IsAffordable)
        {
            return;
        }
        Count += 1;
        soulRef.Souls -= cost;
        DisplayTexts();
        Debug.Log("CurrentCurrency:"+soulRef.Souls);
        Debug.Log("Count:"+Count);
    }

    public void UndeadProduction() {
        //TODO: Make Mathf.Pow to multiply total productionRate with upgradeMultiplier
        soulRef.Souls += this.productionRate * this.Count;
        Debug.Log("Production Rate:"+productionRate);
    }

    public void CreateUndeadButton() {
        CreateUndead();
    }
}
