using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MaxRange : MonoBehaviour
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
        double initialV = float.Parse(ReadVelocity.velocity);
        double range = ((initialV * initialV) * Math.Sin(2 * radians))/9.8;

        range = Math.Round(range, 2);
        string r = range.ToString();
        string displayString = "Maximum horizontal range: " + r + " units";
        text.text = displayString;
    }
}
