using System;
using UnityEngine;
using UnityEngine.UI;

public class SoulCount : MonoBehaviour
{
    public TMPro.TMP_Text soulText;
    public double souls;

    public void Start()
    {
        souls = 1;
    }

    public void Update()
    {
        soulText.text = "Souls:  " + souls;
    }
}