using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2 : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtObj1;
    public GameObject ArtObj2;
    public GameObject ArtObj3;
    public GameObject ArtObj4;
    public GameObject ArtObj5;
    public GameObject ArtBG1;
    public GameObject ArtBG2;
    public GameObject ArtBG3;
    public GameObject ArtBG4;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice1c;
    public GameObject Choice1d;
    public GameObject Choice1e;
    public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    public DialogueGameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        ArtChar1.SetActive(true);
        ArtObj1.SetActive(false);
        ArtObj2.SetActive(false);
        ArtObj3.SetActive(false);
        ArtObj4.SetActive(false);
        ArtObj5.SetActive(false);
        ArtBG1.SetActive(false);
        ArtBG2.SetActive(true);
        ArtBG3.SetActive(false);
        ArtBG4.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Choice1d.SetActive(false); 
        Choice1e.SetActive(false); // function Choice1aFunct()
        Choice2a.SetActive(false); // function Choice2aFunct()
        Choice2b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

        // Dialogue Initialization
        dialogue.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "YOU";
        Char2speech.text = "I’m ready for some shelling!";
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
        if (primeInt == 1) {
            // AudioSource.Play();
        } else if (primeInt == 2) {
            dialogue.SetActive(true);
            ArtBG1.SetActive(true);
            ArtBG2.SetActive(false);
            ArtObj5.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "NARRATOR";
            Char1speech.text = "After you set your stuff down you start thinking about what you might need to bring down the beach with you";
            Char2name.text = "";
            Char2speech.text = "";
        } else if (primeInt == 3) {
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "I’m a pretty experienced sheller, so this shouldn’t take too long. Do I need to bring anything with me?";
            //gameHandler.AddPlayerStat(1);
        } else if (primeInt == 4) {
            ArtChar1.SetActive(true);
            Char1name.text = "Player Choice";
            Char1speech.text = "What do you bring?";
            Char2name.text = "";
            Char2speech.text = "";
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); 
            Choice1c.SetActive(true); 
            Choice1d.SetActive(true); 
            Choice1e.SetActive(true); 
            nextButton.SetActive(false);
            allowSpace = false;
        } else if (primeInt == 5) {
            ArtChar1.SetActive(true);
            ArtObj5.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "Im officially ready to go! Should I turn left or right to start?";
            //gameHandler.AddPlayerStat(1);
        } else if (primeInt == 6) {
            ArtChar1.SetActive(false);
            Char1name.text = "Player";
            Char1speech.text = "(text here)";
            Char2name.text = "";
            Char2speech.text = "";
        //} else if (primeInt == 7) {
            Char1name.text = "(text here)";
            Char1speech.text = "(text here)";
            Char2name.text = "";
            Char2speech.text = "";
        //} else if (primeInt == 8) {
            Char1name.text = "(text here)";
            Char1speech.text = "(text here)";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
            Choice1c.SetActive(true);
            Choice1d.SetActive(true);
            Choice1e.SetActive(true);
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100){
            ArtChar1.SetActive(true);
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true); ;
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
            ArtObj1.SetActive(false);
            ArtObj2.SetActive(false);
            ArtObj3.SetActive(false);
            ArtObj4.SetActive(false);
            ArtObj5.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "Im officially ready to go! Should I turn left or right to start?";
            primeInt = 9;
            nextButton.SetActive(false);
            allowSpace = false;

        }

        else if (primeInt == 200)
        {
            ArtChar1.SetActive(true);
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true);
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
            ArtObj1.SetActive(false);
            ArtObj2.SetActive(false);
            ArtObj3.SetActive(false);
            ArtObj4.SetActive(false);
            ArtObj5.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "Im officially ready to go! Should I turn left or right to start?";
            primeInt = 9;
            nextButton.SetActive(false);
            allowSpace = false;

        }

        else if (primeInt == 300)
        {
            ArtChar1.SetActive(true);
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true);
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
            ArtObj1.SetActive(false);
            ArtObj2.SetActive(false);
            ArtObj3.SetActive(false);
            ArtObj4.SetActive(false);
            ArtObj5.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "Im officially ready to go! Should I turn left or right to start?";
            primeInt = 9;
            nextButton.SetActive(false);
            allowSpace = false;

        }

        else if (primeInt == 400)
        {
            ArtChar1.SetActive(true);
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true);
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
            ArtObj1.SetActive(false);
            ArtObj2.SetActive(false);
            ArtObj3.SetActive(false);
            ArtObj4.SetActive(false);
            ArtObj5.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "Im officially ready to go! Should I turn left or right to start?";
            primeInt = 9;
            nextButton.SetActive(false);
            allowSpace = false;

        }
        else if (primeInt == 500)
        {
            ArtChar1.SetActive(true);
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true);
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
            ArtObj1.SetActive(false);
            ArtObj2.SetActive(false);
            ArtObj3.SetActive(false);
            ArtObj4.SetActive(false);
            ArtObj5.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "Im officially ready to go! Should I turn left or right to start?";
            primeInt = 9;
            nextButton.SetActive(false);
            allowSpace = false;

        }
        else if (primeInt == 700)
        {
            SceneChange2a();
        }
        else if (primeInt == 800)
        {
            SceneChange2b();
        }
        else if (primeInt == 10)
        {
            Char1name.text = "(text here)";
            Char1speech.text = "(text here)";
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
        Char1name.text = "Choice Made: No";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "Nah, I’m all set. I’ll be back in a jiffy, nothing could go wrong at such a beautiful beach!";
        primeInt = 99;
        ArtObj5.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        Choice1e.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        gameHandler.SetPrimaryItem("Hat");
        Char1name.text = "Hat";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "Well a hat will keep the sun out of my eyes so I can focus on the shells on the sand";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        Choice1e.SetActive(false);
        ArtObj1.SetActive(true);
        ArtObj2.SetActive(false);
        ArtObj3.SetActive(false);
        ArtObj4.SetActive(false);
        ArtObj5.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void Choice1cFunct()
    {
        gameHandler.SetPrimaryItem("EpiPEN");
        Char1name.text = "EpiPen";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "My doctor said I have to keep this with me at all times, might as well be prepared!";
        primeInt = 299;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        Choice1e.SetActive(false);
        ArtObj1.SetActive(false);
        ArtObj2.SetActive(true);
        ArtObj3.SetActive(false);
        ArtObj4.SetActive(false);
        ArtObj5.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1dFunct()
    {
        gameHandler.SetPrimaryItem("Sunscreen");
        Char1name.text = "Sunscreen";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "It’s a pretty bright day. No harm in taking my time shelling & being ready to re-apply";
        primeInt = 399;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        Choice1e.SetActive(false);
        ArtObj1.SetActive(false);
        ArtObj2.SetActive(false);
        ArtObj3.SetActive(true);
        ArtObj4.SetActive(false);
        ArtObj5.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void Choice1eFunct()
    {
        gameHandler.SetPrimaryItem("Sand Pail");
        Char1name.text = "Sand Pail";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "If I’m going shelling might as well bring something to put them in!";
        primeInt = 499;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        Choice1e.SetActive(false);
        ArtObj1.SetActive(false);
        ArtObj2.SetActive(false);
        ArtObj3.SetActive(false);
        ArtObj4.SetActive(true);
        ArtObj5.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void Choice2aFunct() //left click
    {
        ArtChar1.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "YOU";
        Char2speech.text = "HERE WE GO!";
        primeInt = 699;
        ArtBG1.SetActive(false);
        ArtBG2.SetActive(false);
        ArtBG3.SetActive(true);
        ArtBG4.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        Choice1e.SetActive(false);
        ArtObj1.SetActive(false);
        ArtObj2.SetActive(false);
        ArtObj3.SetActive(false);
        ArtObj4.SetActive(false);
        ArtObj5.SetActive(false);

        NextScene1Button.SetActive(true);
        allowSpace = true;
    }

    public void Choice2bFunct() //right click
    {
        ArtChar1.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "YOU";
        Char2speech.text = "HERE WE GO!";
        primeInt = 799;
        ArtBG1.SetActive(false);
        ArtBG2.SetActive(false);
        ArtBG3.SetActive(false);
        ArtBG4.SetActive(true);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        Choice1e.SetActive(false);
        ArtObj1.SetActive(false);
        ArtObj2.SetActive(false);
        ArtObj3.SetActive(false);
        ArtObj4.SetActive(false);
        ArtObj5.SetActive(false);

        NextScene1Button.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange2a()
    {
        SceneManager.LoadScene("S3_Shell");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("S3_Shell");
    }
}
