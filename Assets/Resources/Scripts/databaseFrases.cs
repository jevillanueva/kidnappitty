using UnityEngine;
using System.Collections;

public class databaseFrases {
	public static string[] frases;
	public static string[] actionQuoutes;
	// Use this for initialization
	public databaseFrases(){
		frases = new string[10];
		frases [0] = "No Recibas Obsequios de Personas Desconocidas";
		frases [1] = "No Descuides Tu Bebida en una Fiesta";
		frases [2] = "Ten cuidado con ofertas de empleo fraudulentas.";
		frases [3] = "4";
		frases [4] = "5";
		frases [5] = "6";
		frases [6] = "7";
		frases [7] = "8";
		frases [8] = "9";
		frases [9] = "10";

		// Action Quotes
		actionQuoutes = new string[10];
		actionQuoutes [0] = "Esquivalos!";
		actionQuoutes [1] = "No lo pierdas de vista!";
		actionQuoutes [2] = "Evita la tentación!";
		actionQuoutes [3] = "4";
		actionQuoutes [4] = "5";
		actionQuoutes [5] = "6";
		actionQuoutes [6] = "7";
		actionQuoutes [7] = "8";
		actionQuoutes [8] = "9";
		actionQuoutes [9] = "10";
	}

	public string getFrase(int i){
		return frases[i];
	}

	public string getQuote(int i){
		return actionQuoutes[i];
	}
}
