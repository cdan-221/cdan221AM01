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
    public GameObject ArtChar4;
    public GameObject ArtChar5;
    public GameObject ArtBG1;
    public GameObject ArtBG2;
    public GameObject ArtBG3;
    public GameObject ArtOBJ1;
    public GameObject ArtOBJ2;
    public GameObject ArtOBJ3;
    public GameObject ArtOBJ4;
    public GameObject ArtOBJ5;
    public GameObject ArtOBJ6;
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
        // Game Imagery
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        ArtBG3.SetActive(false);
        ArtChar1.SetActive(true);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar4.SetActive(false);
        ArtChar5.SetActive(false);
        ArtOBJ1.SetActive(false);
        ArtOBJ2.SetActive(false);
        ArtOBJ3.SetActive(false);
        ArtOBJ4.SetActive(false);
        ArtOBJ5.SetActive(false);
        ArtOBJ6.SetActive(true);
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        ChoiceBA.SetActive(false);
        ChoiceBB.SetActive(false);

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

        // Start Dialog
        CharacterSays("PHYLLIS", "Bob! BOB! They're going after the kids sandwiches! BOB!!");
    }

    // Initialize Settings
    public void InitSettings()
    {
        // Initialize Parent Settings
        gameHandler.InitSettings();

        // Initialize Scene Settings
        gameHandler.SetCharacterSetting("YOU", "textColor", "black");
        gameHandler.SetCharacterSetting("NARRATOR", "textColor", "purple");
        gameHandler.SetCharacterSetting("PHYLLIS", "textColor", "green");
        gameHandler.SetCharacterSetting("BOB", "textColor", "blue");
        gameHandler.SetCharacterSetting("CHILDREN", "textColor", "red");
    }

    // Have a given character speak a line
    public void CharacterSays(string name, string speech)
    {
        try
        {
            InitSettings();
            charName.text = name;
            charName.color = gameHandler.colors[gameHandler.GetCharacterSetting(name, "textColor")];
            charSpeech.text = speech;
            charSpeech.color = gameHandler.colors[gameHandler.GetCharacterSetting(name, "textColor")];
        }
        catch
        {
            Debug.Log("did not find color" + gameHandler.GetCharacterSetting(name, "textColor"));
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
            ArtOBJ2.SetActive(true);
            ArtOBJ6.SetActive(false);
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            CharacterSays("BOB", "Phyllis they have the chips! You deal with those birds, I’ll deal with these...");
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(true);
            ArtOBJ2.SetActive(false);
            ArtOBJ1.SetActive(true);
            CharacterSays("CHILDREN", "*kids wailing in lament and panick* \n WAAAA! Our sandwiches!!!");
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ChoiceA.SetActive(true);
            ChoiceB.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            CharacterSays("PHYLLIS", "THEY’RE STEALING OUR LUNCH! EXCUSE ME! Can you grab that bag from the birds?!");
        }



        // Encounter After Choice A
        else if (primeInt == 100)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtChar5.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            CharacterSays("YOU", "Don’t you worry I’m on it!");
        }

        else if (primeInt == 101)
        {
            ArtChar5.SetActive(false);
            ArtOBJ1.SetActive(false);
            ArtOBJ2.SetActive(true);
            CharacterSays("NARRATOR", "You run at the seagull waiving your arms to scare them away from the bag of sandwiches");
        }

        else if (primeInt == 102)
        {
            ArtChar2.SetActive(true);
            ArtOBJ2.SetActive(false);
            CharacterSays("BOB", "Thank you! These pesky birds, they sure do know how to ruin a nice relaxing moment with the family but I suppose no beach day is complete without them!");
        }
        else if (primeInt == 103)
        {
            CharacterSays("PHYLLIS", "Kids, help this lovely lunch savior scare off some of these crabs!");
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(true);
        }
        else if (primeInt == 104)
        {
            CharacterSays("YOU", "Wow what a bonus! The kids AND the gulls are going after the crabs!");
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar5.SetActive(true);
        }
        else if (primeInt == 105)
        {
            CharacterSays("NARRATOR", "Thanks to the hard work from the kids, you have a clear path from crabs down the beach!");
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtChar5.SetActive(false);
            NextSceneAButton.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }



        // Encounter After Choice B
        else if (primeInt == 200)
        {
            CharacterSays("NARRATOR", "Do you go back and help the picnickers, maybe you can team up?");
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtChar5.SetActive(false);
            ArtOBJ1.SetActive(false);
            ChoiceBA.SetActive(true);
            ChoiceBB.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }
        else if (primeInt == 201)
        {
            CharacterSays("NARRATOR", "The crab migration is growing bigger and bigger. You can't outrun them...");
            charSpeech.text = "";
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtChar5.SetActive(false);
            ArtOBJ1.SetActive(false);
            ArtOBJ5.SetActive(true);
            ArtOBJ6.SetActive(true);
            NextSceneBButton.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }



        // Encounter After Choice BB
        else if (primeInt == 300)
        {
            CharacterSays("NARRATOR", "");
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtChar5.SetActive(false);
            ArtOBJ1.SetActive(false);
            ChoiceBA.SetActive(false);
            ChoiceBB.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
        }
        else if (primeInt == 301)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtChar5.SetActive(false);
            ArtOBJ1.SetActive(false);
            ArtOBJ5.SetActive(true);
            ArtOBJ6.SetActive(true);
            CharacterSays("NARRATOR", "The crab migration is growing bigger and bigger. You can't outrun them...And now there are seagulls too!");
            nextButton.SetActive(false);
            allowSpace = false;
        }
    }



    // Handle Button Choice A Input
    public void ChoiceAFunct()
    {
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar4.SetActive(false);
        ArtChar5.SetActive(false);
        ArtOBJ1.SetActive(false);
        CharacterSays("NARRATOR", "You decide to help the panicking picnickers recapture their lunch from the seagulls");
        primeInt = 99;
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice B Input
    public void ChoiceBFunct()
    {
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar4.SetActive(false);
        ArtChar5.SetActive(false);
        ArtOBJ1.SetActive(false);
        ArtOBJ2.SetActive(true);
        ArtOBJ3.SetActive(true);
        CharacterSays("NARRATOR", "Oh NO! The seagulls start to go after you!");
        primeInt = 199;
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice BA Input
    public void ChoiceBAFunct()
    {
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar4.SetActive(false);
        ArtChar5.SetActive(false);
        ArtOBJ2.SetActive(false);
        ArtOBJ3.SetActive(false);
        CharacterSays("NARRATOR", "That seems like a wise choice");
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
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar4.SetActive(false);
        ArtChar5.SetActive(false);
        ArtOBJ2.SetActive(false);
        ArtOBJ3.SetActive(false);
        ArtOBJ5.SetActive(true);
        ArtOBJ6.SetActive(true);
        CharacterSays("NARRATOR", "The crab migration is growing bigger and bigger. You can't outrun them...And now there are seagulls too!");
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
