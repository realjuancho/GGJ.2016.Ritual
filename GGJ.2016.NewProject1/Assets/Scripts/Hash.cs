using UnityEngine;
using System.Collections;

public class Hash : MonoBehaviour {

	public enum LocationNames { Sala, Cocina, Dormitorio, Baño, Patio, InterUp, InterDown }; 
	public enum ItemTypes { 
			Vacio,
			Vaso,
			Agua,
			Cafetera,
			LlaveDeBano,
			SwitchDeLuz,
			Frasco,
			Ventana,
			Mariposa,
			Balon,
			Cuchillo,
			Vela,
			Chancla,
			CajaCerillos,
			Columpio,
			Bugambilia,
			Gordolobo,
			CanelaLimon,
			PuertaRefri,
			Taza,
			Tetera,
			Albahaca,
			Huevo,
			TV
	   } ;

	public enum ButtonOption { ButtonA, ButtonB, ButtonC, ButtonD } 
	 
	public static class AnimationParameters
	{
		public static string switchMenu = "switchMenu";

		public static string pressStart = "PressStart";
	}

	public static class Tags
	{
		public static string Player = "Player";
	}

	public static class Layer
	{
		public static string Player = "VisionCone";
	}


}
