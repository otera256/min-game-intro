using UnityEngine;

namespace RollABall
{
    public class Ball : MonoBehaviour
    {
        public void ResetTransform()
        {
            transform
                .SetPositionAndRotation(
                    new Vector3(-4.25f, 15.0f, 15.0f),
                    Quaternion.identity
                );
        }

        private void Start()
        {
            ResetTransform();
        }
    }
}