using UnityEngine;
using UnityEngine.UI;

public class SoulCount : MonoBehaviour
{
    public TMPro.TMP_Text soulText;
    public int souls;
    public int soulsPerClick = 1;
    public int Souls
    {
        get => PlayerPrefs.GetInt("Souls", 0);
        set => PlayerPrefs.SetInt("Souls", value);
    }
    public void Update()
    {
        soulText.text = "Souls:" + Souls;
    }

    public void Click()
    {
        Souls += soulsPerClick;
    }
}