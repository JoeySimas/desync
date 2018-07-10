using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonLoadScene : MonoBehaviour {

    [SerializeField] string sceneToLoad;
    [SerializeField] GameObject button;

	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(Clicked);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Clicked()
    {
        button.GetComponent<Animator>().SetBool("Used", true);
        Invoke("LoadScene", 3);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
