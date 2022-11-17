using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame : MonoBehaviour
{
    public GameObject[] kaleng;
    float i;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i += Time.deltaTime;
        if(i > 1f)
        {
            //Duplikasi kaleng baru
            GameObject kalengBaru = Instantiate(kaleng[Random.Range(0, 1)]);
            i = 0;
        }

        //Menembak
        if(Input.GetMouseButtonDown(0))
        {
           
        }
    }
}
