using UnityEngine;

public class Manager : MonoBehaviour
{
	public static bool isShowVideo;

	public const string url = "https://play.google.com/store/apps/details?id=";

	public bool isEndGame;

	public static Manager Instance
	{
		get;
		private set;
	}

	private void Awake()
	{
		Instance = this;
	}

	private void Start()
	{
		Input.multiTouchEnabled = false;
		AudioListener.volume = PlayerPrefs.GetFloat("Audio");
	}
}
