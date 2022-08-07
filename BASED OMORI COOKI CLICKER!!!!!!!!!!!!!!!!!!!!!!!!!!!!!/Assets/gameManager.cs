using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour

{
    int score = 0;
    int increment = 1;
    public Text text1;
    public AudioSource soundPlayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void increase()
    {

        score += increment;
        text1.text = score.ToString();
    }

    public void Store()
    {

        if (score > 5)
        {
            increment++;
            score -= 5;
            text1.text = score.ToString();
        }
        else
        {
            print("You do not have enough score to power up");

        }


    }

    public void playSoundBoom()
    {
        soundPlayer.Play();

    }
}
