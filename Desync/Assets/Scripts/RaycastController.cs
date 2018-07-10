using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public float interactionDistance;
    public bool raycastOut;
    public Image reticle;

    public Sprite reticleNormal;
    public Sprite reticleHover;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Constant Raycast
        Ray rayUpdate = new Ray(transform.position, transform.forward);
        RaycastHit rayUpdateHit;
        rayUpdate = new Ray(transform.position, transform.forward); 
        if (Physics.Raycast(rayUpdate, out rayUpdateHit, interactionDistance))
        {
            if(rayUpdateHit.transform.tag == "Interactable")
            {
                //reticle.GetComponent<Image>().color = Color.red;
                reticle.GetComponent<Image>().sprite = reticleHover;
                reticle.transform.localScale = new Vector3(2, 2, 2);

            }

        }
            else
            {
                //reticle.GetComponent<Image>().color = Color.white;
                reticle.GetComponent<Image>().sprite = reticleNormal;
                reticle.transform.localScale = new Vector3(1,1,1);
        }

        // Interact Raycast
        if (raycastOut == false && Input.GetButtonDown("Interact"))
        {
            raycastOut = true;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, interactionDistance))
            //1 << LayerMask.NameToLayer("Controllables")
            {
                hit.transform.SendMessage("HitByRay");
                print("hit");
            }
            Invoke("ResetRaycastOut", .1f);

        }
    }

    void ResetRaycastOut ()
    {
        raycastOut = false; 
    }
}
