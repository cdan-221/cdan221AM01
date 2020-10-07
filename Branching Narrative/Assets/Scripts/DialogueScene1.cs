﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene1 : MonoBehaviour
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
            Char1name.text = "NARRATOR";
            Char1speech.text = "Finally, after a few hours of riding in this bumpy, old bus you've arrived to the beautiful shores of Golden Bay.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Oh, man. I think my leg fell asleep.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "NARRATOR";
            Char1speech.text = "Upon stepping off the rickety bus, you give your sleeping leg a good shake. Then, head held high, you look upon the sandy world before you.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "SEAGULL";
            Char2speech.text = "Shreee!! Craw! Craw! Craw! Craw!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(false);
            Char1name.text = "NARRATOR";
            Char1speech.text = "Overhead, the seagulls circle the beach. As annoying as they are, they are apart of the true beach experience.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "NARRATOR";
            Char1speech.text = "Finally, you step your sandle wearing feet upon the scorching sand. Your striped beach bag in tow, its now time for the most important decision of all...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Where should I sit?";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true); // function Choice1bFunct()

        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I'll have to indulge in the salty breeze later.. What a beautiful shore.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 9;

        }

        else if (primeInt == 200)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Lets... Hope that there isn't a strong breeze anytime soon";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 9;
        }

        else if (primeInt == 300)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Now, this way I don't have to have sand on everything!";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 9;
        }

        else if (primeInt == 10)
        {
            Char1name.text = "YOU";
            Char1speech.text = "But now is not the time to louse around! Lets get shell hunting!";
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
        Char1name.text = "NARRATOR";
        Char1speech.text = "Naturally, you make your way to the water as any eager beach-goer would. Comfortably you set your things by the ebbing and flowing shore.";
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
        Char1name.text = "NARRATOR";
        Char1speech.text = "A most interesting choice. Finding interest in the sandy, drawing hills; your towel fits comfortably at the foot of the nearest one.";
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
        Char1name.text = "NARRATOR";
        Char1speech.text = "Why, of course! The rocks are only the most interesting part of every sandy shore. Smack dab in the middle of the biggest rock, your towel rests comfortably on top.";
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
        SceneManager.LoadScene("S2_SandGuy");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("Scene2b");
    }
}