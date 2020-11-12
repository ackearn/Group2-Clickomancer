using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Undead : MonoBehaviour
{
    //Placeholder
    public int currentCurrency = 250;

    [SerializeField] private string name = "Zombie";
    [SerializeField] private int cost = 100;
    [SerializeField] private int productionRate = 5;
    [SerializeField] private int count = 100;
    [SerializeField] private int level = 0;
    [SerializeField] private Sprite sprite;
    
    public float undeadTimeSecond = 1f;
    float elapsedTime;

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

    public void CreateUndead() {
        count += 1;
        currentCurrency -= 10;
        Debug.Log("Count:"+count);
    }

    public void UndeadProduction() {
        productionRate += 1;
        Debug.Log("Count:"+productionRate);
    }

    public void CreateUndeadButton() {
        CreateUndead();
    }
}
