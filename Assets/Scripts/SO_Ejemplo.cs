using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Persona", menuName = "ScriptableObject/PersonaSO", order = 1)]

public class SO_Ejemplo : ScriptableObject
{
    public string nombre;
    public int edad;
    public bool vivo;

    void function()
    {
        Debug.Log("hola mundo");
    }
}
