using UnityEngine;
using UnityEngine.Events;

namespace RollABall
{
    public class Goal : MonoBehaviour
    {
        [SerializeField] private UnityEvent onGameClear = default;
        private UnityEvent OnGameClear => onGameClear;

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.GetComponent<Ball>() != default)
            {
                OnGameClear.Invoke();
            }
        }
    }
}