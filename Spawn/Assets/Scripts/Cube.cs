using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour,IPooledObjects
{

    public float upForce = 1f;
    public float sideForce = .1f;
    [SerializeField]
    private Rigidbody rigidbody;
    [SerializeField]
    private Transform transform;
    public float rotationSpeed;

    public void OnObjectSpawn()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce/2f,upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, yForce, zForce);

        rigidbody.velocity = force;
        
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

}
