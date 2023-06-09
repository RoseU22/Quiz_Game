using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour {

	public List<JautajumiUnAtbildes> JuA;
	public GameObject[] opcijas;
	public GameObject[] Pogas;

	//public AinuParsledzejs ParslegtAinu;
    public Text JautajumuTeksts;

    public int pasreizejaisJautajums;
	public static int JautajumuSkaits = 0;

	private void Start(){
		GeneretJautajumu ();
	}

	public void Pareizs(){
		JuA.RemoveAt(pasreizejaisJautajums);

		JautajumuSkaits++;
		Debug.Log("Atbildētie Jautājumi: " + JautajumuSkaits);

		if (JautajumuSkaits == 10)
		{
			//bool parslegt = true;
			//ParslegtAinu.BeiguEkrans(parslegt);
			Pogas[0].SetActive(false);
            Pogas[1].SetActive(false);
            Pogas[2].SetActive(false);
            Pogas[3].SetActive(false);
            Pogas[4].SetActive(true);

        }
		else
		{
			GeneretJautajumu();
		}
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
