using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAutoMove : MonoBehaviour {
    private NavMeshAgent agent;
    public float minDistance = 1;
    public Transform target;  //目标位置

	void Start () {
        agent = this.GetComponent<NavMeshAgent>();
	}
	
	void Update () {
        if (agent.enabled)
        {
            if (agent.remainingDistance < minDistance)
            {
                agent.Stop();
                agent.enabled = false;
            }
        }

        //鼠标左键按下，小球自动寻路到目标位置
        if (Input.GetMouseButtonDown(0))
        {
            SetDestination(target.position);
        }
	}

    public void SetDestination(Vector3 targetPos)
    {
        agent.enabled = true;
        agent.SetDestination(targetPos);
    }
}
