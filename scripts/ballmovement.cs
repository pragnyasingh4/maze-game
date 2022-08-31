 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    public float moveSpeed=100f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX=Input.GetAxis("Horizontal");
        float moveZ=Input.GetAxis("Vertical");
        Vector3 movement=new Vector3(moveX,0f,moveZ );
        GetComponent<Rigidbody>().velocity=movement*moveSpeed*Time.deltaTime;
    }
}
