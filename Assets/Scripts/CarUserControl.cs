using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Vehicles.Car;

public class CarUserControl : MonoBehaviour
{
    private CarController m_Car;
    float horizontal;
    float vertical;

    // 何周したらゴールにするかを決める
    public int raceRound = 1;
    
    int roundCounter = 1;

    public int carID;
    
    private void Awake()
    {
        m_Car = GetComponent<CarController>();
    }
    
    private void FixedUpdate()
    {

        if (carID == 1)
        {
            horizontal = CrossPlatformInputManager.GetAxis("Horizontal_P1");
            vertical = CrossPlatformInputManager.GetAxis("Vertical_P1");
        }
        else if (carID == 2)
        {
            horizontal = CrossPlatformInputManager.GetAxis("Horizontal_P2");
            vertical = CrossPlatformInputManager.GetAxis("Vertical_P2");
        }
        else
        {
            horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
            vertical = CrossPlatformInputManager.GetAxis("Vertical");
        }
        
        m_Car.Move(horizontal, vertical, vertical, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Checker" && roundCounter == raceRound)
        {
            if (roundCounter == raceRound)
            {
                Debug.Log("Goal");
            }
            else
            {
                roundCounter += 1;
            }
        }
    }
}

