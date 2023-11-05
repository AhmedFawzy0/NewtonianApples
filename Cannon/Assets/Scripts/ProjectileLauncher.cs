using UnityEngine;
 
public class ProjectileLauncher : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject projectile;
    public float launchSpeed = 10f;
    static public Vector3 startVelocity;
 
    [Header("****Trajectory Display****")]
    public LineRenderer lineRenderer;
    public int linePoints = 300;
    public float timeIntervalInPoints = 0.01f;
 
    void Update()
    {
        if(lineRenderer != null)
        {
            if(Input.GetMouseButton(1))
            {
                DrawTrajectory();
                lineRenderer.enabled = true;
            }
            else
                lineRenderer.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var _projectile = Instantiate(projectile, launchPoint.position, launchPoint.rotation);
            _projectile.GetComponent<Rigidbody2D>().velocity = launchSpeed * launchPoint.up;
        }
        launchSpeed = float.Parse(ReadVelocity.velocity);
    }
 
    void DrawTrajectory()
    {
        Vector3 origin = launchPoint.position;
        startVelocity = launchSpeed * launchPoint.up;
        lineRenderer.positionCount = linePoints;
        float time = 0;
        for (int i = 0; i < linePoints; i++)
        {
            // s = u*t + 1/2*g*t*t
            var x = (startVelocity.x * time) + (Physics.gravity.x / 2 * time * time);
            var y = (startVelocity.y * time) + (Physics.gravity.y / 2 * time * time);
            Vector3 point = new Vector3(x, y);
            lineRenderer.SetPosition(i, origin + point);
            time += timeIntervalInPoints;
        }
    }
}