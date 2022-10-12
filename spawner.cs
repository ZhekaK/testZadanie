using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class spawner : MonoBehaviour
{
    public control cubee;
    public float time;
    public GameObject cube;
    public InputField inputTime;
    public InputField inputSpeed;
    public InputField inputDistance;
    public GameObject canv;

    void Start()
    {
        spawn();
    }

    void spawn()
    {
        Instantiate(cube, transform.position, Quaternion.identity);
        Invoke("spawn", time);
    }

    public void ready()
    {
        gameObject.SetActive(true);
        time = System.Single.Parse(inputTime.text);
        cubee.speed = System.Single.Parse(inputSpeed.text);
        cubee.distance =  System.Single.Parse(inputDistance.text);
        canv.SetActive(false);
    }

    void Update()
    {
        
    }
}
