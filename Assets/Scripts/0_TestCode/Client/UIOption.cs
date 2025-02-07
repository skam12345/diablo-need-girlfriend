using UnityEngine;
using UnityEngine.UI;

public class UIOption : MonoBehaviour
{
	[SerializeField] private GameObject option;

	private float prevSEVolume;
	private float prevBGMVolume;
	private float prevChannalCount;

	private float nowSEVolume;
	private float nowBGMVolume;
	private float nowChannalCount;

	[SerializeField] private Scrollbar seScrollbar;
	[SerializeField] private Scrollbar bgmScrollbar;
	[SerializeField] private Scrollbar channalScrollbar;



	private void OnEnable()
	{
		// 게임 매니저든 생성되면 초기화 필요
		prevSEVolume = seScrollbar.value;
		prevBGMVolume = bgmScrollbar.value;
		prevChannalCount = channalScrollbar.value;

	}

	private void OnDisable()
	{
		seScrollbar.value = prevSEVolume;
		bgmScrollbar.value = prevBGMVolume;
		channalScrollbar.value = prevChannalCount;

		// 사운드 세팅을 이전 사운드 불륨으로
		// SoundManager.Instance.SetSoundEffectVolume(prevSEVolume);
		// SoundManager.Instance.SetBackGroundVolume(prevBGMVolume);
	}

	public void OnOption()
	{

	}

	public void OffOption()
	{
	}

	public void OnSaveButton()
	{
		// SoundManager.Instance.SetSoundEffectVolume(prevSEVolume);
		// SoundManager.Instance.SetBackGroundVolume(prevBGMVolume);
	}

	public void OnCancelButton()
	{
		option.SetActive(false);
	}

	public void OnResetButton()
	{
		
	}

	public void ScrollEventSoundEffect()
	{
		nowSEVolume = seScrollbar.value;
		//Debug.Log(nowSEVolume + "\t" + seScrollbar.value);
	}

	public void ScrollEventBackGroundMusic()
	{
		nowBGMVolume = bgmScrollbar.value;
	}

	public void ScrollEventSoundChannalCount()
	{
		nowChannalCount = channalScrollbar.value;
	}

}