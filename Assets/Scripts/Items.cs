using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public static string heldItem;

    void Start()
    {
        heldItem = "";
    }

    public void OnMouseOver(Button button) {
        Tooltip.description = button.name;
    }

    public void OnMouseExit() {
        Tooltip.description = "";
    }

    public void assignHeldItem(Button button){
        heldItem = button.name;
        Debug.Log(heldItem);
    }

    public void deselect(){
        heldItem = "";
        Debug.Log(heldItem);
    }

    public void readLetter(){
        Dialogue.dialogue = "I got this letter from Kyle some time after he died. His front gate key was in it. The letter was brief. It only read \"Retrieve the silver key.\"";
    }
}
