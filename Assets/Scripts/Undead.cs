using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Undead : MonoBehaviour {
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

    public void DisplayTexts() {
        this.TMP_costsText.text = $"Add {name} for {cost} souls";
    }

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    public Button createUndead;
    public void CreateUndead() {
        count += 1;
        Debug.Log("Count:"+count);
    }

    public void CreateUndeadButton() {
        CreateUndead();
    }
}