using UnityEngine;
using System.Collections;

public class AppController : MonoBehaviour {

	public bool isReset;
	public static AppController Instance;
	public enum CurrentWindow{
		None,
		RegisterWindow,
		LoginWindow
	};

	void Awake () {
		Instance = this;
	}


	public CurrentWindow currentWindow;
	private RegisterController registerController;

	public void Register () {
		registerController = MainUIController.Instance.GetAppWindow (AppConstants.REGISTERWINDOW).window.GetComponent<RegisterController> ();
		registerController.Register ();
	}
}
