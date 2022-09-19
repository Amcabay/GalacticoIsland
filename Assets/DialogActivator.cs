using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogActivator : MonoBehaviour
{
    //public Animator animator;
    //public GameObject Popup;
    public string[] lines;

    private bool canActivate;

    private char dialogLines;
    public int currentLine;
    public GameObject tandaTanya;
    public GameObject radio;

    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(canActivate && Input.GetButtonDown("Fire1") && !DialogManager.instance.dialogBox.activeInHierarchy)
        {
            DialogManager.instance.ShowDialog(lines);
            tandaTanya.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Jika player di sekitar object yang bisa interaksi
        if(other.tag == "Player")
        {
            canActivate = true;
            //animator.SetBool("Close", true);
            tandaTanya.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //Jika player di sekitar object yang bisa interaksi
        if(other.tag == "Player")
        {
            canActivate = false;
            //animator.SetBool("Close", false);
            tandaTanya.SetActive(false);
            radio.SetActive(false);
        }
    }
}
