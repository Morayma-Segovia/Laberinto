using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileData
{
    public string filename;
    public string name;
    public bool newGame;

    public float x;
    public float y;
    public float z;

    public int monedas;

    public ProfileData()
    {
        this.filename = "None.xml";
        this.name = "None";
        this.newGame = false;

        this.x = 0;
        this.y = 0;
        this.z = 0;
    }

    public ProfileData(string name, bool newGame, float x, float y, float z, int monedas)
    {
        this.filename = name.Replace(" ", "_") + ".xml";
        this.name = name;
        this.newGame = newGame;
        this.x=x; 
        this.y=y; 
        this.z=z;
        this.monedas = monedas;
    }
}
