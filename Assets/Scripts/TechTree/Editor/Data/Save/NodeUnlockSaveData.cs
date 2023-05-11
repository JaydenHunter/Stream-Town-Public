using UnityEngine;
using Utils;

namespace TechTree.Data.Save
{
	/// <summary>
	/// Holds save data for a node's unlocks.
	/// </summary>
	[System.Serializable]
	public class NodeUnlockSaveData
	{
		[field: SerializeField]
		public TechType TechType { get; set; }
		[field: SerializeField]
		public int IntValue { get; set; }
		[field: SerializeField]
		public float FloatValue { get; set; }
		[field: SerializeField]
		public string StringValue { get; set; }
		[field: SerializeField]
		public object ObjectValue { get; set; }
		[field: SerializeField]
		public char CharValue { get; set; }
		[field: SerializeField]
		public bool BoolValue { get; set; }
		[field: SerializeField]
		public PlayerRole PlayerRole { get; set; }
		[field: SerializeField]
		public BuildingType BuildingType { get; set; }
		[field: SerializeField]
		public StatType StatType { get; set; }
		[field: SerializeField]
		public Resource ResourceType { get; set; }
	}
}