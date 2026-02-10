using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangesMaterial2 : MonoBehaviour


{
    public Material secondMaterial;

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Renderer>().material = secondMaterial;
        }


    }


}
