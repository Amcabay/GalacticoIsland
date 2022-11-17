using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseClick : MonoBehaviour
{
    public GameObject Hancurkan;

    public int currentScore;
    public Text displayScore;
    public int addScore;

    Animator m_KalengAnim;

    Animator m_Nembak;
    // Start is called before the first frame update
    void Start()
    {
        m_KalengAnim = gameObject.GetComponent<Animator>();   
        m_KalengAnim = gameObject.GetComponent<Animator>();

        OnMouseOver();
    }

    void Update()
    {
        displayScore.text = currentScore.ToString();
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            currentScore += addScore;
            //Destroy(gameObject);

            m_KalengAnim.SetTrigger("Active");
            m_Nembak.SetTrigger("Aktif");

            
        }

    }
}