using UnityEngine;

public class BearFurChanger : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer _bear;

    [SerializeField] private Material[] _bearFur;
    
    private void Start()
    {
        _bear.material = _bearFur[CharacterPrefs.PlayerBear];
    }
}