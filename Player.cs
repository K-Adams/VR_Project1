using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	int startingScore = 0;
    int currentScore;
    public Text ScoreText;
    public GameObject Barrier;
	// Use this for initialization
	void Start () {
        currentScore = startingScore;
        ScoreText.text = currentScore.ToString();
	
	}
	
	// Update is called once per frame
	void Update () {

        currentScore += 1;
        ScoreText.text = currentScore.ToString();
        Debug.Log("currentScore +=1");

        if(currentScore >=500 && Input.GetKeyDown(KeyCode.F))
        {
            dropBarrier(currentScore);
        }
        else
        {
            Debug.Log("Cant drop barrier");
        }

	
	}

    public void dropBarrier(int score)
    {
        currentScore = currentScore - 500;
        Barrier = GameObject.Instantiate<GameObject>(Barrier);



    }
	public void hitTarget(Transform target)
	{
		currentScore += 1;
		Debug.Log ("Target hit");

	}
}
