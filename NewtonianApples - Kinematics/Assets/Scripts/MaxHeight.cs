using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MaxHeight : MonoBehaviour
{

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        double radians = (Math.PI / 180) * float.Parse(ReadAngle.angle);
        double initialY = float.Parse(ReadVelocity.velocity) * Math.Sin(radians);
        double maxY = (initialY * initialY)/(2*9.8);
        maxY = Math.Round(maxY, 2);
        string y = maxY.ToString();
        string displayString = "Maximum projectile height: " + y + " units";
        text.text = displayString;
    }
}
