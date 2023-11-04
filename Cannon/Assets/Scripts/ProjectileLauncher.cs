using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ProjectileLauncher : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject projectile;
    public float launchSpeed = 10f;
 
    [Header("****Trajectory Display****")]
    public LineRenderer lineRenderer;
    public int linePoints = 175;
    public float timeIntervalInPoints = 0.01f;
 
    // void Start() {
    //     LineRenderer l = gameObject.AddComponent<LineRenderer>();
        
    //     List<Vector3> pos = new List<Vector3>();
    //     pos.Add(new Vector3(0, 0));
    //     pos.Add(new Vector3(10, 10));
    //     l.startWidth = 1f;
    //     l.endWidth = 1f;
    //     l.SetPositions(pos.ToArray());
    //     l.useWorldSpace = true;
    // }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var _projectile = Instantiate(projectile, launchPoint.position, launchPoint.rotation);
            _projectile.GetComponent<Rigidbody2D>().velocity = launchSpeed * launchPoint.up;
        }
    }
 
    void DrawTrajectory()
    {
        Vector3 origin = launchPoint.position;
        Vector3 startVelocity = launchSpeed * launchPoint.up;
        lineRenderer.positionCount = linePoints;
        float time = 0;
        for (int i = 0; i < linePoints; i++)
        {
            // s = u*t + 1/2*g*t*t
            var x = (startVelocity.x * time) + (Physics.gravity.x / 2 * time * time);
            var y = (startVelocity.y * time) + (Physics.gravity.y / 2 * time * time);
            Vector3 point = new Vector3(x, y, 0);
            lineRenderer.SetPosition(i, origin + point);
            time += timeIntervalInPoints;
        }
    }
}
