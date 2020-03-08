using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryManager : MonoBehaviour {

    private BoxCollider2D managerBox; //This is the BoxCollider of the boundarymanager
    private Transform player; //position of player
    public GameObject boundary; //The real camera boundary which will be activated and deactivated
	// Use this for initialization
	void Start () {
        managerBox = GetComponent<BoxCollider2D>();
       // player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        ManageBoundary();
	}

    void ManageBoundary()
    {
        if (managerBox.bounds.min.x < player.position.x && player.position.x < managerBox.bounds.max.x && managerBox.bounds.min.y < player.position.y && player.position.y < managerBox.bounds.max.y)
        {
            boundary.SetActive(true);
        }
        else
        {
            boundary.SetActive(false);
        }
    }
}
