﻿using UnityEngine;
using System.Collections;

public class TrafficLight : MonoBehaviour
{
    //MARK: Unity public variable(s)
    public GameObject RedLight;
    public GameObject GreenLight;
    public GameObject RedWalkLight;
    public GameObject GreenWalkLight;

    private void Start()
    {

        StartCoroutine(ChangeLightState(2));
    }



    //MARK: private func
    private IEnumerator ChangeLightState(int seconds)
    {

        while (true)
        {
            yield return new WaitForSeconds(seconds);
            Debug.Log(RedLight.activeSelf);
            if (RedLight.activeSelf)
            {
                RedLight.SetActive(false);
                GreenLight.SetActive(true);
                GreenWalkLight.SetActive(false);
                RedWalkLight.SetActive(true);
            }
            else
            {
                RedLight.SetActive(true);
                GreenLight.SetActive(false);
                GreenWalkLight.SetActive(true);
                RedWalkLight.SetActive(false);
            }
        }
    }
}
