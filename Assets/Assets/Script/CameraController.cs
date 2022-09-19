using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Tilemap theMap;
    private Vector3 bottomLeftlimit;
    private Vector3 topRightLimit;

    private float halfHeight;
    private float halfWidht;

    // Start is called before the first frame update
    void Start()
    {
        //CAMERA FOLLOWING PLAYER
        //target = PlayerController.instance.transform;
        target = FindObjectOfType<PlayerController>().transform;

        //CAMERA LIMIT MAP
        halfHeight = Camera.main.orthographicSize;
        halfWidht = halfHeight * Camera.main.aspect;

        bottomLeftlimit = theMap.localBounds.min + new Vector3(halfWidht, halfHeight, 0f);  
        topRightLimit = theMap.localBounds.max + new Vector3(-halfWidht, -halfHeight, 0f);
    
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //PLAYER FOLLOWED BY CAMERA
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);

        //KEEP THE CAMERA INSIDE THE MAP
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftlimit.x, topRightLimit.x), Mathf.Clamp(transform.position.y, bottomLeftlimit.y, topRightLimit.y), transform.position.z);

    }
}
