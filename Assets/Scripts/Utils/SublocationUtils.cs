﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using QuickGraph;
using QuickGraph.Algorithms;

public class SublocationUtils {
	
	private class SublocationGraph : AdjacencyGraph<String, Edge<String>> {}

	private static List<string> SUBLOCATIONS = new List<string> {
		"Basement",
		"Corridor",
		"DiningRoom",
		"Kitchen",
		"Library",
		"LightRoom",
		"LivingRoom",
		"Lobby",
		"SportsBar",
		"RoomInside",
		"TestRoom"
	};

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

	private static SublocationGraph SUBLOCATION_GRAPH = new SublocationGraph();

	static SublocationUtils() {
		for (int roomIndex = 1; roomIndex <= 10; roomIndex++) {
			SUBLOCATION_TO_SCENE.Add(String.Format("RoomOutside{0}", roomIndex), "RoomOutside");
		}

		for (int i = 0; i < SUBLOCATIONS.Count; i++) {
			if (SUBLOCATIONS[i].Equals("Lobby")) {
				continue;
			}
			
			SUBLOCATION_GRAPH.AddVerticesAndEdge (new Edge<String> ("Lobby", SUBLOCATIONS[i]));
			SUBLOCATION_GRAPH.AddVerticesAndEdge (new Edge<String> (SUBLOCATIONS[i], "Lobby"));
        }

		SUBLOCATION_GRAPH.AddVerticesAndEdge (new Edge<String> ("TestRoom", "RoomInside"));
		SUBLOCATION_GRAPH.AddVerticesAndEdge (new Edge<String> ("RoomInside", "TestRoom"));
	}

	static public String SceneName(string sublocationName) {
		return SublocationUtils.SUBLOCATION_TO_SCENE[sublocationName];
	}

	static public String RandomSublocation() {
		return SUBLOCATIONS[UnityEngine.Random.Range (0, SUBLOCATIONS.Count)];
	}
	
	static public String GetNextSublocationInRoute(String sublocationFrom, String sublocationTo) {
		Func<Edge<String>, double> edgeCost = e => 1;
		
		var tryFunc = SUBLOCATION_GRAPH.ShortestPathsDijkstra (edgeCost, sublocationFrom);
		
		IEnumerable<Edge<String>> path;
		
		if (tryFunc(sublocationTo, out path)) {
			var enumerator = path.GetEnumerator();

			if (enumerator.MoveNext()) {
				return enumerator.Current.Target;
			} else {
				return null;
			}
        } else {
            return null;
		}
	}
}
