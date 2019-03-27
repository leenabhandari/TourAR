using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using InfinityEngine.Localization;

//Custom 8
public partial class Wit3D : MonoBehaviour {
    public static string text;
	public Text myHandleTextBox;
	private bool actionFound = false;
    public static String value = "details";
	void Handle (string jsonString) {
		
		if (jsonString != null) {

			RootObject theAction = new RootObject ();
			Newtonsoft.Json.JsonConvert.PopulateObject (jsonString, theAction);
          

            if (theAction.entities.section != null) {
				foreach (Section aPart in theAction.entities.section) {
					Debug.Log (aPart.value);
					//myHandleTextBox.text = aPart.value + "\nScan a marker near you";
                    text = myHandleTextBox.text;
                    value = aPart.value;
                    //ArrowController.instance.triggerAnimation("moveRight");
                    if(value=="details")
                    {
                        myHandleTextBox.text = "The Taj Mahal , meaning Crown of the Palaces is an ivory-white marble mausoleum on the south bank of the Yamuna river in the Indian city of Agra. It was commissioned in 1632 by the Mughal emperor, Shah Jahan (reigned from 1628 to 1658), to house the tomb of his favourite wife, Mumtaz Mahal. It also houses the tomb of Shah Jahan, the builder. The tomb is the centerpiece of a 17-hectare (42-acre) complex, which includes a mosque and a guest house, and is set in formal gardens bounded on three sides by a crenellated wall. Do you want to know anything else?";
                        SpeechEngine.Speak(myHandleTextBox.text);

                    }
                    if(value=="time")
                    {
                        myHandleTextBox.text = "The grounds are open from 06:00 to 19:00 weekdays, except for Friday when the complex is open for prayers at the mosque between 12:00 and 14:00. The complex is open for night viewing on the day of the full moon and two days before and after, excluding Fridays and the month of Ramadan. Most tourists visit in the cooler months of October, November and February. Can I help you with anything else?";
                        SpeechEngine.Speak(myHandleTextBox.text);
                    }

                    if(value=="cost")
                    {
                        myHandleTextBox.text = "The fee for Indian citizens was 50 INR, for foreign tourists 1,100 INR. Is there anything else I can help you with?";
                        SpeechEngine.Speak(myHandleTextBox.text);
                    }
                    actionFound = true;
				}
			}
		

			if (!actionFound) {
				myHandleTextBox.text = "Request unknown, please ask a different way.";
                SpeechEngine.Speak(myHandleTextBox.text);
                text = myHandleTextBox.text;
			} else {
                actionFound = false;
			}

 		}//END OF IF

 	}//END OF HANDLE VOID

}//END OF CLASS
	

//Custom 9

public class Section {
	public bool suggested { get; set; }
	public double confidence { get; set; }
	public string value { get; set; }
	public string type { get; set; }
}

public class Entities {

    public List<Section> section{ get; set; }
}

public class RootObject {
	public string _text { get; set; }
	public Entities entities { get; set; }
	public string msg_id { get; set; }
}