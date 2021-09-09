using UnityEngine;

namespace Settings
{
    [CreateAssetMenu(fileName = "NewInputData", menuName = "Settings/Create Input Data")]
    public class InputData : ScriptableObject
    {
        [Header("Movement")]
        public KeyCode Forward = KeyCode.W;
        public KeyCode Back = KeyCode.S;
        public KeyCode Left = KeyCode.A;
        public KeyCode Right = KeyCode.D;

        [Header("Weapon")]
        public KeyCode Shoot = KeyCode.Mouse0;

        [Header("Active Item Switching")]
        public KeyCode NextItem = KeyCode.RightArrow;
        public KeyCode PreviousItem = KeyCode.LeftArrow;
    }
}
