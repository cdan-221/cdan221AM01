using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueScene9 : MonoBehaviour
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
        ArtChar1.SetActive(false);
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

        // Dialogue Visibility
        dialogue.SetActive(true);

        // Advance Scene Inputs
        NextSceneAButton.SetActive(false);
        NextSceneBButton.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;

        // Start Dialog
        CharacterSays("NARRATOR", "You follow the Crusteologist to the tidepool");
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
            CharacterSays("CRUSTACEOLOGIST", "A colleague of mine used to study those mollusks you are looking for, the tend to tuck away in tidepools liiiiiiiiiike THIS ONE!");
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            CharacterSays("YOU", "Why thank you for showing me this secret spot");
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            CharacterSays("CRUSTACEOLOGIST", "Uhh, sure, it's a secret...You would never find this beach or tidepool on a site like Trip Advisor or near the top of a Google search. This is totally a result of my years of study and expertise. Mmhmm, yup!");
        }
        else if (primeInt == 5)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            CharacterSays("YOU", "Well, here we go!");
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            CharacterSays("CRUSTACEOLOGIST", "Let me know if ya need a hand");
        }
        else if (primeInt == 7)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            CharacterSays("YOU", "WHAT?! No way...Could it be..it's...a...");
        }
        else if (primeInt == 8)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            CharacterSays("CRUSTACEOLOGIST", "Well hurry up! What is it?!");
        }
        else if (primeInt == 9)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtOBJ2.SetActive(true);
            CharacterSays("YOU", "IT'S A GOLDEN SHELLLLLL!!!!!");
            
        }
        else if (primeInt == 10)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtOBJ2.SetActive(true);
            CharacterSays("NARRATOR", "You pull the coveted shell from the tidepool and thrust it over your head! What should you do?!");
            ChoiceA.SetActive(true);
            ChoiceB.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
        }



        // Encounter After Choice A
        else if (primeInt == 100)
        {
            ArtOBJ2.SetActive(true);
            ArtChar2.SetActive(true);
            ChoiceA.SetActive(false);
            ChoiceB.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            CharacterSays("NARRATOR", "You thank the Crustaceologist, grab your other shells and gear, and dash back to your stuff WITH the Golden Shell completely elated. You are stoked to add the shell to your collection");
        }



        // Encounter After Choice B
        else if (primeInt == 200)
        {
            if (gameHandler.GetPrimaryItem() == "EpiPEN")
            {
                ArtChar1.SetActive(false);
                ArtOBJ2.SetActive(true);
                CharacterSays("NARRATOR", "Oh no you start having an allergic reaction! Where is your EpiPEN?! You reach in your pocket...");
                nextButton.SetActive(true);
                allowSpace = true;
            }
            else
            {
                ArtChar1.SetActive(false);
                CharacterSays("NARRATOR", "You remember how allergic you are to shellfish! As the crabs threaten and pinch, you recall leaving behind your EpiPEN...");
                ArtOBJ2.SetActive(true);
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
            NextSceneAButton.SetActive(true);
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
            nextButton.SetActive(false);
            allowSpace = false;
            CharacterSays("NARRATOR", "Ya. You got pinched. Too bad for that shellfish allergy, you're a goner.");
        }




        // Encounter After Choice BB
        else if (primeInt == 300)
        {
            CharacterSays("NARRATOR", "");
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
        primeInt = 99;
        ArtOBJ1.SetActive(true);
        ArtChar2.SetActive(false);
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        NextSceneAButton.SetActive(true);
        nextButton.SetActive(false);
        allowSpace = false;
        CharacterSays("NARRATOR", "You thank the Crustaceologist, grab your other shells and gear, and dash back to your stuff WITH the Golden Shell completely elated. You are stoked to add the shell to your collection");
    }

    // Handle Button Choice B Input
    public void ChoiceBFunct()
    {
        CharacterSays("NARRATOR", "You, for who knows what reason, decide to leave the shell you have spent all day looking for and return to your stuff on the beach");
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtOBJ1.SetActive(false);
        ArtOBJ2.SetActive(false);
        ArtOBJ3.SetActive(true);
        ArtOBJ4.SetActive(true);
        ArtOBJ5.SetActive(true);
        primeInt = 199;
        ChoiceA.SetActive(false);
        ChoiceB.SetActive(false);
        NextSceneBButton.SetActive(true);
        nextButton.SetActive(false);
        allowSpace = false;
    }


    // Handle Button Choice AA Input
    public void ChoiceAAFunct()
    {
        CharacterSays("NARRATOR", "You contain your over excitement and play it cool, and graciously accept the boots as valuable crab armor");
        primeInt = 399;
        ArtChar2.SetActive(false);
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
        CharacterSays("NARRATOR", "");
        primeInt = 499;
        ArtChar2.SetActive(false);
        ArtOBJ1.SetActive(true);
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
        nextButton.SetActive(false);
        allowSpace = false;
        NextSceneBButton.SetActive(true);
    }

    public void SceneChange2a()
    {
        SceneManager.LoadScene("End_Win");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("End_LoseNoShell");
    }

    public void SceneChange2c()
    {
        SceneManager.LoadScene("End_LoseCrabSwarm");
    }

}
