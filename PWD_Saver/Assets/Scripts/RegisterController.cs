using UnityEngine;
using System.Collections;

public class RegisterController : MonoBehaviour {


	public MainUIController.RegisterWindow registerWindow;

	public void Register() {
		AppController.Instance.currentWindow = AppController.CurrentWindow.RegisterWindow;
		MainUIController.Instance.OnRegisterWindowChoose ();
	}

	public void OnSubmitButtonClick () {

		if ((!CheckForEmptyField(registerWindow.FullName_fld.text)) 
			||(!CheckForEmptyField(registerWindow.UserName_fld.text)) 
			||(!CheckForEmptyField(registerWindow.Password_fld.text))
			||(!CheckForEmptyField(registerWindow.ConfirmPassword_fld.text))) {

			EnablePopUP ("Please fill all input fields");
			return;
		}

		if (!ValidatePasswords (registerWindow.Password_fld.text.ToString (), registerWindow.ConfirmPassword_fld.text.ToString ())) {
			EnablePopUP ("Passwords did not match");
			return;
		}
	}


	private void EnablePopUP (string _msg) {
		MainUIController.Instance.OnPopUPWindowChoose ();
		MainUIController.Instance.popUpWindow.popUpmessage.text = _msg;
	}

	public bool ValidatePasswords (string _pws_01, string _pwd_02) {
		if (_pws_01.Equals (_pwd_02)) {
			return true;
		} else {
			return false;
		}
	}

	private bool CheckForEmptyField (string _inputArea) {
		if (_inputArea.Length == 0) {
			return false;
		} else {
			return true;
		}
	}
}
