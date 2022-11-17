using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game : MonoBehaviour
{
    static float timer = 0f;

    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    timer = timer + Time.deltaTime;

    print (timer);

    if(timer >= 2f && timer <= 2.5f)
    {
        GameObject.Find("kaleng 2").transform.position = new Vector3(-6, -5, 0);
        //GameObject.Find("kaleng 2").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
    }

    //Tampilkan score
    score.text = "Score : " + PlayerPrefs.GetInt("skor");
    }
}
