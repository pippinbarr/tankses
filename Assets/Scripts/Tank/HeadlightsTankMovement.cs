using UnityEngine;

namespace Complete
{
    public class HeadlightsTankMovement : TankMovement
    {
       
        private string m_AltFireName;
        private Light[] headlights;


        protected override void Start ()
        {
            base.Start();
            // The axes names are based on player number.
            m_AltFireName = "Alt" + m_PlayerNumber;
            headlights = GetComponentsInChildren<Light>();
        }

        protected override void FixedUpdate ()
        {
            base.FixedUpdate();
            Headlights();
        }

        private void Headlights() {
            if (Input.GetButtonDown(m_AltFireName)) {
                for (int i = 0; i < headlights.Length; i++) {
                    headlights[i].enabled = !headlights[i].enabled;
                }
            }
        }


    }
}