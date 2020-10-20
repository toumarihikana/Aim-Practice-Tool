using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CapsuleMover : MonoBehaviour
{
    private Transform _capsuleTransform;
    
    NavMeshAgent m_navMeshAgent; /// NavMeshAgent

    // Start is called before the first frame update
    void Start()
    {
        _capsuleTransform = this.gameObject.transform;
        // NavMeshAgentコンポーネントを取得
        m_navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //　目的地に到着したかどうかの判定
        if (m_navMeshAgent.remainingDistance < 0.1f)
        {
            arrival();
        }
    }
    
    void arrival()
    {
        // NavMeshが準備できているな
        if (m_navMeshAgent.pathStatus != NavMeshPathStatus.PathInvalid)
        {
            // NavMeshAgentに目的地をセット
            m_navMeshAgent.SetDestination(new Vector3(Random.Range(-15f, 15f), _capsuleTransform.position.y, _capsuleTransform.position.z));
        }
    }
}
