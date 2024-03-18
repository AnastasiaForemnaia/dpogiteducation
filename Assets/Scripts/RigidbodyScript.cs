using UnityEngine;

public class RigidbodyScript : MonoBehaviour
{
    public Rigidbody body;
    public Vector3 force;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) { 
        body.AddForce(force);
        }
    }
}
