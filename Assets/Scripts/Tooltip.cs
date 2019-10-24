using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    public static string description;
    private GameObject descriptionBox;
    // Start is called before the first frame update
    void Start()
    {
        description = "";
        descriptionBox = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = description;
        if(description != ""){
            descriptionBox.GetComponent<Image>().enabled = true;
        } else {
            descriptionBox.GetComponent<Image>().enabled = false;
        }
    }
}
