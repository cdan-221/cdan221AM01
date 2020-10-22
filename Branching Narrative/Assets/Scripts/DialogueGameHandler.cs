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
    public Dictionary<string, Dictionary<string, string>> characterSettings = new Dictionary<string, Dictionary<string, string>>();
    public Dictionary<string, Color> colors = new Dictionary<string, Color>();

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

    public void SetCharacterSetting(string charName, string setting, string value)
    {
        if (!characterSettings.ContainsKey(charName)) characterSettings.Add(charName, new Dictionary<string, string>());
        if (!characterSettings[charName].ContainsKey(setting)) characterSettings[charName].Add(setting, "");
        characterSettings[charName][setting] = value;
    }

    public string GetCharacterSetting(string charName, string setting)
    {
        try
        {
            return characterSettings[charName][setting];
        }
        catch
        {
            string characters = "";
            foreach (string key in characterSettings.Keys)
            {
                if (characters.Length > 0)
                {
                    characters += ", ";
                }
                characters += key;
            }
            Debug.Log("could not find setting \"" + setting + "\" for charName \"" + charName + "\" in characterSettings.Keys: [" + characters + "]");
            return "";
        }
    }



    // Initialize Player Stats
    void Start () {
        tote = new ArrayList();
        hasTote = false;
        numShells = 0;
        primaryItem = "";
        characterSettings = new Dictionary<string, Dictionary<string, string>>();
        colors = new Dictionary<string, Color>();
        InitSettings();
    }

    // Initialize Dialog Settings
    public void InitSettings()
    {
        // Colors
        if (!colors.ContainsKey("black")) colors.Add("black", new Color(0, 0, 0));
        if (!colors.ContainsKey("green")) colors.Add("green", new Color(0, 0.3f, 0));
        if (!colors.ContainsKey("purple")) colors.Add("purple", new Color(0.3f, 0, 0.2f));
        if (!colors.ContainsKey("blue")) colors.Add("blue", new Color(0, 0, 1f));
        if (!colors.ContainsKey("red")) colors.Add("red", new Color(1f, 0, 0.1f));
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