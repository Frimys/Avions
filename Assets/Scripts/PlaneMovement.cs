using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float planeSpeed = 20f;
    public float planeRotation = 1f;
    protected Rigidbody Plane;
    public GameObject Helice;
    public ParticleSystem Fumee;


    // Start is called before the first frame update
    void Start()
    {
        Plane = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Jump") != 0)
        {
            Plane.AddForce(transform.forward * planeSpeed * Time.deltaTime);
            Helice.transform.Rotate(0f, 0f, planeSpeed);
            if(!Fumee.isEmitting)
            Fumee.Play();

        }
        else
        {
            Fumee.Stop();
        }
            Plane.transform.Rotate(Input.GetAxis("Vertical") * planeRotation, 0f, -1*Input.GetAxis("Horizontal") * planeRotation);

    }
}
