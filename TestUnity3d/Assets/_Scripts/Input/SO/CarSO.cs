using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CREAR MENU PARA EL CARRO

[CreateAssetMenu(fileName="New Car", menuName = "Car/New Car")]


public class CarSO : ScriptableObject
{
    // Caracteristicas del carro ( velocidad, fuerza de freno y angulo)

    public float speed;
    public float brake; // fuerza//
    public float angle;


}
