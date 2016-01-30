using UnityEngine;
using System.Collections;

public class Hash : MonoBehaviour {

	public enum LocationNames { Sala, Cocina, Dormitorio, Baño, Patio, InterUp, InterDown }; 

	public static class Tags
	{
		public static string Player = "Player";
	}

	public static class Layer
	{
		public static string Player = "VisionCone";
	}


}
