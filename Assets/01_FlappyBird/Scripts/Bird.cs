using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float flapHeight = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //stop bird moving downward
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;

            //push bird up with force
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * flapHeight, ForceMode2D.Impulse);
        }
    }

    void OnCollision2D()
    {
        SceneManager.LoadScene(0);
    }
}
