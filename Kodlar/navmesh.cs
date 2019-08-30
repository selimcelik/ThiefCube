using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class navmesh : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;

    public float gameoverTime=75;
    public Text gameOverText;
    public Text gameOverOldunText;

    void Start()
    {

    }


    void Update()
    {
        gameoverTime -= Time.deltaTime;
        gameOverText.text = "Time = " + (int)gameoverTime;
        if (gameoverTime <= 0)
        {
            gameoverTime = 0;
            gameOverOldunText.text = "GAME OVER";
            Invoke("restart", 2f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
