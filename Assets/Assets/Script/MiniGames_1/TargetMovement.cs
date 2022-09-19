using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //RANDOM
        float xPos = Random.Range(-1, -5);
        float yVel = Random.Range(9, 14);
        float xVel = Random.Range(-1, 4);

        //MOVE OBJECT ON X-AXIS
        if(this.transform.position.y < -6)
        {
            xPos = Random.Range(-7, 7);

            //KANAN KIRI (not optimal)
            if(xPos < -3)
            {
                xVel = Random.Range(-1, 6);
            }
            
            else if(xPos > 3)
            {
                xVel = Random.Range(-6, 1);
            }

            //NYOBA DULUR
            this.transform.position =  new Vector2(xPos, -5);

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, yVel);
            this.GetComponent<Rigidbody2D>().AddTorque(15);
        }


    }

    void MouseOnDown()
    {
        Destroy(gameObject);
    }
}
