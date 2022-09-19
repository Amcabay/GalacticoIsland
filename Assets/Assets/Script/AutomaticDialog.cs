using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticDialog : MonoBehaviour
{
    //public Animator animator;
    //public GameObject Popup;
    public string[] lines;

    private bool canActivate;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canActivate && Input.GetButtonDown("Fire1") &&!DialogManager.instance.dialogBox.activeInHierarchy)
        {
            DialogManager.instance.ShowDialog(lines);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Jika player di sekitar object yang bisa interaksi
        if(other.tag == "Player")
        {
            canActivate = true;
            
            //animator.SetBool("Close", true);
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //Jika player di sekitar object yang bisa interaksi
        if(other.tag == "Player")
        {
            canActivate = false;
            //animator.SetBool("Close", false);


        }
    }
}
