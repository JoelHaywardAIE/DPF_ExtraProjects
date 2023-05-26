using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the ground left slightly every update cycle
        transform.position = transform.position - (Vector3.right * speed * Time.deltaTime);

        //check if the position of ground is off screen
        if(transform.position.x <= -3.84f)
        {
            //move grouhnd to the far right of screen
            transform.position = transform.position + (Vector3.right * 3.84f * 2);
        }
    }
}
