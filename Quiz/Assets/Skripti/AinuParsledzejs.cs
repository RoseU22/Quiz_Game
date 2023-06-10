using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AinuParsledzejs : MonoBehaviour {

    //Párslédz ainu uz sákuma ekránu
    public void UzSakumaEkranu()
    {
        SceneManager.LoadScene("SakumaEkrans", LoadSceneMode.Single);
    }

    //Parslédz ainu uz galveno quiz
    public void UzQuizAinu()
    {
        SceneManager.LoadScene("Quiz", LoadSceneMode.Single);
    }

    //Atsákt testu no jauna
    public void AtsaktTestu()
    {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
    }

	//Iziet no spéles
	public void IzietNoSpeles(){
		Application.Quit ();
	}
        
}
