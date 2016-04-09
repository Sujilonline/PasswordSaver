using UnityEngine;
using System.Collections;

public class PopUPController : MonoBehaviour {

	public void OnSingleSetbuttonClick () {

		switch (AppController.Instance.currentWindow) {
		case AppController.CurrentWindow.RegisterWindow:
			MainUIController.Instance.OnRegisterWindowChoose ();
			break;
		}
		
	}

	public void OnDoubleSetButtonClick (int index) {
		
	}

	public void OnTrippleSetButtonClick (int index) {
		
	}
}
