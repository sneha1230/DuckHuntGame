
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject Bulletobj;
    public float bulletspeed = 1.0f;
    ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager=FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetMouseButtonDown(0))
        {
            BulletDirection(Vector3.forward);
        }
        float xAxis = Input.GetAxis("Mouse X");
        float yAxis = Input.GetAxis("Mouse Y");
        transform.Rotate(-yAxis, xAxis,0);
    }
    private void BulletDirection(Vector3 direction)
    {
        GameObject bulletref = Instantiate(Bulletobj);
        bulletref.transform.position = transform.position;
        Rigidbody rb = bulletref.GetComponent<Rigidbody>();
        //rb.AddForce(direction * bulletspeed);
        //rb.velocity = Vector3.forward * bulletspeed;
        //Camera camera = GetComponentInChildren<Camera>();
        rb.velocity =transform.rotation * Vector3.forward * bulletspeed;
    }
        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            scoreManager.IncrementScore();
            Destroy(this.gameObject);
            //enemyDestroySound.clip = enemyClip;
            //enemyDestroySound.Play();
            //scoreManager.incrementScore();
        }

    }
}
