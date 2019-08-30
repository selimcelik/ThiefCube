using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Levelend : MonoBehaviour
{

    void Start()
    {
        if (MoveObject.levelEnd)
        {
            gameObject.SetActive(true);
           
        }
    }

    void OnTriggerEnter(Collider col)
    {
      
            if (col.gameObject.tag == "Player")
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        
    }
}
