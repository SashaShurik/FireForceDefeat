using System;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorldTime{
    public class WorldTimeDisplay : MonoBehaviour
    {
        [SerializeField] private WorldTime _worldTime;

        private TMP_Text _text;

        private void Awake() {
            _text = GetComponent<TMP_Text>();
            _worldTime.WorldTimeChanged += OnWorldTimeChanged;
        }

        private void OnDestroy() {
            _worldTime.WorldTimeChanged -= OnWorldTimeChanged;
        }

        private void OnWorldTimeChanged(object sender, TimeSpan newTime){
            _text.SetText(newTime.ToString(@"hh\:mm"));
        }
    }
}