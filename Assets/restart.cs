using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void startagain()
    {
        SceneManager.LoadScene("Forest");
        Time.timeScale = 1f;
    }
}
