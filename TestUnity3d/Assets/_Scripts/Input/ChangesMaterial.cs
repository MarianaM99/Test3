using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangesMaterial : MonoBehaviour
   
{
    public Material secondMaterial;

        private void   OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Renderer>().material = secondMaterial;
        }


    }

    
}
