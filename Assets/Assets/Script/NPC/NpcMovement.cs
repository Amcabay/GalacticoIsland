using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;


    private Rigidbody2D myRigidbody;

    public bool isWalking;
    public float walkTime;
    private float walkCounter;

    public float waitTime;
    private float waitCounter;

    private int walkDirection;

    public Collider2D walkZone;
    private bool hasWalkZone;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        ChooseDirection();

        if(walkZone != null)
        {
            minWalkPoint = walkZone.bounds.min;
            maxWalkPoint = walkZone.bounds.max;

            //MENGECEK APAKAH WORK
            hasWalkZone = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isWalking)
        {
            walkCounter -= Time.deltaTime;
            
            switch(walkDirection)
            {
                //MOVE UP
                case 0:
                    myRigidbody.velocity = new Vector2(0, moveSpeed);
                    if(hasWalkZone && transform.position.y > maxWalkPoint.y)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                
                //MOVE RIGHT
                case 1:
                    myRigidbody.velocity = new Vector2(moveSpeed, 0);
                    if(hasWalkZone && transform.position.x > maxWalkPoint.x)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                
                //MOVE DOWN
                case 2:
                    myRigidbody.velocity = new Vector2(0, -moveSpeed);
                    if(hasWalkZone && transform.position.y < maxWalkPoint.y)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
                
                //MOVE LEFT
                case 3:
                    myRigidbody.velocity = new Vector2(-moveSpeed, 0);
                    if(hasWalkZone && transform.position.x < maxWalkPoint.x)
                    {
                        isWalking = false;
                        waitCounter = waitTime;
                    }
                    break;
            }

            if(walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }
        } 
        else
        {
            waitCounter -= Time.deltaTime;

            myRigidbody.velocity = Vector2.zero;

            if(waitCounter < 0)
            {
                ChooseDirection();
            }
        }
    }

    public void ChooseDirection()
    {
        walkDirection = Random.Range(0, 4);
        isWalking = true;

        walkCounter = walkTime;
    }
}
