using UnityEngine;

namespace RollABall
{
    public class Stage : MonoBehaviour
    {
        [SerializeField] [Range(0.1f, 2.0f)] private float horizontalBias = 1.0f;
        [SerializeField] [Range(0.1f, 2.0f)] private float verticalBias = 1.0f;

        private float HorizontalBias => horizontalBias;
        private float VerticalBias => verticalBias;

        private float RotationZ { get; set; }
        private float RotationX { get; set; }

        public void ResetTransform()
        {
            RotationX = 0.0f;
            RotationZ = 0.0f;
            transform.localRotation = Quaternion.identity;
        }

        private void Start()
        {
            ResetTransform();
        }

        private void FixedUpdate()
        {
            if (Input.GetAxis("Horizontal") > 0.0f || Input.GetAxis("Horizontal") < 0.0f)
            {
                RotationZ -= Input.GetAxis("Horizontal") * HorizontalBias;
            }

            if (Input.GetAxis("Vertical") > 0.0f || Input.GetAxis("Vertical") < 0.0f)
            {
                RotationX += Input.GetAxis("Vertical") * VerticalBias;
            }

            transform.SetPositionAndRotation(transform.position, Quaternion.Euler(RotationX, 0.0f, RotationZ));
            // transform.localRotation = Quaternion.Euler(RotationX, 0.0f, RotationZ);
        }
    }
}