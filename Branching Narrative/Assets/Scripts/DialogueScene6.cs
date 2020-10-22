using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueScene6 : MonoBehaviour
{
    // Variable Declartions
    public int primeInt = 1;
    public DialogueGameHandler gameHandler;
    public GameObject dialogue;
    public Text charName;
    public Text charSpeech;
    public GameObject ArtChar1;
    public GameObject ArtChar2;
    public GameObject ArtChar3;
    public GameObject ArtBG1;
    public GameObject ArtOBJ1;
    public GameObject ChoiceA;
    public GameObject ChoiceB;
    public GameObject NextSceneAButton;
    public GameObject NextSceneBButton;
    public GameObject nextButton;
    private bool allowSpace = true;

    // Initialize Scene
    void Start()
    {
        // Game Imagery
        ArtBG1.SetActive(true);
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtOBJ1.SetActive(true);

        // Dialogue Values
        charName.text = "NARRATOR";
        charSpeech.text = "As you walk down the beach you see a dog sprinting toward you...";

        // Game Inputs
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);

        // Dialogue Visibility
        dialogue.SetActive(true);

        // Advance Scene Inputs
        NextSceneAButton.SetActive(false);
        NextSceneBButton.SetActive(false);
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
            ArtOBJ1.SetActive(false);
            ArtChar1.SetActive(true);
            charName.text = "FRISBEE DUDE 1";
            charSpeech.text = "Ah man the dog got it! Hey dog! Give it back!!";
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            charName.text = "FRISBEE DUDE 2";
            charSpeech.text = "Who’s dog is this?! What the...hey there he’s running toward you grab him!";
        }
        else if (primeInt == 4)
        {
            charName.text = "YOU";
            charSpeech.text = "Who me?!";
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
        }
        else if (primeInt == 5)
        {
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            charName.text = "FRISBEE DUDE 3";
            charSpeech.text = "YES GRAB THE DOG HE HAS OUR FRISBEEEE!";

        }
        else if (primeInt == 6)
        {
            ArtChar3.SetActive(false);
            charName.text = "NARRATOR";
            charSpeech.text = "Help the fellas get the frisbee back?";
            ChoiceA.SetActive(true);
            ChoiceB.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }



        // Encounter After Choice A
        else if (primeInt == 100)
        {
            charName.text = "YOU";
            charSpeech.text = "Here doge, want a treat?!";
        }

        else if (primeInt == 101)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "The dog drops the frisbee at your feet";
        }

        else if (primeInt == 102)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "You dig around in your pocket and find an old cheese-it, which you give to the dog";
        }
        else if (primeInt == 103)
        {
            charName.text = "FRISBEE DUDE 1";
            charSpeech.text = "Hey thanks! That was really nice of you!";
            ArtChar1.SetActive(true);
        }
        else if (primeInt == 104)
        {
            charName.text = "FRISBEE DUDE 2";
            charSpeech.text = "Is there anything we can do to repay ya?";
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
        }
        else if (primeInt == 105)
        {
            charName.text = "YOU";
            charSpeech.text = "well, Im shell hunting and there are all the crabs that seem to just be coming out of nowhere…";
            ArtChar2.SetActive(false);

        }
        else if (primeInt == 106)
        {
            charName.text = "FRISBEE DUDE 3";
            charSpeech.text = "Sure that’s no problem, we can scare some away for you, they don’t seem to come near us running around with the frisbee!";
            ArtChar3.SetActive(true);
        }
        else if (primeInt == 107)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "The Frisbee Dudes help shoo away crabs so you can shell peacefully";
            ArtChar3.SetActive(false);
            NextSceneAButton.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }



        // Encounter After Choice B
        else if (primeInt == 200)
        {
            charName.text = "FRISBEE BRO 1";
            charSpeech.text = "Wow, real nice he was bringing the frisbee to you and you couldn’t just grab it for us? Jerk…";
            ArtChar1.SetActive(true);
        }
        else if (primeInt == 201)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "The crab migration is growing bigger and bigger. You can't outrun them...";
            ArtChar1.SetActive(false);
            NextSceneBButton.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }
    }



    // Handle Button Choice A Input
    public void ChoiceAFunct()
    {
        charName.text = "NARRATOR";
        charSpeech.text = "You decide to help get the frisbee back";
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
        charSpeech.text = "You decide it's getting late, and you don't have time to try to get a frisbee from the dog...";
        primeInt = 199;
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }



    // Handle Load Scene A Input
    public void SceneChangeA()
    {
        SceneManager.LoadScene("S7");
    }

    // Handle Load Scene B Input
    public void SceneChangeB()
    {
        SceneManager.LoadScene("End_LoseCrabSwarm");
    }
}
