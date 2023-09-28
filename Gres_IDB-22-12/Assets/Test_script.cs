using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cube;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            this.gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
    }
}
