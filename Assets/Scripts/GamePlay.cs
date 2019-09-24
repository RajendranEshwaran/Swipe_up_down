using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour {



	public Text timer_txt;

	float totalTime;
	private int gameTime=3;
	private float startTime = 0; 
	private float restSeconds = 0; 
	private int roundedRestSeconds = 0; 
	private float displaySeconds = 0; 
	private float displayMinutes = 0; 
	public int CountDownSeconds = 3; 
	private float Timeleft = 0; 
	string timetext = "";

	// Use this for initialization
	void Start () {


		//Shuffle ();

		CountDownSeconds=gameTime;
		startTime = Time.time;
	}
		

	// Update is called once per frame
	void Update () {
		
		Timeleft = Time.time-startTime;
		restSeconds = CountDownSeconds-(Timeleft);
		roundedRestSeconds = Mathf.CeilToInt(restSeconds);
		displaySeconds = roundedRestSeconds % 60;
		displayMinutes = (roundedRestSeconds / 60)%60;
		timetext = (displayMinutes.ToString() + ":");
		if (displaySeconds > 9)
		{
			timetext = displaySeconds.ToString();
		}
		else 
		{
			timetext =  displaySeconds.ToString();
		} 

		timer_txt.text = timetext;


		if(roundedRestSeconds==0)
		{
			Debug.Log ("Game Over");
			ResetTimer();
		}
	}

	public void ResetTimer()
	{
		startTime=Time.time;
		CountDownSeconds = gameTime;
	}


	void Shuffle()
	{
		 int[] a = new int[] { 1,2,3,4,5,6,7,8,9,10 };

		// Loop array
		for (int i = a.Length - 1; i > 0; i--)
		{
			// Randomize a number between 0 and i (so that the range decreases each time)
			int rnd = UnityEngine.Random.Range(0, i);

			// Save the value of the current i, otherwise it'll overwrite when we swap the values
			int temp = a[i];

			// Swap the new and old values
			a[i] = a[rnd];
			a[rnd] = temp;
		}

		// Print
		for (int i = 0; i < a.Length; i++)
		{
			Debug.Log(a[i]);
		}
	}
}


