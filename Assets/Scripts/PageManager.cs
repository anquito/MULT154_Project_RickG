using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    public GameObject[] pages;
    public bool finishLevel = false;
    // Start is called before the first frame update
    void Start()
    {
        pages = GameObject.FindGameObjectsWithTag("Page");
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Page").Length == 0)
        {
            finishLevel = true;
        }
    }
}
