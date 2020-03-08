using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerPlatformerController : PhysicsObject {

    public float jumpTakeoffSpeed = 7;
    public float maxspeed = 7;
    Vector2 move = Vector2.zero;

    Rigidbody2D rb;
    //float dirX;

    [SerializeField]
    float lazerSpeed = 500f; //lazer speed

    //to help see if player is moving right or left
    bool facingRight = true;
    Vector3 localScale;

    //For Firing Lazers
    public Transform barrel;
    public Rigidbody2D lazer;

	// Use this for initialization
	void Start () {
        //changes that may affect movement of player. If so delete.
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
	}

   /* void update()
    {

    }*/

    protected override void computeVelocity()
    {        
        move.x = CrossPlatformInputManager.GetAxis("Horizontal"); //Go back to input if this does not work for crossplatforminputmanager

        //For Firing Lazers. Trying to import to turrets
        if (CrossPlatformInputManager.GetButtonDown("Fire1") /*&& Time.time > nextfire*/)
        {
            fire();
        }

        if (CrossPlatformInputManager.GetButtonDown ("Jump") && grounded)//Go back to input if this does not work for crossplatforminputmanager
        {
            velocity.y = jumpTakeoffSpeed;
        }
        else if (CrossPlatformInputManager.GetButtonUp ("Jump"))//Go back to input if this does not work for crossplatforminputmanager
        {
            if (velocity.y > 0)
                velocity.y = velocity.y * .5f;
        }

        targetVelocity = move * maxspeed;

        /*if (Input.GetMouseButton(0))//Go back to input if this does not work for crossplatforminputmanager
        {
            Debug.Log(Input.mousePosition.x);//Go back to input if this does not work for crossplatforminputmanager
            Debug.Log(Input.mousePosition.y);//Go back to input if this does not work for crossplatforminputmanager
        }*///for debuging and seeing where mouse is on screen.

    }

    void LateUpdate()
    {
        CheckWhereToFace();
    }

    void CheckWhereToFace()
    {
        if (move.x > 0)
            facingRight = true;
        else
        {
            if (move.x < 0)
                facingRight = false;
        }
        //this if may fuck with everything especially with jumping
        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
        {
            localScale.x *= -1;
        }
        transform.localScale = localScale;
    }

    //Method for projectile lazers
    void fire()
    {
        var firedLazer = Instantiate(lazer, barrel.position, barrel.rotation);
        firedLazer.AddForce(barrel.up * lazerSpeed);
    }
}
