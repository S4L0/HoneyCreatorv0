using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float BeeSpeed = 2f;
    Rigidbody2D rg;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        rg.velocity = transform.right * BeeSpeed;
    }
}
