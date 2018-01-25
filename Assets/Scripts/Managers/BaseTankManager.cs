using System;
using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

namespace Complete
{
    [Serializable]
    public class BaseTankManager : TankManager
    {

        public bool m_isAITank = false;
        public TankState m_StartState;

        public void Setup(List<Transform> wayPointList)
        {
            if (m_isAITank)
            {
                UnityEngine.Object.Destroy(m_Instance.gameObject.GetComponent<TankMovement>());
                m_PlayerNumber = 1000;
                m_Instance.GetComponent<Rigidbody>().isKinematic = false;
                m_Instance.GetComponent<StateController>().currentState = m_StartState;
                SetupAI(wayPointList);
            }
            else
            {
                UnityEngine.Object.Destroy(m_Instance.GetComponent<NavMeshAgent>());
                UnityEngine.Object.Destroy(m_Instance.GetComponent<StateController>());
                SetupPlayerTank();
            }
        }
    }
}