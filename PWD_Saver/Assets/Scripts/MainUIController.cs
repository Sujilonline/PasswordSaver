using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class MainUIController : MonoBehaviour {

	public static MainUIController Instance;


	[System.Serializable]
	public class RegisterWindow {
		public InputField FullName_fld;
		public InputField UserName_fld;
		public InputField Password_fld;
		public InputField ConfirmPassword_fld;
	}
	[System.Serializable]
	public class PopUPWindow {
		public Text popUpmessage;
		public Button oneButtonSet;
		public List <Button> twoButtonSet;
		public List <Button> threeButtonSet;
	}

	[System.Serializable]
	public class LoginWindow {
		public InputField Email_ID_fld;
		public InputField Password_fld;
		public Toggle isSavedPassword_tgle;
	}

	[System.Serializable]
	public class AppWindow
	{
		public string name;
		public GameObject window;
	}



	public PopUPWindow popUpWindow;
	public LoginWindow loginWindow;

	public List<AppWindow> AppWindows;

	void Awake () {
		Instance = this;
	}

	// Use this for initialization
	void Start () {
//		OnHomeWindowChoose ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPopUPWindowChoose () {
		
		foreach (var apw in AppWindows) {
			if (apw.name.Equals (AppConstants.POPUPWINDOW)) {
				apw.window.SetActive (true);
			}
		}
	}
	public void OnRegisterWindowChoose () {
		SwitchWindows (AppConstants.REGISTERWINDOW);
	}
		
	public void OnHomeWindowChoose () {
		SwitchWindows ("HomeWindow");
	}

	public void OnSavePasswordWindowChoose () {
		SwitchWindows ("PasswordWindow");
	}

	public void OnDateReminderWindowChoose () {
		SwitchWindows ("DateReminderWindow");
	}


	public AppWindow GetAppWindow (string _WindowName) {
		AppWindow appWin = null;
		foreach (var apw in AppWindows) {
			if (apw.name.Equals (_WindowName)) {
				appWin = apw;
			}
		}
		return appWin;
	}

	private void SwitchWindows (string _winName) {
		
		foreach (var apw in AppWindows) {
			if (apw.name.Equals (_winName)) {
				apw.window.SetActive (true);
			} else {
				apw.window.SetActive (false);
			}
		}
	}


}
