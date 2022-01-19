using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour
{
    int num = 0;
    public Sprite sp;
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Flower")
        {
            this.GetComponent<Move>().BeeSpeed =0f;
            transform.SetParent(collision.transform);

            GameObject.FindGameObjectWithTag("HexCreator").GetComponent<HexCreate>().Hexs[num].GetComponent<SpriteRenderer>().sprite = sp;

            num++;
        }


    }
    void Update()
    {
        
    }
}
