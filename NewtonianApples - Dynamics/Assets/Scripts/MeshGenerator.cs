using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
{
    Mesh mesh;
    MeshFilter meshFilter;

    Vector3[] vertices;
    int[] triangles;

    private PolygonCollider2D polygonCollider;

    void Start()
    {
        polygonCollider = GetComponent<PolygonCollider2D>();
        mesh = new Mesh();

        meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = mesh;

        CreateMesh();
        UpdateMesh();

        if (meshFilter != null)
        {
            UpdateColliderFromMeshFilter();
        }


    }

    void CreateMesh()
    {
        vertices = new Vector3[]
        {
            new Vector3(0, -4, 0),
            new Vector3(9, -4, 0),
            new Vector3(9, 0, 0)
        };

        triangles = new int[]
        {
            0, 2, 1
        };
    }

    void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }

    void UpdateColliderFromMeshFilter()
    {
        // Get the mesh from the MeshFilter component
        Mesh mesh = meshFilter.mesh;

        // Get the vertices of the mesh
        Vector3[] vertices = mesh.vertices;

        // Calculate the points for the collider based on the mesh vertices
        Vector2[] colliderPoints = new Vector2[vertices.Length];
        for (int i = 0; i < vertices.Length; i++)
        {
            colliderPoints[i] = vertices[i]; // Convert vertices to Vector2
        }

        // Set the calculated points to the PolygonCollider2D
        polygonCollider.SetPath(0, colliderPoints);
    }

}
