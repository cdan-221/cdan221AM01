using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueScene5 : MonoBehaviour
{
    // Variable Declartions
    public int primeInt = 1;
    public DialogueGameHandler gameHandler;
    public GameObject dialogue;
    public Text charName;
    public Text charSpeech;
    public GameObject ArtChar1;
    public GameObject ArtBG1;
    public GameObject ArtOBJ1;
    public GameObject ArtOBJ2;
    public GameObject ChoiceA;
    public GameObject ChoiceB;
    public GameObject ChoiceAA;
    public GameObject ChoiceAB;
    public GameObject ChoiceBA;
    public GameObject ChoiceBB;
    public GameObject NextSceneAButton;
    public GameObject NextSceneBButton;
    public GameObject NextSceneCButton;
    public GameObject nextButton;
    private bool allowSpace = true;

    // Initialize Scene
    void Start()
    {
        // Game Imagery
        ArtBG1.SetActive(true);
        ArtChar1.SetActive(false);
        ArtOBJ1.SetActive(false);
        ArtOBJ2.SetActive(false);

        // Dialogue Values
        charName.text = "NARRATOR";
        charSpeech.text = "As you continue to shell you hear a voice in the distance...";

        // Game Inputs
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        ChoiceAA.SetActive(false);
        ChoiceAB.SetActive(false);
        ChoiceBA.SetActive(false);
        ChoiceBB.SetActive(false);

        // Dialogue Visibility
        dialogue.SetActive(true);

        // Advance Scene Inputs
        NextSceneAButton.SetActive(false);
        NextSceneBButton.SetActive(false);
        NextSceneCButton.SetActive(false);
        nextButton.SetActive(true);
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
            charName.text = "???";
            charSpeech.text = "Hey guys, this isn't funny!";
        }
        else if (primeInt == 3)
        {
            charName.text = "???";
            charSpeech.text = "C'mon you guys, I'm stuck!!!";
        }
        else if (primeInt == 4)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "As you search for the source of the voice you come across an irate head sticking out of the sand!";
            ArtChar1.SetActive(true);
        }
        else if (primeInt == 5)
        {
            charName.text = "SANDY";
            charSpeech.text = "HEY YOU! Down here! Excuse me, call me Sandy, can you dig me out?";
        }
        else if (primeInt == 6)
        {
            charName.text = "YOU";
            charSpeech.text = "Do you mean me???";
        }
        else if (primeInt == 7)
        {
            charName.text = "SANDY";
            charSpeech.text = "Yeah you! My friends left me for dead here, so will you help me out?";
        }
        else if (primeInt == 8)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "You consider Sandy's plea...";
            ChoiceA.SetActive(true);
            ChoiceB.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }



        // Encounter After Choice A
        else if (primeInt == 100)
        {
            charName.text = "SANDY";
            charSpeech.text = "Thank you thank you thank you, I thought I was a goner! I don't know if my friends were even planning to come back...";
        }

        else if (primeInt == 101)
        {
            charName.text = "YOU";
            charSpeech.text = "No problem, glad I could help!";
        }

        else if (primeInt == 102)
        {
            charName.text = "SANDY";
            charSpeech.text = "So what are you up to, it seemed like you were looking for something?";
        }
        else if (primeInt == 103)
        {
            charName.text = "YOU";
            charSpeech.text = "I am! I'm shelling and looking for something special!";
        }
        else if (primeInt == 104)
        {
            charName.text = "SANDY";
            charSpeech.text = "Sounds like a whoop. Here, want this old tote bag to carry all those shells in?";
        }
        else if (primeInt == 105)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "Do you accept the tote from Sandy?";
            ArtOBJ1.SetActive(true);
            ChoiceAA.SetActive(true);
            ChoiceAB.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }

        // Encounter After Choice B
        else if (primeInt == 200)
        {
            charName.text = "SANDY";
            charSpeech.text = "Aww c'mon I'm really stuck!!! ...jerk!";
        }
        else if (primeInt == 201)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "You go back to shelling merrily, ignoring Sandy's cries for attention";
        }
        else if (primeInt == 202)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "As you lose yourself in the wonder of shelling, you hardly notice the crabs beginning to encircle you...";
        }
        else if (primeInt == 203)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "You feel a sudden sting and wince in pain, as you see a swarm of pinching crabs gatherering around you and pinching you!!!";
        }
        else if (primeInt == 204)
        {
            if (gameHandler.GetPrimaryItem() == "EpiPEN")
            {
                charName.text = "NARRATOR";
                charSpeech.text = "You remember how allergic you are to shellfish! Luckily you brought your EpiPEN!!!";
            }
            else
            {
                charName.text = "NARRATOR";
                charSpeech.text = "You remember how allergic you are to shellfish! As the crabs threaten and pinch, you recall leaving behind your EpiPEN...";
                ArtOBJ2.SetActive(true);
                NextSceneCButton.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;
            }
        }
        else if (primeInt == 205)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "You use your EpiPEN and make your escape.";
        }
        else if (primeInt == 206)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "Reflecting on this close call, you stop to consider your options...";
            ChoiceBA.SetActive(true);
            ChoiceBB.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }



        // Encounter After Choice AA, AB, and BA
        else if (primeInt == 300)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "You continue walking down the beach...";
            NextSceneAButton.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }

        // Encounter After Choice BB
        else if (primeInt == 400)
        {
            NextSceneBButton.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }
    }



    // Handle Button Choice A Input
    public void ChoiceAFunct()
    {
        charName.text = "NARRATOR";
        charSpeech.text = "You dig Sandy out of his early grave...";
        primeInt = 99;
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice B Input
    public void ChoiceBFunct()
    {
        charName.text = "NARRATOR";
        charSpeech.text = "You back away slowly, turn around, and go on your way...";
        primeInt = 199;
        ArtChar1.SetActive(false);
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }



    // Handle Button Choice AA Input
    public void ChoiceAAFunct()
    {
        charName.text = "NARRATOR";
        charSpeech.text = "You accept the tote from Sandy and continue on your merry way!";
        primeInt = 299;
        gameHandler.ObtainTote();
        ArtChar1.SetActive(false);
        ArtOBJ1.SetActive(false);
        ChoiceAA.SetActive(false);
        ChoiceAB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice AB Input
    public void ChoiceABFunct()
    {
        charName.text = "NARRATOR";
        charSpeech.text = "You think twice before accepting a random bag from a stranger and walk away slowly...";
        primeInt = 299;
        ArtChar1.SetActive(false);
        ArtOBJ1.SetActive(false);
        ChoiceAA.SetActive(false);
        ChoiceAB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }



    // Handle Button Choice BA Input
    public void ChoiceBAFunct()
    {
        charName.text = "NARRATOR";
        charSpeech.text = "You press on";
        primeInt = 299;
        ChoiceBA.SetActive(false);
        ChoiceBB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice BB Input
    public void ChoiceBBFunct()
    {
        charName.text = "NARRATOR";
        charSpeech.text = "You head back to your stuff";
        primeInt = 399;
        ChoiceBA.SetActive(false);
        ChoiceBB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }



    // Handle Load Scene A Input
    public void SceneChangeA()
    {
        SceneManager.LoadScene("S6");
    }

    // Handle Load Scene B Input
    public void SceneChangeB()
    {
        SceneManager.LoadScene("S2_Stuff");
    }

    // Handle Load Scene C Input
    public void SceneChangeC()
    {
        SceneManager.LoadScene("End_LoseCrabPinch");
    }
}
