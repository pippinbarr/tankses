using UnityEngine;

namespace Complete
{
    public class ShellCutsShellExplosion : ShellExplosion
    {       
        protected override void OnTriggerEnter (Collider other)
        {
            GameObject cam = GameObject.Find("Main Camera");
            Transform t = transform;
            cam.transform.position = new Vector3(t.position.x,t.position.y + 1,t.position.z);
            cam.transform.eulerAngles = new Vector3(t.eulerAngles.x,t.eulerAngles.y - 180,t.eulerAngles.z);

            base.OnTriggerEnter(other);
        }

    }
}