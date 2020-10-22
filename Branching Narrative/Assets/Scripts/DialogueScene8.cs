using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueScene8 : MonoBehaviour
{
    // Variable Declartions
    public int primeInt = 1;
    public DialogueGameHandler gameHandler;
    public GameObject dialogue;
    public Text charName;
    public Text charSpeech;
    public GameObject ArtChar1;
    public GameObject ArtChar2;
    public GameObject ArtBG1;
    public GameObject ArtBG2;
    public GameObject ArtBG3;
    public GameObject ArtOBJ1;
    public GameObject ArtOBJ2;
    public GameObject ArtOBJ3;
    public GameObject ArtOBJ4;
    public GameObject ArtOBJ5;
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
        ArtBG2.SetActive(false);
        ArtBG3.SetActive(false);
        ArtChar1.SetActive(true);
        ArtChar2.SetActive(false);
        ArtOBJ1.SetActive(false);
        ArtOBJ2.SetActive(false);
        ArtOBJ3.SetActive(false);
        ArtOBJ4.SetActive(false);
        ArtOBJ5.SetActive(false);

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

        // Start Dialog
        CharacterSays("YOU", "Why hello there, are you shelling too?");
    }

    // Initialize Settings
    public void InitSettings()
    {
        // Initialize Parent Settings
        gameHandler.InitSettings();

        // Initialize Scene Settings
        gameHandler.SetCharacterSetting("YOU", "textColor", "black");
        gameHandler.SetCharacterSetting("NARRATOR", "textColor", "purple");
        gameHandler.SetCharacterSetting("CRUSTACEOLOGIST", "textColor", "green");
        /*gameHandler.SetCharacterSetting("BOB", "textColor", "blue");
        gameHandler.SetCharacterSetting("CHILDREN", "textColor", "red");*/
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
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            CharacterSays("CRUSTACEOLOGIST", "I am not, I am here on this beautiful beach studying these rare little crabs!");
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            CharacterSays("YOU", "Yikes, how brave! I keep my distance from shellfish...");
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            CharacterSays("CRUSTACEOLOGIST", "They only swarm and attack if aggravated, otherwise they are content to carry on finding food and mates! This is their annual migration!");
        }
        else if (primeInt == 5)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            CharacterSays("YOU", "I did not know crabs migrated...");
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            CharacterSays("CRUSTACEOLOGIST", "These do! Can you help me count them?");
            ChoiceA.SetActive(true);
            ChoiceB.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }



        // Encounter After Choice A
        else if (primeInt == 100)
        {
            ArtOBJ1.SetActive(false);
            ArtOBJ2.SetActive(false);
            ArtOBJ3.SetActive(false);
            ArtChar2.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            ChoiceAA.SetActive(true);
            ChoiceAB.SetActive(true);
            CharacterSays("CRUSTACEOLOGIST", "Thank you for your help! Would you like my extra boots to protect you from the crabs?");
        }



        // Encounter After Choice B
        else if (primeInt == 200)
        {
            if (gameHandler.GetPrimaryItem() == "EpiPEN")
            {
                ArtChar1.SetActive(false);
                ArtOBJ2.SetActive(true);
                ArtOBJ5.SetActive(true);
                CharacterSays("NARRATOR", "Oh no you start having an allergic reaction! Where is your EpiPEN?! You reach in your pocket...");
                nextButton.SetActive(true);
                allowSpace = true;
            }
            else
            {
                ArtChar1.SetActive(false);
                CharacterSays("NARRATOR", "You remember how allergic you are to shellfish! As the crabs threaten and pinch, you recall leaving behind your EpiPEN...");
                ArtOBJ2.SetActive(true);
                ArtOBJ5.SetActive(true);
                NextSceneCButton.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;
            }
        }
        else if (primeInt == 201)
        {
            CharacterSays("NARRATOR", "Your EpiPEN comes in handy! You decide to head back to your stuff without your coveted shell...");

            NextSceneBButton.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }

        // Encounter After Choice AA
        else if (primeInt == 400)
        {
            nextButton.SetActive(true);
            allowSpace = true;
            ChoiceAA.SetActive(false);
            ChoiceAB.SetActive(false);
            CharacterSays("YOU", "Ah these are just my size. Thank you!");
        }
        else if (primeInt == 401)
        {
            NextSceneAButton.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            CharacterSays("CRUSTACEOLOGIST", "Say, what type of shell did you say you were looking for--I think I might be able to help you find that shell you are looking for. Follow me.");
        }

        // Encounter After Choice AB
        else if (primeInt == 500)
        {
            ArtOBJ1.SetActive(true);
            ArtOBJ2.SetActive(true);
            nextButton.SetActive(true);
            allowSpace = true;
            ChoiceAA.SetActive(false);
            ChoiceAB.SetActive(false);
            CharacterSays("NARRATOR", "Things are now awkward with the Crustaceologist because you spent a lot of time whining, then rejected the boots, a way to keep yourself safe from the crusty shellfish.");
        }
        else if (primeInt == 501)
        {
            ArtOBJ3.SetActive(true);
            CharacterSays("NARRATOR", "You decide you should probably mosey and get on with looking for the Golden Shell. As you start to walk again you find yourself having to leap through swarms of crabs...you start to think 'perhaps those boots would have been helpf--'");
        }
        else if (primeInt == 502)
        {
            ArtOBJ1.SetActive(false);
            ArtOBJ2.SetActive(false);
            ArtOBJ3.SetActive(false);
            ArtChar1.SetActive(true);
            CharacterSays("YOU", "YOUCH!!!");
        }
        else if (primeInt == 503)
        {
            ArtChar1.SetActive(false);
            ArtOBJ1.SetActive(true);
            ArtOBJ2.SetActive(true);
            ArtOBJ3.SetActive(true);
            NextSceneCButton.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            CharacterSays("NARRATOR", "Ya. You got pinched. Too bad for that shellfish allergy, you're a goner.");
        }




        // Encounter After Choice BB
        else if (primeInt == 300)
        {
            CharacterSays("NARRATOR", "");
            ChoiceBA.SetActive(false);
            ChoiceBB.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
        }
        else if (primeInt == 301)
        {
            CharacterSays("NARRATOR", "The crab migration is growing bigger and bigger. You can't outrun them...And now there are seagulls too!");
            nextButton.SetActive(false);
            allowSpace = false;
        }
    }



    // Handle Button Choice A Input
    public void ChoiceAFunct()
    {
        CharacterSays("NARRATOR", "You decide to help the Crustaceologist count crabs for their study");
        primeInt = 99;
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtOBJ1.SetActive(true);
        ArtOBJ2.SetActive(true);
        ArtOBJ3.SetActive(true);
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice B Input
    public void ChoiceBFunct()
    {
        CharacterSays("YOU", "OUCH!");
        ArtChar1.SetActive(true);
        ArtChar2.SetActive(false);
        ArtOBJ1.SetActive(true);
        ArtOBJ2.SetActive(true);
        ArtOBJ3.SetActive(true);
        primeInt = 199;
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }


    // Handle Button Choice AA Input
    public void ChoiceAAFunct()
    {
        CharacterSays("NARRATOR", "You contain your over excitement and play it cool, and graciously accept the boots as valuable crab armor");
        primeInt = 399;
        ArtChar2.SetActive(false);
        ArtOBJ4.SetActive(true);
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        ChoiceAA.SetActive(false);
        ChoiceAB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice AB Input
    public void ChoiceABFunct()
    {
        CharacterSays("NARRATOR", "You reject the boots");
        primeInt = 499;
        ArtChar2.SetActive(false);
        ArtOBJ1.SetActive(true);
        ArtOBJ4.SetActive(false);
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        ChoiceAA.SetActive(false);
        ChoiceAB.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // Handle Button Choice BA Input
    public void ChoiceBAFunct()
    {
        CharacterSays("NARRATOR", "You contain your over excitement and play it cool, and graciously accept the boots!");
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
        CharacterSays("NARRATOR", "The crab migration is growing bigger and bigger. You can't outrun them...");
        primeInt = 299;
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        ChoiceBA.SetActive(false);
        ChoiceBB.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = false;
        NextSceneBButton.SetActive(true);
    }



    public void SceneChange2a()
    {
        SceneManager.LoadScene("S8");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("End_LoseCrabSwarm");
    }
    public void SceneChangeLoseCrabPinch()
    {
        SceneManager.LoadScene("End_LoseCrabPinch");
    }
}
