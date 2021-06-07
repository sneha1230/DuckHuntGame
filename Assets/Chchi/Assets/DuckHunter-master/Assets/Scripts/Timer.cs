using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Timer : MonoBehaviour
{
    public GameObject TimerText;
    public int secondsLeft = 30;
    public bool takingAway = false;

    void Start()
    {
        TimerText.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    private void Update()
    {
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
            TimerText.GetComponent<Text>().text = "00:0" + secondsLeft;
        }
        else if(secondsLeft > 10)
        {
            TimerText.GetComponent<Text>().text = "00:" + secondsLeft;
        }
        else if(secondsLeft == 0)
        {
            SceneManager.LoadScene(2);
        }
        takingAway = false;
    }
}
