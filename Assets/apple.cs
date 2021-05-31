using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<game>().score += 1;
        FindObjectOfType<Endpoint>().scoreEnd += 1;
        Destroy(gameObject);
    }

}
