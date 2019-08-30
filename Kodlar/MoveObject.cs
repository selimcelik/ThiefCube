using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveObject : MonoBehaviour
{
    public static bool levelEnd;
    public bool sphere;

    public GameObject item;
    public GameObject tempParent;
    public Transform guide;


    public GameObject LeveLEnd;


    void Start()
    {

        if (sphere)
        {
            item.GetComponent<Rigidbody>().useGravity = true;
        }
        LeveLEnd.SetActive(false);
    }


    void Update()
    {
    }

    void OnTriggerEnter(Collider col)
    {
        if (sphere)
        {
            if (col.gameObject.tag == "Player")
            {
                item.GetComponent<Rigidbody>().useGravity = false;
                item.GetComponent<Rigidbody>().isKinematic = true;
                item.transform.position = guide.transform.position;
                item.transform.rotation = guide.transform.rotation;
                item.transform.parent = tempParent.transform;
                LeveLEnd.SetActive(true);
                levelEnd = true;
            }
        }
    }
}
