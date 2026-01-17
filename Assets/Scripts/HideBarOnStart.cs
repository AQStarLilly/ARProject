using UnityEngine;

public class HideBarOnStart : MonoBehaviour
{
    [SerializeField] private Canvas ARMagicBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UIButtonHandler.OnUIStartButtonClicked += OnStartButtonClicked;
        UIButtonHandler.OnUIResetButtonClicked += OnResetButtonClicked;
    }

    private void OnResetButtonClicked()
    {
        ARMagicBar.enabled = true;
    }

    private void OnStartButtonClicked()
    {
        ARMagicBar.enabled = false;
    }

}
