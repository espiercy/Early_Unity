using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
		
		StartGame ();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("=========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but don't tell me!");
		
		
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal");
		
		max = max + 1;
	}
	
	void NextGuess () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			//print("Up arrow pressed");
			min = guess;
			guess = (max + min) / 2;
			print ("Higher or lower than " + guess);
			print ("Up = higher, down = lower, return = equal");
		}
		
		else if(Input.GetKeyDown(KeyCode.DownArrow)){
			//print("Down arrow pressed");
			max = guess;
			guess = (max + min) / 2;
			print ("Is the number higher or lower than " + guess + "?");
			print ("Up = higher, down = lower, return = equal");
			
		}
		
		else if(Input.GetKeyDown(KeyCode.Return)){
			print("I won!");
			StartGame();
		}
	}
	
	// Update is called once per frame
	void Update () {
		NextGuess ();
	}
}
