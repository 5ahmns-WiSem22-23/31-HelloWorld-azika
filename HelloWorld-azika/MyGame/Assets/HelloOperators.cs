using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloOperators : MonoBehaviour
{
    public float eins = 10.5f;
    public float zwei = 2f;
    public bool bool1 = true;
    public bool bool2 = false;
    public int drei = 3;
    public int vier = 4;

    // Start is called before the first frame update
    void Start()
    {
        // Arithmetische Operatoren
        float sum = eins + zwei; // sum wird 15.5 sein
        float difference = eins - zwei; // difference wird 5.5 sein
        float product = eins * zwei; // product wird 52.5 sein
        float quotient = eins / zwei; // quotient wird 2.1 sein

        Debug.Log(sum);
        Debug.Log(difference);
        Debug.Log(product);
        Debug.Log(quotient);


        // Logische Operatoren
        bool andResult = bool1 && bool2; // andResult wird false sein
        bool orResult = bool1 || bool2; // orResult wird true sein
        bool notResult = !bool1; // notResult wird false sein

        Debug.Log(andResult);
        Debug.Log(orResult);
        Debug.Log(notResult);

        // Gleichheits Operatoren
        bool equal = eins == zwei; // equal wird false sein
        bool notEqual = eins != zwei; // notEqual wird true sein

        Debug.Log(equal);
        Debug.Log(notEqual);

        // Vergleichs Operatoren
        bool greaterThan = eins > zwei; // greaterThan wird true sein
        bool lessThan = eins < zwei; // lessThan wird false sein
        bool greaterThanOrEqualTo = eins >= zwei; // greaterThanOrEqualTo wird true sein
        bool lessThanOrEqualTo = eins <= zwei; // lessThanOrEqualTo wird false sein

        Debug.Log(greaterThan);
        Debug.Log(lessThan);
        Debug.Log(greaterThanOrEqualTo);
        Debug.Log(lessThanOrEqualTo);

        // Zuweisungs Operatoren
        int result = drei; // result wird 3 sein
        result += vier; // result wird 7 sein
        result -= vier; // result wird 3 sein
        result *= vier; // result wird 12 sein
        result /= vier; // result wird 3 sein

        Debug.Log(result);
    }
}
