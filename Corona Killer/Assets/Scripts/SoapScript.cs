using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapScript : MonoBehaviour
{
    [SerializeField] private int speed;
    private GameObject gun;
    private Vector3 gunRotation;

    void Start()
    {
        gun = GameObject.FindGameObjectWithTag("Gun");
        gunRotation = gun.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(gunRotation * speed * Time.deltaTime);
    }
}
