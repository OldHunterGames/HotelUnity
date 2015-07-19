using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class SublocationUtils {

	private static Dictionary<string, string> SUBLOCATION_TO_SCENE = new Dictionary<string, string> {
		{"Basement", "Basement"},
		{"Corridor", "Corridor"},
		{"DiningRoom", "DiningRoom"},
		{"Kitchen", "Kitchen"},
		{"Library", "Library"},
		{"LightRoom", "LightRoom"},
		{"LivingRoom", "LivingRoom"},
		{"Lobby", "Lobby"},
		{"SportsBar", "SportsBar"},
		{"RoomInside", "RoomInside"},
		{"TestRoom", "TestRoom"},
	};

	static SublocationUtils() {
		for (int roomIndex = 1; roomIndex <= 10; roomIndex++) {
			SUBLOCATION_TO_SCENE.Add(String.Format("RoomOutside{0}", roomIndex), "RoomOutside");
		}
	}

	static public String SceneName(string sublocationName) {
		return SublocationUtils.SUBLOCATION_TO_SCENE[sublocationName];
	}
}
