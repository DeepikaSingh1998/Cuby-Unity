using UnityEngine;

public class playercontroller : MonoBehaviour {
    public Rigidbody rb;
    // Use this for initialization
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
	// Update is called once per frame
    //We are using a 'fixed' update here becoz here we are messing with physics
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
    }
}
