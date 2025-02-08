using UnityEngine;

public class LobbyScene : MonoBehaviour
{
	[SerializeField] private SceneForFade sceneFade;

	// Setting
	[Header("SceneSettings")]
	[SerializeField] private float fadeInTime;
	[SerializeField] private float fadeOutTime;

	private void Start()
	{
		sceneFade.StartFadeIn(fadeInTime);
	}

	public void OnAdventure()
	{

	}

	public void OnQuestView()
	{

	}

	public void OnInventory()
	{

	}

	public void OnBuddySelect()
	{

	}

	public void OnOption()
	{

	}
}
