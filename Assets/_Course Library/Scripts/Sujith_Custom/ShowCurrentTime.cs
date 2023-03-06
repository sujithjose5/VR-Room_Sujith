using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;


public class ShowCurrentTime : MonoBehaviour
{
    
    private TextMeshPro clockTimeText;
    DateTime localTime;

    // Start is called before the first frame update
    void Start()
    {
        clockTimeText = GetComponent<TextMeshPro>();
     

    }

    // Update is called once per frame
    void Update()
    {
        localTime = DateTime.Now;
        clockTimeText.text = localTime.Hour.ToString() + ":" +localTime.Minute.ToString() + ":" + localTime.Second.ToString();
        
    }
}
