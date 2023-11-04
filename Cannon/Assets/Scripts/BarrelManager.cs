using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelManager : MonoBehaviour
{

    private Camera cam;
    private bool pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            pressed = true;
        }
        if (Input.GetMouseButtonUp(0)) {
            pressed = false;
        }

        if (pressed) {
            var dir = Input.mousePosition - cam.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        
    }
}
