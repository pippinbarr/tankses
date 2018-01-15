using UnityEngine;
using UnityEngine.UI;

namespace Complete
{
    public class VampireTankHealth : TankHealth
    {

        public Light m_Sun;
        public Transform[] m_WeakPoints;
        public float m_SunDamage = 0.5f;

        private Vector3 m_ReverseSun;

        protected override void Awake()
        {
            base.Awake();

            m_ReverseSun = -m_Sun.transform.forward; 
        }

        private void Update()
        {
            bool damage = false;

            for (int i = 0; i < m_WeakPoints.Length; i++)
            {
                if (!Physics.Raycast(m_WeakPoints[i].position, m_ReverseSun, 100f, LayerMask.GetMask("Default")))
                {
                    Debug.DrawRay(m_WeakPoints[i].position, m_ReverseSun * 100, Color.green);
                    damage = true;
                }
                else {
                    Debug.DrawRay(m_WeakPoints[i].position, m_ReverseSun * 100, Color.red);
                }
            }
            if (damage)
            {
                TakeDamage(m_SunDamage);
            }
        }
    }
}