using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public string myString = "";
    public string mySecondString = "Hello";

    public Color myColour = Color.black;
    public bool myBool = true;
    public char myChar = 'd';
    public Vector2 myVector2 = new Vector2(0, 3);
    public Vector3 myVector3 = new Vector3(3, 2, 1);
    public Vector4 myVector4 = new Vector4(0, 0, 0, 0);
    public List<float> myFloatList = new List<float>();
    public List<int> myIntList = new List<int>();
    public List<Color> myColourList = new List<Color>();
    public List<Vector3> myVectorList = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
