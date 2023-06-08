using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour {

	public List<JautajumiUnAtbildes> JuA;
	public GameObject[] opcijas;
	public int pasreizejaisJautajums;

	public Text JautajumuTeksts;

	private void Start(){
		GeneretJautajumu ();
	}

	public void Pareizs(){
		JuA.RemoveAt(pasreizejaisJautajums);
		GeneretJautajumu();
	}

	void SetAtbildes(){
		for(int i = 0; i < opcijas.Length; i++){
			
			opcijas [i].GetComponent<AtbilžuSkripts> ().irPareizs = false;
			opcijas[i].transform.GetChild(0).GetComponent<Text>().text = JuA[pasreizejaisJautajums].Atbildes[i]; 

			if (JuA [pasreizejaisJautajums].PareizaAtbilde == i + 1) {
				opcijas [i].GetComponent<AtbilžuSkripts> ().irPareizs = true;
			}
		}
	}

	void GeneretJautajumu(){
		
		pasreizejaisJautajums = Random.Range (0, JuA.Count);

		JautajumuTeksts.text = JuA[pasreizejaisJautajums].Jautajums;
		SetAtbildes();
	}
}
