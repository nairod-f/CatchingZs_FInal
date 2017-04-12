using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // Lets setup the cmera controll variables.
  
    public Transform target;

    public static float MaximumX;
    public static float MaximumY;

    // Use this for initialization
    public static void GetCoords()
    {

        MaximumX = Camera.main.ViewportToWorldPoint(Vector3.one).x;
        MaximumY = Camera.main.ViewportToWorldPoint(Vector3.one).y;

    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, target.position.y, -10);
    }
}