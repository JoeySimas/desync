using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAuto : MonoBehaviour {

    private GameObject myDoorway;
    private Animator doorAnim;

	// Use this for initialization
	void Start () {
        myDoorway = this.gameObject.transform.parent.gameObject;
        doorAnim = myDoorway.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            doorAnim.SetBool("Open", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            doorAnim.SetBool("Open", false);
        }
    }
}
