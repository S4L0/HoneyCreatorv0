using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform Player;
    public float smoothX;
    public float smoothY;
    public float MinX;
    public float MinY;
    public float MaxX;
    public float MaxY;
    void Start()
    {
        Player = GameObject.Find("Bee").transform;
    }

    private void LateUpdate()
    {
        float posX = Mathf.MoveTowards(transform.position.x, Player.position.x, smoothX);
        float posY = Mathf.MoveTowards(transform.position.y, Player.position.y, smoothY);

        transform.position = new Vector3(Mathf.Clamp(posX, MinX, MaxX), Mathf.Clamp(posY, MinY, MaxY), transform.position.z);

    }
}
