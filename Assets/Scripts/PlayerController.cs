using UnityEngine;
namespace Golf
{
public class Plaercontroller : MonoBehaviour
{
    public Transform stick;
        public float maxAngle = 30f;
        public float minAngle = 330f;
        public float speed = 1f;

        private void Update()
        {
            Vector3 angle = stick.localEulerAngles;
            if (Input.GetMouseButton(0))
            {   
                angle.z = Mathf.MoveTowardsAngle(angle.z, -maxAngle, speed * Time.deltaTime);
            }
            else
            {
                angle.z = Mathf.MoveTowardsAngle(angle.z, -maxAngle, speed * Time.deltaTime);
            }
            stick.localEulerAngles = angle;
    }
}
}
