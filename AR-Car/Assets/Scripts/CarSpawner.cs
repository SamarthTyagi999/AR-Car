using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject car;
    public GameObject placementIndicator;
    public GameObject carControls;
    public GameObject placeCarButtons;

    private void Start()
    {
        car.SetActive(false);
        carControls.SetActive(false);
        placeCarButtons.SetActive(true);
        placementIndicator.SetActive(true);
    }

    public void OnPlaceCarButton()
    {
        car.SetActive(true);
        car.transform.position = placementIndicator.transform.position;

        carControls.SetActive(true);
        placeCarButtons.SetActive(false);
        placementIndicator.SetActive(false);
    }
}
