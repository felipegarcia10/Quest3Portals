using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeRay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log($"Ray hit: {hit.collider.name}");
            Debug.DrawRay(transform.position, transform.forward, Color.red);
        }
    }
}
