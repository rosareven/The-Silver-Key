using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public static string dialogue;
    private GameObject dialogueBox;
    // Start is called before the first frame update
    void Start()
    {
        dialogue = "";
        dialogueBox = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = dialogue;
        if(dialogue != ""){
            dialogueBox.GetComponent<Image>().enabled = true;
        } else {
            dialogueBox.GetComponent<Image>().enabled = false;
        }
        if(Input.GetMouseButtonDown(0)&&Tooltip.description==""){
            dialogue = "";
            dialogueBox.GetComponent<Image>().enabled = false;
        }
    }
}
