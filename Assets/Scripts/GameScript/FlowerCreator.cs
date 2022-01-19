using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerCreator : MonoBehaviour
{
    public static int FlowerCount;
    public GameObject[] flower;
    public Vector3 top;
    int Count = 0;
    void Start()
    {
        InvokeRepeating("Create", 0f, 1f);
    }

    public void Create()
    {
        if (Count < FlowerCount)
        {
            Vector3 vec = new Vector3(top.x + (Count * 20f), Random.Range(top.y, -top.y), 0f);
            Instantiate(flower[Random.Range(0,flower.Length)],vec,Quaternion.identity);
            Count++;
        }
        else
        {
            CancelInvoke();
        }
    }
    
   
}
