using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyShips : MonoBehaviour {

    public float _time = 0f;
    public Transform radialProgress;

    public GameObject NextObject;
    public GameObject Explosion_;
    // Use this for initialization
    void Start()
    {
        radialProgress.GetComponent<Image>().fillAmount = _time;
    }

    // Update is called once per frame
    void Update()
    {

        _time += Time.deltaTime;
        radialProgress.GetComponent<Image>().fillAmount = _time / 1;

        if (_time >= 1f)
        {
            this.gameObject.SetActive(false);
            Instantiate(Explosion_, this.transform.position, Quaternion.identity);
            NextObject.SetActive(true);
            GameObject.Find("Counter").GetComponent<PointsAdd>().Points++;
            ResetTime();
            this.gameObject.GetComponent<DestroyShips>().enabled = false;
        }
    }

    public void ResetTime()
    {
        _time = 0f;
        radialProgress.GetComponent<Image>().fillAmount = _time;
    }
}

