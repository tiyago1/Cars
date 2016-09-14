using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarController : MonoBehaviour 
{
	#region Fields

   // public Camera mCamera;
    private Rigidbody mRigidBody;
    public float speed = 100.0f;
    //public Dictionary<Vector3>

	#endregion //Fields
	
	#region Unity Methods
	
	private void Start () 
	{
	    Initalize();
	}
	
	private void Update () 
	{

    Vector3 directonValue;
        directonValue = Vector3.zero;

        Debug.Log(directonValue);
        if (Input.GetKey(KeyCode.W))
        {
            directonValue = new Vector3(0.0f,0.0f,1.0f);
            Debug.Log("LOL" + directonValue);
        }
        if (Input.GetKey(KeyCode.A))
        {
            directonValue = new Vector3(-1.0f, 0.0f, 0.0f);   
        }
        if (Input.GetKey(KeyCode.S))
        {
            directonValue = new Vector3(0.0f, 0.0f, -1.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            directonValue = new Vector3(0.0f, 1.0f, 0.0f);
        }

        if (directonValue.z > 0)
        {
            Debug.Log("GELDİ");
            mRigidBody.AddForce(Vector3.forward * speed * Time.deltaTime);
            // forward
        }

        if (directonValue.z < 0)
        {
            mRigidBody.AddForce(Vector3.back * speed * Time.deltaTime);
            // Back
        }

        if (directonValue.x > 0)
        {
            mRigidBody.AddForce(Vector3.right * speed * Time.deltaTime);
            // Right	 
        }

        if (directonValue.x < 0)
        {
            mRigidBody.AddForce(Vector3.left * speed * Time.deltaTime);
            // Left
        }

       
	}
	
	#endregion //Unity Methods
	
	#region Public Methods
	
	public void Initalize()
	{
        //mCamera = this.transform.GetChild(0).GetComponent<Camera>();
        mRigidBody = this.GetComponent<Rigidbody>();
	}
	
	#endregion // Public Methods
	
	#region Private Methods
	
	private void SamplePrivateMethods()
	{
	
	}

    //private void CarController(Vector3 direction)
    //{
    //    if (direction.z > 0)
    //    {
    //        mRigidBody.AddForce(Vector3.forward * speed * Time.deltaTime);
    //        // forward
    //    }

    //    if (direction.z < 0)
    //    {
    //        mRigidBody.AddForce(Vector3.back * speed * Time.deltaTime);
    //        // Back
    //    }

    //    if (direction.x > 0)
    //    {
    //        mRigidBody.AddForce(Vector3.right * speed * Time.deltaTime);
    //        // Right	 
    //    }

    //    if (direction.x < 0)
    //    {
    //        mRigidBody.AddForce(Vector3.left * speed * Time.deltaTime);
    //        // Left
    //    }
    //}

	#endregion //Private Methods
}
