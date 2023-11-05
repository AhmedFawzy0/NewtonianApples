using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoxScript : MonoBehaviour
{
    Transform _tf;
    Rigidbody2D _rb;
    public TextMeshProUGUI speedTagX;
    public TextMeshProUGUI speedTagY;


    // Start is called before the first frame update
    void Awake()
    {
        _tf = gameObject.GetComponent<Transform>();
        _rb = gameObject.GetComponent<Rigidbody2D>();

        _rb.mass = DataManager.Instance.variables[2];
        float friction = DataManager.Instance.variables[3];

        if (friction <= 0) friction = 0.001f;
        else if (friction > 1) friction = 1;

        _rb.sharedMaterial.friction = friction;

        RaycastHit2D hit = Physics2D.Raycast(transform.position + Vector3.down, Vector2.down, Mathf.Infinity);

        if (hit.collider != null)
        {
            _tf.rotation = Quaternion.FromToRotation(Vector3.right, hit.normal);
            _tf.position = hit.point + new Vector2(0, 0.73f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        speedTagX.text = "velocity: " + Mathf.Round(_rb.velocity.x);
        speedTagY.text = "velocity: " + Mathf.Round(_rb.velocity.y);
    }
}
