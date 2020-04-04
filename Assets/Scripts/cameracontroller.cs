using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{

    public GameObject Player1;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player1.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player1.transform.position + offset;
    }
}