using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3 : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtBG1;
    public GameObject ArtBG2;
    public GameObject ArtBG3;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice1c;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        dialogue.SetActive(true);
        Char1name.text = "YOU";
        Char1speech.text = "Hmm anything over here?";
        Char2name.text = "";
        Char2speech.text = "";
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt++;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Nope, just a rock";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "How about here?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 4)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Nope, just a dead crab";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 5)
        {
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "What’s that?! Could I have already found the ‘Golden Shell’?!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
          
        }

        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Sea Chanty Lyrics* *Sea Chanty Lyrics*";
            Char2name.text = "";
            Char2speech.text = "";
            ArtChar1.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }

        else if (primeInt == 101)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I hope I find that Golden Shell soon!";
            Char2name.text = "";
            Char2speech.text = "";
            ArtChar1.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "It’s not the Golden Shell but it sure is pretty! I call it a keeper!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Too plain and boring, not worth it. Moving on with the hunt!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        ArtChar1.SetActive(true);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange3a()
    {
        SceneManager.LoadScene("S4_Sunburn");
    }
    public void SceneChange3b()
    {
        SceneManager.LoadScene("Scene3b");
    }
}
