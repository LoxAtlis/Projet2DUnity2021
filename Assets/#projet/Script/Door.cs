using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    

    public string destination;
    public bool isOpen = true;

    public Sprite doorOpen;
    public Sprite doorClose;

    private void Start(){
        if (isOpen)
        {
            GetComponent<SpriteRenderer>().sprite = doorOpen;
        }
        else{
            GetComponent<SpriteRenderer>().sprite = doorClose;
        }
    }

    public UnityEvent WhenEnter;
    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")&& isOpen){
             SceneManager.LoadScene(destination);;
        }
    }

    public void Unlock(){
        isOpen = true;
        GetComponent<SpriteRenderer>();
    }

}
