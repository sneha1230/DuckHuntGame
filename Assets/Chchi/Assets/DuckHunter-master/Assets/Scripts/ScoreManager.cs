using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public int score=0;
    // Start is called before the first frame update
    public void IncrementScore()
    {
        score+=5;
        ScoreText.text="Score:"+score;
    }
}
