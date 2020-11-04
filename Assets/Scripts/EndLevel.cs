using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    private PlayerController playerController;
    private PageManager pageManager;
    public GameObject endScreen;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        pageManager = GameObject.Find("Page Manager").GetComponent<PageManager>();
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && pageManager.finishLevel == true)
        {
            endScreen.gameObject.SetActive(true);
        }
    }
}
