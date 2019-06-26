using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imbalance : MonoBehaviour
{
    float smooth = 5.0f;
    float tiltAngle = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // void Update()
    // {
    //     float torqueValue = Random.Range(-4f,4f);
    //     rb.AddRelativeForce(0,0,-torqueValue);
    //     Debug.Log(torqueValue);
    //     //rb.AddRelativeTorque(0,0,2);
    // }


    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
    }
}

//     float speed = 2.0f;
 
//     void Update ()
//     {
//         Vector3 move = Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
//         transform.Translate(move * speed * Time.deltaTime);
// }
// }
