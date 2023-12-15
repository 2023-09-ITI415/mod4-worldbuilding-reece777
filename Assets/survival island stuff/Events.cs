using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{

    public GameObject starterPanel;
    public GameObject TimeText;
    public GameObject FirstPersonController;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        TimeText.SetActive(false);
        //FirstPersonController.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Begin()
    {
        Time.timeScale = 1;
        starterPanel.SetActive(false);
        TimeText.SetActive(true);
        //FirstPersonController.SetActive(true);
    }
}
