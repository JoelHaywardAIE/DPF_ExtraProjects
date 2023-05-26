using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 1.5f;
    private int score = 0;
    public float rdmRngLow = -2.5f;
    public float rdmRngHigh = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //every update cycle move object left
        transform.position = transform.position - (Vector3.right * speed * Time.deltaTime);

       //check if pipe moves off screen
        if(transform.position.x <= -2.3f)
        {
            //reset position to right, then random new height
            transform.position = transform.position + (new Vector3(2.3f * 2, 0, 0));
            transform.position = new Vector3(transform.position.x, Random.Range(rdmRngLow, rdmRngHigh), 0);

            if (GameObject.Find("Text"))
            {
                GameObject.Find("Text").GetComponent<TMP_Text>().text = (++score).ToString();
            }
        }
    }
}
