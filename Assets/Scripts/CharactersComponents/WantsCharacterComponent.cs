using UnityEngine;
using System.Collections;

public class WantsCharacterComponent : MonoBehaviour {

	public int Altruism;
	public int Affinity;
	public int Authority;
	public int Hedonism;
	public int Greed;
	public int Communication;
	public int Curiosity;
	public int Order;
	public int Entertainment;
	public int Creativity;
	public int Ambition;

	public WantsCharacterComponent(){
		Altruism = 3;
		Affinity = 3;
		Authority = 3;
		Hedonism = 3;
		Greed = 3;
		Communication = 3;
		Curiosity = 3;
		Order = 3;
		Entertainment = 3;
		Creativity = 3;
		Ambition = 3;
	}

	public WantsCharacterComponent(int al, int af, int au, int he, int gr, int co, 
	                               int cu, int or, int en, int cr, int am){
		Altruism = al;
		Affinity = af;
		Authority = au;
		Hedonism = he;
		Greed = gr;
		Communication = co;
		Curiosity = cu;
		Order = or;
		Entertainment = en;
		Creativity = cr;
		Ambition = am;
	}
}
