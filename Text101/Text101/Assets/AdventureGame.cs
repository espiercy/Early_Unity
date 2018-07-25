﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField]
    Text textComponent;

    [SerializeField]
    State startingState;

    State state;

	// Use this for initialization
	void Start () {
        state = startingState;
        textComponent.text = state.GetStateStory();
	}
	
	// Update is called once per frame
	void Update () {
        ManageState();
    }

    void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //going to error out!
            state = nextStates[2];
            //Debug.Log("Unsupported option!");
        }

        textComponent.text = state.GetStateStory();
    }

}
