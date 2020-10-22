using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueScene7 : MonoBehaviour
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
    public GameObject ArtBG2;
    public GameObject ArtBG3;
    public GameObject ArtOBJ1;
    public GameObject ChoiceA;
    public GameObject ChoiceB;
    public GameObject ChoiceBA;
    public GameObject ChoiceBB;
    public GameObject NextSceneAButton;
    public GameObject NextSceneBButton;
    public GameObject nextButton;
    private bool allowSpace = true;

    // Initialize Scene
    void Start()
    {
        gameHandler.InitSettings();

        // Game Imagery
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        ArtBG3.SetActive(false);
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtOBJ1.SetActive(false);
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        ChoiceBA.SetActive(false);
        ChoiceBB.SetActive(false);

        // Dialogue Values
        gameHandler.NewCharacterSettings("PHYLLIS");
        gameHandler.SetCharacterSetting("PHYLLIS", "textColor", "green");
        gameHandler.NewCharacterSettings("BOB");
        gameHandler.SetCharacterSetting("BOB", "textColor", "blue");
        gameHandler.NewCharacterSettings("CHILDREN");
        gameHandler.SetCharacterSetting("CHILDREN", "textColor", "red");
        CharacterSays("PHYLLIS", "Bob! BOB! They're going after the kids sandwiches! BOB!!");

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

    // Have a given character speak a line
    public void CharacterSays(string name, string speech)
    {
        try
        {
            charName.text = name;
            charName.color = gameHandler.colors[gameHandler.GetCharacterSetting(name, "textColor")];
            charSpeech.text = speech;
            charSpeech.color = gameHandler.colors[gameHandler.GetCharacterSetting(name, "textColor")];
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message);
        }
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
            CharacterSays("BOB", "Phyllis they have the chips! You deal with those birds, I’ll deal with these...");
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            charName.text = "CHILDREN";
            charSpeech.text = "*kids wailing in lament and panick* \n WAAAA! Our sandwiches!!!";
        }
        else if (primeInt == 4)
        {
            charName.text = "PHYLLIS";
            charSpeech.text = "THEY’RE STEALING OUR LUNCH! EXCUSE ME! Can you grab that bag?!";
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ChoiceA.SetActive(true);
            ChoiceB.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }



        // Encounter After Choice A
        else if (primeInt == 100)
        {
            charName.text = "YOU";
            charSpeech.text = "Don’t you worry I’m on it!";
            nextButton.SetActive(true);
            allowSpace = true;
        }

        else if (primeInt == 101)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "You run at the seagull waiving your arms to scare them away from the bag of sandwiches";
        }

        else if (primeInt == 102)
        {
            charName.text = "BOB";
            charSpeech.text = "Thank you! These pesky birds, they sure do know how to ruin a nice relaxing moment with the family but I suppose no beach day is complete without them!";
        }
        else if (primeInt == 103)
        {
            charName.text = "PHYLLIS";
            charSpeech.text = "Kids, help this lovely lunch savior scare off some of these crabs!";
            ArtChar1.SetActive(false);
        }
        else if (primeInt == 104)
        {
            charName.text = "YOU";
            charSpeech.text = "Wow what a bonus! The kids AND the gulls are going after the crabs!";
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
        }
        else if (primeInt == 105)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "Thanks to the hard work from the kids, you have a clear path from crabs down the beach!";
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            NextSceneAButton.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }



        // Encounter After Choice B
        else if (primeInt == 200)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "Do you go back and help the picnickers, maybe you can team up?";
            ArtChar1.SetActive(false);
            ChoiceBA.SetActive(true);
            ChoiceBB.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
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



        // Encounter After Choice BB
        else if (primeInt == 300)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "Jai I need it to return to encounter after choice a";
            ArtChar1.SetActive(false);
            ChoiceBA.SetActive(false);
            ChoiceBB.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
        }
        else if (primeInt == 301)
        {
            charName.text = "NARRATOR";
            charSpeech.text = "The crab migration is growing bigger and bigger. You can't outrun them...And now there are seagulls too!";
            nextButton.SetActive(false);
            allowSpace = false;
        }
    }



    // Handle Button Choice A Input
    public void ChoiceAFunct()
    {
        charName.text = "NARRATOR";
        charSpeech.text = "You decide to help the panicking picnicers recapture their lunch from the seagulls";
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
        charSpeech.text = "Oh NO! The seagulls start to go after you!";
        primeInt = 199;
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice BA Input
    public void ChoiceBAFunct()
    {
        charName.text = "NARRATOR";
        charSpeech.text = "That seems like a wise choice";
        primeInt = 99;
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        ChoiceBA.SetActive(false);
        ChoiceBB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice BB Input
    public void ChoiceBBFunct()
    {
        charName.text = "NARRATOR";
        charSpeech.text = "The crab migration is growing bigger and bigger. You can't outrun them...And now there are seagulls too!";
        primeInt = 299;
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        ChoiceBA.SetActive(false);
        ChoiceBB.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = false;
        NextSceneBButton.SetActive(true);
    }



    // Handle Load Scene A Input
    public void SceneChangeA()
    {
        SceneManager.LoadScene("S8");
    }

    // Handle Load Scene B Input
    public void SceneChangeB()
    {
        SceneManager.LoadScene("End_LoseCrabSwarm");
    }
}
