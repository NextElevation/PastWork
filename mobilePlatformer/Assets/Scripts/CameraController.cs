using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private BoxCollider2D cameraBox; //The box collider of the camera
    private Transform player;//The position of player

   // private GameObject player;
   // private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        cameraBox = GetComponent<BoxCollider2D>();
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //offset = transform.position - player.transform.position;
    }

    void Update()
    {
        FollowPlayer();//This may conflict with how the camera follows player
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    
    void LateUpdate() //Runs after all items are processed in update
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void FollowPlayer()
    {
        if (GameObject.Find("Boundary")) //So we dont get null reference error
        {
            transform.position = new Vector3(Mathf.Clamp(player.position.x, GameObject.Find("Boundary").GetComponent<BoxCollider2D>().bounds.min.x + cameraBox.size.x / 2, GameObject.Find("Boundary").GetComponent<BoxCollider2D>().bounds.max.x - cameraBox.size.x / 2),
                                              Mathf.Clamp(player.position.y, GameObject.Find("Boundary").GetComponent<BoxCollider2D>().bounds.min.y + cameraBox.size.y / 2, GameObject.Find("Boundary").GetComponent<BoxCollider2D>().bounds.max.y - cameraBox.size.y / 2),
                                              transform.position.z);
        }
    }
}

