using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public int score;
    public Text scoretext;

    private void FixedUpdate()
    {
        scoretext.text = score.ToString();
    }
}
