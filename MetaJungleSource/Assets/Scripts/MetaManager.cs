using Cinemachine;
using Newtonsoft.Json;
using Photon.Pun;
using StarterAssets;
using UnityEngine;

public class MetaManager : MonoBehaviour
{

    public static MetaManager insta;

    public Transform[] playerPoz;
    public CinemachineVirtualCamera playerCam;
    public UICanvasControllerInput uiInput;
    public GameObject myCam;
    public GameObject myPlayer;


    //public static GameObject fightPlayer;
    //public static Photon.Pun.PhotonView fighterView;
    public static bool isFighting = false;
    public static bool isAtttacking = false;
    public static bool isShooting = false;
    public static Photon.Realtime.Player fightReqPlayer;

    public static string _fighterid;

    public static bool inVirtualWorld = false;


    [Header("Common References")]
    public UnityEngine.UI.Button shootingAreaBtn;
    public UnityEngine.UI.Button shootBulletBtn;
    public GameObject ShootArea;
    public TMPro.TMP_Text Text_ShootTimer;
    public TMPro.TMP_Text Text_ShootCounter;
    public GameObject crossHair;


    private void Awake()
    {
        insta = this;
    }

    private void Start()
    {



    }

    public void UpdatePlayerWorldProperties()
    {
        if (SingletonDataManager.myNFTData.Count > 0)
        {
            var hash = PhotonNetwork.LocalPlayer.CustomProperties;
            hash["virtualworld"] = JsonConvert.SerializeObject(SingletonDataManager.myNFTData);
            PhotonNetwork.LocalPlayer.SetCustomProperties(hash);
            Debug.Log("Updated UpdatePlayerWorldProperties");
        }
    }



}


