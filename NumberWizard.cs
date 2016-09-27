using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	

	
	// Use this for initialization
	void Start () {
		print ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
		print ("===========================================================");
		print ("Welcome To Number Wizard");
		print ("please pick a range of numbers");
		print ("press 1 for 1 to 1000");
		print ("press 2 for 1 to 2000");
		print ("press 3 for 1 to 1000000");
		
	
	}
	
	
	void StartGame () {
	
		print ("Pick A Number In your head, but don't tell me");
		print ("the highest number you can pick is " + max);
		print ("the lowest number you can pick is " + min);
		print ("is this number higher or lower than " + guess);
		print ("press up for higher, Down for lower or Enter if its your number.");
		max = max + 1;	
	}
	
	
	// Update is called once per frame
	void Update () {
	
	
		if (Input.GetKeyDown (KeyCode.Alpha1)){
			print ("OK you have selected 1 to 1,000");
			max = 1000;
			min = 1;
			guess = Random.Range (min, max);
			
			StartGame ();
			
			
		} else if  (Input.GetKeyDown (KeyCode.Alpha2)){
			print ("OK you have selected 1 to 2,000");
			max = 2000;
			min = 1;
			guess = Random.Range (min, max);
			
			StartGame ();
			
			
		} else if  (Input.GetKeyDown (KeyCode.Alpha3)){
			print ("OK you have selected 1 to 1,000,000");
			max = 1000000;
			min = 1;
			guess = Random.Range (min, max);
			
			StartGame ();
			
			
		}
		;
		
		if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I WON");
			Start();
			
		
			
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess ();

		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max =  guess;
			NextGuess();
	}
}
	
		void NextGuess () {
			
			guess = (min + max) / 2;
			print ("higher or lower than" + guess);
			print ("press up for higher, Down for lower or Enter if its your number.");
	}
}
