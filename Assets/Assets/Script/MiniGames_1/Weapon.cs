using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    Animator m_Nembak;
    // Start is called before the first frame update
    void Start()
    { 
        m_Nembak = gameObject.GetComponent<Animator>();
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Destroy(gameObject);
            m_Nembak.SetTrigger("nembak");
        }
    }
}
