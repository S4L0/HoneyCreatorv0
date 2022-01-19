using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexCreate : MonoBehaviour
{
    public static int HexCount;
    public Vector2 StartPoint;
    public GameObject[] Hexs = new GameObject[20];
    public GameObject Hex;
    bool odd = true;
    public GameObject Camera;
    void Start()
    {
        for(int i=0; i < HexCount; i++)
        {
            if(odd)
            {
                GameObject obj = Instantiate(Hex, new Vector3(StartPoint.x + (i*1f)/2.5f,StartPoint.y,-5f),Quaternion.identity);
                Hexs[i] = obj;
                obj.transform.SetParent(Camera.transform);
                odd = false;
            }
            else
            {
                GameObject obj = Instantiate(Hex, new Vector3(0.2f + StartPoint.x + (i * 1f) / 2.5f, StartPoint.y + 1f / 2.9f, -5f), Quaternion.identity);
                Hexs[i] = obj;
                obj.transform.SetParent(Camera.transform);
                if(i != 19)
                {
                    GameObject obj2 = Instantiate(Hex, new Vector3(0.2f + StartPoint.x + (i * 1f) / 2.5f, StartPoint.y - 1f / 2.9f, -5f), Quaternion.identity);
                    Hexs[i + 1] = obj2;
                    obj2.transform.SetParent(Camera.transform);
                }
                odd = true;
                ++i;
            }
        }
    }
}
