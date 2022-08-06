using UnityEngine;

public class UbhSpaceship : UbhMonoBehaviour
{
	public float _Speed;

	[SerializeField]
	private GameObject _ExplosionPrefab;

	private Animator _Animator;

	private void Start()
	{
		_Animator = GetComponent<Animator>();
	}

	public void Explosion()
	{
		if (_ExplosionPrefab != null)
		{
			Object.Instantiate(_ExplosionPrefab, base.transform.position, base.transform.rotation);
		}
	}

	public Animator GetAnimator()
	{
		return _Animator;
	}
}
