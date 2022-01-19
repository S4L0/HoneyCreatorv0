using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossing : MonoBehaviour
{
    


    void Update()
    {
        if(transform.parent !=null && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Move>().BeeSpeed = 4f;
            transform.parent.GetChild(0).gameObject.SetActive(false);
            transform.SetParent(null);
            GameObject x = GameObject.FindGameObjectWithTag("Flower");
            Destroy(x);
        }

    }

    //public void OnTriggerExit2D(Collider2D col)
    //{                                                                     NEDEN ÇALIŞMIYOR!!!
    //    Destroy(col.gameObject);
    //}
}
