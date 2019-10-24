using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindClock : MonoBehaviour
{
    public static bool day;
    public Animator animator;

    void Start()
    {
        day = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(day){
            animator.SetTrigger("Study-Night 2");
        }
    }
}
