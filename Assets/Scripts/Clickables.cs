using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clickables : MonoBehaviour
{
    public static Dictionary<string,string> clickables; // id, tooltip

    void Start(){
        clickables = new Dictionary<string, string>();
        clickables.Add("lamp","Lamp");
        clickables.Add("history bookshelf","Bookshelf");
        clickables.Add("history of umbrage","Books");
        clickables.Add("to Dn","To Dining Room");
        clickables.Add("to Ln","To Living Room");
        clickables.Add("to Un","To Upstairs");
        clickables.Add("Dn big paint","Painting");
        clickables.Add("Dn mid paint","Painting");
        clickables.Add("Dn small paint","Painting");
        clickables.Add("to En","To Entrance");
        clickables.Add("to Kn","To Kitchen");
        clickables.Add("Kn backdoor","Backdoor");
        clickables.Add("cabinet","Cabinet");
        clickables.Add("key cabinet","Cabinet");
        clickables.Add("flowers","Flowers");
        clickables.Add("sink","Kitchen Sink");
        clickables.Add("fireplace","Fireplace");
        clickables.Add("mirror","Mirror");
        clickables.Add("radio","Radio");
        clickables.Add("Ln bookshelf 1","Bookshelf");
        clickables.Add("Ln bookshelf 2","Bookshelf");
        clickables.Add("Un bookshelf","Bookshelf");
        clickables.Add("necronomicon","Books");
        clickables.Add("Un drawer","Drawer");
        clickables.Add("clock","Grandfather Clock");
        clickables.Add("Un paint","Painting");
        clickables.Add("frontgate","Front gate");
        clickables.Add("gatekey","Gate Key");
    }

    public static void interactions(string id){
        switch(id){
            case "to Dn": moveCamera(new Vector3(0,-11f,-10f)); break;
            case "to Ln": moveCamera(new Vector3(0,-33f,-10f)); break;
            case "to Kn": moveCamera(new Vector3(0,-22f,-10f)); break;
            case "to Un": moveCamera(new Vector3(0,-44f,-10f)); break;
            case "to En": moveCamera(new Vector3(0,0f,-10f)); break;
            case "key cabinet": keycabinet(); break;
            case "Un drawer": drawer(); break;
            case "clock": clock(); break;
            case "frontgate": frontgate(); break;
            default: showDialogue(id); break;
        }
    }

    public static void moveCamera(Vector3 location){
        Camera.main.transform.position = location;
        Dialogue.dialogue = "";
    }

    public static void frontgate(){
        if(Items.heldItem=="Gate Key"){
            interactions("to En");
            Dialogue.dialogue = "The front door was not locked, but as soon as I enter, it locks itself shut.";
        } else {
            Items.heldItem="";
            Dialogue.dialogue = "Yes, Kyle's family is rich enough to have a front gate. And it's locked.";
        }
    }

    public static void keycabinet(){
        if(GetDrawerKey.obtained==false){
            GetDrawerKey.obtained = true;
            Dialogue.dialogue = "Oh? There's a key here.";
        } else {
            Dialogue.dialogue = "There's nothing else in there now.";
        }
    }

    public static void drawer(){
        if(Items.heldItem=="Drawer Key"){
            GetClockKey.obtained = true;
            Dialogue.dialogue = "How sneaky. The clock winding key is here.";
        } else {
            Dialogue.dialogue = "This wee sneaky drawer is a great place to lock up precious, important small objects.";
        }
    }

    public static void clock(){
        if(Items.heldItem=="Clock Key"){
            SceneManager.LoadScene("EndScene");
        } else {
            Items.heldItem="";
            Dialogue.dialogue = "This clock is not electric and can be manually winded. If I can find the key to wind it, it'll operate again.";
        }
    }

    public static void showDialogue(string id){
        switch(id){
            case "lamp": Dialogue.dialogue = "No electricity. Can't switch anything on now."; break;
            case "history bookshelf": Dialogue.dialogue = "This shelf is filled with history books about this house and the surrounding region. Nice and welcoming display for the front door."; break;
            case "history of umbrage": Dialogue.dialogue = "\"History of Umbrage\"... I guess that means this house?"; break;
            case "Dn big paint": Dialogue.dialogue = "An old painting of the front gate outside. This house really has been around a long time."; break;
            case "Dn mid paint": Dialogue.dialogue = "It's a painting of a family I don't know of. The title reads \"The Carter's\"."; break;
            case "Dn small paint": Dialogue.dialogue = "A painting of this house during day time. It looks nothing gloomy like right now."; break;
            case "Kn backdoor": Dialogue.dialogue = "Locked, just like the front door."; break;
            case "cabinet": Dialogue.dialogue = "It's empty."; break;
            case "flowers": Dialogue.dialogue = "I don't remember exactly how long it has been since Kyle's gone, but it should be long enough for these flowers to wilt by now. They're still going strong."; break;
            case "sink": Dialogue.dialogue = "Wouldn't be a rich house without the kitchen sink. No water coming out through."; break;
            case "fireplace": Dialogue.dialogue = "One would think I should at least see *something* burning in this house, but even the fireplace is dead and cold. This is getting ironic."; break;
            case "mirror": Dialogue.dialogue = "Now this is strange. It's not reflecting anything. Not even my torch light."; break;
            case "radio": Dialogue.dialogue = "It's battery operated, but the batteries are dead so I can't turn it on anyway."; break;
            case "Ln bookshelf 1": Dialogue.dialogue = "Various books on European mythologies like Greek, Scandinavian, Gaelic etc."; break;
            case "Ln bookshelf 2": Dialogue.dialogue = "Kyle's whole family sure read a lot."; break;
            case "Un bookshelf": Dialogue.dialogue = "The collections here are starting to look strange. \"Call of Cthulu\", \"Book of Blood\", \"Mountain of Madness\"..."; break;
            case "necronomicon": Dialogue.dialogue = "\"Necronomicon\"... My gut tells me I should stay far away from that book, let alone touching it."; break;
            default: Dialogue.dialogue = ""; break;
        }
    }
}
