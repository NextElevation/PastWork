using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInTime : MonoBehaviour {

    [SerializeField]
    float destroyTime = 2f; //for destruction of lazer

	// Use this for initialization
	void Start () {
        Destroy(gameObject, destroyTime); //destroys lazer after 2 seconds
	}

}
