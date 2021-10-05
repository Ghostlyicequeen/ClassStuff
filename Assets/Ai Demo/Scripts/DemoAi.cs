using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class DemoAi : MonoBehaviour
{
    // AI 
    NavMeshAgent agent = null;
    //GameObject TargetPoint = null;


    // RayCast
    public LayerMask mask = 0;
    public float dist = 10f;

    private GameObject hitTarget = null;

    // Start is called before the first frame update
    void Start()
    {
        // Generate a game object (target point) for agent to follow 
        /* agent = GetComponent<NavMeshAgent>();
         TargetPoint = new GameObject("TargetPoint");
         hitTarget = TargetPoint;*/

       // SpawnTargetPoint();
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 direction = new Vector3(Mathf.Sin(Time.time),0, 1);
        // agent.Move(direction * Time.deltaTime * 5);

       

        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * dist, Color.red);
        if (Physics.Raycast(transform.position,transform.forward,out hit, dist, mask))
        {
            hitTarget = hit.transform.gameObject;
        }
        agent.SetDestination(hitTarget.transform.position);
    }

     void SpawnTargetPoint()
    {
        
    }
}
