using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public int startingScore = 0;
    public int currentScore;
    public Text ScoreText;
    private int scoreIncrement = 0;
	// Use this for initialization
	void Start () {
        currentScore = startingScore;
        ScoreText.text = currentScore.ToString();
	
	}
	
	// Update is called once per frame
	void Update () {
        scoreIncrement++;
        if(scoreIncrement >= 40)
        {
            currentScore += 10;
            scoreIncrement = 0;
        }
        //currentScore += 1;
        ScoreText.text = currentScore.ToString();
        //Debug.Log("currentScore +=1");
    
	
	}


	public void hitTarget(Transform target)
	{
		currentScore += 1;
		Debug.Log ("Target hit");

	}
}
