using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueGameHandler : MonoBehaviour
{
    // Tote Bag
    public ArrayList tote = new ArrayList();

    // Player Stats
    public bool hasTote = false;
    public int numShells = 0;
    public string primaryItem = "";

    // Dialog Colors
    public Dictionary<string, Dictionary<string, string>> characterSettings;
    public Dictionary<string, Color> colors;

    // Modify Player Stats
    public string GetPrimaryItem()
    {
        return primaryItem;
    }
    public void SetPrimaryItem(string choice)
    {
        primaryItem = choice;
        Debug.Log("Player Chose Primary Item: " + choice);
    }

    public void ObtainTote()
    {
        hasTote = true;
        Debug.Log("Player Obtained the Tote");
    }

    public void AddShells(int amount)
    {
        numShells += amount;
        Debug.Log("Player Gained " + amount + " Shells. [Shells: " + numShells + "]");
    }

    public void AddItemToTote(string itemName)
    {
        tote.Add(itemName);
        Debug.Log("Added " + itemName + " to the Tote");
    }

    public void RemoveItemFromTote(string itemName)
    {
        tote.Remove(itemName);
        Debug.Log("Removed " + itemName + " from the Tote");
    }

    public bool IsItemInTote(string itemName)
    {
        return tote.Contains(itemName);
    }

    public void NewCharacterSettings(string charName)
    {
        characterSettings.Add(charName, new Dictionary<string, string>());
    }

    public bool SetCharacterSetting(string charName, string setting, string value)
    {
        if (characterSettings.ContainsKey(charName))
        {
            if (characterSettings[charName].ContainsKey(setting))
            {
                characterSettings[charName][setting] = value;
            }
            else
            {
                characterSettings[charName].Add(setting, value);
            }
            return true;
        }
        return false;
    }

    public string GetCharacterSetting(string charName, string setting)
    {
        if (characterSettings.ContainsKey(charName))
        {
            if (characterSettings[charName].ContainsKey(setting))
            {
                return characterSettings[charName][setting];
            }
        }
        return "";
    }



    // Initialize Player Stats
    void Start () {
        tote = new ArrayList();
        hasTote = false;
        numShells = 0;
        primaryItem = "";
        InitSettings();
    }

    // Initialize Dialog Settings
    public void InitSettings()
    {
        // Colors
        colors = new Dictionary<string, Color>();
        colors.Add("black", new Color(0, 0, 0));
        colors.Add("green", new Color(0, 1, 0));
        colors.Add("purple", new Color(1, 0, 1));
        colors.Add("blue", new Color(0, 0, 1));
        colors.Add("red", new Color(1, 0, 0));

        // Character Settings
        characterSettings = new Dictionary<string, Dictionary<string, string>>();
        NewCharacterSettings("YOU");
        SetCharacterSetting("YOU", "textColor", "black");
        NewCharacterSettings("NARRATOR");
        SetCharacterSetting("NARRATOR", "textColor", "purple");
    }

    // Detect Inputs
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            QuitGame();
        }
    }



    // Game Scene Manager
    public void StartGame()
    {
        SceneManager.LoadScene("S1_Arrival");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}