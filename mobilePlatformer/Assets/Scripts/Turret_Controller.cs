using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Controller : MonoBehaviour {

    [SerializeField]
    float lazerSpeed = 500f; //lazer speed

    //For Firing Lazers
    public Transform barrel;
    public Rigidbody2D lazer;
    public int starting_angle;

    float m_timer = 2.0f;
    void Update()
    {

        m_timer -= Time.deltaTime;
        //fire();
        if (m_timer <= 0.0f)
        {
            if (transform.rotation.eulerAngles.z < 225)
            {
                Quaternion rot = new Quaternion();
                rot.eulerAngles = new Vector3(0, 0, -0);
                transform.rotation = rot;
            }
            m_timer += 2.0f;
            transform.Rotate(0.0f, 0.0f, -45.0f);
            fire();
        }
    }

    //Method for projectile lazers
    void fire()
    {
        var firedLazer = Instantiate(lazer, barrel.position, barrel.rotation);
        firedLazer.AddForce(barrel.up * lazerSpeed);
    }
}
