using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueScene4 : MonoBehaviour
{
    // Variable Declartions
    public int primeInt = 1;
    public Text charName;
    public Text charSpeech;
    public DialogueGameHandler gameHandler;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtChar2;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject NextScene1Button;
    public GameObject nextButton;
    public GameObject ArtOBJ1;
    public GameObject ArtOBJ2;
    private bool allowSpace = true;

    // Initialize Scene
    void Start()
    {
        // Game Imagery
        ArtBG1.SetActive(true);
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtOBJ1.SetActive(false);
        ArtOBJ2.SetActive(false);

        // Dialogue Values
        charName.text = "CRISPY";
        charSpeech.text = "Z-Z-Z!!!";

        // Game Inputs
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);

        // Dialogue Visibility
        dialogue.SetActive(true);

        // Advance Scene Inputs
        nextButton.SetActive(true);
        NextScene1Button.SetActive(false);
        allowSpace = true;
    }

    // Handle Advance Scene Input
    void Update()
    {
        if (allowSpace == true && Input.GetKeyDown("space"))
        {
            Talking();
        }
    }

    // Main Scene Sequence
    public void Talking()
    {
        primeInt++;
        if (primeInt == 2)
        {
            ArtChar1.SetActive(false);
            charName.text = "YOU";
            charSpeech.text = "What the heck?!";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(true);
            charName.text = "CRISPY";
            charSpeech.text = "Z-Z-Z!!!";
            nextButton.SetActive(true);
            allowSpace = true;
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(true);
            charName.text = "YOU";
            charSpeech.text = "Yikes I don’t think they meant to get that crispy!";
            nextButton.SetActive(true);
            allowSpace = true;
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 5)
        {
            ArtChar1.SetActive(true);
            charName.text = "NARRATOR";
            charSpeech.text = "You approach the snoozing, sunburnt, beach goer, do you help?";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
        }

        // Encounter After Choice 1a
        else if (primeInt == 100)
        {
            charName.text = "YOU";
            charSpeech.text = "Excuse me, are you ok? You were asleep and maybe getting a little extra red!";
        }

        else if (primeInt == 101)
        {
            charName.text = "CRISPY";
            charSpeech.text = "Ouch!! Thank you for waking me up, this is way too much sun! Good thing you were walking by! Why were you walking by?";
        }

        else if (primeInt == 102)
        {
            charName.text = "YOU";
            charSpeech.text = "I am shelling and heard this beach was a prime spot to find a Golden Shell";
        }
        else if (primeInt == 103)
        {
            charName.text = "CRISPY";
            charSpeech.text = "Thank you for your help, how ‘bout I join you on your search for a bit? Two sets of eyes are better than one!";
        }
        else if (primeInt == 104)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "Accept Crispy's help?";
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }

        // Encounter After Choice 1b
        else if (primeInt == 200)
        {
            ArtOBJ1.SetActive(false);
            NextScene1Button.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }

        // Encounter After Choice 2a
        else if (primeInt == 300)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "And so they spent hours collecting sea shells...";
        }
        else if (primeInt == 301)
        {
            gameHandler.AddShells(2);
            ArtOBJ1.SetActive(true);
            ArtOBJ2.SetActive(true);
            ArtChar1.SetActive(false);
            charName.text = "YOU";
            charSpeech.text = "We found like about tree fiddy shells!";
        }
        else if (primeInt == 302)
        {
            charName.text = "CRISPY";
            charSpeech.text = "Yeah dude, let's keep lookin'!";
            ArtOBJ1.SetActive(false);
            ArtOBJ2.SetActive(false);
            NextScene1Button.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }

        // Encounter After Choice 2b
        else if (primeInt == 400)
        {
            ArtOBJ1.SetActive(false);
            NextScene1Button.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }
    }

    // Handle Button Choice 1a Input
    public void Choice1aFunct()
    {
        charName.text = "NARRATOR";
        charSpeech.text = "You nudge Crispy";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice 1b Input
    public void Choice1bFunct()
    {
        gameHandler.AddShells(1);
        charName.text = "NARRATOR";
        charSpeech.text = "You wander around a bit and find only 1 lame shell...";
        primeInt = 199;
        ArtChar1.SetActive(false);
        ArtOBJ1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice 2a Input
    public void Choice2aFunct()
    {
        charName.text = "YOU";
        charSpeech.text = "Thank you, I'd love the help, let's do it!";
        primeInt = 299;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice 2b Input
    public void Choice2bFunct()
    {
        gameHandler.AddShells(1);
        charName.text = "NARRATOR";
        charSpeech.text = "You wander around a bit and find only 1 lame shell...";
        primeInt = 399;
        ArtChar1.SetActive(false);
        ArtOBJ1.SetActive(true);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Load Scene 5 Input
    public void SceneChange5()
    {
        SceneManager.LoadScene("S5");
    }

    // Handle Load Lose Crab Swarm Scene
    public void SceneChange2b()
    {
        SceneManager.LoadScene("End_LoseCrabSwarm");
    }
}
