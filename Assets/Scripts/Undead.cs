using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.PlayerLoop;

public class Undead : MonoBehaviour
{
    //Placeholder
    public int currentCurrency = 250;

    [SerializeField] private string name = "Zombie";
    [SerializeField] private int cost = 100;
    [SerializeField] private int productionRate = 1;
    [SerializeField] private int count = 100;
    [SerializeField] private int level = 0;
    [SerializeField] private Sprite sprite;
    
    public float undeadTimeSecond = 1f;
    float elapsedTime;

    public TextMeshProUGUI TMP_statusText;

    public bool IsAffordable => currentCurrency >= this.cost; 
    
    public void DisplayTexts()
    {
        this.TMP_statusText.text = $"{count}x {name} = {productionRate * count} souls/second (Level{level})";
    }
    
    // Start is called before the first frame update
    void Start()
    {
        DisplayTexts();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateProduction();
    }

    void UpdateProduction() {
        this.elapsedTime += Time.deltaTime;
        if (this.elapsedTime >= this.undeadTimeSecond) {
            UndeadProduction();
            this.elapsedTime -= this.undeadTimeSecond;
        }
    }
    
    private void CreateUndead() {
        if (!IsAffordable)
        {
            return;
        }
        count += 1;
        currentCurrency -= cost;
        DisplayTexts();
        Debug.Log("CurrentCurrency:"+currentCurrency);
        Debug.Log("Count:"+count);
    }

    public void UndeadProduction() {
        //TODO: Make Mathf.Pow to multiply total productionRate with upgradeMultiplier
        currentCurrency += this.productionRate * this.count;
        Debug.Log("Production Rate:"+productionRate);
    }

    public void CreateUndeadButton() {
        CreateUndead();
    }
}
