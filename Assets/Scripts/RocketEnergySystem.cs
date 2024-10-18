using UnityEngine;
using UnityEngine.UI;

public class RocketEnergySystem : MonoBehaviour {
    [SerializeField] Image fillAmountImage;

    private Rocket rocket;

    private void Awake () {
        rocket = GetComponent<Rocket>();    
    }

    private void Update () {
        fillAmountImage.fillAmount = rocket.Fuel / 100f;
    }
}
