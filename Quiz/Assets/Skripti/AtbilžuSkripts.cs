using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtbilžuSkripts : MonoBehaviour {

	public bool irPareizs = false;	
	public QuizManager quizManager;

	public void Atbilde(){
		
		if (irPareizs) {
			
			quizManager.Pareizs();

		} else {
			
			quizManager.Nepareizs();

		}
	}
}