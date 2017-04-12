using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDest : MonoBehaviour
{


    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
