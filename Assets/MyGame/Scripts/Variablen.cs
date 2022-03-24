using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}

public class Variablen : MonoBehaviour
{
    public GameObject x;
    Color farbe;
    int anzTuerenInstanz;
    int food;
    int bird;
    bool fahren;
    string name;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Himmelsrichtungen.Nord + "" + Himmelsrichtungen.Sued + "" + Himmelsrichtungen.West + "" + Himmelsrichtungen.Ost);

        farbe = Color.red;
        Debug.Log("red" + farbe.ToString());

        farbe = Color.yellow;
        Debug.Log("yellow" + farbe.ToString());

        farbe = Color.white;
        Debug.Log("white" + farbe.ToString());


        Debug.Log(x.ToString());
        Debug.Log(anzTuerenInstanz.ToString());
        Debug.Log(fahren.ToString());

        int anzTueren = int.Parse("4");
        float anzTuerenf = float.Parse("4");

        

        Debug.Log(anzTueren + "" + anzTuerenf + "" + anzTuerenInstanz);
        //Beispiel 1
        name = "meow";
        Debug.Log("Hallo" + name);

        //Beispiel 2
        anzTueren = 6;
        food = 9;
        bird = 2;
        Debug.Log(anzTueren + food  + bird);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
