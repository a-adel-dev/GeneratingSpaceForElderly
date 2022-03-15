using UnityEngine;

namespace GSFE.AngleReports
{
    public class KneeReporter : MonoBehaviour
    {
        [SerializeField] float reportingFrequency;
        Vector3 parentdirection;
        float angle;
        float defaultAngle;
        float timer;
        private void Start()
        {
            defaultAngle = Vector3.SignedAngle(parentdirection, transform.up, transform.forward);

        }

        void Update()
        {
            
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                parentdirection = transform.position - transform.parent.transform.position;
                Vector3 Axis = transform.forward;
                angle = Vector3.SignedAngle(parentdirection,  transform.up, Axis);
                Debug.Log($"Angle is {defaultAngle - angle}");
                //Debug.Log($"bone direction is [{transform.eulerAngles.x}, {transform.eulerAngles.y},{transform.eulerAngles.z}]");
                timer = reportingFrequency;
            }
        }
    }
}