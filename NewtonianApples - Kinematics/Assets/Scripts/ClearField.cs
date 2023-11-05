using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearField : MonoBehaviour
{
    // Start is called before the first frame update
    public void clear()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("projectile");
        foreach(GameObject go in gos)
            Destroy(go);

    }
}
