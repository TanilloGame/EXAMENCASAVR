using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour
{
    public GameObject Luz;
    
    public void EncenderApagar()
    {
        if (Luz != null) 
        {
            Luz.SetActive(!Luz.activeSelf); 
        }
    }
}

