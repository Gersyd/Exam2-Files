using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointsAdd : MonoBehaviour {

    public float Points;

	// Update is called once per frame
	void Update ()
    {
        if (Points == 12)
        {
            Debug.Log("End");
            SceneManager.LoadScene(0);
        }
	}
}
