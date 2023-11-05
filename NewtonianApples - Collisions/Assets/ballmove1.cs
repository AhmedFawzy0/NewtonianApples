using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
//using UnityEngine.UIElements;

public class ballmove1 : MonoBehaviour
{

    private Rigidbody2D rb;
    public float vLeftBlock = 2;
    public float vLeftMass = 1;
    public TextMeshProUGUI buttonSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        vLeftBlock = DataManager.Instance.variables[2];
        vLeftMass = DataManager.Instance.variables[0];

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(vLeftBlock, 0);
        rb.mass = vLeftMass;
        
    }

    // Update is called once per frame
    void Update()
    {
         string dir = rb.velocity.x < 0 ? "[L]" : "[R]";

        if (rb.velocity.x == 0)
        {
            dir = "";
        }

         buttonSpeed.text = "Velocity 1: " + Math.Abs(rb.velocity.x) + " m/s " + dir;

    }
}
