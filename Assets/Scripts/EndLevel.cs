using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    private PlayerController playerController;
    private PageManager pageManager;
    //private Renderer exitRend;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        pageManager = GameObject.Find("Page").GetComponent<PageManager>();
        //exitRend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (pageManager.finishLevel == true && playerController.onExitDoor == true)
        //{
        //    //move player to next level/end screen
        //    //exitRend.material.color = new Color(9f, 9, 9);
        //    Destroy(gameObject);
        //}
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    // set on ground state to true if we hit ground
    //    if (other.CompareTag("Player") && pageManager.finishLevel == true)
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
