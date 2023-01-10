using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushing2 : MonoBehaviour

{
    //PSEDO CODE: Declare float variables for speed, maxspeed, acceleration, deceleration, rotation
    public float speed = 20.0f;
    public float maxspeed = 50.0f;
    public float acc = 5.0f;
    public float dec = 5.0f;
    public float rotation = 0.0f;
    // Start is called before the first frame update
   // void Start()
    //{
        
    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        //PSEUDO CODE: Check for space key input. If not max speed, accelerate, else decelerate
        if(Input.GetButton("Vertical"))
        {
            //acc
            if (speed < maxspeed) {
                speed += acc;
            }
        }
        else
        {
            //dec
            if (speed > 0) {
                speed -= dec;
            }
       


        }

        //PSEUDO CODE: Use the speed and transform to move the object forward
        //FUNCTION: Simplist transform with ACC, DEC, Speed (Space bar), and TDT

        //PSEUDO CODE: Check for Left and Right Key inputs. Turn if left or right keys are pressed
        transform.position += transform.forward * Time.deltaTime * speed;
       
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, 2.0f, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, -2.0f, 0);
        }


        //PSEUDO CODE: Use the speed and transform to move the object forward
        //FUNCTION: Simplist transform w
         /*if(Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.left=1000.0f);
        }*/
        
    }
}
