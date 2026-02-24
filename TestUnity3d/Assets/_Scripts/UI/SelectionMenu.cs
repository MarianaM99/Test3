using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // Usar los textos //

public class SelectionMenu : MonoBehaviour
{
    [Header("UI")]
    public Image carImage; 
    public TextMeshProUGUI carName ;
    public Scrollbar speedScrollbar;
    public Scrollbar brakeScrollbar;
    public Scrollbar angleScrollbar;

    [Header("Cars")]
    public MainCameraController cam;
    public CarSO[] cars;
    private int index;
    private CarSO selectedCar;

    private float maxScrollbar = 1000;
    private float maxScrollbarAngle = 60;

    public Transform startPos;

    void Start()
    {
        index = 0;
        selectedCar = cars[index];
        UpdateUI();
    }
   // metodo para actualizar en UI
   public void UpdateUI()
    {
        carImage.sprite = selectedCar.carImage;
        carName.text = selectedCar.carName;
        speedScrollbar.size = selectedCar.speed/ maxScrollbar;
        brakeScrollbar.size = selectedCar.brake/ maxScrollbar;
        angleScrollbar.size = selectedCar.angle/ maxScrollbarAngle;

    }

    // cambio derecha e izquierda 
    public void ChangeCharacter(bool isButtonRight)
    {
        if (isButtonRight)
        {
            index = (index + 1) % cars.Length;
        } else
        {
           index = (index + 1 + cars.Length) % cars.Length;
        }
        selectedCar = cars[index]; //para que cambie el so del carro 
        UpdateUI();
    }

    // Metodo de seleccion
    public void SelectCar()
    {
        GameObject prefabSelected = Instantiate(selectedCar.carPrefab, startPos.position , Quaternion.identity);
        cam.target = prefabSelected.transform;// target es una variable en el script de la camara la cual va seguir
    }
}
