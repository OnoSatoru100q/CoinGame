using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalManager : MonoBehaviour
{
    const int FirstMedals = 10;
    public int Medals = FirstMedals;
    public void GetMedal(int medal)
    {
        Medals += medal;
    }
    public void LostMedal()
    {
        if (Medals > 0)
        {
            Medals--;
        }
    }
    private void OnGUI()
    {
        GUI.color = Color.black;
        string label = "メダル" + Medals;
        GUI.skin.label.fontSize = 100;
        GUI.Label(new Rect(50, 50, 600, 400), label);
    }
}
