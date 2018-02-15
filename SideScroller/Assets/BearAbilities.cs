using UnityEngine;


public class BearAbilities : MonoBehaviour {

	public enum BearType
	{
		Grizzly, Polar, Panda
	}


	[SerializeField, Range(0, 30), Tooltip("Number of Seconds for Cooldown")]private int _coolDown;
	[SerializeField, Range(0, 30), Tooltip("Range of Bear Ability")]private float _abilityRange = 7.5f;

	private float _coolDownTimer;

	[SerializeField] private BearType _bearType;
	
	// Use this for initialization
	void Start ()
	{
		_bearType = (BearType) (CharacterPrefs.PlayerBear);
		_coolDownTimer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (_bearType == BearType.Polar)
		{
			//freeze effect
			if (Input.GetAxis("Power") == 1 && _coolDownTimer <= 0)
			{
				var objects = Physics.OverlapSphere(transform.position, _abilityRange);
				foreach (var obj in objects)
				{
					var enemy = obj.gameObject.GetComponent<EnemyControl>();
					if (enemy != null)
					{
						enemy.Freeze();
					}
				}
				_coolDownTimer = _coolDown;
			}
			//set cooldown timer to cooldown
		}
		else if (_bearType == BearType.Panda)
		{
			//shoots and leaves
			
			//set cooldown timer to cooldown
		}

		if (_coolDownTimer > 0)
		{
			_coolDownTimer -= Time.deltaTime;
		}
		
	}
}
