using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour {
    public Rigidbody2D rb;
    public float WaitTime = 2f;
    public GameObject projectile;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
    }
}