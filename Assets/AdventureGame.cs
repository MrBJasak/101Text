using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;

    private State state;

    private void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}