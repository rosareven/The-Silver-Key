using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter() {
        GetComponent<Renderer>().enabled = true;
        Tooltip.description = Clickables.clickables[name];
    }

    private void OnMouseExit() {
        GetComponent<Renderer>().enabled = false;
        Tooltip.description = "";
    }

    private void OnMouseDown() {
        Clickables.interactions(name);
    }
}
