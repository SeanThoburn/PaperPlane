using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Endpoint : MonoBehaviour
{
    public Text finalScore;
    public int scoreEnd;
    public GameObject restart;
    public GameObject endText;
    public GameObject endScore;

    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0;
        finalScore.text = scoreEnd.ToString();
        restart.gameObject.SetActive(true);
        endText.gameObject.SetActive(true);
        endScore.gameObject.SetActive(true);
    }

}
