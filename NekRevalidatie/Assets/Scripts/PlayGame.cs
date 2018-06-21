﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

    public float myTime = 0f;
    public Transform radialProgress;

    // Use this for initialization
    void Start()
    {
        radialProgress.GetComponent<Image>().fillAmount = myTime;
    }

    // Update is called once per frame
    void Update()
    {

        myTime += Time.deltaTime;
        radialProgress.GetComponent<Image>().fillAmount = myTime / 1;

        if (myTime >= 1f)
        {
            SceneManager.LoadScene(1);
            Resetinator();
        }
    }

    public void Resetinator()
    {
        myTime = 0f;
        radialProgress.GetComponent<Image>().fillAmount = myTime;
    }
}
