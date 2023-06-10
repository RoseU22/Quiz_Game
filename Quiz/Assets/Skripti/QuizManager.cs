using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour {

	public List<JautajumiUnAtbildes> JuA;
	public List<string> Jautajumi = new List<string>(10); 

	public AtbilžuSkripts Atbilde;

	public GameObject[] opcijas;
	public GameObject QuizPanel;
	public GameObject GOPanel;

	public Text RezultatuTeksts;
    public Text JautajumuTeksts;
	public Text AtbilzuTeksts;

    public int pasreizejaisJautajums;
	public static int JautajumuSkaits = 0;

	int MaksimalieJautajumi = 0;
	public int Rezultats = 0;

	private void Start(){
		MaksimalieJautajumi = JuA.Count;
		GOPanel.SetActive (false);
		GeneretJautajumu ();
	}

	public void Atgriezties(){
		SceneManager.LoadScene ("SakumaEkrans", LoadSceneMode.Single);
	}

	public void SpelesBeigas(){
		QuizPanel.SetActive (false);
		GOPanel.SetActive (true);
		RezultatuTeksts.text = "Pareizi atbildéti jautájumi: " + Rezultats + "/"+ MaksimalieJautajumi;
	}

	public void Pareizs(){
		
		Rezultats += 1;
		JuA.RemoveAt(pasreizejaisJautajums);

		JautajumuSkaits++;
		Debug.Log("Atbildētie Jautājumi: " + JautajumuSkaits);

		GeneretJautajumu();
	}

	public void Nepareizs(){
		
		JautajumuSkaits++;
		Debug.Log("Atbildētie Jautājumi: " + JautajumuSkaits);

		JuA.RemoveAt(pasreizejaisJautajums);
		GeneretJautajumu ();
	}

	void SetAtbildes(){
		for(int i = 0; i < opcijas.Length; i++){
			
			opcijas [i].GetComponent<AtbilžuSkripts> ().irPareizs = false;
			opcijas[i].transform.GetChild(0).GetComponent<Text>().text = JuA[pasreizejaisJautajums].Atbildes[i];

			if (JuA [pasreizejaisJautajums].PareizaAtbilde == i + 1) {	
				opcijas [i].GetComponent<AtbilžuSkripts> ().irPareizs = true;
				AtbilzuTeksts.text += JuA [pasreizejaisJautajums].Jautajums+" - Pareizá atbilde bija: ''"+JuA[pasreizejaisJautajums].Atbildes[i]+"''\n";
			}
		}
	}

	void GeneretJautajumu(){

		if (JuA.Count > 0) {
			pasreizejaisJautajums = Random.Range (0, JuA.Count);

			JautajumuTeksts.text = JuA [pasreizejaisJautajums].Jautajums;
			SetAtbildes ();

		} else {
			Debug.Log ("Vairák jautájuma nav!");
			SpelesBeigas ();
		}
	}
}
