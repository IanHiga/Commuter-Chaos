using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetCarScript : MonoBehaviour
{
    [SerializeField] private GameObject playerCar;
    [SerializeField] private Button resetButton;
    private Vector3 resetPos;
    private Quaternion resetRot;
    
    // Start is called before the first frame update
    void Start()
    {
        resetPos = playerCar.transform.position;
        resetRot = playerCar.transform.rotation;
    }

    public void ResetCar()
    {
        playerCar.transform.position = resetPos;
        playerCar.transform.rotation = resetRot;
        playerCar.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }
}
