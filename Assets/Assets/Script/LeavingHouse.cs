using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeavingHouse : MonoBehaviour
{
    public string transitionName;   

    // Start is called before the first frame update
    void Start()
    {
        //POSITION Z harus 0, agar visible
        if(transitionName == PlayerController.instance.areaTransitionName)
        {
            PlayerController.instance.transform.position = transform.position;
        }

        UIFade.instance.FadeFromBlack();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
