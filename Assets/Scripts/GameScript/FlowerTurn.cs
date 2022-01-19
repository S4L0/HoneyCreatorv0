using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerTurn : MonoBehaviour
{
    public static float FlowerSpeed=30;
    void Update()
    {
        gameObject.transform.Rotate(0,0,FlowerSpeed * Time.deltaTime);
    }
}
