using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDemo : MonoBehaviour
{

    public LayerMask mask;
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Debug.DrawRay(Vector3.zero, transform.forward * 50, Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
            if(Physics.Raycast(Vector3.zero, transform.forward, out hit, 10, mask))
            {
                Debug.Log(hit.transform.name);
                 
            }
        }
    }
}
