using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueGameHandler : MonoBehaviour
{

    public static int playerStat;
    //public GameObject textGameObject;

    //void Start () { UpdateScore (); }

    void Update()
    {                // Remove this function when PauseMenu is added
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void AddPlayerStat(int amount)
    {
        playerStat += amount;
        Debug.Log("Current Player Stat = " + playerStat);
        //      UpdateScore ();
    }

    //voidÂ UpdateScore () {
    //        Text scoreTextB = textGameObject.GetComponent ();
    //        scoreTextB.text = "Score: " + score; }

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