using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public GameObject MyHealth; 
    public int hp;
    public GameObject spawner;
    public GameObject wintext;
    public GameObject mission;
    void Start()
    {
        hp = 100;
        MyHealth.GetComponent<Text>().text = "Health:" + hp;
    }
    void Update()
    {
        MyHealth.GetComponent<Text>().text = "Health:" + hp;
        if (hp <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
            Debug.Log("see lõpetab mängu");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kill block")
        {
            hp--;
        }

        if (collision.gameObject.tag == "Finish")
        {
            spawner.SetActive(true);
            wintext.SetActive(true);
            mission.SetActive(true);
            
        }
    }
}
