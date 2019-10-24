using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetDrawerKey : MonoBehaviour
{
    public static bool obtained;

    void Start()
    {
        obtained = false;    
    }

    void Update()
    {
        if(obtained){
            GetComponent<RectTransform>().localPosition = new Vector2(-240f,190f);
        }
    }
}
