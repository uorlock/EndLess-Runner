using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Coin_Counter : MonoBehaviour
{
    // Canvas
    private int score = 0;
    public Text scoreText;
    public Text resultText;

    // Canvas Win/Lose Text
    public string loseText;

    public string loseItemStringTag;
    public string coinStringTag;

    public GameObject Menu;
    public PlayerMotor move;
    public Rigidbody myBody;
    
    void Start()
    {
        Menu.SetActive(false);
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("collixion");
        //Debug.Log("Collision  " + col.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == coinStringTag)
        {
            score++;
        }
        else if (other.tag == loseItemStringTag)
        {
            GameOver(false,score);
        }
        Debug.Log("Trigger  " + score + "  " + other.gameObject.name);

        scoreText.text = score.ToString();
        Destroy(other.gameObject);
    }

    void GameOver(bool didWin, int _score)
    {

        Menu.SetActive(true);
        move.enabled = false;
        myBody.isKinematic = true;
        
        resultText.text = loseText + " " + _score.ToString();

    }
}
