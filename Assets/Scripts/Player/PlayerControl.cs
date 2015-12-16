using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    

    public Vector3 DefaultSpeed;
    public Vector3 MaxSpeed;

    private Vector3 m_Speed;




	// Use this for initialization
	void Start () {

        m_Speed = DefaultSpeed;
	}
	
	// Update is called once per frame
	void Update ()
	{

	    this.transform.position += (this.transform.rotation * m_Speed*Time.deltaTime);


        if (Input.GetKey(KeyCode.UpArrow))
        {
            Quaternion destination_Rotation = transform.rotation*Quaternion.Euler(40, 0, 0);

            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, destination_Rotation, Time.deltaTime * 2.0f);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Quaternion destination_Rotation = transform.rotation * Quaternion.Euler(-40, 0, 0);

            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, destination_Rotation, Time.deltaTime * 2.0f);

        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Quaternion destination_Rotation = transform.rotation * Quaternion.Euler(0, 40, 0);

            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, destination_Rotation, Time.deltaTime * 2.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Quaternion destination_Rotation = transform.rotation * Quaternion.Euler(0, -40, 0);

            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, destination_Rotation, Time.deltaTime * 2.0f);

        }
	
	}
}
