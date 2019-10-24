using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorTorch : MonoBehaviour{

    private float moveSpeed = 100f;

    private void Start() {
    }

    void Update(){
        transform.position = Vector2.MoveTowards(transform.position,Camera.main.ScreenToWorldPoint(Input.mousePosition),moveSpeed*Time.deltaTime);
    }
}
