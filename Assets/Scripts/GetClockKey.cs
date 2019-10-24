using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetClockKey : MonoBehaviour
{
    public static bool obtained;

    void Start()
    {
        obtained = false;    
    }

    void Update()
    {
        if(obtained){
            GetComponent<RectTransform>().localPosition = new Vector2(-180f,190f);
        }
    }
}
