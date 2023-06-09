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

    //Párslédz ainu uz beiga ekránu
    public void BeiguEkrans()
    {
        //if(parslegt==true)
         SceneManager.LoadScene("BeiguEkrans", LoadSceneMode.Single); ;
    }

	//Iziet no spéles
	public void IzietNoSpeles(){
		Application.Quit ();
	}
        
}
