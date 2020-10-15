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



    // Initialize Player Stats
    void Start () {
        tote = new ArrayList();
        hasTote = false;
        numShells = 0;
        primaryItem = "";
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