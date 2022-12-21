using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalloVerzweigung : MonoBehaviour
{
    public int eins = 0;
    public string zwei = "hello";

    void Start()
    {
        // If-Statement
        if (eins == 0)
        {
            Debug.Log("eins ist 0");
        }

        // If-Else-Statement
        if (eins == 1)
        {
            Debug.Log("eins ist 1");
        }
        else
        {
            Debug.Log("eins ist nicht 1");
        }

        // If-Statement mit Return
        if (eins == 0)
        {
            Debug.Log("zwei ist 0");
            return;
        }

        // Verschachtelung von If-Statements
        if (eins == 0)
        {
            Debug.Log("eins ist 0");

            if (eins == 1)
            {
                Debug.Log("eins ist 1");
            }
            else
            {
                Debug.Log("eins ist nicht 1");
            }
        }
        else
        {
            Debug.Log("eins ist nicht 0");
        }

        var zwei = "hello";
        Debug.Log(zwei); // Ausgabe: "hello"
        zwei += " world";
        Debug.Log(zwei); // Ausgabe: "hello world"


        switch (eins)
        {
            case 0:
                Debug.Log("eins ist 0");
                break;
            case 1:
                Debug.Log("eins ist 1");
                break;
            default:
                Debug.Log("eins ist weder 0 noch 1");
                break;
        }
    }
    }
