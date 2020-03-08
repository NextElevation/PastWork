using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject player1;
    public GameObject player1Clone;
    void Start()
    {
        player1Clone = Instantiate(player1, transform.position, Quaternion.identity) as GameObject;
    }

    void Update()
    {
        if (player1Clone == null)
        {
            player1Clone = Instantiate(player1, transform.position, Quaternion.identity) as GameObject;
        }/*
        if (player1Clone == null && PlayerControler.hasflag2)
        {
            player1Clone = Instantiate(player1, transform.position, Quaternion.identity) as GameObject;
        }*/
    }
}
