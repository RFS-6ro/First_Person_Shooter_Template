using System.Collections.Generic;
using System.Linq;
using Types;
using UnityEngine;

namespace Settings
{
    [CreateAssetMenu(fileName = "NewInventoryData", menuName = "Settings/Create Inventory Data")]
    public class InventoryData : ScriptableObject
    {
        #region Granades
        [System.Serializable]
        public struct GranadeInventoryData
        {
            public GranadeType Type;
            public int Limit;

            public GranadeInventoryData(GranadeType type, int limit)
            {
                Type = type;
                Limit = limit;
            }
        }

        [Header("Granades")]
        [SerializeField] private GranadeInventoryData[] _granades =
        {
            new GranadeInventoryData(GranadeType.Type1, 5),
            new GranadeInventoryData(GranadeType.Type2, 5),
            new GranadeInventoryData(GranadeType.Type3, 5),
        };

        public Dictionary<GranadeType, int> Granades;
        #endregion



        private void OnValidate()
        {
            #region Granades

            if (Granades == null)
            {
                Granades = new Dictionary<GranadeType, int>();
            }

            for (int i = 0; i < _granades.Length; i++)
            {
                Granades.Add(_granades[i].Type, _granades[i].Limit);
            }

            _granades = Granades.Select((data) => new GranadeInventoryData(data.Key, data.Value)).ToArray();

            #endregion
        }
    }
}
