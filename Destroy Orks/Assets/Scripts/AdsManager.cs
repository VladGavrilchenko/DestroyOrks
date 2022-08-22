using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsListener
{
    [SerializeField] private bool testMode = true;
    private Bank bank;
    public static AdsManager Instance;
 

#if UNITY_ANDROID
    private string gameId = "4895233";
#elif UNITY_IOS
     private string gameId = "4895232";
#endif

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            Advertisement.AddListener(this);
            Advertisement.Initialize(gameId, testMode);
        }
    }

    public void ShowAd(Bank bank)
    {
        this.bank = bank;
        bank.AddMoney(10);
        Advertisement.Show("rewardedTest");
    }

    public void OnUnityAdsReady(string placementId)
    {
        Debug.Log("Ad Ready");
    }

    public void OnUnityAdsDidError(string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        Debug.Log("Ad Started");
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        switch (showResult)
        {
            case ShowResult.Finished:
               
                break;
            case ShowResult.Skipped:
                
                break;
            case ShowResult.Failed:
                Debug.Log(showResult.ToString());
                break;
        }
    }

}