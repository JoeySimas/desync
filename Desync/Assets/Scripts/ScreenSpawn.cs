using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScreenSpawn : MonoBehaviour {

    public Text text;
    public string msg1;
    public string msg2;

    public GameObject screen;

    public GameObject player;
    public GameObject cameraTemp;

	// Use this for initialization
	void Start () {
        text.text = "welcome user 004";
        Invoke("Message1", 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Message1()
    {
        text.text = msg1;
        Invoke("Message2", 5);
    }

    void Message2()
    {
        text.text = msg2;
        Destroy(cameraTemp);
        player.SetActive(true);
        Invoke("Undock", 1f);
    }

    void Undock()
    {
        screen.GetComponent<Animator>().SetBool("Docked", false);
    }
}
