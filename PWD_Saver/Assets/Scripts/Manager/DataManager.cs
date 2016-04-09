using System.Collections;
public class DataManager {

	private static DataManager _instance;
	public static DataManager GetInstance () {

		if (_instance == null) {
			_instance = new DataManager ();
		}
		return _instance;
	}

	public string UserName;
	public string Password;

}
