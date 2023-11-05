using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using System;
using System.Net.NetworkInformation;

public class ballmove2 : MonoBehaviour
{

    private Rigidbody2D rb;
    public float vRightBlock = 3;
    public float vRightMass = 1;
    public TextMeshProUGUI buttonSpeed2;

    // Start is called before the first frame update
    void Start()
    {
        vRightBlock = DataManager.Instance.variables[3];
        vRightMass = DataManager.Instance.variables[1];

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(vRightBlock*-1, 0);
        rb.mass = vRightMass;
    }

    // Update is called once per frame
    void Update()
    {
        string dir = rb.velocity.x < 0 ? "[L]" : "[R]";

        if (rb.velocity.x == 0)
        {
            dir = "";
        }

        buttonSpeed2.text = "Velocity 2: " + Math.Abs(rb.velocity.x) + " m/s " + dir;
    }
}
