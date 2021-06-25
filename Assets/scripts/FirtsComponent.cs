using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirtsComponent : MonoBehaviour
{

    public float rotationSeed ;

    public bool reverse;

    public Vector3 rotationAxis;

    public string myString;

    public char[] myArray;

    public List<int> myList;

    private void Start()
    {
        Debug.Log("Inside the start method !");
    }

    private void Update()
    {
        float rotation = rotationSeed = Time.deltaTime;
        if( reverse)
        {
            rotation *= -1;
        }

        //rotationAxis = new Vector3(0, 1, 0);

        transform.Rotate(rotationAxis*rotation, Space.World);
        //Debug.Log("Into the UpDate !");

        //rotationAxis = new Vector3(0,1,0)
        //if(reverse )
        //{
        //    transform.Rotate(rotationAxis*rotation= -Time.deltaTime, 0, Space.World);

        //}
        //else
        //{
            transform.Rotate(rotation*rotationAxis, Space.World );

        //}

    }


}
