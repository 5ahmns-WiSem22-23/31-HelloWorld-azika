using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVariablen : MonoBehaviour

    
{
    int myInt = 0;
    bool myBool = true;
    string a = "Hallo";
    int[] myArray = new int[3] { 0, 0, 0 };
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(sizeof(int));
        Debug.Log(sizeof(bool));

        //Value type
        int tmp = myInt; //Zwischengespeichert
        myInt++;
        Debug.Log("myInt: " + myInt + " tmp " + tmp);

        //Referencetype
        int[] tmpArray = myArray;
        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;

        Debug.Log("-------tmpArray");
        foreach(int a in tmpArray)
        {
            Debug.Log(a);
        }
        Debug.Log("-------tmpArray");
        foreach (int a in myArray)
        {
            Debug.Log(a);
        }


        string tmpString = a;
        a = "hello";
        Debug.Log("a" + a + "tmpString " + tmpString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
