using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene9 : MonoBehaviour
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
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            
            dialogue.SetActive(true);
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "CRISPY";
            Char2speech.text = "Z-Z-Z!!!";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "What the heck?";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "CRISPY";
            Char2speech.text = "Z-Z-Z!!!";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yikes I don’t think they meant to get that crispy!";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "(you approach the snoozing, sunburnt, beach goer, do you help?)";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 7)
        {
            Char1name.text = "YOU";
            Char1speech.text = "excuse me, are you ok? You were asleep and maybe getting a little extra red!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "(text here)";
            Char1speech.text = "(text here 2)";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            /* nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true); // function Choice1bFunct() */

        }  
        // ENCOUNTER AFTER CHOICE #1  
        else if (primeInt == 100)
        {
            Char1name.text = "(text here)";
            Char1speech.text = "(text here 3)";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 9;

        }

        else if (primeInt == 200)
        {
            Char1name.text = "(text here)";
            Char1speech.text = "(text here 4)";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 9;
        }

        else if (primeInt == 300)
        {
            Char1name.text = "(text here)";
            Char1speech.text = "(text here 5)";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 9;
        }

        else if (primeInt == 10)
        {
            Char1name.text = "(text here)";
            Char1speech.text = "(text here 6)";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "(You nudge Crispy)";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "(text here)";
        Char1speech.text = "(text here 7)";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);

        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void Choice1cFunct()
    {
        Char1name.text = "(text here)";
        Char1speech.text = "(text here 8)";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 299;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange2a()
    {
        SceneManager.LoadScene("S10");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("S11");
    }

    public void SceneChange2c()
    {
        SceneManager.LoadScene("End_LoseCrabSwarm");
    }

}
