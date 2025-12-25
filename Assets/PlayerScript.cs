using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float horizotalInput = 0.0f;
    private float speed = 20.0f;
    private float turnSpeed = 100.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizotalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //transform.Translate(horizotalInput * Time.deltaTime, 0, 0);
        transform.Rotate(0, horizotalInput * Time.deltaTime * turnSpeed, 0);
    }
}
