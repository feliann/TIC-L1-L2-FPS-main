using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class COLLIDER : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Piza")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
            SceneManager.LoadScene("Video");
            Time.timeScale = 1f;

        }
    }
}
