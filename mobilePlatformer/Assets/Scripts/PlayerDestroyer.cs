using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyer : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check to make sure there is contact with player
        // Note that this is not the best method for doing so.
        if (collision.gameObject.name == "Blax" || collision.gameObject.name == "Player 1")
        {
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}
