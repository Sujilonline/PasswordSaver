using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class MainUIController : MonoBehaviour {
	
	[System.Serializable]
	public class LoginWindow {
		public InputField Email_ID_fld;
		public InputField Password_fld;
		public Toggle isSavedPassword_tgle;
	}
	[System.Serializable]
	public class RegisterWindow {
		public InputField Email_ID_fld;
		public InputField Password_fld;
		public InputField ConfirmPassword_fld;
	}

	[System.Serializable]
	public class AppWindow
	{
		public string name;
		public GameObject window;
	}


	public LoginWindow loginWindow;

	public List<AppWindow> AppWindows;

	// Use this for initialization
	void Start () {
		OnHomeWindowChoose ();
	}
	
	// Update is called once per frame
	void Update () {
	
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
