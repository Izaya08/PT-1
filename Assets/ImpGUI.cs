using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ImpGUI : MonoBehaviour
{
    public string Labeltext = "Hello Fellow Gamer";
    [SerializeField] private TextMeshProUGUI GUIText;


    public void OnGUI()
    {
        GUI.Box(new Rect(10, 20, 1450, 700), "Start");

        if (GUI.Button(new Rect(10, 60, 200, 200), "Player One"))
        {
            print("player One Stats");
            Labeltext = "Name: Marcus Ureta\n\rAttck: 10000\n\rDefense: 6969\n\rSpeed: 10001\n\rLuck: 100\r\nIntelligence: Infinite\r\nSpecial: Being Built Different";
        }
        if (GUI.Button(new Rect(10, 280, 200, 200), "Player Two"))
        {
            print("player Two Stats");
            Labeltext = "Name: Micheal George\n\rAttck: 69\n\rDefense: n + 1993 + r:\n\rSpeed: 150\n\rLuck: 1\r\nIntelligence: 90\r\nSpecial: Biryani";
        }
        if (GUI.Button(new Rect(10, 500, 200, 200), "Player Three"))
        {
            print("player Three Stats");
            Labeltext = "Name: Enzo Villarin\n\rAttck: -69\n\rDefense: -420\n\rSpeed: -69420\n\rLuck: -1000\r\nIntelligence: 10\r\nSpecial: 150"; 
        }

        GUI.Label(new Rect(800, 300, 500, 500), Labeltext);
    }
}
