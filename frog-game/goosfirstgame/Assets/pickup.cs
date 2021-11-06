using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pickup : MonoBehaviour
{
    public int score;
    public AudioSource audio;
    public GameObject scoreText;
   // public int health;
    // Start is called before the first frame update
    void Start()
    {score = 0;
       // health = 100;
        scoreText.GetComponent<Text>().text = "My Score:" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="coin")
        {
            score++;
            scoreText.GetComponent<Text>().text = "My Score:" + score;
            audio.Play();
            Destroy(collision.gameObject);
        }
       
    }
}
