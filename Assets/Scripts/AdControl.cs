using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class AdControl : MonoBehaviour
{
    string gameId = "3084083";
    bool testMode = false;
    public string placementId = "video";
    // Start is called before the first frame update
    void Start()
    {
        Monetization.Initialize(gameId, testMode);
    }

    // Update is called once per frame
    public void ShowAd()
    {
        StartCoroutine(ShowAdWhenReady());
    }

    private IEnumerator ShowAdWhenReady()
    {
        while (!Monetization.IsReady(placementId))
        {
            yield return new WaitForSeconds(0.25f);
        }

        ShowAdPlacementContent ad = null;
        ad = Monetization.GetPlacementContent(placementId) as ShowAdPlacementContent;

        if (ad != null)
        {
            ad.Show();
        }
    }
}

