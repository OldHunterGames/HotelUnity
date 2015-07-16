using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class LocationUtils {

	private static Dictionary<string, string> LOCATION_TO_SCENE = new Dictionary<string, string> {
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
	};

	static LocationUtils() {
		for (int roomIndex = 1; roomIndex <= 10; roomIndex++) {
			LOCATION_TO_SCENE.Add(String.Format("RoomOutside{0}", roomIndex), "RoomOutside");
		}
	}

	static public String SceneName(string locationName) {
		return LocationUtils.LOCATION_TO_SCENE[locationName];
	}
}
