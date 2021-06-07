using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Rigidbody bulletRb;
    //AudioSource enemyDestroySound;
    //public AudioClip enemyClip;
    //public int score;
    //ScoreManager scoreManager;
    //public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        //scoreManager = FindObjectOfType<ScoreManager>();
        //enemyDestroySound = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletRb.velocity = new Vector3(0,0,1);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "lb_bird")
        {
            
            //enemyDestroySound.clip = enemyClip;
            //enemyDestroySound.Play();
            //scoreManager.incrementScore();
        }

    }
}
