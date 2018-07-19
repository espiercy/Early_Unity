using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    private int max, min, guess;
    private bool found = false;

    // Use this for initialization
    void Start ()
    {
        StartGame();
    }
	
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        WriteWelcome();
        max++;
    }

	// Update is called once per frame
	void Update () {
        NextGuess();
	}

    //we can abstract the KeyPress events above through this method? Maybe not how I've constructed this
    void NextGuess()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            DirectionArrowPressed("higher", changedLimit: ref min);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            DirectionArrowPressed("lower", changedLimit: ref max);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            FoundSolution();
        }
    }

    void DirectionArrowPressed(string keyStr, ref int changedLimit)
    {
        Debug.Log("So! It was " + keyStr + " than " + guess);
        changedLimit = guess;
        guess = (max + min) / 2;
        WriteInstructions();
    }

    void FoundSolution() {
        Debug.Log("I got it! Yay! I'm a total genuis!");
        StartGame();
    }

    void WriteWelcome()
    {
        Debug.Log("Tubular Times, Dude! Welcome to the Number Wizard, bro!");
        Debug.Log("Pick a number!");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);

        WriteInstructions();
    }

    void WriteInstructions() {
        Debug.Log("Higher or lower than: " + guess);
        Debug.Log("Push Up Arrow key for higher, Push Down Arrow key for lower, and the Enter key for Correct");
    }

}
