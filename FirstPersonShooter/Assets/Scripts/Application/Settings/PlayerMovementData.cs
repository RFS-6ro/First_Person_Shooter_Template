using UnityEngine;

namespace Settings
{
    [CreateAssetMenu(fileName = "NewPlayerMovementData", menuName = "Settings/Create Player Movement Data")]
    public class PlayerMovementData : ScriptableObject
    {
        [Header("Movement")]
        public float MovementVelocity = 10f;

        [Header("Interaction")]
        public float ForceLimit = 10f;
    }
}
