using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeBackground : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackgroundChanger()
    {
        Image1.SetActive(false);
        Image2.SetActive(true);
    }
}
