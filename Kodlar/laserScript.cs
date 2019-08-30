using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class laserScript : MonoBehaviour
{
    public LineRenderer lr;

    public bool basic;
    public bool activeordeactive;
    public bool activeordeactive1;
    public bool rotating45;
    public bool rotating90;
    public bool rotating_90;
    public bool rotating180;
    public bool rotating_180;
    public bool rotating270;
    public bool rotating_270;
    public bool destroyer;


    void Start()
    {
        lr = GetComponent<LineRenderer>();
        if (activeordeactive)
        {
            StartCoroutine(BlinkTimer());
        }
        if (activeordeactive1)
        {
            StartCoroutine(BlinkTimerr());
        }
    }
    IEnumerator BlinkTimerr()
    {
        yield return new WaitForSeconds(1.5f);
        lr.enabled = false;
        StartCoroutine(BlinkTimerr2());
    }
    IEnumerator BlinkTimerr2()
    {
        yield return new WaitForSeconds(1.5f);
        lr.enabled = true;
        StartCoroutine(BlinkTimerr());
    }
    IEnumerator BlinkTimer()
    {
        yield return new WaitForSeconds(1);
        lr.enabled = false;
        StartCoroutine(BlinkTimer2());
    }

    IEnumerator BlinkTimer2()
    {
        yield return new WaitForSeconds(1);
        lr.enabled = true;
        StartCoroutine(BlinkTimer());
    }
    void Update()
    {

        if (rotating45)
        {
            lr.transform.eulerAngles = new Vector3(0, Mathf.PingPong(Time.time * 50, 65), 0);
        }
        if (rotating90)
        {
            lr.transform.eulerAngles = new Vector3(0, Mathf.PingPong(Time.time * 50, 90), 0);
        }
        if (rotating_90)
        {
            lr.transform.eulerAngles = new Vector3(0, -Mathf.PingPong(Time.time * 50, 90), 0);
        }
        if (rotating180)
        {
            lr.transform.eulerAngles = new Vector3(0, Mathf.PingPong(Time.time * 50, 180), 0);
        }
        if (rotating_180)
        {
            lr.transform.eulerAngles = new Vector3(0, -Mathf.PingPong(Time.time * 50, 180), 0);
        }
        if (rotating270)
        {
            lr.transform.eulerAngles = new Vector3(0, Mathf.PingPong(Time.time * 50, 270), 0);
        }
        if (rotating_270)
        {
            lr.transform.eulerAngles = new Vector3(0, Mathf.PingPong(Time.time * 50, 270), 0);
        }
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                lr.SetPosition(1, new Vector3(0, 0, hit.distance));

            }
            else
            {
                lr.SetPosition(1, new Vector3(0, 0, 0.5f));
            }

            if (lr.enabled == true)
            {

                if (hit.collider.gameObject.tag == "Player")
                {
                    Destroy(hit.collider.gameObject);
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

                }
            }
        }

    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}