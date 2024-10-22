using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ImpGUI : MonoBehaviour
{
    public string Labeltext = "Hello Fellow Gamer";

    [SerializeField] private TextMeshProUGUI GUIText;
    public int Player1attack = 100;
    public int Player2attack = 75;
    public int Player3attack = 60;

    public int Player1Defense = 200;
    public int Player2Defense = 225;
    public int Player3Defense = 230;

    public int Player1Speed = 50;
    public int Player2Speed = 70;
    public int Player3Speed = 60;

    public int Player1Luck = 30;
    public int Player2Luck = 40;
    public int Player3Luck = 35;

    public int Player1Intelligence = 150;
    public int Player2Intelligence = 170;
    public int Player3Intelligence = 140;

    public int Player1Special = 20;
    public int Player2Special = 25;
    public int Player3Special = 30;

    public void OnGUI()
    {
        GUI.Box(new Rect(10, 20, 1450, 700), "Start");

        if (GUI.Button(new Rect(10, 60, 200, 200), "Player One"))
        {
            print("player One Stats");
            Labeltext = $"Name: Marcus Ureta\n\rAttck: {Player1attack}\n\rDefense: {Player1Defense}\n\rSpeed: {Player1Speed}\n\rLuck: {Player1Luck}\r\nIntelligence: {Player1Intelligence}\r\nSpecial:{Player1Special}";
        }
        if (GUI.Button(new Rect(10, 280, 200, 200), "Player Two"))
        {
            print("player Two Stats");
            Labeltext = $"Name: Micheal George\n\rAttck: {Player2attack}\n\rDefense: {Player2Defense}:\n\rSpeed: {Player2Speed}\n\rLuck: {Player2Luck}\r\nIntelligence: {Player2Intelligence}\r\nSpecial: {Player1Special}";
        }
        if (GUI.Button(new Rect(10, 500, 200, 200), "Player Three"))
        {
            print("player Three Stats");
            Labeltext = $"Name: Enzo Villarin\n\rAttck: {Player3attack}\n\rDefense: {Player3Defense}\n\rSpeed: {Player3Speed}\n\rLuck: {Player3Luck}\r\nIntelligence: {Player3Intelligence}\r\nSpecial: {Player3Special}";
        }


        GUI.Label(new Rect(800, 300, 500, 500), Labeltext);
    }
       
    }

