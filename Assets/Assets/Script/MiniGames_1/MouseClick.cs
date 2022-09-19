using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public GameObject Hancurkan;

    Animator m_KalengAnim;

    Animator m_Nembak;
    // Start is called before the first frame update
    void Start()
    {
        m_KalengAnim = gameObject.GetComponent<Animator>();   
        m_KalengAnim = gameObject.GetComponent<Animator>();
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Destroy(gameObject);

            m_KalengAnim.SetTrigger("Active");
            m_Nembak.SetTrigger("Aktif");
        }
    }
}
