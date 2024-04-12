using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class SetPlayer : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    [SerializeField] GameObject player;
    [SerializeField] List<CharacterSO> characters = new List<CharacterSO>();
    void Start()
    {
        player = Instantiate(_prefab);
        player.transform.position = Vector3.zero;
        virtualCamera.Follow = player.transform;

        int selected = PlayerPrefs.GetInt("CharacterSelect", 0);
        player.GetComponent<SetEntitySO>().SetEntity = characters[selected];
    }
}
