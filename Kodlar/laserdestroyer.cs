using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserdestroyer : MonoBehaviour
{
    public GameObject player;
    Collider[] playerInsideZone;
    public GameObject Laser;
    public bool laserActivator;

    void Start()
    {
        
    }

    void Update()
    {
        playerInsideZone = Physics.OverlapSphere(this.transform.position, 0.15f);
        foreach (var player in playerInsideZone)
        {
            Laser.SetActive(false);
        }
    }
}
