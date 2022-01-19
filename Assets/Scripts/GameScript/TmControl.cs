using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TmControl : MonoBehaviour
{

    public Text txtRemainingTime;
    public float StartTime = 60;
    

    void Start()
    {
        
    }
    public void constime()
    {
        txtRemainingTime.text = StartTime.ToString("F0");
    }

  
    void Update()
    {
        StartTime -= Time.deltaTime;
        Invoke("constime", 0f);
    }
}
