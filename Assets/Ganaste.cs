﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ganaste : MonoBehaviour
{
    public void Restar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        SceneManager.LoadScene("Ganaste");
        Time.timeScale = 1f;

    }
}
