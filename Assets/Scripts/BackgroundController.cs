using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

    public Transform fruitBar1Transform;
    public Transform fruitBar2Transform;
    public Transform fruitBar3Transform;

    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        fruitBar1Transform.position = new Vector3(fruitBar1Transform.position.x, 5.0f, fruitBar1Transform.position.z);
        fruitBar2Transform.position = new Vector3(fruitBar2Transform.position.x, 5.0f, fruitBar2Transform.position.z);
        fruitBar3Transform.position = new Vector3(fruitBar3Transform.position.x, 5.0f, fruitBar3Transform.position.z);

    }
}
