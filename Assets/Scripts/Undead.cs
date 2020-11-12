using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Undead : MonoBehaviour
{
    //Placeholder
    public int currentCurrency = 250;

    [SerializeField] private string name;
    [SerializeField] private int cost;
    [SerializeField] private int productionRate;
    [SerializeField] private int count;
    [SerializeField] private int level;
    [SerializeField] private Sprite sprite;

    public TextMeshProUGUI TMP_costsText;

    public bool IsAffordable => currentCurrency >= this.cost; 
    
    public void DisplayTexts()
    {
        this.TMP_costsText.text = $"{count}x {name} = {productionRate} souls/second (Level{level})";
    }
    
    // Start is called before the first frame update
    void Start()
    {
        DisplayTexts();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
