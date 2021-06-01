using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserState : MonoBehaviour
{
    // Start is called before the first frame update
    private string playerName;
    private int lastLevelIndex;
    private int mass;
    private int level;
    private int bodyId;
    private string bodyColor;
    private int experience;
    private void Start()
    {
        playerName = PlayerPrefs.GetString("playerName", "player");
        lastLevelIndex = PlayerPrefs.GetInt("lastLevelIndex", 0);
        mass = PlayerPrefs.GetInt("mass", 0);
        level = PlayerPrefs.GetInt("level", 1);
        experience = PlayerPrefs.GetInt("experience", 1);
        bodyId = PlayerPrefs.GetInt("bodyId", 0);
        bodyColor = PlayerPrefs.GetString("bodyColor", "#000000");
    }

    public void UpdateExperience(int dExp)
    {
        experience += dExp;
        PlayerPrefs.SetInt("experience", experience);
    }
    public void SetBodyColor(Color color)
    {
        bodyColor = color.ToString();
        PlayerPrefs.SetString("bodyColor", bodyColor);
    }
    public string GetName()
    {
        return playerName;
    }
}
