using UnityEngine;
using System.Collections;
using JsonFx;
public class AppManager : MonoBehaviour {

	private static AppManager instance;
	private AppController appController;

	public static AppManager GetInstance() {
		return instance;
	}

	void Awake () {
		instance = this;
		appController = GameObject.Find ("AppController").GetComponent<AppController> ();
	}

	void Start () {
		if (appController.isReset) {
			PlayerPrefs.DeleteAll ();
		}
		Init ();
	}

	private void Init() {
		if (isUsingFirstTime()) {
			appController.Register ();
		} else {
			//Get the data
		}
	}

	string saved = "Save_01";
	private bool isUsingFirstTime () {
		if (PlayerPrefs.HasKey (saved)) {
			return false;
		} else {
			return true;
		}
	}
}
