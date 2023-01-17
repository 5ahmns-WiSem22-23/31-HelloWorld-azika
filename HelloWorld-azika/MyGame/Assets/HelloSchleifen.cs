using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloSchleifen : MonoBehaviour
{
    // Start is called before the first frame update
    int[,] arr = new int[4, 2];
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                arr[i,j] = i + j;
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
