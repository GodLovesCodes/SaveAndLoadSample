using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _uiText;
    [SerializeField]
    private PlayerData _playerData;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetString("jsondata", JsonUtility.ToJson(_playerData));
            _uiText.text = $"Save successfully";
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            _playerData = JsonUtility.FromJson<PlayerData>(PlayerPrefs.GetString("jsondata"));
            _uiText.text = $"Load successfully";
        }
    }

    [System.Serializable]
    public class PlayerData
    {
        public string name;
        public int level;
    }
}