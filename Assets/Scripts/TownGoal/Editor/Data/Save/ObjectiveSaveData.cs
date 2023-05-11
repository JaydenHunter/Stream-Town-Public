using TownGoal.Enumerations;
using UnityEngine;
using Utils;

namespace TownGoal.Data.Save 
{
	[System.Serializable]
    public class ObjectiveSaveData 
	{
		[field: SerializeField]
		public ObjectiveType ObjectiveType { get; set; }
		[field: SerializeField]
		public int IntValue { get; set; }
		[field: SerializeField]
		public float FloatValue { get; set; }
		[field: SerializeField]
		public BuildingType BuildingType { get; set; }
		[field: SerializeField]
		public Resource ResourceType { get; set; }
		[field: SerializeField]
		public EnemyType EnemyType { get; set; }
	}
}