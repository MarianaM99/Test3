using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    //hacer las variabes de las 4 llantas y del transform
    // Se neceista el input del jugador 

    private OldInput oldInput;
    public CarSO car;

    [SerializeField] private WheelCollider[] _wheelCollider;
    [SerializeField] private Transform[] _wheelTransform;

    public float speed;

    void Start()
    {
        oldInput = GetComponent<OldInput>();
        speed = car.speed;
    }
    void Update()
    {
        WheelBrake();
        WheelAngle();
        WheelsUpdate();

    }

    void FixedUpdate()
    {
        MotorSpeed();
        WheelAngle();

    }

    // velocidad

    public void MotorSpeed()
    {
        foreach (var wheel in _wheelCollider)
        {
            wheel.motorTorque = oldInput.vertical * speed;
        }
    }
    // Frenos
    public void WheelBrake()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var wheel in _wheelCollider)
            {
                wheel.brakeTorque = car.brake;
            }
        }else if (Input.GetKeyUp(KeyCode.Space))
        {
            foreach (var wheel in _wheelCollider)
            {
                wheel.brakeTorque = 0;
            }
        }
    }
    // angulo
    public void WheelAngle()
    {
        _wheelCollider[1].steerAngle = oldInput.horizontal * car.angle;
        _wheelCollider[3].steerAngle = oldInput.horizontal * car.angle;

    }
    // Actualizar las llantas
    public void WheelsUpdate()
    {
        for(int i = 0; i <_wheelCollider.Length; i ++)
        {
            UpdateWheel(_wheelCollider[i], _wheelTransform[i]);
        }

    }

    // Constructor metodo

    public void UpdateWheel(WheelCollider collider, Transform transform )
    {
        Vector3 pos;
        Quaternion rot;

        collider.GetWorldPose(out pos, out rot);

        transform.position = pos;
        transform.rotation = rot;

    }

}
