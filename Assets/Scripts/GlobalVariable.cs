using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinerClass
{
    public int m_home;
    public int m_position;
    public int m_depth;
    public double m_cost;
    public float m_basProfit;
    public int m_time;
    public int m_posHome;
    
    public MinerClass(int _home, int _position, int _depth, double _cost,int _time, int _posHome)
    {
        m_home = _home;
        m_position = _position;
        m_depth = _depth;
        m_cost = _cost;
        m_basProfit = 1.09f;
        m_time = _time;
        m_posHome = _posHome;
    }
    ~MinerClass()
    { }
}

public class PanelDic
{
    string name;
    GameObject obj;

    public PanelDic(string _name, GameObject _obj)
    {
        name = _name;
        obj = _obj;
    }
    ~PanelDic() { }
    public string GetName()
    {
        return name;
    }
    public GameObject GetObj()
    {
        return obj;
    }
};
public class PanelPopUpDic
{
    string name;
    GameObject obj;

    public PanelPopUpDic(string _name, GameObject _obj)
    {
        name = _name;
        obj = _obj;
    }
    ~PanelPopUpDic() { }
    public string GetName()
    {
        return name;
    }
    public GameObject GetObj()
    {
        return obj;
    }
};

public class SupporterClass
{
    public int m_Pos;
    //1 채굴량 2 채굴스피드 3 드릴파워 4 판매량
    public int m_Bufftype;
    public float m_BuffPower;

    //1 채굴량 2 채굴스피드 3 드릴파워 4 판매량
    public SupporterClass(int _pos,int _bufftype, float _buffpower)
    {
        m_Pos = _pos;
        m_Bufftype = _bufftype;
        m_BuffPower = _buffpower;
    }
    ~SupporterClass()
    { }
}

public class GlobalVariable : MonoBehaviour {

    private static GlobalVariable _instance = null;

    public static GlobalVariable Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("cSingleton == null");
            return _instance;
        }
    }
    ~GlobalVariable() { }

    public class recipes
    {

        public int[] Mineral1 = new int[2];
        public int[] Mineral2 = new int[2];

        public recipes(int[] _min1, int[] _min2)
        {
            Mineral1 = _min1;
            Mineral2 = _min2;
        }
    }
    public int isDrStart = 0;
    public bool bPlacementMiner = false;
    public int isKingGameStart = 0;
    public bool bStartKingGame = false;
    public float NowMineralEnergy = 0;
    public float KingDps = 0;
    public float kingBuffPower= 0;
    public float kingBuffSpeed = 0;
    public List<float> KingMIneralsEnergy = new List<float>();

    public int RewardKingMineralsChip1 = 0;
    public int RewardKingMineralsChip2 = 0;
    public int RewardKingMineralsHoitstone = 0;
    
    public int KingMineralsStage = -1;
    public int KingMineralStageNormal = 1;
    public int KingMineralStageDesert = 1;
    public int KingMineralStageIce = 1;
    public int KingMineralStageForest = 1;
    public int[] KingMineralMiners = new int[6];
    public List<int> RobotNormal = new List<int>();
    public List<int> RobotDesert = new List<int>();
    public List<int> RobotIce = new List<int>();
    public List<int> RobotForest = new List<int>();

    public int Semiconductor1;
    public int Semiconductor2;
    public int Semiconductor3;
    public int Semiconductor4;

    public int bReview = 0;
    public bool bPlacementTutorial = false;
    public int iAdsDailyCount;    
    public int iAdDrillBuffTime = 3600;
    public int iAdSaleBuffTime = 3600;
    public List<int> MainTutorialList = new List<int>();
    public int ClickCount = 0;
    public bool bStartGold = true;
    public int MiningPotionTime = 300;
    public int MiningPotionDoubleTime = 300;

    public int DrillPotionTime = 300;
    public int DrillPotionDoubleTime = 300;

    public int SalePotionTime = 300;
    public int SalePotionDoubleTime = 300;

    public int ZzangPotionTime = 300;
    public int ZzangPotionDoubleTime = 300;

    public int SkillPotionTime = 300;
    public int SkillPotionDoubleTime = 300;

    public int AutoSalePotionTime = 600;
    public int AutoSalePotionDoubleTime = 3600;

    public int TotalAdsRandomMiner1 = 0;
    public int TotalBuyRandomMiner1 = 0;
    public int isBuyCostPack = 0;
    public int isMiddelSpecialPack = 0;
    public int isHighSpecialPack = 0;
    public int isSperHighSpecialPack = 0;
    public int isStaterPack = 0;
    public int isMinerPack1 = 0;
    public int isMinerPack2 = 0;
    public int isMinerPack3 = 0;

    public int isCoinPack1 = 0;
    public int isCoinPack2 = 0;

    
    public bool bStartMiniQuest = false;
    public List<float> MiniQuestIndex = new List<float>();
    public int CraftAdsCoolTimeCount = 0;
    public int CrafttAdsCount = 0;

    public int CraftAdsCoolTimeCountDesert = 0;
    public int CrafttAdsCountDesert = 0;

    public int CraftAdsCoolTimeCountIce = 0;
    public int CrafttAdsCountIce = 0;

    public int CraftAdsCoolTimeCountForest = 0;
    public int CrafttAdsCountForest = 0;

    public int DynamiteAdsCoolTimeCount = 0;
    public int DynamiteAdsCount = 0;

    public int DynamiteAdsCoolTimeCountDesert = 0;
    public int DynamiteAdsCountDesert = 0;

    public int DynamiteAdsCoolTimeCountIce = 0;
    public int DynamiteAdsCountIce = 0;

    public int DynamiteAdsCoolTimeCountForest = 0;
    public int DynamiteAdsCountForest = 0;

    

    public int iSelectAdsBox =-1;
    public bool bUpgrade = false;
    public List<PanelDic> listPanelDic = new List<PanelDic>();
    public List<PanelPopUpDic> listPanelPopupDic = new List<PanelPopUpDic>();
    public bool bGetKeydwon =false;
    public int DayRewardTime = 0;
    public int DayRewardNext = 0;
    public List<int> ListDayRewardCount = new List<int>();
    public List<int> UniqueMinerList = new List<int>();
    public List<string> UniqueMinerBuffTypeList = new List<string>();
    public int rewardHoitStone;
    public double UpgradeCost;

    public recipes[] recipe = new recipes[] { new recipes( new int[] {1 ,940}, new int[] { 0, 0 }),
                                              new recipes( new int[] {1,500}, new int[] { 2, 100 }),
                                              new recipes( new int[] {3,10}, new int[] { 0, 0 }),

                                              new recipes( new int[] {3,1000}, new int[] { 4, 300 }),
                                              new recipes( new int[] {3,700}, new int[] { 5, 400 }),
                                              new recipes( new int[] {4,40}, new int[] { 5, 2 }),

                                              new recipes( new int[] {1,5000}, new int[] { 3, 2000 }),
                                              new recipes( new int[] {4,500}, new int[] { 5, 30}),
                                              new recipes( new int[] {4,500}, new int[] { 5, 200}),

                                              new recipes( new int[] {1,50000}, new int[] { 6, 12000}),
                                              new recipes( new int[] {4,10000}, new int[] { 5, 3000}),
                                              new recipes( new int[] {4,5000}, new int[] { 6, 200}),

                                              new recipes( new int[] {1,200000}, new int[] { 0, 0}),
                                              new recipes( new int[] {6,100000}, new int[] { 0, 0}),
                                              new recipes( new int[] {7,50000}, new int[] { 0, 0}),

                                              new recipes( new int[] {3,600000}, new int[] { 0, 0}),
                                              new recipes( new int[] {7,500000}, new int[] { 0, 0}),
                                              new recipes( new int[] {8,2000}, new int[] { 0, 0}),

                                              new recipes( new int[] {3,1000000}, new int[] { 0, 0}),
                                              new recipes( new int[] {8,100000}, new int[] { 0, 0}),
                                              new recipes( new int[] {10,500}, new int[] { 0, 0}),

                                              new recipes( new int[] {6,5000}, new int[] { 8, 3000}),
                                              new recipes( new int[] {6,3000000}, new int[] { 0, 0}),
                                              new recipes( new int[] {11,10000}, new int[] { 0, 0}),

                                              new recipes( new int[] {11,100000}, new int[] { 0, 0}),
                                              new recipes( new int[] {11,1000000}, new int[] { 0, 0}),
                                              new recipes( new int[] {12,10000}, new int[] { 0, 0}),

                                              new recipes( new int[] {13,100000}, new int[] { 0, 0}),
                                              new recipes( new int[] {12,40000}, new int[] { 0, 0}),
                                              new recipes( new int[] {13,100000}, new int[] { 14, 1000}),

                                              new recipes( new int[] {14,200000}, new int[] { 0, 0}),
                                              new recipes( new int[] {14,100000}, new int[] { 0, 0}),
                                              new recipes( new int[] {14,100000}, new int[] { 0, 0}),

                                              new recipes( new int[] {15,2000000}, new int[] { 16, 200000}),
                                              new recipes( new int[] {16,1000000}, new int[] { 17, 200000}),
                                              new recipes( new int[] {17,1000000}, new int[] { 0, 0}),

                                              new recipes( new int[] {17,1000000}, new int[] { 0, 0}),
                                              new recipes( new int[] {17,1000000}, new int[] { 18, 5000000}),
                                              new recipes( new int[] {17,1000000}, new int[] { 18, 5000000}),

                                              new recipes( new int[] {10,1000000}, new int[] { 18, 5000000}),
                                              new recipes( new int[] {16,1000000}, new int[] { 18, 5000000}),
                                              new recipes( new int[] { 18,10000000}, new int[] { 18,0 }),

                                              new recipes( new int[] {0,0}, new int[] { 0, 0}),
                                              new recipes( new int[] {0,0}, new int[] { 0, 0}),
                                              new recipes( new int[] {18,10000000}, new int[] { 0, 0}),

                                              new recipes( new int[] {0,0}, new int[] { 0, 0}),
                                              new recipes( new int[] {0,0}, new int[] { 0, 0}),
                                              new recipes( new int[] {18,100000000}, new int[] { 0, 0}),

                                              new recipes( new int[] {0,0}, new int[] { 0, 0}),
                                              new recipes( new int[] {0,0}, new int[] { 0, 0}),
                                              new recipes( new int[] { 18, 100000000}, new int[] {0 , 0}),
    };
    public GameObject MainStausCanvas;
    public int SelectRobotIndex = 0;
    public List<int> MiningType = new List<int>();
    public List<int> BuffType = new List<int>();
    public List<float> BuffPower = new List<float>();
    public List<float> DefaultBuffPower = new List<float>();
    public int TutorialCount = 0;
    public string CombiPopupName = string.Empty;
    public int rewardBoxTotalCount = 0;
    public int iSelectDialogue = -1;
    public float scaleFactor = 0.000000000000000001f;
    public int iSelectEventRewardMiner = -1;
    public string strGetSomething = string.Empty;
    public int DesertKey =0;
    public int IceKey =0 ;
    public int ForestKey =0;
    public bool isFirstDialogue = false;
    void Awake()
    {

        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        //int width = Screen.width;
        //int height = Screen.height;
        //Screen.SetResolution(width, height, true);
        Screen.SetResolution(900, 1600, true);
        //Application.targetFrameRate = 30;
        //DontDestroyOnLoad(this);
        MiningPotionTime = 300;
        MiningPotionDoubleTime = 300;

        DrillPotionTime = 300;
        DrillPotionDoubleTime = 300;

        SalePotionTime = 300;
        SalePotionDoubleTime = 300;

        ZzangPotionTime = 300;
        ZzangPotionDoubleTime = 300;

        SkillPotionTime = 300;
        SkillPotionDoubleTime = 300;

        AutoSalePotionTime = 600;
        AutoSalePotionDoubleTime = 3600;
        iAdDrillBuffTime = 3600;
        iAdSaleBuffTime = 3600;

        _instance = this;

        ListCraftTime.Add(15);
        ListCraftTime.Add(60);
        ListCraftTime.Add(180);
        ListCraftTime.Add(300);
        ListCraftTime.Add(600);
        ListCraftTime.Add(1200);
        ListCraftTime.Add(1800);
        ListCraftTime.Add(2700);
        ListCraftTime.Add(3600);
        ListCraftTime.Add(7200);
        ListCraftTime.Add(10800);
        ListCraftTime.Add(21600);
        ListCraftTime.Add(32400);
        ListCraftTime.Add(43200);
        ListCraftTime.Add(43200);
        ListCraftTime.Add(43200);
        ListCraftTime.Add(43200);
        ListCraftTime.Add(43200);
        ListCraftTime.Add(43200);

        

        for (int i = 0; i < 200; i++)
        {
            RobotNormal.Add(0);
            RobotDesert.Add(0);
            RobotIce.Add(0);
            RobotForest.Add(0);
        }

   
        //퀘스트 갯수 !!
        for (int i=0; i<= 28; i++)
        {
            MiniQuestIndex.Add(0);
        }
        for(int i=0; i< 9;i++)
        {
            MainTutorialList.Add(0);
        }
        for (int i = 0; i < 110; i++)
        {
            ListHireCount.Add(0);

            ListHireDesertCount.Add(0);
            ListHireIceCount.Add(0);
            ListHireForestCount.Add(0);

            ListHireCardBuyCount.Add(0);
            ListHireLevel.Add(1);
            ListHireCardOwnCount.Add(0);
            ListbStartMineralAnim.Add(false);

            MinerSkillIndex.Add(0);
        }
   
        for(int i=0; i< 6; i++)
        {
            KingMineralMiners[i] = 0;
        }
        for(int i=0; i< 20; i++)
        {
            ListDayRewardCount.Add(0);
        }
        for(int i=0; i< 33; i++)
        {
            CombinationStatus.Add(0);
            CombinationStatusPos.Add(0);

            CombinationStatusNormal.Add(0);
            CombinationStatusPosNormal.Add(0);

            CombinationStatusDesert.Add(0);
            CombinationStatusPosDesert.Add(0);

            CombinationStatusIce.Add(0);
            CombinationStatusPosIce.Add(0);

            CombinationStatusForest.Add(0);
            CombinationStatusPosForest.Add(0);

            CollectionStatus.Add(0);

            QuestCompleteIndex.Add(0);
            QuestingCount.Add(0);

        }
        {
            MinerClass m = new MinerClass(1, 1, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 2, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 3, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 58, 1, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 4, 2, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 5, 2, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 6, 2, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 59, 2, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 7, 3, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 8, 3, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 60, 3, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 69, 3, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(2, 70, 4, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 9, 4, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 10, 4, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 61, 4, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 11, 5, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 12, 5, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 71, 5, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(3, 89, 5, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 13, 6, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 14, 6, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 15, 6, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 79, 6, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 16, 7, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 17, 7, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 18, 7, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 72, 7, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 19, 8, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 20, 8, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 21, 8, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 80, 8, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(4, 78, 9, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 22, 9, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 23, 9, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 24, 10, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 25, 10, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 26, 10, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 27, 11, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 28, 11, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 63, 11, 0, 5, 0);
            ListMinerClass.Add(m);



            m = new MinerClass(1, 62, 12, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(3, 91, 12, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 29, 13, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 93, 13, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 30, 14, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 73, 14, 0, 5, 0);
            ListMinerClass.Add(m);



            m = new MinerClass(1, 31, 15, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(3, 92, 15, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 64, 16, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 82, 16, 0, 5, 0);
            ListMinerClass.Add(m);



            m = new MinerClass(1, 32, 17, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 33, 17, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 34, 18, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 81, 18, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 35, 19, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 36, 19, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(2, 74, 20, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 75, 20, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 37, 20, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(3, 90, 21, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 65, 21, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 38, 22, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 39, 22, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 76, 22, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 40, 23, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 84, 23, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 41, 24, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 66, 24, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(3, 94, 24, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 42, 25, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 85, 25, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(2, 43, 26, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 83, 26, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 44, 27, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 77, 27, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(2, 45, 28, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(2, 46, 29, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(2, 47, 30, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(2, 48, 31, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(3, 95, 31, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 67, 32, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(3, 49, 33, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(3, 50, 34, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 86, 34, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(4, 87, 35, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(4, 51, 36, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 68, 37, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(4, 52, 38, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(4, 53, 39, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(4, 88, 40, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 54, 41, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(3, 55, 42, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(3, 96, 43, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 56, 44, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 57, 45, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(-1, 97, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 98, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 99, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 100, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 101, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 102, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 103, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 104, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 105, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 106, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 107, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 108, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 109, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 110, 99999, 0, 5, 0);
            ListMinerClass.Add(m);
        }
        {
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(20); //만수르
            BuffPower.Add(2);
            BuffPower.Add(1.5f);
            BuffPower.Add(1.5f);
            BuffPower.Add(2);
            BuffPower.Add(2.5f);
            BuffPower.Add(5.5f);
            BuffPower.Add(3);
            BuffPower.Add(9);
            BuffPower.Add(9);
            BuffPower.Add(6.5f);
            BuffPower.Add(15.5f);
            BuffPower.Add(2);
            BuffPower.Add(3.5f);
            BuffPower.Add(2);
            BuffPower.Add(2.5f);
            BuffPower.Add(12);
            BuffPower.Add(4);
            BuffPower.Add(4);
            BuffPower.Add(4.5f);
            BuffPower.Add(10.5f);
            BuffPower.Add(4.5f);
            BuffPower.Add(4);
            BuffPower.Add(2);
            BuffPower.Add(7.5f);
            BuffPower.Add(6);
            BuffPower.Add(5.5f);
            BuffPower.Add(4.5f);
            BuffPower.Add(5.5f);
            BuffPower.Add(6.5f);
            BuffPower.Add(6);
            BuffPower.Add(0);
            BuffPower.Add(3.5f);
            BuffPower.Add(7.5f);
            BuffPower.Add(2.5f);
            BuffPower.Add(3);
            BuffPower.Add(5);
            BuffPower.Add(10.5f);
            BuffPower.Add(12.5f);
            BuffPower.Add(7.5f);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(18.5f);
            BuffPower.Add(15);
            BuffPower.Add(0);
            BuffPower.Add(0);
            BuffPower.Add(0);

            //1 Miner // Supporter
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(1);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(1);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(1);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(1);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(0);
            MiningType.Add(0);
            MiningType.Add(1);
            MiningType.Add(1);
            MiningType.Add(1);

            //채굴량		5
            //드릴파워        6
            //채굴스피드       7
            //판매량     8

            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(7); //만수르
            BuffType.Add(5);
            BuffType.Add(6);
            BuffType.Add(7);
            BuffType.Add(6);
            BuffType.Add(6);
            BuffType.Add(5);
            BuffType.Add(7);
            BuffType.Add(5);
            BuffType.Add(8);
            BuffType.Add(6);
            BuffType.Add(1);
            BuffType.Add(8);
            BuffType.Add(5);
            BuffType.Add(7);
            BuffType.Add(1);
            BuffType.Add(8);
            BuffType.Add(6);
            BuffType.Add(7);
            BuffType.Add(6);
            BuffType.Add(8);
            BuffType.Add(8);
            BuffType.Add(5);
            BuffType.Add(7);
            BuffType.Add(5);
            BuffType.Add(8);
            BuffType.Add(7);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(7);
            BuffType.Add(5);
            BuffType.Add(1);
            BuffType.Add(8);
            BuffType.Add(8);
            BuffType.Add(7);
            BuffType.Add(1);
            BuffType.Add(8);
            BuffType.Add(5);
            BuffType.Add(5);
            BuffType.Add(6);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(1);
            BuffType.Add(5);
            BuffType.Add(7);
            BuffType.Add(10);
            BuffType.Add(10);
            BuffType.Add(10);
        }
        {
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(20); //만수르
            DefaultBuffPower.Add(2);
            DefaultBuffPower.Add(1.5f);
            DefaultBuffPower.Add(1.5f);
            DefaultBuffPower.Add(2);
            DefaultBuffPower.Add(2.5f);
            DefaultBuffPower.Add(5.5f);
            DefaultBuffPower.Add(3);
            DefaultBuffPower.Add(9);
            DefaultBuffPower.Add(9);
            DefaultBuffPower.Add(6.5f);
            DefaultBuffPower.Add(15.5f);
            DefaultBuffPower.Add(2);
            DefaultBuffPower.Add(3.5f);
            DefaultBuffPower.Add(2);
            DefaultBuffPower.Add(2.5f);
            DefaultBuffPower.Add(12);
            DefaultBuffPower.Add(4);
            DefaultBuffPower.Add(4);
            DefaultBuffPower.Add(4.5f);
            DefaultBuffPower.Add(10.5f);
            DefaultBuffPower.Add(4.5f);
            DefaultBuffPower.Add(4);
            DefaultBuffPower.Add(2);
            DefaultBuffPower.Add(7.5f);
            DefaultBuffPower.Add(6);
            DefaultBuffPower.Add(5.5f);
            DefaultBuffPower.Add(4.5f);
            DefaultBuffPower.Add(5.5f);
            DefaultBuffPower.Add(6.5f);
            DefaultBuffPower.Add(6);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(3.5f);
            DefaultBuffPower.Add(7.5f);
            DefaultBuffPower.Add(2.5f);
            DefaultBuffPower.Add(3);
            DefaultBuffPower.Add(5);
            DefaultBuffPower.Add(10.5f);
            DefaultBuffPower.Add(12.5f);
            DefaultBuffPower.Add(7.5f);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(18.5f);
            DefaultBuffPower.Add(15);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
            DefaultBuffPower.Add(0);
        }
        KingMineralStageNormal = 1;
        KingMineralStageDesert = 1;
        KingMineralStageIce = 1;
        KingMineralStageForest = 1;
        MiningPotionTotalCount = 0;
        DrillPotionTotalCount = 0;
        SalePotionTotalCount = 0;
        ZzangPotionTotalCount = 0;
        SkillPotionTotalCount = 0;
        AutoSellPotionTotalCount = 0;
        AutoSellDoublePotionTotalCount = 0;

        MiningDoublePotionTotalCount = 0;
        DrillDoublePotionTotalCount = 0;
        SaleDoublePotionTotalCount = 0;
        ZzangDoublePotionTotalCount = 0;
        SkillDoublePotionTotalCount = 0;

        UpgradeTotalCount = 0;
        LottoTotalLoseCount = 0;
        LottoTotalWinCount = 0;
        SadariTotalLoseCount = 0;
        SadariTotalWinCount = 0;
        WinMarkTotal = 0;
        LoseMarkTotal = 0;
        AdsTotalCount = 0;
        isDrillTimeBuff = 0;
        isSaleTimeBuff = 0;
        isOpening = 0;
        DayRewardNext = 0;
        //DayRewardTime = 0;
        isStartTimeDepth = 0;
        isStartTimeDepthDesert = 0;
        isStartTimeDepthForest = 0;
        isStartTimeDepthIce = 0;


        isStartCraftEngineNormal = 0;
        isStartCraftEngineDesert = 0;
        isStartCraftEngineIce = 0;
        isStartCraftEngineForest = 0;


        isStartCraftBitNormal = 0;
        isStartCraftBitDesert = 0;
        isStartCraftBitIce = 0;
        isStartCraftBitForest = 0;

        EventObjectNormal1Status = 0;
        EventObjectNormal2Status = 0;
        EventObjectNormal3Status = 0;
        EventObjectNormal4Status = 0;
        EventObjectNormal5Status = 0;
        EventObjectNormal6Status = 0;
        EventObjectNormal7Status = 0;

        EventObjectDesert1Status= 0;
        EventObjectDesert2Status = 0;
        EventObjectDesert3Status = 0;
        EventObjectDesert4Status = 0;
        EventObjectDesert5Status = 0;
        EventObjectDesert6Status = 0;
        EventObjectDesert7Status = 0;
        EventObjectDesert8Status = 0;
        EventObjectDesert9Status = 0;

        EventObjectIce1Status = 0;
        EventObjectIce2Status = 0;
        EventObjectIce3Status = 0;
        EventObjectIce4Status = 0;
        EventObjectIce5Status = 0;
        EventObjectIce6Status = 0;
        EventObjectIce7Status = 0;

        EventObjectForest1Status= 0;
        EventObjectForest2Status = 0;
        EventObjectForest3Status = 0;
        EventObjectForest4Status = 0;
        EventObjectForest5Status = 0;
        EventObjectForest6Status = 0;
        EventObjectForest7Status = 0;

        CertificateGold = 0;
        CertificateTime = 0;
        IslandForest = 0;
        IslandIce = 0;
        IslandDesert = 0;
        ManagerStatus1 = 0;
        ManagerStatus2 = 0;
        ManagerStatus3 = 0;

        DrillManagerStatus = 0;
        ManagerPackStatus = 0;

        isOnBGM = 1;
        isOnEffectBGM = 1;
        DrillBuffCount = 0;
        SaleBuffCount = 0;

        DrillBuffCountDesert = 0;
        SaleBuffCountDesert = 0;

        DrillBuffCountIce = 0;
        SaleBuffCountIce = 0;

        DrillBuffCountForest = 0;
        SaleBuffCountForest = 0;

        NotConnectedMoney = 0;
        NotConnectedMoneyDesert = 0;
        NotConnectedMoneyIce = 0;
        NotConnectedMoneyForest = 0;

        BoxBuffPower = 0;
        CraftMoneyDiscount = 0;
        HireMoneyDiscount = 0;
        DrillBuffPower = 0;
        SaleBuffPower = 0;
        MiningBuffPower = 0;
        PotionRemainTime = 0;
        IsdynamiteTime = 0;
        dynamiteReTime = 0;
        isDrillPotion = 0;
        isSalePotion = 0;
        isMiningPotion = 0;
        isBuffPotion = 0;
        isZzangPotion = 0;
        isAutoSellPotion = 0;
        isAutoSellPotionDesert = 0;
        isAutoSellPotionIce = 0;
        isAutoSellPotionForest = 0;
        HoitStoneBuffPercent = 0;
        HoitStoneBuffPower = 0;


        isAutoSellDoublePotion = 0;
        isAutoSellDoublePotionDesert = 0;
        isAutoSellDoublePotionIce = 0;
        isAutoSellDoublePotionForest = 0;

        SkillCoolTimePower = 0;
        SkillRemainTimePower = 0;
        CapacityPower = 0;

        ReTimePower = 0;

        isDrillPotionDouble = 0;
        isSalePotionDouble = 0;
        isMiningPotionDouble = 0;
        isBuffPotionDouble = 0;
        isZzangPotionDouble = 0;


        isDrillPotionDesert = 0;
        isSalePotionDesert = 0;
        isMiningPotionDesert = 0;
        isBuffPotionDesert = 0;
        isZzangPotionDesert = 0;

        isDrillPotionDoubleDesert = 0;
        isSalePotionDoubleDesert = 0;
        isMiningPotionDoubleDesert = 0;
        isBuffPotionDoubleDesert = 0;
        isZzangPotionDoubleDesert = 0;


        isDrillPotionIce = 0;
        isSalePotionIce = 0;
        isMiningPotionIce = 0;
        isBuffPotionIce = 0;
        isZzangPotionIce = 0;

        isDrillPotionDoubleIce = 0;
        isSalePotionDoubleIce = 0;
        isMiningPotionDoubleIce = 0;
        isBuffPotionDoubleIce = 0;
        isZzangPotionDoubleIce = 0;

        isDrillPotionForest = 0;
        isSalePotionForest = 0;
        isMiningPotionForest = 0;
        isBuffPotionForest = 0;
        isZzangPotionForest = 0;

        isDrillPotionDoubleForest = 0;
        isSalePotionDoubleForest = 0;
        isMiningPotionDoubleForest = 0;
        isBuffPotionDoubleForest = 0;
        isZzangPotionDoubleForest = 0;

        Init();
        bStart = PlayerPrefs.GetInt("bStart");
        if (bStart > 0)
            LoadData();
        else
        {
            SaveData();
            for (int i = 0; i < 4; i++)
            {
                string SaveName = string.Empty;
                string MapStr = string.Empty;
                switch (i)
                {
                    case 0:
                        MapStr = "Normal";
                        break;
                    case 1:
                        MapStr = "Desert";
                        break;
                    case 2:
                        MapStr = "Ice";
                        break;
                    case 3:
                        MapStr = "Forest";
                        break;
                }
                for (int k = 1; k <= 200; k++)
                {
                    SaveName = MapStr + "SpeacialAblity_Type1" + k;
                    PlayerPrefs.SetInt(SaveName, 0);
                    SaveName = MapStr + "SpeacialAblity_Type2" + k;
                    PlayerPrefs.SetInt(SaveName, 0);
                    SaveName = MapStr + "SpeacialAblity_Type3" + k;
                    PlayerPrefs.SetInt(SaveName, 0);

                    SaveName = MapStr + "iSpeacialAblity1" + k;
                    PlayerPrefs.SetFloat(SaveName, 0);
                    SaveName = MapStr + "iSpeacialAblity1" + k;
                    PlayerPrefs.SetFloat(SaveName, 0);
                    SaveName = MapStr + "iSpeacialAblity1" + k;
                    PlayerPrefs.SetFloat(SaveName, 0);
                }
            }
        }
            

        if(MapType ==1)
        {
            iCapacityIndex = iCapacityNormalIndex;
        }
        if (MapType == 2)
        {
            iCapacityIndex = iCapacityDesertIndex;
        }
        if (MapType == 3)
        {
            iCapacityIndex = iCapacityIceIndex;
        }
        if (MapType == 4)
        {
            iCapacityIndex = iCapacityForestIndex;
        }

        float defaultKingEnergy = 95;
        float scaleKingMinerals = 2.2f;
        for (int i = 1; i <= 220; i++)
        {
            if (i == 1)
            {
                KingMIneralsEnergy.Add(defaultKingEnergy);
            }
            else
            {
                KingMIneralsEnergy.Add(KingMIneralsEnergy[KingMIneralsEnergy.Count - 1] * scaleKingMinerals);
            }
            if (i == 8)
            {
                scaleKingMinerals = 1.28f;
            }
            if (i == 20)
            {
                scaleKingMinerals = 1.1f;
            }
            if (i == 50)
            {
                scaleKingMinerals = 1.1f;
            }
            
        }
    }
    public double rewardMoney =0;
    public double rewardExp = 0;
    public int PakageCardType = 0;
    public string strCharacterSelect = "";
    public bool bClickCard = false;
    public int AdsType = -1;
    public bool bDayRewardBtn = false;
    public float iScrollPos;

    public int selectIAPitem = 0;
    //땅파기 시작한 애들 정보 확인할수 있는 창

    public int EventObjectNormal1Status = 0;
    public int EventObjectNormal2Status = 0;
    public int EventObjectNormal3Status = 0;
    public int EventObjectNormal4Status = 0;
    public int EventObjectNormal5Status = 0;
    public int EventObjectNormal6Status = 0;
    public int EventObjectNormal7Status = 0;


    public int EventObjectDesert1Status = 0;
    public int EventObjectDesert2Status = 0;
    public int EventObjectDesert3Status = 0;
    public int EventObjectDesert4Status = 0;
    public int EventObjectDesert5Status = 0;
    public int EventObjectDesert6Status = 0;
    public int EventObjectDesert7Status = 0;
    public int EventObjectDesert8Status = 0;
    public int EventObjectDesert9Status = 0;

    public int EventObjectIce1Status = 0;
    public int EventObjectIce2Status = 0;
    public int EventObjectIce3Status = 0;
    public int EventObjectIce4Status = 0;
    public int EventObjectIce5Status = 0;
    public int EventObjectIce6Status = 0;
    public int EventObjectIce7Status = 0;

    public int EventObjectForest1Status = 0;
    public int EventObjectForest2Status = 0;
    public int EventObjectForest3Status = 0;
    public int EventObjectForest4Status = 0;
    public int EventObjectForest5Status = 0;
    public int EventObjectForest6Status = 0;
    public int EventObjectForest7Status = 0;


    public List<int> EventDepthNormal = new List<int>();
    public List<int> EventDepthDesert = new List<int>();
    public List<int> EventDepthIce = new List<int>();
    public List<int> EventDepthForest = new List<int>();

    public int isOnBGM = 1;
    public int isOnEffectBGM = 1;
    public int ManagerPackStatus = 0;
    public int DrillManagerStatus = 0;
    public int ManagerStatus1 =0;
    public int ManagerStatus2 = 0;
    public int ManagerStatus3 = 0;

    public int iMinerSelectStatus = -1;
    public GameObject MinerStatusViewObj;
    public GameObject MInerspeechObj;
    public bool bMinerStatus = false;
    public List<GameObject> listMinerStatusRibbon = new List<GameObject>();
    public List<GameObject> listMinerStatusLv = new List<GameObject>();
    public GameObject MinerStatusProgass;
    public GameObject MinerCapacityProgassBack;
    public GameObject MinerCapacityProgass;
    public GameObject MinerCapacityProgassText;
    public GameObject TextBtnMoney;
    public GameObject TextMiningPower;

    public GameObject BtnSell;
    public GameObject BtnBuff;
    public GameObject BtnBuffType0;
    public List<GameObject> listMinerHomeIndex = new List<GameObject>();
    public List<int> listMinerGrade = new List<int>();

    public List<float> eachMiningPower = new List<float>();
    public List<float> eachSellPower= new List<float>();
    public List<float> eachMiningSpeed= new List<float>();


    //메인 변수
    public int IslandDesert = 0;
    public int IslandIce = 0;
    public int IslandForest = 0;
    public int CertificateGold = 0;
    public int CertificateTime = 1;
    public int isStartTimeDepth =0;
    public int isStartTimeDepthDesert = 0;
    public int isStartTimeDepthIce = 0;
    public int isStartTimeDepthForest = 0;

    public int isStartCraftEngineNormal = 0;
    public int isStartCraftEngineDesert = 0;
    public int isStartCraftEngineIce = 0;
    public int isStartCraftEngineForest = 0;


    public int isStartCraftBitNormal = 0;
    public int isStartCraftBitDesert = 0;
    public int isStartCraftBitIce = 0;
    public int isStartCraftBitForest = 0;

    public int CardGetType = 0;

    public float CraftMoneyDiscount = 0;
    public float HireMoneyDiscount = 0;
    public float BoxBuffPower = 0;
    public float dynamiteReTime = 0;
    public int IsdynamiteTime = 0;
    public float PotionRemainTime = 0;
    public float HoitStoneBuffPercent =0;
    public float HoitStoneBuffPower =0;

    public float NotConnectedMoney = 0;
    public float NotConnectedMoneyDesert = 0;
    public float NotConnectedMoneyIce = 0;
    public float NotConnectedMoneyForest = 0;

    public float MiningBuffPower = 0;
    public float DrillBuffPower = 0;
    public float SaleBuffPower = 0;
    public float buffBuffPower = 0;

    public int AutoSellPower = 0;

    public float SkillCoolTimePower = 0;
    public float SkillRemainTimePower = 0;
    public float CapacityPower = 0;

    public float ReTimePower = 0;



    public int MiningPotionTotalCount = 0;
    public int DrillPotionTotalCount = 0;
    public int SalePotionTotalCount = 0;
    public int ZzangPotionTotalCount = 0;
    public int SkillPotionTotalCount = 0;
    public int AutoSellPotionTotalCount = 0;

    public int MiningDoublePotionTotalCount = 0;
    public int DrillDoublePotionTotalCount = 0;
    public int SaleDoublePotionTotalCount = 0;
    public int ZzangDoublePotionTotalCount = 0;
    public int SkillDoublePotionTotalCount = 0;
    public int AutoSellDoublePotionTotalCount = 0;



    public int isDrillPotion = 0;
    public int isSalePotion = 0;
    public int isMiningPotion = 0;
    public int isBuffPotion = 0;
    public int isZzangPotion = 0;
    public int isAutoSellPotion = 0;

    public int isDrillPotionDouble = 0;
    public int isSalePotionDouble = 0;
    public int isMiningPotionDouble = 0;
    public int isBuffPotionDouble = 0;
    public int isZzangPotionDouble = 0;
    public int isAutoSellDoublePotion = 0;

    public int isDrillPotionDesert = 0;
    public int isSalePotionDesert = 0;
    public int isMiningPotionDesert = 0;
    public int isBuffPotionDesert = 0;
    public int isZzangPotionDesert = 0;
    public int isAutoSellPotionDesert = 0;

    public int isDrillPotionDoubleDesert = 0;
    public int isSalePotionDoubleDesert = 0;
    public int isMiningPotionDoubleDesert = 0;
    public int isBuffPotionDoubleDesert = 0;
    public int isZzangPotionDoubleDesert = 0;
    public int isAutoSellDoublePotionDesert = 0;

    public int isDrillPotionIce = 0;
    public int isSalePotionIce = 0;
    public int isMiningPotionIce = 0;
    public int isBuffPotionIce = 0;
    public int isZzangPotionIce = 0;
    public int isAutoSellPotionIce = 0;

    public int isDrillPotionDoubleIce = 0;
    public int isSalePotionDoubleIce = 0;
    public int isMiningPotionDoubleIce = 0;
    public int isBuffPotionDoubleIce = 0;
    public int isZzangPotionDoubleIce = 0;
    public int isAutoSellDoublePotionIce = 0;


    public int isDrillPotionForest = 0;
    public int isSalePotionForest = 0;
    public int isMiningPotionForest = 0;
    public int isBuffPotionForest = 0;
    public int isZzangPotionForest = 0;
    public int isAutoSellPotionForest = 0;

    public int isDrillPotionDoubleForest = 0;
    public int isSalePotionDoubleForest = 0;
    public int isMiningPotionDoubleForest = 0;
    public int isBuffPotionDoubleForest = 0;
    public int isZzangPotionDoubleForest = 0;
    public int isAutoSellDoublePotionForest = 0;


    public int DrillBuffCount = 0;
    public int SaleBuffCount = 0;

    public int DrillBuffCountDesert = 0;
    public int SaleBuffCountDesert = 0;

    public int DrillBuffCountIce = 0;
    public int SaleBuffCountIce = 0;

    public int DrillBuffCountForest = 0;
    public int SaleBuffCountForest = 0;


    public int isOpening = 0;
    public int isDrillTimeBuff = 0;
    public int isSaleTimeBuff = 0;
    public int AdsTotalCount = 0;
    public int WinMarkTotal = 0;
    public int LoseMarkTotal = 0;
    public int SadariTotalWinCount = 0;
    public int SadariTotalLoseCount = 0;
    public int LottoTotalWinCount = 0;
    public int LottoTotalLoseCount = 0;
    public int UpgradeTotalCount = 0;
    public List<int> QuestCompleteIndex = new List<int>();
    public List<int> QuestingCount = new List<int>();

    public List<int> CombinationStatus = new List<int>();
    public List<int> CombinationStatusPos = new List<int>();
    public List<int> CombinationStatusNormal = new List<int>();
    public List<int> CombinationStatusPosNormal = new List<int>();
    public List<int> CombinationStatusDesert = new List<int>();
    public List<int> CombinationStatusPosDesert = new List<int>();
    public List<int> CombinationStatusIce = new List<int>();
    public List<int> CombinationStatusPosIce = new List<int>();
    public List<int> CombinationStatusForest = new List<int>();
    public List<int> CombinationStatusPosForest = new List<int>();


    public List<int> CollectionStatus = new List<int>();
    public List<int> MinerSkillIndex = new List<int>();
    public List<double> EquipmentCost = new List<double>();
    public List<double> DefaulteEquipmentCost = new List<double>();
    public List<int> EquipmentHoitStoneCost = new List<int>();
    public List<int> DefaultEquipmentHoitStoneCost = new List<int>();
    public int MapType = 1;
    public int Depth = 1;
    public int DesertDepth = 1;
    public int IceDepth = 1;
    public int ForestDepth = 1;
    public bool isEnableUnderConstructionCanvas = false;
    public int EngineLv = 0;
    public int BitLv = 0;

    public int EngineNormalLv = 0;
    public int BitNormalLv = 0;

    public int EngineDesertLv = 0;
    public int BitDesertLv = 0;

    public int EngineIceLv = 0;
    public int BitIceLv = 0;

    public int EngineForestLv = 0;
    public int BitForestLv = 0;

    public bool isSelect = false;

    public List<int> ListCraftTime = new List<int>();

    public List<double> ListHireCost = new List<double>();
    public List<double> ListHireCostDefault = new List<double>();
    public bool bStartMine = true;
    public List<int> ListHireCount = new List<int>();
    public List<int> ListHireDesertCount = new List<int>();
    public List<int> ListHireIceCount = new List<int>();
    public List<int> ListHireForestCount = new List<int>();

    public List<int> ListHireCardOwnCount = new List<int>();
    public List<int> ListHireLevel = new List<int>();
    public List<int> ListHireCardBuyCount = new List<int>();
    public List<float> ListMiningTime = new List<float>();

    public List<int> ListMiningMax = new List<int>();
    public List<int> ListMiningMaxDefault = new List<int>();

    public List<int> ListMiningMin = new List<int>();
    public List<int> ListDefaultListMiningMin = new List<int>();
    public List<int> ListDefaultListMiningMax = new List<int>();
    public List<float> ListDefaultListMiningTime = new List<float>();
    public List<float> ListDefaultListMiningTimeCompose = new List<float>();
    public List<bool> ListbStartMineralAnim = new List<bool>();

    public List<Color> lvColorList = new List<Color>();

    public double ExpNow;    
    public double ExpNowDesert;
    public double ExpNowIce;
    public double ExpNowForest;

    public double[] DepthExp;
    public List<double> ListEnginePower = new List<double>();
    public List<double> ListBitPower = new List<double>();

    public List<MinerClass> ListMinerClass = new List<MinerClass>();
    public List<SupporterClass> ListSupporterClass = new List<SupporterClass>();

    public List<Color> listTextColor = new List<Color>();
    public List<Color> listTextOutlineColor = new List<Color>();

    public List<int> listNowMiner = new List<int>();
    public List<int> listMaxCapacity = new List<int>();
    public List<float> listMaxMinerCapacity = new List<float>();
    public List<float> listMaxMinerCapacityDefault = new List<float>();
    public List<double> listOwnMinerals = new List<double>();
    

    public List<double> listOwnNoramlMinerals = new List<double>();
    public List<double> listOwnDesertMinerals = new List<double>();
    public List<double> listOwnIceMinerals = new List<double>();
    public List<double> listOwnForestMinerals = new List<double>();

    public List<double> ListCostMinerals = new List<double>();

    public List<double> ListCapacityNow = new List<double>();

    public double CapacityNow = 0;
    public double CapacityDesertNow = 0;
    public double CapacityIceNow = 0;
    public double CapacityForestNow = 0;


    public int iCapacityIndex ;
    public int iCapacityNormalIndex;
    public int iCapacityDesertIndex;
    public int iCapacityIceIndex;
    public int iCapacityForestIndex;


    public List<double> ListMoney = new List<double>();
    public double Money = 350;

    public double SplitMoney;
    public int splitNumber;

    public int BlackCoinCount =15;

    public int HoitStoneCount;
    public int GodStoneCount;
    //캐릭터 선택했을때 확인하는 플래그
    public int selectNumber = -1;
    //사다리 동전 파티글 변수
    public double GhostLegGamePercentIndex;
    public double GhostLegMoney;
    public double GhostLegSplitMoney =-1;
    public int ParticleCount = 0;
    public bool bChangeScroll = false;
    public double GhostLegSplitMoney_win;
    public int GhostLegSelectNumber = -1;
    public double RetrunGhostLegMoney;

    public int SelectMiniGame = -1;
    //로또 당첨 번호
    public int LottoCorrectCount = 0;

    //미니게임 카운트
    public int GhostLegCount;
    public int LottoCount;
    public int SpinwheelCount;

    public int bStart = 0;


    //info
    public bool bShowSellShop = false;
    public bool bShowDrillShop = false;


    // 0 1 2 
    // 0 미고용
    // 1 고용 - 인벤토리
    // -1,-2,-3 고용 - 채굴중
    public bool bChangeMap = false;
    public void ChangeMap(int i)
    {
        if (i == MapType)
        {
            bChangeMap = false;
            GameObject.Find("MainCanvas").GetComponent<MainBtnSrc>().PressMap(0);
            return;

        }
        bChangeMap = true;


        eachSellPower.Clear();
        eachMiningSpeed.Clear();
        eachMiningPower.Clear();
        for (int j=0; j< 110;j++)
        {
            eachSellPower.Add(0);
            eachMiningSpeed.Add(0);
            eachMiningPower.Add(0);
        }

        iCapacityNormalIndex = PlayerPrefs.GetInt("iCapacityNormalIndex");
        EngineNormalLv = PlayerPrefs.GetInt("EngineNormalLv");
        BitNormalLv = PlayerPrefs.GetInt("BitNormalLv");

        iCapacityDesertIndex = PlayerPrefs.GetInt("iCapacityDesertIndex");
        EngineDesertLv = PlayerPrefs.GetInt("EngineDesertLv");
        BitDesertLv = PlayerPrefs.GetInt("BitDesertLv");

        iCapacityIceIndex = PlayerPrefs.GetInt("iCapacityIceIndex");
        EngineIceLv = PlayerPrefs.GetInt("EngineIceLv");
        BitIceLv = PlayerPrefs.GetInt("BitIceLv");

        iCapacityForestIndex = PlayerPrefs.GetInt("iCapacityForestIndex");
        EngineForestLv = PlayerPrefs.GetInt("EngineForestLv");
        BitForestLv = PlayerPrefs.GetInt("BitForestLv");

        for (int k = 0; k < 18; k++)
        {
            int index = k + 1;
            string strMinerals = "Mineral" + index;
            listOwnMinerals[k] = PlayerPrefs.GetFloat(strMinerals);

            strMinerals = "MineralNormal" + index;
            listOwnNoramlMinerals[k] = PlayerPrefs.GetFloat(strMinerals);
            strMinerals = "MineralDesert" + index;
            listOwnDesertMinerals[k] = PlayerPrefs.GetFloat(strMinerals);
            strMinerals = "MineralIce" + index;
            listOwnIceMinerals[k] = PlayerPrefs.GetFloat(strMinerals);
            strMinerals = "MineralForest" + index;
            listOwnForestMinerals[k] = PlayerPrefs.GetFloat(strMinerals);

        }

        List<int> tempList = new List<int>();
        if(MapType == 1)
        {
            for(int k=0; k< ListHireCount.Count; k++)
            {
                if(ListHireCount[k] >= 0)
                {
                    tempList.Add(ListHireCount[k]);
                }
                else
                {
                    tempList.Add(1000);
                }
            }
            for(int k=0; k < CombinationStatusPos.Count; k++)
            {
                CombinationStatusNormal[k] = CombinationStatus[k];
                CombinationStatusPosNormal[k] = CombinationStatusPos[k];
            }          
        }
        if (MapType == 2)
        {
            for (int k = 0; k < ListHireDesertCount.Count; k++)
            {
                if (ListHireDesertCount[k] >= 0)
                {
                    tempList.Add(ListHireDesertCount[k]);
                }
                else
                {
                    tempList.Add(1000);
                }
            }
            for (int k = 0; k < CombinationStatusPos.Count; k++)
            {
                CombinationStatusDesert[k] = CombinationStatus[k];
                CombinationStatusPosDesert[k] = CombinationStatusPos[k];
            }
        }
        if (MapType == 3)
        {
            for (int k = 0; k < ListHireIceCount.Count; k++)
            {
                if (ListHireIceCount[k] >= 0)
                {
                    tempList.Add(ListHireIceCount[k]);
                }
                else
                {
                    tempList.Add(1000);
                }
            }
            for (int k = 0; k < CombinationStatusPos.Count; k++)
            {
                CombinationStatusIce[k] = CombinationStatus[k];
                CombinationStatusPosIce[k] = CombinationStatusPos[k];
            }
        }
        if (MapType == 4)
        {
            for (int k = 0; k < ListHireForestCount.Count; k++)
            {
                if (ListHireForestCount[k] >= 0)
                {
                    tempList.Add(ListHireForestCount[k]);
                }
                else
                {
                    tempList.Add(1000);
                }
            }
            for (int k = 0; k < CombinationStatusPos.Count; k++)
            {
                CombinationStatusForest[k] = CombinationStatus[k];
                CombinationStatusPosForest[k] = CombinationStatusPos[k];
            }
        }

        if(i ==1)
        {
            
            iCapacityIndex = iCapacityNormalIndex;
            EngineLv = EngineNormalLv;
            BitLv = BitNormalLv;
            ExpNow = PlayerPrefs.GetFloat("ExpNow");

            GameObject.Find("MainCanvas").GetComponent<AnimCheckSrc>().SetbStart(false);
            GameObject.Find("MainCanvas").GetComponent<MineAnimController>().SetDrillAnim(true);
            
            for (int k=0; k< listOwnNoramlMinerals.Count;k++)
            {
                listOwnMinerals[k] = listOwnNoramlMinerals[k];
            }
            for (int k=0; k< tempList.Count; k++)
            {
                if(tempList[k] ==1000)
                {
                    int index = k + 1;
                    string strHireCount = "HireCount" + index;
                    if (ListHireCount[k] == 0)
                    {
                        ListHireCount[k] = 1000;
                    }
                    else
                    {
                        ListHireCount[k] = PlayerPrefs.GetInt(strHireCount);
                    }
                }
                else
                {
                    ListHireCount[k] = tempList[k];
                }
                
            }

            for (int k = 0; k < CombinationStatusPos.Count; k++)
            {
                CombinationStatus[k] = CombinationStatusNormal[k] ;
                CombinationStatusPos[k] = CombinationStatusPosNormal[k];
            }
        }
        if (i == 2)
        {
            
            iCapacityIndex = iCapacityDesertIndex;
            EngineLv = EngineDesertLv;
            BitLv = BitDesertLv;
            ExpNowDesert = PlayerPrefs.GetFloat("ExpNowDesert");
       
            GameObject.Find("MainCanvas").GetComponent<AnimCheckSrc>().SetbStart(false);
            GameObject.Find("MainCanvas").GetComponent<MineAnimController>().SetDrillAnim(true);
            
            for (int k = 0; k < listOwnDesertMinerals.Count; k++)
            {
                listOwnMinerals[k] = listOwnDesertMinerals[k];
            }
            for (int k = 0; k < tempList.Count; k++)
            {
                if (tempList[k] == 1000)
                {
                    int index = k + 1;
                    string strHireCount = "HireDesertCount" + index;
                    if(ListHireDesertCount[k] ==0)
                    {
                        ListHireDesertCount[k] = 1000;
                    }
                    else
                    {
                        ListHireDesertCount[k] = PlayerPrefs.GetInt(strHireCount);
                    }   
                }
                else
                {
                    ListHireDesertCount[k] = tempList[k];
                }
            }
            for (int k = 0; k < CombinationStatusPos.Count; k++)
            {
                CombinationStatus[k] = CombinationStatusDesert[k];
                CombinationStatusPos[k] = CombinationStatusPosDesert[k];
            }

        }
        if (i == 3)
        {
            
            iCapacityIndex = iCapacityIceIndex;
            EngineLv = EngineIceLv;
            BitLv = BitIceLv;
            ExpNowIce = PlayerPrefs.GetFloat("ExpNowIce");
        
            GameObject.Find("MainCanvas").GetComponent<AnimCheckSrc>().SetbStart(false);
            GameObject.Find("MainCanvas").GetComponent<MineAnimController>().SetDrillAnim(true);

            for (int k = 0; k < listOwnIceMinerals.Count; k++)
            {
                listOwnMinerals[k] = listOwnIceMinerals[k];
            }
            for (int k = 0; k < tempList.Count; k++)
            {
                if (tempList[k] == 1000)
                {
                    int index = k + 1;
                    string strHireCount = "HireIceCount" + index;
                    if (ListHireIceCount[k] == 0)
                    {
                        ListHireIceCount[k] = 1000;
                    }
                    else
                    {
                        ListHireIceCount[k] = PlayerPrefs.GetInt(strHireCount);
                    }
                }
                else
                {
                    ListHireIceCount[k] = tempList[k];
                }
            }
            for (int k = 0; k < CombinationStatusPos.Count; k++)
            {
                CombinationStatus[k] = CombinationStatusIce[k];
                CombinationStatusPos[k] = CombinationStatusPosIce[k];
            }
        }
        if (i == 4)
        {
            
            iCapacityIndex = iCapacityForestIndex;
            EngineLv = EngineForestLv;
            BitLv = BitForestLv;
            ExpNowForest = PlayerPrefs.GetFloat("ExpNowForest");

            GameObject.Find("MainCanvas").GetComponent<AnimCheckSrc>().SetbStart(false);
            GameObject.Find("MainCanvas").GetComponent<MineAnimController>().SetDrillAnim(true);
            for (int k = 0; k < listOwnForestMinerals.Count; k++)
            {
                listOwnMinerals[k] = listOwnForestMinerals[k];
            }
            for (int k = 0; k < tempList.Count; k++)
            {
                if (tempList[k] == 1000)
                {
                    int index = k + 1;
                    string strHireCount = "HireForestCount" + index;
                    if (ListHireCount[k] == 0)
                    {
                        ListHireForestCount[k] = 1000;
                    }
                    else
                    {
                        ListHireForestCount[k] = PlayerPrefs.GetInt(strHireCount);
                    }
                }
                else
                {
                    ListHireForestCount[k] = tempList[k];
                }
            }

            for (int k = 0; k < CombinationStatusPos.Count; k++)
            {
                CombinationStatus[k] = CombinationStatusForest[k];
                CombinationStatusPos[k] = CombinationStatusPosForest[k];
            }
        }
        DrillBuffPower = 0;
        SaleBuffPower = 0;
        buffBuffPower = 0;
        AutoSellPower = 0;
        MiningBuffPower = 0;
        dynamiteReTime = 0;
        BoxBuffPower = 0;
        CraftMoneyDiscount = 0;
        HireMoneyDiscount = 0;
        NotConnectedMoney = 0;
        HoitStoneBuffPercent = 0;
        HoitStoneBuffPower = 0;
        CapacityPower = 0;
        GameObject.Find("MainCanvas").GetComponent<TimeRewardManager>().SetPreData(MapType);
        MapType = i;
        PlayerPrefs.SetInt("MapType", MapType);


        PlayerPrefs.Save();

        GameObject.Find("MainCanvas").GetComponent<HireSettingController>().InitData();
        
        GameObject.Find("MainCanvas").GetComponent<MapContorller>().SetTop();
        GameObject.Find("MainCanvas").GetComponent<MainBtnSrc>().PressMap(0);
        
        GameObject.Find("MainCanvas").GetComponent<Hire_Drill_Manager>().DeleteList();
        GameObject.Find("MainCanvas").GetComponent<Hire_Drill_Manager>().InitData();


        GameObject.Find("Main Camera").GetComponent<MiningAlgorithm>().SetRandTable();
        GameObject.Find("MainCanvas").GetComponent<MineAnimController>().SetAnim(true);
  

        if(CertificateGold ==1)
        {
            SaleBuffPower += 2;
        }
        GameObject.Find("MainCanvas").GetComponent<MapContorller>().ChangeMap();
        GameObject.Find("MainCanvas").GetComponent<CombinationManager>().SetbCombination();
        GameObject.Find("MainCanvas").GetComponent<CombinationManager>().ChangeMapCombinamtion();
        GameObject.Find("MainCanvas").GetComponent<CombinationManager>().ChangeMapCollection();

        MainStausCanvas.GetComponent<DrillManager>().CheckBuffAds();
        MainStausCanvas.GetComponent<SoundManager>().ChageMap();
        SaveData();
        GameObject.Find("MainCanvas").GetComponent<QuestManager>().SetExclamationmark(GameObject.Find("MainCanvas").GetComponent<QuestManager>().CheckMoveMapQuest());

        GameObject.Find("MainCanvas").GetComponent<BlackCoinSpendUIManager>().ChangeMapPotion();
        GameObject.Find("MainCanvas").GetComponent<MineralSellManager>().ChangeMap();
        GameObject.Find("MainCanvas").GetComponent<MineralSellManager>().AutoSell();
        GameObject.Find("MainCanvas").GetComponent<TimeRewardManager>().ChangeMap();
        GameObject.Find("MainCanvas").GetComponent<UnderConstructionManager>().SetUnderConstruction();
        GameObject.Find("MainCanvas").GetComponent<EventDialogueController>().ChangeMap();

        MainStausCanvas.GetComponent<GiftBoxManager>().ResetBox();

        GameObject.Find("MainCanvas").GetComponent<MainBtnSrc>().SetGoldPerSec();

        if(DrillManagerStatus ==1)
        {
            DrillBuffPower += 20;
        }

        if (GameObject.Find("MainCanvas").GetComponent<MiniQuestManager>().GetCurrentPosData() == 18)
        {
            GameObject.Find("MainCanvas").GetComponent<MiniQuestManager>().SetMiniQuest(18, 0);
        }
        if (GameObject.Find("MainCanvas").GetComponent<MiniQuestManager>().GetCurrentPosData() == 28)
        {
            GameObject.Find("MainCanvas").GetComponent<MiniQuestManager>().SetMiniQuest(28, 0);
        }
    }
    public void SaveData()
    {
        
        PlayerPrefs.SetInt("bStart", 5);
        PlayerPrefs.SetInt("GhostLegCount", GhostLegCount);
        PlayerPrefs.SetInt("LottoCount", LottoCount);
        PlayerPrefs.SetInt("SpinwheelCount", SpinwheelCount);
        PlayerPrefs.SetInt("MapType", MapType);

        PlayerPrefs.SetFloat("Money", (float)Money);
        PlayerPrefs.SetInt("BlackCoin", BlackCoinCount);
        PlayerPrefs.SetInt("HoitStoneCount", HoitStoneCount);
        PlayerPrefs.SetInt("GodStoneCount", GodStoneCount);

        PlayerPrefs.SetInt("Depth", Depth);
        PlayerPrefs.SetInt("DesertDepth", DesertDepth);
        PlayerPrefs.SetInt("IceDepth", IceDepth);
        PlayerPrefs.SetInt("ForestDepth", ForestDepth);


        PlayerPrefs.SetInt("iCapacityNormalIndex", iCapacityNormalIndex);
        PlayerPrefs.SetInt("EngineNormalLv", EngineNormalLv);
        PlayerPrefs.SetInt("BitNormalLv", BitNormalLv);

        PlayerPrefs.SetInt("iCapacityIndex", iCapacityIndex);
        PlayerPrefs.SetInt("EngineLv", EngineLv);

        PlayerPrefs.SetInt("iCapacityDesertIndex", iCapacityDesertIndex);
        PlayerPrefs.SetInt("EngineDesertLv", EngineDesertLv);
        PlayerPrefs.SetInt("iCapacityIceIndex", iCapacityIceIndex);
        PlayerPrefs.SetInt("EngineIceLv", EngineIceLv);
        PlayerPrefs.SetInt("iCapacityForestIndex", iCapacityForestIndex);
        PlayerPrefs.SetInt("EngineForestLv", EngineForestLv);

        PlayerPrefs.SetInt("BitLv", BitLv);
        PlayerPrefs.SetInt("BitDesertLv", BitDesertLv);
        PlayerPrefs.SetInt("BitIceLv", BitIceLv);
        PlayerPrefs.SetInt("BitForestLv", BitForestLv);

        PlayerPrefs.SetFloat("ExpNow", (float)ExpNow);
        PlayerPrefs.SetFloat("ExpNowDesert", (float)ExpNowDesert);
        PlayerPrefs.SetFloat("ExpNowIce", (float)ExpNowIce);
        PlayerPrefs.SetFloat("ExpNowForest", (float)ExpNowForest);
        PlayerPrefs.SetFloat("CapacityNow", (float)CapacityNow);


        for (int i = 0; i < 18; i++)
        {
            int index = i + 1;
            string strMinerals = "Mineral" + index;
            PlayerPrefs.SetFloat(strMinerals, (float)listOwnMinerals[i]);
            strMinerals = "MineralNormal" + index;
            PlayerPrefs.SetFloat(strMinerals, (float)listOwnNoramlMinerals[i]);
            strMinerals = "MineralDesert" + index;
            PlayerPrefs.SetFloat(strMinerals, (float)listOwnDesertMinerals[i]);
            strMinerals = "MineralIce" + index;
            PlayerPrefs.SetFloat(strMinerals, (float)listOwnIceMinerals[i]);
            strMinerals = "MineralForest" + index;
            PlayerPrefs.SetFloat(strMinerals, (float)listOwnForestMinerals[i]);
        }
        for (int i = 0; i < 33; i++)
        {
            int index = i + 1;
            string strCombi = "Combi" + index;
            PlayerPrefs.SetInt(strCombi, CombinationStatus[i]);
            strCombi = "CombiPos" +index;
            PlayerPrefs.SetInt(strCombi, CombinationStatusPos[i]);

            strCombi = "CombiNormal" + index;
            PlayerPrefs.SetInt(strCombi, CombinationStatusNormal[i]);
            strCombi = "CombiPosNormal" + index;
            PlayerPrefs.SetInt(strCombi, CombinationStatusPosNormal[i]);


            strCombi = "CombiDesert" + index;
            PlayerPrefs.SetInt(strCombi, CombinationStatusDesert[i]);
            strCombi = "CombiPosDesert" + index;
            PlayerPrefs.SetInt(strCombi, CombinationStatusPosDesert[i]);

            strCombi = "CombiIce" + index;
            PlayerPrefs.SetInt(strCombi, CombinationStatusIce[i]);
            strCombi = "CombiPosIce" + index;
            PlayerPrefs.SetInt(strCombi, CombinationStatusPosIce[i]);

            strCombi = "CombiForest" + index;
            PlayerPrefs.SetInt(strCombi, CombinationStatusForest[i]);
            strCombi = "CombiPosForest" + index;
            PlayerPrefs.SetInt(strCombi, CombinationStatusPosForest[i]);


            strCombi = "Collection" + index;
            PlayerPrefs.SetInt(strCombi, CollectionStatus[i]);

            strCombi = "QuestComplete" + index;
            PlayerPrefs.SetInt(strCombi, QuestCompleteIndex[i]);

            strCombi = "Questing" + index;
            PlayerPrefs.SetInt(strCombi, QuestingCount[i]);


        }

        string strUpgradeTotalCount = "TotalUpgrade";
        PlayerPrefs.SetInt(strUpgradeTotalCount, UpgradeTotalCount);


        strUpgradeTotalCount = "KingMineralStageNormal";
        PlayerPrefs.SetInt(strUpgradeTotalCount, KingMineralStageNormal);
        strUpgradeTotalCount = "KingMineralStageDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, KingMineralStageDesert);
        strUpgradeTotalCount = "KingMineralStageIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, KingMineralStageIce);
        strUpgradeTotalCount = "KingMineralStageForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, KingMineralStageForest);


        strUpgradeTotalCount = "MiningPotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, MiningPotionTotalCount);
        strUpgradeTotalCount = "DrillPotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillPotionTotalCount);
        strUpgradeTotalCount = "SalePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SalePotionTotalCount);
        strUpgradeTotalCount = "ZzangPotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ZzangPotionTotalCount);
        strUpgradeTotalCount = "SkillPotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SkillPotionTotalCount);
        strUpgradeTotalCount = "AutoSellPotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, AutoSellPotionTotalCount);

        strUpgradeTotalCount = "MiningDoublePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, MiningDoublePotionTotalCount);
        strUpgradeTotalCount = "DrillDoublePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillDoublePotionTotalCount);
        strUpgradeTotalCount = "SaleDoublePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SaleDoublePotionTotalCount);
        strUpgradeTotalCount = "ZzangDoublePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ZzangDoublePotionTotalCount);
        strUpgradeTotalCount = "SkillDoublePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SkillDoublePotionTotalCount);

        strUpgradeTotalCount = "AutoSellDoublePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, AutoSellDoublePotionTotalCount);

        strUpgradeTotalCount = "TotalSadariWin";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SadariTotalWinCount);
        strUpgradeTotalCount = "TotalSadariLose";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SadariTotalLoseCount);
        strUpgradeTotalCount = "TotalLottoWin";
        PlayerPrefs.SetInt(strUpgradeTotalCount, LottoTotalWinCount);
        strUpgradeTotalCount = "TotalLottoLose";
        PlayerPrefs.SetInt(strUpgradeTotalCount, LottoTotalLoseCount);

        strUpgradeTotalCount = "WinMark";
        PlayerPrefs.SetInt(strUpgradeTotalCount, WinMarkTotal);
        strUpgradeTotalCount = "LoseMark";
        PlayerPrefs.SetInt(strUpgradeTotalCount, LoseMarkTotal);


        strUpgradeTotalCount = "isOnBGM";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isOnBGM);
        strUpgradeTotalCount = "isOnEffectBGM";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isOnEffectBGM);

        strUpgradeTotalCount = "ManagerStatus1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ManagerStatus1);
        strUpgradeTotalCount = "ManagerStatus2";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ManagerStatus2);
        strUpgradeTotalCount = "ManagerStatus3";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ManagerStatus3);


        strUpgradeTotalCount = "DrillManagerStatus";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillManagerStatus);
        strUpgradeTotalCount = "ManagerPackStatus";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ManagerPackStatus);


        strUpgradeTotalCount = "IslandDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, IslandDesert);
        strUpgradeTotalCount = "IslandIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, IslandIce);
        strUpgradeTotalCount = "IslandForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, IslandForest);

        strUpgradeTotalCount = "CertificateGold";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CertificateGold);
        strUpgradeTotalCount = "CertificateTime";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CertificateTime);

        strUpgradeTotalCount = "isStartTimeDepth";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartTimeDepth);
        strUpgradeTotalCount = "isStartTimeDepthDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartTimeDepthDesert);
        strUpgradeTotalCount = "isStartTimeDepthIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartTimeDepthIce);
        strUpgradeTotalCount = "isStartTimeDepthForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartTimeDepthForest);


        strUpgradeTotalCount = "isStartCraftEngineNormal";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftEngineNormal);
        strUpgradeTotalCount = "isStartCraftEngineDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftEngineDesert);
        strUpgradeTotalCount = "isStartCraftEngineIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftEngineIce);
        strUpgradeTotalCount = "isStartCraftEngineForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftEngineForest);


        strUpgradeTotalCount = "isStartCraftBitNormal";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftBitNormal);
        strUpgradeTotalCount = "isStartCraftBitDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftBitDesert);
        strUpgradeTotalCount = "isStartCraftBitIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftBitIce);
        strUpgradeTotalCount = "isStartCraftBitForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftBitForest);


        strUpgradeTotalCount = "CraftAdsCoolTimeCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CraftAdsCoolTimeCount);
        strUpgradeTotalCount = "CrafttAdsCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CrafttAdsCount);

        strUpgradeTotalCount = "CraftAdsCoolTimeCountDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CraftAdsCoolTimeCountDesert);
        strUpgradeTotalCount = "CrafttAdsCountDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CrafttAdsCountDesert);

        strUpgradeTotalCount = "Semiconductor1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, Semiconductor1);

        strUpgradeTotalCount = "Semiconductor2";
        PlayerPrefs.SetInt(strUpgradeTotalCount, Semiconductor2);

        strUpgradeTotalCount = "Semiconductor4";
        PlayerPrefs.SetInt(strUpgradeTotalCount, Semiconductor3);

        strUpgradeTotalCount = "Semiconductor4";
        PlayerPrefs.SetInt(strUpgradeTotalCount, Semiconductor4);

        strUpgradeTotalCount = "CraftAdsCoolTimeCountIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CraftAdsCoolTimeCountIce);
        strUpgradeTotalCount = "CrafttAdsCountIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CrafttAdsCountIce);

        strUpgradeTotalCount = "CraftAdsCoolTimeCountForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CraftAdsCoolTimeCountForest);
        strUpgradeTotalCount = "CrafttAdsCountForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CrafttAdsCountForest);


        strUpgradeTotalCount = "DynamiteAdsCoolTimeCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCoolTimeCount);
        strUpgradeTotalCount = "DynamiteAdsCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCount);

        strUpgradeTotalCount = "DynamiteAdsCoolTimeCountDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCoolTimeCountDesert);
        strUpgradeTotalCount = "DynamiteAdsCountDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCountDesert);

        strUpgradeTotalCount = "DynamiteAdsCoolTimeCountIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCoolTimeCountIce);
        strUpgradeTotalCount = "DynamiteAdsCountIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCountIce);


        strUpgradeTotalCount = "DynamiteAdsCoolTimeCountForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCoolTimeCountForest);
        strUpgradeTotalCount = "DynamiteAdsCountForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCountForest);

        strUpgradeTotalCount = "iAdsDailyCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, iAdsDailyCount);

        strUpgradeTotalCount = "ClickCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ClickCount);

        strUpgradeTotalCount = "TotalAdsRandomMiner1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, TotalAdsRandomMiner1);
        strUpgradeTotalCount = "TotalBuyRandomMiner1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, TotalBuyRandomMiner1);

        strUpgradeTotalCount = "isBuyCostPack";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuyCostPack);
        strUpgradeTotalCount = "isMiddelSpecialPack";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiddelSpecialPack);
        strUpgradeTotalCount = "isHighSpecialPack";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isHighSpecialPack);
        strUpgradeTotalCount = "isSperHighSpecialPack";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSperHighSpecialPack);
        strUpgradeTotalCount = "isStaterPack";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStaterPack);
        strUpgradeTotalCount = "isMinerPack1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMinerPack1);
        strUpgradeTotalCount = "isMinerPack2";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMinerPack2);
        strUpgradeTotalCount = "isMinerPack3";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMinerPack3);

        strUpgradeTotalCount = "isCoinPack1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isCoinPack1);
        strUpgradeTotalCount = "isCoinPack2";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isCoinPack2);


        strUpgradeTotalCount = "isDrStart";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrStart);


        strUpgradeTotalCount = "bReview";
        PlayerPrefs.SetInt(strUpgradeTotalCount, bReview);

        strUpgradeTotalCount = "DesertKey";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DesertKey);
        strUpgradeTotalCount = "IceKey";
        PlayerPrefs.SetInt(strUpgradeTotalCount, IceKey);
        strUpgradeTotalCount = "ForestKey";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ForestKey);

        //Event Flag

        strUpgradeTotalCount = "EventObjectNormal1Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal1Status);
        strUpgradeTotalCount = "EventObjectNormal2Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal2Status);
        strUpgradeTotalCount = "EventObjectNormal3Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal3Status);
        strUpgradeTotalCount = "EventObjectNormal4Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal4Status);
        strUpgradeTotalCount = "EventObjectNormal5Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal5Status);
        strUpgradeTotalCount = "EventObjectNormal6Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal6Status);
        strUpgradeTotalCount = "EventObjectNormal7Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal7Status);

        strUpgradeTotalCount = "EventObjectDesert1Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert1Status);
        strUpgradeTotalCount = "EventObjectDesert2Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert2Status);
        strUpgradeTotalCount = "EventObjectDesert3Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert3Status);
        strUpgradeTotalCount = "EventObjectDesert4Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert4Status);
        strUpgradeTotalCount = "EventObjectDesert5Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert5Status);
        strUpgradeTotalCount = "EventObjectDesert6Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert6Status);
        strUpgradeTotalCount = "EventObjectDesert7Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert7Status);
        strUpgradeTotalCount = "EventObjectDesert8Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert8Status);
        strUpgradeTotalCount = "EventObjectDesert9Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert9Status);

        strUpgradeTotalCount = "EventObjectIce1Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce1Status);
        strUpgradeTotalCount = "EventObjectIce2Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce2Status);
        strUpgradeTotalCount = "EventObjectIce3Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce3Status);
        strUpgradeTotalCount = "EventObjectIce4Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce4Status);
        strUpgradeTotalCount = "EventObjectIce5Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce5Status);
        strUpgradeTotalCount = "EventObjectIce6Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce6Status);
        strUpgradeTotalCount = "EventObjectIce7Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce7Status);


        strUpgradeTotalCount = "EventObjectForest1Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest1Status);
        strUpgradeTotalCount = "EventObjectForest2Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest2Status);
        strUpgradeTotalCount = "EventObjectForest3Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest3Status);
        strUpgradeTotalCount = "EventObjectForest4Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest4Status);
        strUpgradeTotalCount = "EventObjectForest5Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest5Status);
        strUpgradeTotalCount = "EventObjectForest6Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest6Status);
        strUpgradeTotalCount = "EventObjectForest7Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest7Status);

        //

        strUpgradeTotalCount = "AdsTotal";
        PlayerPrefs.SetInt(strUpgradeTotalCount, AdsTotalCount);

        strUpgradeTotalCount = "DrillTimeBuff";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillTimeBuff);

        strUpgradeTotalCount = "SaleTimeBuff";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSaleTimeBuff);


        strUpgradeTotalCount = "DayRewardNext";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DayRewardNext);

        strUpgradeTotalCount = "DayRewardTime";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DayRewardTime);

        strUpgradeTotalCount = "Opening";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isOpening);

        for(int i=0; i< 20; i++)
        {
            strUpgradeTotalCount = "DayReward" + i;
            PlayerPrefs.SetInt(strUpgradeTotalCount, ListDayRewardCount[i]);
        }
        strUpgradeTotalCount = "DrillBuffCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillBuffCount);

        strUpgradeTotalCount = "SaleBuffCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SaleBuffCount);

        strUpgradeTotalCount = "DrillBuffCountDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillBuffCountDesert);

        strUpgradeTotalCount = "SaleBuffCountDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SaleBuffCountDesert);

        strUpgradeTotalCount = "DrillBuffCountIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillBuffCountIce);

        strUpgradeTotalCount = "SaleBuffCountIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SaleBuffCountIce);

        strUpgradeTotalCount = "DrillBuffCountForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillBuffCountForest);

        strUpgradeTotalCount = "SaleBuffCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SaleBuffCount);


        strUpgradeTotalCount = "NotConnectedMoney";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, NotConnectedMoney);
        strUpgradeTotalCount = "NotConnectedMoneyDesert";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, NotConnectedMoneyDesert);
        strUpgradeTotalCount = "NotConnectedMoneyIce";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, NotConnectedMoneyIce);
        strUpgradeTotalCount = "NotConnectedMoneyForest";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, NotConnectedMoneyForest);


        //strUpgradeTotalCount = "dynamiteReTime";
        //PlayerPrefs.SetFloat(strUpgradeTotalCount, dynamiteReTime);

        strUpgradeTotalCount = "IsdynamiteTime";
        PlayerPrefs.SetInt(strUpgradeTotalCount, IsdynamiteTime);

        strUpgradeTotalCount = "PotionRemainTime";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, PotionRemainTime);

        //strUpgradeTotalCount = "HoitStoneBuffPercent";
        //PlayerPrefs.SetFloat(strUpgradeTotalCount, HoitStoneBuffPercent);

        //strUpgradeTotalCount = "HoitStoneBuffPower";
        //PlayerPrefs.SetFloat(strUpgradeTotalCount, HoitStoneBuffPower);

        strUpgradeTotalCount = "MiningBuffPower";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, MiningBuffPower);

        strUpgradeTotalCount = "DrillBuffPower";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, DrillBuffPower);

        strUpgradeTotalCount = "SaleBuffPower";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, SaleBuffPower);

        strUpgradeTotalCount = "buffBuffPower";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, buffBuffPower);


        strUpgradeTotalCount = "isDrillPotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotion);

        strUpgradeTotalCount = "isSalePotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotion);

        strUpgradeTotalCount = "isMiningPotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotion);

        strUpgradeTotalCount = "isBuffPotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotion);

        strUpgradeTotalCount = "isZzangPotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotion);

        strUpgradeTotalCount = "isAutoSellPotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellPotion);

        strUpgradeTotalCount = "isDrillPotionDouble";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionDouble);

        strUpgradeTotalCount = "isSalePotionDouble";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionDouble);

        strUpgradeTotalCount = "isMiningPotionDouble";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionDouble);

        strUpgradeTotalCount = "isBuffPotionDouble";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionDouble);

        strUpgradeTotalCount = "isZzangPotionDouble";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionDouble);

        strUpgradeTotalCount = "isAutoSellDoublePotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellDoublePotion);

        strUpgradeTotalCount = "isDrillPotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionDesert);

        strUpgradeTotalCount = "isSalePotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionDesert);

        strUpgradeTotalCount = "isMiningPotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionDesert);

        strUpgradeTotalCount = "isBuffPotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionDesert);

        strUpgradeTotalCount = "isZzangPotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionDesert);


        strUpgradeTotalCount = "isAutoSellPotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellPotionDesert);

        strUpgradeTotalCount = "isAutoSellDoublePotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellDoublePotionDesert);

        strUpgradeTotalCount = "isDrillPotionDoubleDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionDoubleDesert);

        strUpgradeTotalCount = "isSalePotionDoubleDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionDoubleDesert);

        strUpgradeTotalCount = "isMiningPotionDoubleDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionDoubleDesert);

        strUpgradeTotalCount = "isBuffPotionDoubleDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionDoubleDesert);

        strUpgradeTotalCount = "isZzangPotionDoubleDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionDoubleDesert);

        strUpgradeTotalCount = "isDrillPotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionIce);

        strUpgradeTotalCount = "isSalePotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionIce);

        strUpgradeTotalCount = "isMiningPotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionIce);

        strUpgradeTotalCount = "isBuffPotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionIce);

        strUpgradeTotalCount = "isZzangPotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount,isZzangPotionIce);
        strUpgradeTotalCount = "isAutoSellPotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellPotionIce);


        strUpgradeTotalCount = "isDrillPotionDoubleIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionDoubleIce);

        strUpgradeTotalCount = "isSalePotionDoubleIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionDoubleIce);

        strUpgradeTotalCount = "isMiningPotionDoubleIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionDoubleIce);

        strUpgradeTotalCount = "isBuffPotionDoubleIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionDoubleIce);

        strUpgradeTotalCount = "isZzangPotionDoubleIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionDoubleIce);
        strUpgradeTotalCount = "isAutoSellDoublePotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellDoublePotionIce);

        strUpgradeTotalCount = "isDrillPotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionForest);

        strUpgradeTotalCount = "isSalePotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionForest);

        strUpgradeTotalCount = "isMiningPotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionForest);

        strUpgradeTotalCount = "isBuffPotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionForest);

        strUpgradeTotalCount = "isZzangPotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionForest);

        strUpgradeTotalCount = "isAutoSellPotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellPotionForest);


        strUpgradeTotalCount = "isAutoSellDoublePotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellDoublePotionForest);

        strUpgradeTotalCount = "isDrillPotionDoubleForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionDoubleForest);

        strUpgradeTotalCount = "isSalePotionDoubleForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionDoubleForest);

        strUpgradeTotalCount = "isMiningPotionDoubleForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionDoubleForest);

        strUpgradeTotalCount = "isBuffPotionDoubleForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionDoubleForest);

        strUpgradeTotalCount = "isZzangPotionDoubleForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionDoubleForest);
        for(int i=0; i<= 28;i++)
        {
            string strMiniQuest = "MiniQuest" +i;
            PlayerPrefs.SetFloat(strMiniQuest, MiniQuestIndex[i]);
            PlayerPrefs.Save();
        }
        for (int i = 0; i < 9; i++)
        {
            string strMiniQuest = "MainTutorial" + i;
            PlayerPrefs.SetFloat(strMiniQuest, MainTutorialList[i]);
            PlayerPrefs.Save();
        }


        for (int i = 0; i < 200; i++)
        {
            int index = i + 1;
            string strHireCount = "RobotNormal" + index;
            PlayerPrefs.SetInt(strHireCount, RobotNormal[i]);
            strHireCount = "RobotDesert" + index;
            PlayerPrefs.SetInt(strHireCount, RobotDesert[i]);
            strHireCount = "RobotIce" + index;
            PlayerPrefs.SetInt(strHireCount, RobotIce[i]);
            strHireCount = "RobotForest" + index;
            PlayerPrefs.SetInt(strHireCount, RobotForest[i]);    
        }
        for(int i=0; i< 6; i++)
        {
            int index = i + 1;
            string strHireCount = "KingMineralMiners" + index;
            PlayerPrefs.SetInt(strHireCount, KingMineralMiners[i]);            
        }
        for (int i = 0; i < 110; i++)
        {
            int index = i + 1;
            string strHireCount = "HireCount" + index;
            string strHireLevel = "HireLevel" + index;
            string strHireCardCount = "HireCardCount" + index;

            string strHireDesertCount = "HireDesertCount" + index;
            string strHireIceCount = "HireIceCount" + index;
            string strHireForestCount = "HireForestCount" + index;
            string MoneyCount = "Money" + index;
            string strCapacityNow = "Capacity" + index;
            string strSkillIndex = "Skill" + i;


            PlayerPrefs.SetInt(strSkillIndex, MinerSkillIndex[i]);
            PlayerPrefs.SetFloat(strCapacityNow, (float)ListCapacityNow[i]);
            PlayerPrefs.SetFloat(MoneyCount, (float)ListMoney[i]);
            PlayerPrefs.SetInt(strHireCount, ListHireCount[i]);
            PlayerPrefs.SetInt(strHireDesertCount, ListHireDesertCount[i]);
            PlayerPrefs.SetInt(strHireIceCount, ListHireIceCount[i]);
            PlayerPrefs.SetInt(strHireForestCount, ListHireForestCount[i]);

            if (ListHireLevel[i] ==0)
            {
                PlayerPrefs.SetInt(strHireLevel, 1);
            }
            else
            {
                PlayerPrefs.SetInt(strHireLevel, ListHireLevel[i]);
            }
            PlayerPrefs.SetInt(strHireCardCount, ListHireCardOwnCount[i]);            
        }

        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        
        GhostLegCount = PlayerPrefs.GetInt("GhostLegCount");
        LottoCount = PlayerPrefs.GetInt("LottoCount");
        SpinwheelCount = PlayerPrefs.GetInt("SpinwheelCount");

        Money = PlayerPrefs.GetFloat("Money");
        ////Debug Load
        //if (Money > 1000000000000)
        //{
        //    Money = 1000;
        //}
        if (Money <= 0)
            Money = 350 *scaleFactor;        

        BlackCoinCount = PlayerPrefs.GetInt("BlackCoin");
        HoitStoneCount = PlayerPrefs.GetInt("HoitStoneCount");
        GodStoneCount = PlayerPrefs.GetInt("GodStoneCount");
        Depth = PlayerPrefs.GetInt("Depth");
        DesertDepth = PlayerPrefs.GetInt("DesertDepth");
        IceDepth = PlayerPrefs.GetInt("IceDepth");
        ForestDepth = PlayerPrefs.GetInt("ForestDepth");
        MapType = PlayerPrefs.GetInt("MapType");
        if(MapType <=0)
        {
            MapType = 1;
        }
        if (Depth <=0)
        {
            Depth = 1;
        }
        if(DesertDepth <=0)
        {
            DesertDepth = 1;
        }
        if(IceDepth <=0)
        {
            IceDepth = 1;
        }
        if(ForestDepth <=0)
        {
            ForestDepth = 1;
        }


        iCapacityIndex = PlayerPrefs.GetInt("iCapacityIndex");
        EngineLv = PlayerPrefs.GetInt("EngineLv");
        BitLv= PlayerPrefs.GetInt("BitLv");

        iCapacityNormalIndex = PlayerPrefs.GetInt("iCapacityNormalIndex");
        EngineNormalLv = PlayerPrefs.GetInt("EngineNormalLv");
        BitNormalLv = PlayerPrefs.GetInt("BitNormalLv");

        iCapacityDesertIndex = PlayerPrefs.GetInt("iCapacityDesertIndex");
        EngineDesertLv = PlayerPrefs.GetInt("EngineDesertLv");
        BitDesertLv = PlayerPrefs.GetInt("BitDesertLv");

        iCapacityIceIndex = PlayerPrefs.GetInt("iCapacityIceIndex");
        EngineIceLv = PlayerPrefs.GetInt("EngineIceLv");
        BitIceLv = PlayerPrefs.GetInt("BitIceLv");

        iCapacityForestIndex = PlayerPrefs.GetInt("iCapacityForestIndex");
        EngineForestLv = PlayerPrefs.GetInt("EngineForestLv");
        BitForestLv = PlayerPrefs.GetInt("BitForestLv");

        ExpNow = PlayerPrefs.GetFloat("ExpNow");
        ExpNowDesert = PlayerPrefs.GetFloat("ExpNowDesert");
        ExpNowIce = PlayerPrefs.GetFloat("ExpNowIce");
        ExpNowForest = PlayerPrefs.GetFloat("ExpNowForest");

        CapacityNow = PlayerPrefs.GetFloat("CapacityNow");

        for (int i = 0; i < 18; i++)
        {
            int index = i + 1;
            string strMinerals = "Mineral" + index;
            listOwnMinerals[i] = PlayerPrefs.GetFloat(strMinerals);

            strMinerals = "MineralNormal" + index;
            listOwnNoramlMinerals[i] = PlayerPrefs.GetFloat(strMinerals);
            strMinerals = "MineralDesert" + index;
            listOwnDesertMinerals[i] = PlayerPrefs.GetFloat(strMinerals);
            strMinerals = "MineralIce" + index;
            listOwnIceMinerals[i] = PlayerPrefs.GetFloat(strMinerals);
            strMinerals = "MineralForest" + index;
            listOwnForestMinerals[i] = PlayerPrefs.GetFloat(strMinerals);

        }
        for(int i =0; i<33; i++)
        {
            int index = i + 1;
            string strCombi = "Combi" + index;
            CombinationStatus[i] = PlayerPrefs.GetInt(strCombi);
            strCombi = "CombiPos" + index;
            CombinationStatusPos[i] = PlayerPrefs.GetInt(strCombi);

            strCombi = "CombiNormal" + index;
            CombinationStatusNormal[i] = PlayerPrefs.GetInt(strCombi);
            strCombi = "CombiPosNormal" + index;
            CombinationStatusPosNormal[i] = PlayerPrefs.GetInt(strCombi);

            strCombi = "CombiDesert" + index;
            CombinationStatusDesert[i] = PlayerPrefs.GetInt(strCombi);
            strCombi = "CombiPosDesert" + index;
            CombinationStatusPosDesert[i] = PlayerPrefs.GetInt(strCombi);

            strCombi = "CombiIce" + index;
            CombinationStatusIce[i] = PlayerPrefs.GetInt(strCombi);
            strCombi = "CombiPosIce" + index;
            CombinationStatusPosIce[i] = PlayerPrefs.GetInt(strCombi);

            strCombi = "CombiForest" + index;
            CombinationStatusForest[i] = PlayerPrefs.GetInt(strCombi);
            strCombi = "CombiPosForest" + index;
            CombinationStatusPosForest[i] = PlayerPrefs.GetInt(strCombi);


            strCombi = "Collection" + index;
            CollectionStatus[i] = PlayerPrefs.GetInt(strCombi);

            strCombi = "QuestComplete" + index;
            QuestCompleteIndex[i] = PlayerPrefs.GetInt(strCombi);

            strCombi = "Questing" + index;
            QuestingCount[i] = PlayerPrefs.GetInt(strCombi);
        }

        string strUpgradeTotalCount = "TotalUpgrade";
        UpgradeTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "KingMineralStageNormal";
        KingMineralStageNormal= PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "KingMineralStageDesert";
        KingMineralStageDesert= PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "KingMineralStageIce";
        KingMineralStageIce = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "KingMineralStageForest";
        KingMineralStageForest = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "MiningPotionTotalCount";
        MiningPotionTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "DrillPotionTotalCount";
        DrillPotionTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "SalePotionTotalCount";
        SalePotionTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "ZzangPotionTotalCount";
        ZzangPotionTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "SkillPotionTotalCount";
        SkillPotionTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "AutoSellPotionTotalCount";
        AutoSellPotionTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "MiningDoublePotionTotalCount";
        MiningDoublePotionTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "DrillDoublePotionTotalCount";
        DrillDoublePotionTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "SaleDoublePotionTotalCount";
        SaleDoublePotionTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "ZzangDoublePotionTotalCount";
        ZzangDoublePotionTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "SkillDoublePotionTotalCount";
        SkillDoublePotionTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "AutoSellDoublePotionTotalCount";
        AutoSellDoublePotionTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "TotalSadariWin";
        SadariTotalWinCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "TotalSadariLose";
        SadariTotalLoseCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "TotalLottoWin";
        LottoTotalWinCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "TotalLottoLose";
        LottoTotalLoseCount = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "WinMark";
        WinMarkTotal = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "LoseMark";
        LoseMarkTotal = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isOnBGM";
        isOnBGM = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isOnEffectBGM";
        isOnEffectBGM = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "ManagerStatus1";
        ManagerStatus1 = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "ManagerStatus2";
        ManagerStatus2 = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "ManagerStatus3";
        ManagerStatus3 = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "DrillManagerStatus";
        DrillManagerStatus = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "ManagerPackStatus";
        ManagerPackStatus = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "CertificateGold";
        CertificateGold = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "CertificateTime";
        CertificateTime = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "IslandDesert";
        IslandDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "IslandIce";
        IslandIce = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "IslandForest";
        IslandForest = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isStartTimeDepth";
        isStartTimeDepth = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isStartTimeDepthDesert";
        isStartTimeDepthDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isStartTimeDepthIce";
        isStartTimeDepthIce = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isStartTimeDepthForest";
        isStartTimeDepthForest = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "isStartCraftEngineNormal";
        isStartCraftEngineNormal = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isStartCraftEngineDesert";
        isStartCraftEngineDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isStartCraftEngineIce";
        isStartCraftEngineIce = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isStartCraftEngineForest";
        isStartCraftEngineForest = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isStartCraftBitNormal";
        isStartCraftBitNormal = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isStartCraftBitDesert";
        isStartCraftBitDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isStartCraftBitIce";
        isStartCraftBitIce = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isStartCraftBitForest";
        isStartCraftBitForest = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "CrafttAdsCount";
        CrafttAdsCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "CraftAdsCoolTimeCount";
        CraftAdsCoolTimeCount = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "CrafttAdsCountDesert";
        CrafttAdsCountDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "CraftAdsCoolTimeCountDesert";
        CraftAdsCoolTimeCountDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "CrafttAdsCountIce";
        CrafttAdsCountIce = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "CraftAdsCoolTimeCountIce";
        CraftAdsCoolTimeCountIce = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "CrafttAdsCountForest";
        CrafttAdsCountForest = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "CraftAdsCoolTimeCountForest";
        CraftAdsCoolTimeCountForest = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "Semiconductor1";
        Semiconductor1 = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "Semiconductor2";
        Semiconductor2 = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "Semiconductor3";
        Semiconductor3 = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "Semiconductor4";
        Semiconductor4 = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "DynamiteAdsCoolTimeCount";
        DynamiteAdsCoolTimeCount = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "DynamiteAdsCount";
        DynamiteAdsCount = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "DynamiteAdsCoolTimeCountDesert ";
        DynamiteAdsCoolTimeCountDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "DynamiteAdsCountDesert ";
        DynamiteAdsCountDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "DynamiteAdsCoolTimeCountIce ";
        DynamiteAdsCoolTimeCountIce = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "DynamiteAdsCountIce ";
        DynamiteAdsCountIce = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "DynamiteAdsCoolTimeCountForest ";
        DynamiteAdsCoolTimeCountForest = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "DynamiteAdsCountForest ";
        DynamiteAdsCountForest = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "iAdsDailyCount";
        iAdsDailyCount = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "TotalAdsRandomMiner1";
        TotalAdsRandomMiner1 = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "TotalBuyRandomMiner1";
        TotalBuyRandomMiner1 = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "ClickCount";
        ClickCount = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isBuyCostPack";
        isBuyCostPack = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isMiddelSpecialPack";
        isMiddelSpecialPack = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isHighSpecialPack";
        isHighSpecialPack = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isSperHighSpecialPack";
        isSperHighSpecialPack = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isStaterPack";
        isStaterPack = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isMinerPack1";
        isMinerPack1 = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isMinerPack2";
        isMinerPack2 = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isMinerPack3";
        isMinerPack3 = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isCoinPack1";
        isCoinPack1 = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isCoinPack2";
        isCoinPack2 = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "isDrStart";
        isDrStart = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "bReview";
        bReview = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "DesertKey";
        DesertKey = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "IceKey";
        IceKey = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "ForestKey";
        ForestKey = PlayerPrefs.GetInt(strUpgradeTotalCount);
        //EventFlag

        strUpgradeTotalCount = "EventObjectNormal1Status";
        EventObjectNormal1Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectNormal2Status";
        EventObjectNormal2Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectNormal3Status";
        EventObjectNormal3Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectNormal4Status";
        EventObjectNormal4Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectNormal5Status";
        EventObjectNormal5Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectNormal6Status";
        EventObjectNormal6Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectNormal7Status";
        EventObjectNormal7Status = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "EventObjectDesert1Status";
        EventObjectDesert1Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectDesert2Status";
        EventObjectDesert2Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectDesert3Status";
        EventObjectDesert3Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectDesert4Status";
        EventObjectDesert4Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectDesert5Status";
        EventObjectDesert5Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectDesert6Status";
        EventObjectDesert6Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectDesert7Status";
        EventObjectDesert7Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectDesert8Status";
        EventObjectDesert8Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectDesert9Status";
        EventObjectDesert9Status = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "EventObjectIce1Status";
        EventObjectIce1Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectIce2Status";
        EventObjectIce2Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectIce3Status";
        EventObjectIce3Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectIce4Status";
        EventObjectIce4Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectIce5Status";
        EventObjectIce5Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectIce6Status";
        EventObjectIce6Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectIce7Status";
        EventObjectIce7Status = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "EventObjectForest1Status";
        EventObjectForest1Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectForest2Status";
        EventObjectForest2Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectForest3Status";
        EventObjectForest3Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectForest4Status";
        EventObjectForest4Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectForest5Status";
        EventObjectForest5Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectForest6Status";
        EventObjectForest6Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "EventObjectForest7Status";
        EventObjectForest7Status = PlayerPrefs.GetInt(strUpgradeTotalCount);
        ///


        strUpgradeTotalCount = "AdsTotal";
        AdsTotalCount = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "DrillTimeBuff";
        isDrillTimeBuff = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "SaleTimeBuff";
        isSaleTimeBuff = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "DayRewardNext";
        DayRewardNext = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "DayRewardTime";
        DayRewardTime = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "Opening";
        isOpening = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "DrillBuffCount";
        DrillBuffCount = PlayerPrefs.GetInt(strUpgradeTotalCount);

        for(int i =0; i< ListDayRewardCount.Count; i++)
        {
            strUpgradeTotalCount = "DayReward" + i;
            ListDayRewardCount[i] = PlayerPrefs.GetInt(strUpgradeTotalCount);
        }

        strUpgradeTotalCount = "SaleBuffCount";
        SaleBuffCount = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "DrillBuffCountDesert";
        DrillBuffCountDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "SaleBuffCountDesert";
        SaleBuffCountDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "DrillBuffCountIce";
        DrillBuffCountIce = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "SaleBuffCountIce";
        SaleBuffCountIce = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "DrillBuffCountForest";
        DrillBuffCountForest = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "SaleBuffCountForest";
        SaleBuffCountForest = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "NotConnectedMoney";
        NotConnectedMoney = PlayerPrefs.GetFloat(strUpgradeTotalCount);
        strUpgradeTotalCount = "NotConnectedMoneyDesert";
        NotConnectedMoneyDesert= PlayerPrefs.GetFloat(strUpgradeTotalCount);
        strUpgradeTotalCount = "NotConnectedMoneyIce";
        NotConnectedMoneyIce = PlayerPrefs.GetFloat(strUpgradeTotalCount);
        strUpgradeTotalCount = "NotConnectedMoneyForest";
        NotConnectedMoneyForest= PlayerPrefs.GetFloat(strUpgradeTotalCount);

        strUpgradeTotalCount = "dynamiteReTime";
        dynamiteReTime = PlayerPrefs.GetFloat(strUpgradeTotalCount);

        strUpgradeTotalCount = "IsdynamiteTime";
        IsdynamiteTime = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "PotionRemainTime";
        PotionRemainTime = PlayerPrefs.GetFloat(strUpgradeTotalCount);

        //strUpgradeTotalCount = "HoitStoneBuffPercent";
        //HoitStoneBuffPercent = PlayerPrefs.GetFloat(strUpgradeTotalCount);

        //strUpgradeTotalCount = "HoitStoneBuffPower";
        //HoitStoneBuffPower = PlayerPrefs.GetFloat(strUpgradeTotalCount);

        //strUpgradeTotalCount = "MiningBuffPower";
        //MiningBuffPower = PlayerPrefs.GetFloat(strUpgradeTotalCount);

        //strUpgradeTotalCount = "DrillBuffPower";
        //DrillBuffPower = PlayerPrefs.GetFloat(strUpgradeTotalCount);

        //strUpgradeTotalCount = "SaleBuffPower";
        //SaleBuffPower = PlayerPrefs.GetFloat(strUpgradeTotalCount);

        strUpgradeTotalCount = "isAutoSellPotion";
        isAutoSellPotion = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isAutoSellPotionDesert";
        isAutoSellPotionDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isAutoSellPotionIce";
        isAutoSellPotionIce = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isAutoSellPotionForest";
        isAutoSellPotionForest = PlayerPrefs.GetInt(strUpgradeTotalCount);




        strUpgradeTotalCount = "isAutoSellDoublePotion";
        isAutoSellDoublePotion = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isAutoSellDoublePotionDesert";
        isAutoSellDoublePotionDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isAutoSellDoublePotionIce";
        isAutoSellDoublePotionIce = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isAutoSellDoublePotionForest";
        isAutoSellDoublePotionForest = PlayerPrefs.GetInt(strUpgradeTotalCount);



        strUpgradeTotalCount = "isDrillPotion";
        isDrillPotion = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isSalePotion";
        isSalePotion = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isMiningPotion";
        isMiningPotion = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isBuffPotion";
        isBuffPotion = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isZzangPotion";
        isZzangPotion = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "isDrillPotionDouble";
        isDrillPotionDouble = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isSalePotionDouble";
        isSalePotionDouble = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isMiningPotionDouble";
        isMiningPotionDouble = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isBuffPotionDouble";
        isBuffPotionDouble = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isZzangPotionDouble";
        isZzangPotionDouble = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "isDrillPotionDesert";
        isDrillPotionDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isSalePotionDesert";
        isSalePotionDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isMiningPotionDesert";
        isMiningPotionDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isBuffPotionDesert";
        isBuffPotionDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isZzangPotionDesert";
        isZzangPotionDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "isDrillPotionDoubleDesert";
        isDrillPotionDoubleDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isSalePotionDoubleDesert";
        isSalePotionDoubleDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isMiningPotionDoubleDesert";
        isMiningPotionDoubleDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isBuffPotionDoubleDesert";
        isBuffPotionDoubleDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isZzangPotionDoubleDesert";
        isZzangPotionDoubleDesert = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "isDrillPotionIce";
        isDrillPotionIce = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isSalePotionIce";
        isSalePotionIce = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isMiningPotionIce";
        isMiningPotionIce = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isBuffPotionIce";
        isBuffPotionIce = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isZzangPotionIce";
        isZzangPotionIce = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "isDrillPotionDoubleIce";
        isDrillPotionDoubleIce = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isSalePotionDoubleIce";
        isSalePotionDoubleIce = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isMiningPotionDoubleIce";
        isMiningPotionDoubleIce = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isBuffPotionDoubleIce";
        isBuffPotionDoubleIce = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isZzangPotionDoubleIce";
        isZzangPotionDoubleIce = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "isDrillPotionForest";
        isDrillPotionForest = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isSalePotionForest";
        isSalePotionForest = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isMiningPotionForest";
        isMiningPotionForest = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isBuffPotionForest";
        isBuffPotionForest = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isZzangPotionForest";
        isZzangPotionForest = PlayerPrefs.GetInt(strUpgradeTotalCount);


        strUpgradeTotalCount = "isDrillPotionDoubleForest";
        isDrillPotionDoubleForest = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isSalePotionDoubleForest";
        isSalePotionDoubleForest = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isMiningPotionDoubleForest";
        isMiningPotionDoubleForest = PlayerPrefs.GetInt(strUpgradeTotalCount);

        strUpgradeTotalCount = "isBuffPotionDoubleForest";
        isBuffPotionDoubleForest = PlayerPrefs.GetInt(strUpgradeTotalCount);
        strUpgradeTotalCount = "isZzangPotionDoubleForest";
        isZzangPotionDoubleForest = PlayerPrefs.GetInt(strUpgradeTotalCount);

        for (int i = 0; i <= 28; i++)
        {
            string strMiniQuest = "MiniQuest" + i;
            MiniQuestIndex[i] = PlayerPrefs.GetFloat(strMiniQuest);            
        }
        for (int i = 0; i < 9; i++)
        {
            string strMiniQuest = "MainTutorial" + i;
            MainTutorialList[i] = PlayerPrefs.GetInt(strMiniQuest);
        }

        for(int i=0; i< 200; i++)
        {
            int index = i + 1;
            string strHireCount = "RobotNormal" + index;
            RobotNormal[i] = PlayerPrefs.GetInt(strHireCount);
            strHireCount = "RobotDesert" + index;
            RobotDesert[i] = PlayerPrefs.GetInt(strHireCount);
            strHireCount = "RobotIce" + index;
            RobotIce[i] = PlayerPrefs.GetInt(strHireCount);
            strHireCount = "RobotForest" + index;
            RobotForest[i] = PlayerPrefs.GetInt(strHireCount);
        }
        for(int i=0; i< 6; i++)
        {
            int index = i + 1;
            string strHireCount = "KingMineralMiners" + index;
            KingMineralMiners[i] = PlayerPrefs.GetInt(strHireCount);
        }
        for (int i = 0; i < 110; i++)
        {
            int index = i + 1;
            string strHireCount = "HireCount" + index;
            string strHireLevel = "HireLevel" + index;
            string strHireCardCount = "HireCardCount" + index;

            string strHireDesertCount = "HireDesertCount" + index;
            string strHireIceCount = "HireIceCount" + index;
            string strHireForestCount = "HireForestCount" + index;
            string MoneyCount = "Money" + index;

            string strCapacityNow = "Capacity" + index;


            string strSkillIndex = "Skill" + i;


            MinerSkillIndex[i] = PlayerPrefs.GetInt(strSkillIndex);


            ListCapacityNow[i] = PlayerPrefs.GetFloat(strCapacityNow);

            ListMoney[i] = PlayerPrefs.GetFloat(MoneyCount);
            ListHireCount[i] = PlayerPrefs.GetInt(strHireCount);

            ListHireDesertCount[i] = PlayerPrefs.GetInt(strHireDesertCount);
            ListHireIceCount[i] = PlayerPrefs.GetInt(strHireIceCount);
            ListHireForestCount[i] = PlayerPrefs.GetInt(strHireForestCount);

            ListHireLevel[i] = PlayerPrefs.GetInt(strHireLevel);
            if (ListHireLevel[i] == 0)
            {
                ListHireLevel[i] = 1;
            }
            
            ListHireCardOwnCount[i] = PlayerPrefs.GetInt(strHireCardCount);
        }



        if (MapType == 1)
        {
            iCapacityIndex = iCapacityNormalIndex;
            EngineLv = EngineNormalLv;
            BitLv = BitNormalLv;
            for (int k = 0; k < listOwnNoramlMinerals.Count; k++)
            {
                listOwnMinerals[k] = listOwnNoramlMinerals[k];
            }    
        }
        if (MapType == 2)
        {
            iCapacityIndex = iCapacityDesertIndex;
            EngineLv = EngineDesertLv;
            BitLv = BitDesertLv;
            for (int k = 0; k < listOwnDesertMinerals.Count; k++)
            {
                listOwnMinerals[k] = listOwnDesertMinerals[k];
            }
     
        }
        if (MapType == 3)
        {
            iCapacityIndex = iCapacityIceIndex;
            EngineLv = EngineIceLv;
            BitLv = BitIceLv;
            for (int k = 0; k < listOwnIceMinerals.Count; k++)
            {
                listOwnMinerals[k] = listOwnIceMinerals[k];
            }     
        }
        if (MapType == 4)
        {
            iCapacityIndex = iCapacityForestIndex;
            EngineLv = EngineForestLv;
            BitLv = BitForestLv;
            for (int k = 0; k < listOwnForestMinerals.Count; k++)
            {
                listOwnMinerals[k] = listOwnForestMinerals[k];
            }     
        }


        GameObject.Find("MainCanvas").GetComponent<AnimCheckSrc>().SetbStart(false);
        GameObject.Find("MainCanvas").GetComponent<MineAnimController>().SetDrillAnim(true);
        PlayerPrefs.Save();
        GameObject.Find("MainCanvas").GetComponent<MineAnimController>().SetAnim(true);
    }

    public void ResetData()
    {
        for(int i=0; i< 4; i++)
        {
            string SaveName = string.Empty;
            string MapStr = string.Empty;
            switch (i)
            {
                case 0:
                    MapStr = "Normal";
                    break;
                case 1:
                    MapStr = "Desert";
                    break;
                case 2:
                    MapStr = "Ice";
                    break;
                case 3:
                    MapStr = "Forest";
                    break;
            }
            for (int k = 1; k <= 200; k++)
            {
                SaveName = MapStr + "SpeacialAblity_Type1" + k;
                PlayerPrefs.SetInt(SaveName, 0);
                SaveName = MapStr + "SpeacialAblity_Type2" + k;
                PlayerPrefs.SetInt(SaveName, 0);
                SaveName = MapStr + "SpeacialAblity_Type3" + k;
                PlayerPrefs.SetInt(SaveName, 0);

                SaveName = MapStr + "iSpeacialAblity1" + k;
                PlayerPrefs.SetFloat(SaveName, 0);
                SaveName = MapStr + "iSpeacialAblity1" + k;
                PlayerPrefs.SetFloat(SaveName, 0);
                SaveName = MapStr + "iSpeacialAblity1" + k;
                PlayerPrefs.SetFloat(SaveName, 0);
            }
        }
       
       


        GhostLegCount =0;
        LottoCount = 0;
        SpinwheelCount =0;
        PlayerPrefs.SetInt("GhostLegCount", GhostLegCount);
        PlayerPrefs.SetInt("LottoCount", LottoCount);
        PlayerPrefs.SetInt("SpinwheelCount", SpinwheelCount);

        bStart = 0;
        PlayerPrefs.SetInt("bStart",bStart);


        MapType = 1;
        PlayerPrefs.SetInt("MapType", MapType);
        Money = 350;
        BlackCoinCount = 0;
        HoitStoneCount = 0;
        GodStoneCount = 0;
        Depth = 1;
        IceDepth = 1;
        DesertDepth = 1;
        ForestDepth = 1;
        PlayerPrefs.SetFloat("Money", (float)Money);
        PlayerPrefs.SetInt("BlackCoin", BlackCoinCount);
        PlayerPrefs.SetInt("HoitStoneCount", HoitStoneCount);
        PlayerPrefs.SetInt("GodStoneCount", GodStoneCount);
        PlayerPrefs.SetInt("Depth", Depth);
        PlayerPrefs.SetInt("DesertDepth", DesertDepth);
        PlayerPrefs.SetInt("IceDepth", IceDepth);
        PlayerPrefs.SetInt("ForestDepth", ForestDepth);

        iCapacityIndex = 0;        
        EngineLv = 0;
        BitLv = 0;

        iCapacityNormalIndex = 0;
        EngineNormalLv = 0;
        BitNormalLv = 0;

        iCapacityDesertIndex = 0;
        EngineDesertLv = 0;
        BitDesertLv = 0;

        iCapacityIceIndex = 0;
        EngineIceLv = 0;
        BitIceLv = 0;

        iCapacityForestIndex = 0;
        EngineForestLv = 0;
        BitForestLv = 0;

        PlayerPrefs.SetInt("iCapacityIndex", iCapacityIndex);
        PlayerPrefs.SetInt("EngineLv", EngineLv);
        PlayerPrefs.SetInt("BitLv", BitLv);

        PlayerPrefs.SetInt("iCapacityNormalIndex", iCapacityNormalIndex);
        PlayerPrefs.SetInt("EngineNormalLv", EngineNormalLv);
        PlayerPrefs.SetInt("BitNormalLv", BitNormalLv);


        PlayerPrefs.SetInt("iCapacityDesertIndex", iCapacityDesertIndex);
        PlayerPrefs.SetInt("EngineDesertLv", EngineDesertLv);
        PlayerPrefs.SetInt("BitDesertLv", BitDesertLv);

        PlayerPrefs.SetInt("iCapacityIceIndex", iCapacityIceIndex);
        PlayerPrefs.SetInt("EngineIceLv", EngineIceLv);
        PlayerPrefs.SetInt("BitIceLv", BitIceLv);

        PlayerPrefs.SetInt("iCapacityForestIndex", iCapacityForestIndex);
        PlayerPrefs.SetInt("EngineForestLv", EngineForestLv);
        PlayerPrefs.SetInt("BitForestLv", BitForestLv);

        ExpNow = 0;
        ExpNowDesert = 0;
        ExpNowIce = 0;
        ExpNowForest = 0;
        CapacityNow = 0;
        PlayerPrefs.SetFloat("ExpNow", (float)ExpNow);
        PlayerPrefs.SetFloat("ExpNowDesert", (float)ExpNowDesert);
        PlayerPrefs.SetFloat("ExpNowIce", (float)ExpNowIce);
        PlayerPrefs.SetFloat("ExpNowForest", (float)ExpNowForest);
        PlayerPrefs.SetFloat("CapacityNow", (float)CapacityNow);

        for (int i=0; i< 18; i++)
        {
            int index = i+1;
            string strMinerals = "Mineral" + index;
            listOwnMinerals[i] = 0;
            PlayerPrefs.SetFloat(strMinerals, (float)listOwnMinerals[i]);


    


            strMinerals = "MineralNormal" + index;
            listOwnNoramlMinerals[i] = 0;
            PlayerPrefs.SetFloat(strMinerals, (float)listOwnNoramlMinerals[i]);
            strMinerals = "MineralDesert" + index;
            listOwnDesertMinerals[i] = 0;
            PlayerPrefs.SetFloat(strMinerals, (float)listOwnDesertMinerals[i]);
            strMinerals = "MineralIce" + index;
            listOwnIceMinerals[i] = 0;
            PlayerPrefs.SetFloat(strMinerals, (float)listOwnIceMinerals[i]);
            strMinerals = "MineralForest" + index;
            listOwnForestMinerals[i] = 0;
            PlayerPrefs.SetFloat(strMinerals, (float)listOwnForestMinerals[i]);
        }

    
        ListHireCount.Clear();
        ListHireDesertCount.Clear();
        ListHireIceCount.Clear();
        ListHireForestCount.Clear();

        RobotNormal.Clear();
        RobotDesert.Clear();
        RobotIce.Clear();
        RobotForest.Clear();

        for(int i=0; i< 6;i++)
        {
            KingMineralMiners[i] = 0;
        }

        ListHireCardBuyCount.Clear();
        ListHireLevel.Clear();
        ListHireCardOwnCount.Clear();
        MiniQuestIndex.Clear();
        MainTutorialList.Clear();
        ListCapacityNow.Clear();
        ListMoney.Clear();
        CombinationStatus.Clear();
        CombinationStatusPos.Clear();

        CombinationStatusNormal.Clear();
        CombinationStatusPosNormal.Clear();

        CombinationStatusDesert.Clear();
        CombinationStatusPosDesert.Clear();
        CombinationStatusIce.Clear();
        CombinationStatusPosIce.Clear();
        CombinationStatusForest.Clear();
        CombinationStatusPosForest.Clear();

        CollectionStatus.Clear();
        QuestingCount.Clear();
        QuestCompleteIndex.Clear();
        UpgradeTotalCount = 0;
        string strUpgradeTotalCount = "TotalUpgrade";
        PlayerPrefs.SetInt(strUpgradeTotalCount, UpgradeTotalCount);


        KingMineralStageNormal = 1;
        strUpgradeTotalCount = "KingMineralStageNormal";
        PlayerPrefs.SetInt(strUpgradeTotalCount, KingMineralStageNormal);

        KingMineralStageDesert = 1;
        strUpgradeTotalCount = "KingMineralStageDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, KingMineralStageDesert);

        KingMineralStageIce = 1;
        strUpgradeTotalCount = "KingMineralStageIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, KingMineralStageIce);

        KingMineralStageForest = 1;
        strUpgradeTotalCount = "KingMineralStageForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, KingMineralStageForest);


        MiningPotionTotalCount = 0;
        strUpgradeTotalCount = "MiningPotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, MiningPotionTotalCount);
        DrillPotionTotalCount = 0;
        strUpgradeTotalCount = "DrillPotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillPotionTotalCount);
        SalePotionTotalCount = 0;
        strUpgradeTotalCount = "SalePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SalePotionTotalCount);
        ZzangPotionTotalCount = 0;
        strUpgradeTotalCount = "ZzangPotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ZzangPotionTotalCount);
        SkillPotionTotalCount = 0;
        strUpgradeTotalCount = "SkillPotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SkillPotionTotalCount);

        AutoSellPotionTotalCount = 0;
        strUpgradeTotalCount = "AutoSellPotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, AutoSellPotionTotalCount);

        AutoSellDoublePotionTotalCount = 0;
        strUpgradeTotalCount = "AutoSellDoublePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, AutoSellDoublePotionTotalCount);


        MiningDoublePotionTotalCount = 0;
        strUpgradeTotalCount = "MiningDoublePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, MiningDoublePotionTotalCount);
        DrillDoublePotionTotalCount = 0;
        strUpgradeTotalCount = "DrillDoublePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillDoublePotionTotalCount);
        SaleDoublePotionTotalCount = 0;
        strUpgradeTotalCount = "SaleDoublePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SaleDoublePotionTotalCount);
        ZzangDoublePotionTotalCount = 0;
        strUpgradeTotalCount = "ZzangDoublePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ZzangDoublePotionTotalCount);
        SkillDoublePotionTotalCount = 0;
        strUpgradeTotalCount = "SkillDoublePotionTotalCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SkillDoublePotionTotalCount);


        SadariTotalWinCount = 0;
        strUpgradeTotalCount = "TotalSadariWin";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SadariTotalWinCount);
        SadariTotalLoseCount = 0;
        strUpgradeTotalCount = "TotalSadariLose";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SadariTotalLoseCount);
        LottoTotalWinCount = 0;
        strUpgradeTotalCount = "TotalLottoWin";
        PlayerPrefs.SetInt(strUpgradeTotalCount, LottoTotalWinCount);
        LottoTotalLoseCount = 0;
        strUpgradeTotalCount = "TotalLottoLose";
        PlayerPrefs.SetInt(strUpgradeTotalCount, LottoTotalLoseCount);

        WinMarkTotal = 0;
        strUpgradeTotalCount = "WinMark";
        PlayerPrefs.SetInt(strUpgradeTotalCount, WinMarkTotal);

        isOnBGM =1;
        strUpgradeTotalCount = "isOnBGM";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isOnBGM);
        isOnEffectBGM = 1;
        strUpgradeTotalCount = "isOnEffectBGM";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isOnEffectBGM);


        ManagerStatus1 = 0;
        strUpgradeTotalCount = "ManagerStatus1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ManagerStatus1);
        ManagerStatus2 = 0;
        strUpgradeTotalCount = "ManagerStatus2";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ManagerStatus2);
        ManagerStatus3 = 0;
        strUpgradeTotalCount = "ManagerStatus3";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ManagerStatus3);


        DrillManagerStatus = 0;
        strUpgradeTotalCount = "DrillManagerStatus";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillManagerStatus);
        ManagerPackStatus = 0;
        strUpgradeTotalCount = "ManagerPackStatus";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ManagerPackStatus);


        CertificateGold = 0;
        strUpgradeTotalCount = "CertificateGold";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CertificateGold);
        CertificateTime = 0;
        strUpgradeTotalCount = "CertificateTime";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CertificateTime);

        IslandDesert = 0;
        strUpgradeTotalCount = "IslandDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, IslandDesert);
        IslandIce = 0;
        strUpgradeTotalCount = "IslandIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, IslandIce);
        IslandForest = 0;
        strUpgradeTotalCount = "IslandForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, IslandForest);



        isStartTimeDepth = 0;
        strUpgradeTotalCount = "isStartTimeDepth";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartTimeDepth);
        isStartTimeDepthDesert = 0;
        strUpgradeTotalCount = "isStartTimeDepthDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartTimeDepthDesert);
        isStartTimeDepthIce = 0;
        strUpgradeTotalCount = "isStartTimeDepthIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartTimeDepthIce);
        isStartTimeDepthForest = 0;
        strUpgradeTotalCount = "isStartTimeDepthForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartTimeDepthForest);


        isStartCraftEngineNormal = 0;
        strUpgradeTotalCount = "isStartCraftEngineNormal";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftEngineNormal);
        isStartCraftBitDesert = 0;
        strUpgradeTotalCount = "isStartCraftBitDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftBitDesert);
        isStartCraftEngineIce = 0;
        strUpgradeTotalCount = "isStartCraftEngineIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftEngineIce);
        isStartCraftEngineForest = 0;
        strUpgradeTotalCount = "isStartCraftEngineForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftEngineForest);



        isStartCraftBitNormal = 0;
        strUpgradeTotalCount = "isStartCraftBitNormal";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftBitNormal);
        isStartCraftBitDesert = 0;
        strUpgradeTotalCount = "isStartCraftBitDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftBitDesert);
        isStartCraftBitIce = 0;
        strUpgradeTotalCount = "isStartCraftBitIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftBitIce);
        isStartCraftBitForest = 0;
        strUpgradeTotalCount = "isStartCraftBitForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStartCraftBitForest);

        CraftAdsCoolTimeCount = 0;
        strUpgradeTotalCount = "CraftAdsCoolTimeCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CraftAdsCoolTimeCount);

        CrafttAdsCount = 0;
        strUpgradeTotalCount = "CrafttAdsCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CrafttAdsCount);


        CraftAdsCoolTimeCountDesert = 0;
        strUpgradeTotalCount = "CraftAdsCoolTimeCountDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CraftAdsCoolTimeCountDesert);

        CrafttAdsCountDesert = 0;
        strUpgradeTotalCount = "CrafttAdsCountDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CrafttAdsCountDesert);


        Semiconductor1 = 0;
        strUpgradeTotalCount = "Semiconductor1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, Semiconductor1);

        Semiconductor2 = 0;
        strUpgradeTotalCount = "Semiconductor2";
        PlayerPrefs.SetInt(strUpgradeTotalCount, Semiconductor2);
        Semiconductor3 = 0;
        strUpgradeTotalCount = "Semiconductor3";
        PlayerPrefs.SetInt(strUpgradeTotalCount, Semiconductor3);
        Semiconductor4 = 0;
        strUpgradeTotalCount = "Semiconductor4";
        PlayerPrefs.SetInt(strUpgradeTotalCount, Semiconductor4);

        CraftAdsCoolTimeCountIce = 0;
        strUpgradeTotalCount = "CraftAdsCoolTimeCountIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CraftAdsCoolTimeCountIce);

        CrafttAdsCountIce = 0;
        strUpgradeTotalCount = "CrafttAdsCountIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CrafttAdsCountIce);

        CraftAdsCoolTimeCountForest = 0;
        strUpgradeTotalCount = "CraftAdsCoolTimeCountForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CraftAdsCoolTimeCountForest);

        CrafttAdsCountForest = 0;
        strUpgradeTotalCount = "CrafttAdsCountForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, CrafttAdsCountForest);






        DynamiteAdsCoolTimeCount = 0;
        strUpgradeTotalCount = "DynamiteAdsCoolTimeCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCoolTimeCount);

        DynamiteAdsCount = 0;
        strUpgradeTotalCount = "DynamiteAdsCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCount);


        DynamiteAdsCoolTimeCountDesert = 0;
        strUpgradeTotalCount = "DynamiteAdsCoolTimeCountDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCoolTimeCountDesert);

        DynamiteAdsCountDesert = 0;
        strUpgradeTotalCount = "DynamiteAdsCountDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCountDesert);

        DynamiteAdsCoolTimeCountIce = 0;
        strUpgradeTotalCount = "DynamiteAdsCoolTimeCountIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCoolTimeCountIce);

        DynamiteAdsCountIce = 0;
        strUpgradeTotalCount = "DynamiteAdsCountIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCountIce);

        DynamiteAdsCoolTimeCountForest = 0;
        strUpgradeTotalCount = "DynamiteAdsCoolTimeCountForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCoolTimeCountForest);

        DynamiteAdsCountForest = 0;
        strUpgradeTotalCount = "DynamiteAdsCountForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DynamiteAdsCountForest);

        iAdsDailyCount = 0;
        strUpgradeTotalCount = "iAdsDailyCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, iAdsDailyCount);



        ClickCount = 0;
        strUpgradeTotalCount = "ClickCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ClickCount);

        TotalAdsRandomMiner1 = 0;
        strUpgradeTotalCount = "TotalAdsRandomMiner1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, TotalAdsRandomMiner1);
        TotalBuyRandomMiner1 = 0;
        strUpgradeTotalCount = "TotalBuyRandomMiner1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, TotalBuyRandomMiner1);

        isBuyCostPack = 0;
        strUpgradeTotalCount = "isBuyCostPack";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuyCostPack);
        isMiddelSpecialPack = 0;
        strUpgradeTotalCount = "isMiddelSpecialPack";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiddelSpecialPack);
        isHighSpecialPack = 0;
        strUpgradeTotalCount = "isHighSpecialPack";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isHighSpecialPack);
        isSperHighSpecialPack = 0;
        strUpgradeTotalCount = "isSperHighSpecialPack";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSperHighSpecialPack);
        isStaterPack = 0;
        strUpgradeTotalCount = "isStaterPack";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isStaterPack);
        isMinerPack1 = 0;
        strUpgradeTotalCount = "isMinerPack1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMinerPack1);
        isMinerPack2 = 0;
        strUpgradeTotalCount = "isMinerPack2";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMinerPack2);
        isMinerPack3 = 0;
        strUpgradeTotalCount = "isMinerPack3";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMinerPack3);

        isCoinPack1 = 0;
        strUpgradeTotalCount = "isCoinPack1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isCoinPack1);

        bReview = 0;
        strUpgradeTotalCount = "bReview";
        PlayerPrefs.SetInt(strUpgradeTotalCount, bReview);

        isCoinPack2 = 0;
        strUpgradeTotalCount = "isCoinPack2";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isCoinPack2);

        isDrStart = 0;
        strUpgradeTotalCount = "isDrStart";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrStart);

        DesertKey = 0;
        strUpgradeTotalCount = "DesertKey";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DesertKey);

        IceKey = 0;
        strUpgradeTotalCount = "IceKey";
        PlayerPrefs.SetInt(strUpgradeTotalCount, IceKey);

        ForestKey = 0;
        strUpgradeTotalCount = "ForestKey";
        PlayerPrefs.SetInt(strUpgradeTotalCount, ForestKey);

        EventObjectNormal1Status = 0;
        strUpgradeTotalCount = "EventObjectNormal1Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal1Status);
        EventObjectNormal2Status = 0;
        strUpgradeTotalCount = "EventObjectNormal2Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal2Status);
        EventObjectNormal3Status = 0;
        strUpgradeTotalCount = "EventObjectNormal3Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal3Status);
        EventObjectNormal4Status = 0;
        strUpgradeTotalCount = "EventObjectNormal4Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal4Status);
        EventObjectNormal5Status = 0;
        strUpgradeTotalCount = "EventObjectNormal5Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal5Status);
        EventObjectNormal6Status = 0;
        strUpgradeTotalCount = "EventObjectNormal6Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal6Status);
        EventObjectNormal7Status = 0;
        strUpgradeTotalCount = "EventObjectNormal7Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectNormal7Status);


        EventObjectDesert1Status = 0;
        strUpgradeTotalCount = "EventObjectDesert1Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert1Status);
        EventObjectDesert2Status = 0;
        strUpgradeTotalCount = "EventObjectDesert2Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert2Status);
        EventObjectDesert3Status = 0;
        strUpgradeTotalCount = "EventObjectDesert3Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert3Status);
        EventObjectDesert4Status = 0;
        strUpgradeTotalCount = "EventObjectDesert4Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert4Status);
        EventObjectDesert5Status = 0;
        strUpgradeTotalCount = "EventObjectDesert5Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert5Status);
        EventObjectDesert6Status = 0;
        strUpgradeTotalCount = "EventObjectDesert6Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert6Status);
        EventObjectDesert7Status = 0;
        strUpgradeTotalCount = "EventObjectDesert7Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert7Status);
        EventObjectDesert8Status = 0;
        strUpgradeTotalCount = "EventObjectDesert8Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert8Status);
        EventObjectDesert9Status = 0;
        strUpgradeTotalCount = "EventObjectDesert9Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectDesert9Status);


        EventObjectIce1Status= 0;
        strUpgradeTotalCount = "EventObjectIce1Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce1Status);
        EventObjectIce2Status = 0;
        strUpgradeTotalCount = "EventObjectIce2Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce2Status);
        EventObjectIce3Status = 0;
        strUpgradeTotalCount = "EventObjectIce3Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce3Status);
        EventObjectIce4Status = 0;
        strUpgradeTotalCount = "EventObjectIce4Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce4Status);
        EventObjectIce5Status = 0;
        strUpgradeTotalCount = "EventObjectIce5Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce5Status);
        EventObjectIce6Status = 0;
        strUpgradeTotalCount = "EventObjectIce6Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce6Status);
        EventObjectIce7Status = 0;
        strUpgradeTotalCount = "EventObjectIce7Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectIce7Status);

        EventObjectForest1Status= 0;
        strUpgradeTotalCount = "EventObjectForest1Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest1Status);
        EventObjectForest2Status = 0;
        strUpgradeTotalCount = "EventObjectForest2Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest2Status);
        EventObjectForest3Status = 0;
        strUpgradeTotalCount = "EventObjectForest3Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest3Status);
        EventObjectForest4Status = 0;
        strUpgradeTotalCount = "EventObjectForest4Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest4Status);
        EventObjectForest5Status = 0;
        strUpgradeTotalCount = "EventObjectForest5Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest5Status);
        EventObjectForest6Status = 0;
        strUpgradeTotalCount = "EventObjectForest6Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest6Status);
        EventObjectForest7Status = 0;
        strUpgradeTotalCount = "EventObjectForest7Status";
        PlayerPrefs.SetInt(strUpgradeTotalCount, EventObjectForest7Status);


        LoseMarkTotal = 0;
        strUpgradeTotalCount = "LoseMark";
        PlayerPrefs.SetInt(strUpgradeTotalCount, LoseMarkTotal);

        AdsTotalCount = 0;
        strUpgradeTotalCount = "AdsTotal";
        PlayerPrefs.SetInt(strUpgradeTotalCount, AdsTotalCount);

        isDrillTimeBuff = 0;
        strUpgradeTotalCount = "DrillTimeBuff";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillTimeBuff);

        isSaleTimeBuff = 0;
        strUpgradeTotalCount = "SaleTimeBuff";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSaleTimeBuff);

        DayRewardNext = 0;
        strUpgradeTotalCount = "DayRewardNext";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DayRewardNext);

        DayRewardTime = 0;
        strUpgradeTotalCount = "DayRewardTime";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DayRewardTime);

        isOpening = 0;
        strUpgradeTotalCount = "Opening";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isOpening);

        for(int i=0; i<20; i++)
        {
            ListDayRewardCount[i] = 0;
            strUpgradeTotalCount = "DayReward" + i;
            PlayerPrefs.SetInt(strUpgradeTotalCount, ListDayRewardCount[i]);
        }

        DrillBuffCount = 0;
        strUpgradeTotalCount = "DrillBuffCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillBuffCount);

        SaleBuffCount = 0;
        strUpgradeTotalCount = "SaleBuffCount";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SaleBuffCount);

        DrillBuffCountDesert = 0;
        strUpgradeTotalCount = "DrillBuffCountDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillBuffCountDesert);

        SaleBuffCountDesert = 0;
        strUpgradeTotalCount = "SaleBuffCountDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SaleBuffCountDesert);

        DrillBuffCountIce = 0;
        strUpgradeTotalCount = "DrillBuffCountIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillBuffCountIce);

        SaleBuffCountIce = 0;
        strUpgradeTotalCount = "SaleBuffCountIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SaleBuffCountIce);

        DrillBuffCountForest = 0;
        strUpgradeTotalCount = "DrillBuffCountForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DrillBuffCountForest);

        SaleBuffCountForest = 0;
        strUpgradeTotalCount = "SaleBuffCountForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, SaleBuffCountForest);



        BoxBuffPower = 0;
        HireMoneyDiscount = 0;
        CraftMoneyDiscount = 0;

        dynamiteReTime = 0;
        strUpgradeTotalCount = "dynamiteReTime";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, dynamiteReTime);
        IsdynamiteTime = 0;
        strUpgradeTotalCount = "IsdynamiteTime";
        PlayerPrefs.SetInt(strUpgradeTotalCount, IsdynamiteTime);

        PotionRemainTime = 0;
        strUpgradeTotalCount = "PotionRemainTime";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, PotionRemainTime);

        //HoitStoneBuffPercent = 0;
        //strUpgradeTotalCount = "HoitStoneBuffPercent";
        //PlayerPrefs.SetFloat(strUpgradeTotalCount, HoitStoneBuffPercent);

        //HoitStoneBuffPower = 0;
        //strUpgradeTotalCount = "HoitStoneBuffPower";
        //PlayerPrefs.SetFloat(strUpgradeTotalCount, HoitStoneBuffPower);

        NotConnectedMoney = 0;
        strUpgradeTotalCount = "NotConnectedMoney";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, NotConnectedMoney);

        NotConnectedMoneyDesert = 0;
        strUpgradeTotalCount = "NotConnectedMoneyDesert";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, NotConnectedMoneyDesert);

        NotConnectedMoneyIce = 0;
        strUpgradeTotalCount = "NotConnectedMoneyIce";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, NotConnectedMoneyIce);

        NotConnectedMoneyForest = 0;
        strUpgradeTotalCount = "NotConnectedMoneyForest";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, NotConnectedMoneyForest);



        DrillBuffPower = 0;
        strUpgradeTotalCount = "DrillBuffPower";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, DrillBuffPower);
        SaleBuffPower = 0;
        strUpgradeTotalCount = "SaleBuffPower";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, SaleBuffPower);

        buffBuffPower = 0;
        strUpgradeTotalCount = "buffBuffPower";
        PlayerPrefs.SetFloat(strUpgradeTotalCount, buffBuffPower);

        isAutoSellPotion = 0;
        strUpgradeTotalCount = "isAutoSellPotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellPotion);

        isAutoSellPotionDesert = 0;
        strUpgradeTotalCount = "isAutoSellPotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellPotionDesert);

        isAutoSellPotionIce = 0;
        strUpgradeTotalCount = "isAutoSellPotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellPotionIce);

        isAutoSellPotionForest = 0;
        strUpgradeTotalCount = "isAutoSellPotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellPotionForest);


        isAutoSellDoublePotion = 0;
        strUpgradeTotalCount = "isAutoSellDoublePotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellDoublePotion);

        isAutoSellDoublePotionDesert = 0;
        strUpgradeTotalCount = "isAutoSellDoublePotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellDoublePotionDesert);

        isAutoSellDoublePotionIce = 0;
        strUpgradeTotalCount = "isAutoSellDoublePotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellDoublePotionIce);

        isAutoSellDoublePotionForest = 0;
        strUpgradeTotalCount = "isAutoSellDoublePotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isAutoSellDoublePotionForest);




        isDrillPotion = 0;
        strUpgradeTotalCount = "isDrillPotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotion);
        isSalePotion = 0;
        strUpgradeTotalCount = "isSalePotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotion);
        isMiningPotion = 0;
        strUpgradeTotalCount = "isMiningPotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotion);
        isBuffPotion = 0;
        strUpgradeTotalCount = "isBuffPotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotion);
        isZzangPotion = 0;
        strUpgradeTotalCount = "isZzangPotion";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotion);

        isDrillPotionDouble = 0;
        strUpgradeTotalCount = "isDrillPotionDouble";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionDouble);
        isSalePotionDouble = 0;
        strUpgradeTotalCount = "isSalePotionDouble";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionDouble);
        isMiningPotionDouble = 0;
        strUpgradeTotalCount = "isMiningPotionDouble";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionDouble);
        isBuffPotionDouble = 0;
        strUpgradeTotalCount = "isBuffPotionDouble";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionDouble);
        isZzangPotionDouble = 0;
        strUpgradeTotalCount = "isZzangPotionDouble";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionDouble);


        isDrillPotionDesert = 0;
        strUpgradeTotalCount = "isDrillPotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionDesert);
        isSalePotionDesert = 0;
        strUpgradeTotalCount = "isSalePotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionDesert);
        isMiningPotionDesert = 0;
        strUpgradeTotalCount = "isMiningPotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionDesert);
        isBuffPotionDesert = 0;
        strUpgradeTotalCount = "isBuffPotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionDesert);
        isZzangPotionDesert = 0;
        strUpgradeTotalCount = "isZzangPotionDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionDesert);

        isDrillPotionDoubleDesert = 0;
        strUpgradeTotalCount = "isDrillPotionDoubleDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionDoubleDesert);
        isSalePotionDoubleDesert = 0;
        strUpgradeTotalCount = "isSalePotionDoubleDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionDoubleDesert);
        isMiningPotionDoubleDesert = 0;
        strUpgradeTotalCount = "isMiningPotionDoubleDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionDoubleDesert);
        isBuffPotionDoubleDesert = 0;
        strUpgradeTotalCount = "isBuffPotionDoubleDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionDoubleDesert);
        isZzangPotionDoubleDesert = 0;
        strUpgradeTotalCount = "isZzangPotionDoubleDesert";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionDoubleDesert);


        isDrillPotionIce = 0;
        strUpgradeTotalCount = "isDrillPotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionIce);
        isSalePotionIce = 0;
        strUpgradeTotalCount = "isSalePotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionIce);
        isMiningPotionIce = 0;
        strUpgradeTotalCount = "isMiningPotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionIce);
        isBuffPotionIce = 0;
        strUpgradeTotalCount = "isBuffPotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionIce);
        isZzangPotionIce = 0;
        strUpgradeTotalCount = "isZzangPotionIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionIce);

        isDrillPotionDoubleIce = 0;
        strUpgradeTotalCount = "isDrillPotionDoubleIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionDoubleIce);
        isSalePotionDoubleIce = 0;
        strUpgradeTotalCount = "isSalePotionDoubleIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionDoubleIce);
        isMiningPotionDoubleIce = 0;
        strUpgradeTotalCount = "isMiningPotionDoubleIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionDoubleIce);
        isBuffPotionDoubleIce = 0;
        strUpgradeTotalCount = "isBuffPotionDoubleIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionDoubleIce);
        isZzangPotionDoubleIce = 0;
        strUpgradeTotalCount = "isZzangPotionDoubleIce";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionDoubleIce);


        isDrillPotionForest = 0;
        strUpgradeTotalCount = "isDrillPotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionForest);
        isSalePotionForest = 0;
        strUpgradeTotalCount = "isSalePotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionForest);
        isMiningPotionForest = 0;
        strUpgradeTotalCount = "isMiningPotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionForest);
        isBuffPotionForest = 0;
        strUpgradeTotalCount = "isBuffPotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionForest);
        isZzangPotionForest = 0;
        strUpgradeTotalCount = "isZzangPotionForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionForest);

        isDrillPotionDoubleForest = 0;
        strUpgradeTotalCount = "isDrillPotionDoubleForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isDrillPotionDoubleForest);
        isSalePotionDoubleForest = 0;
        strUpgradeTotalCount = "isSalePotionDoubleForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isSalePotionDoubleForest);
        isMiningPotionDoubleForest = 0;
        strUpgradeTotalCount = "isMiningPotionDoubleForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isMiningPotionDoubleForest);
        isBuffPotionDoubleForest = 0;
        strUpgradeTotalCount = "isBuffPotionDoubleForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isBuffPotionDoubleForest);
        isZzangPotionDoubleForest = 0;
        strUpgradeTotalCount = "isZzangPotionDoubleForest";
        PlayerPrefs.SetInt(strUpgradeTotalCount, isZzangPotionDoubleForest);

        for (int i=0; i< 33; i++)
        {
            int index = i + 1;
            string strCombi = "Combi" + index;
            CombinationStatus.Add(0);
            PlayerPrefs.SetInt(strCombi, CombinationStatus[i]);

            strCombi = "CombiPos" + index;
            CombinationStatusPos.Add(0);
            PlayerPrefs.SetInt(strCombi, CombinationStatusPos[i]);


            strCombi = "CombiNormal" + index;
            CombinationStatusNormal.Add(0);
            PlayerPrefs.SetInt(strCombi, CombinationStatusNormal[i]);

            strCombi = "CombiPosNormal" + index;
            CombinationStatusPosNormal.Add(0);
            PlayerPrefs.SetInt(strCombi, CombinationStatusPosNormal[i]);


            strCombi = "CombiDesert" + index;
            CombinationStatusDesert.Add(0);
            PlayerPrefs.SetInt(strCombi, CombinationStatusDesert[i]);

            strCombi = "CombiPosDesert" + index;
            CombinationStatusPosDesert.Add(0);
            PlayerPrefs.SetInt(strCombi, CombinationStatusPosDesert[i]);

            strCombi = "CombiIce" + index;
            CombinationStatusIce.Add(0);
            PlayerPrefs.SetInt(strCombi, CombinationStatusIce[i]);

            strCombi = "CombiPosIce" + index;
            CombinationStatusPosIce.Add(0);
            PlayerPrefs.SetInt(strCombi, CombinationStatusPosIce[i]);

            strCombi = "CombiForest" + index;
            CombinationStatus.Add(0);
            PlayerPrefs.SetInt(strCombi, CombinationStatus[i]);

            strCombi = "CombiPosForest" + index;
            CombinationStatusPosForest.Add(0);
            PlayerPrefs.SetInt(strCombi, CombinationStatusPosForest[i]);

            strCombi = "Collection" + index;
            CollectionStatus.Add(0);
            PlayerPrefs.SetInt(strCombi, CollectionStatus[i]);


            strCombi = "QuestComplete" + index;
            QuestCompleteIndex.Add(0);
            PlayerPrefs.SetInt(strCombi, QuestCompleteIndex[i]);

            strCombi = "Questing" + index;
            QuestingCount.Add(0);
            PlayerPrefs.SetInt(strCombi, QuestingCount[i]);
        }
        for(int i=0; i< 200; i++)
        {
            int index = i + 1;
            string strHireCount = "RobotNormal" + index;
            RobotNormal.Add(0);  
            PlayerPrefs.SetInt(strHireCount, RobotNormal[RobotNormal.Count - 1]);

            strHireCount = "RobotDesert" + index;
            RobotDesert.Add(0);
            PlayerPrefs.SetInt(strHireCount, RobotDesert[RobotDesert.Count - 1]);

            strHireCount = "RobotIce" + index;
            RobotIce.Add(0);
            PlayerPrefs.SetInt(strHireCount, RobotIce[RobotIce.Count - 1]);

            strHireCount = "RobotForest" + index;
            RobotForest.Add(0);
            PlayerPrefs.SetInt(strHireCount, RobotForest[RobotForest.Count - 1]);
        }
        for(int i=0; i <6; i++)
        {
            int index = i + 1;
            string strHireCount = "KingMineralMiners" + index;
            KingMineralMiners[i] = 0;
            PlayerPrefs.SetInt(strHireCount, KingMineralMiners[i]);
        }
        for (int i = 0; i < 110; i++)
        {
            int index = i + 1;
            string strHireCount = "HireCount" +index;

            string strHireDesertCount = "HireCount" + index;
            string strHireIceCount = "HireCount" + index;
            string strHireForestCount = "HireCount" + index;

            string strHireLevel = "HireLevel" +index;
            string strHireCardCount = "HireCardCount"+index;

            string MoneyCount = "Money" + index;

            string strCapacityNow = "Capacity" + index;
            string strSkill = "Skill" + i;   

            MinerSkillIndex.Add(0);
            ListCapacityNow.Add(0);

            ListMoney.Add(0);
            ListHireCount.Add(0);

            ListHireDesertCount.Add(0);
            ListHireIceCount.Add(0);
            ListHireForestCount.Add(0);


            PlayerPrefs.SetInt(strSkill, MinerSkillIndex[i]);
            PlayerPrefs.SetFloat(strCapacityNow, (float)ListCapacityNow[ListCapacityNow.Count - 1]);
            PlayerPrefs.SetFloat(MoneyCount, (float)ListMoney[ListMoney.Count - 1]);
            PlayerPrefs.SetInt(strHireCount, ListHireCount[ListHireCount.Count-1]);

            PlayerPrefs.SetInt(strHireDesertCount, ListHireDesertCount[ListHireDesertCount.Count - 1]);
            PlayerPrefs.SetInt(strHireIceCount, ListHireIceCount[ListHireIceCount.Count - 1]);
            PlayerPrefs.SetInt(strHireForestCount, ListHireForestCount[ListHireForestCount.Count - 1]);

            ListHireCardBuyCount.Add(0);
            ListHireLevel.Add(1);
            PlayerPrefs.SetInt(strHireLevel, ListHireLevel[ListHireLevel.Count - 1]);

            ListHireCardOwnCount.Add(0);
            PlayerPrefs.SetInt(strHireCardCount, ListHireCardOwnCount[ListHireCardOwnCount.Count - 1]);

            ListbStartMineralAnim.Add(false);
        }
        for(int i=0; i<= 28; i++)
        {
            string strMiniQuest = "MiniQuest" + i;
            MiniQuestIndex.Add(0);
            PlayerPrefs.SetFloat(strMiniQuest, MiniQuestIndex[i]);
            PlayerPrefs.Save();
        }
        for (int i = 0; i < 9; i++)
        {
            string strMiniQuest = "MainTutorial" + i;
            MainTutorialList.Add(0);
            PlayerPrefs.SetFloat(strMiniQuest, MainTutorialList[i]);
            PlayerPrefs.Save();
        }

        PlayerPrefs.Save();


        Init();
        {
            MinerClass m = new MinerClass(1, 1, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 2, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 3, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 58, 1, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 4, 2, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 5, 2, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 6, 2, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 59, 2, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 7, 3, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 8, 3, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 60, 3, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 69, 3, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(2, 70, 4, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 9, 4, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 10, 4, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 61, 4, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 11, 5, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 12, 5, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 71, 5, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(3, 89, 5, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 13, 6, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 14, 6, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 15, 6, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 79, 6, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 16, 7, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 17, 7, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 18, 7, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 72, 7, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 19, 8, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 20, 8, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 21, 8, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 80, 8, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(4, 78, 9, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 22, 9, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 23, 9, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 24, 10, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 25, 10, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 26, 10, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 27, 11, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 28, 11, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 63, 11, 0, 5, 0);
            ListMinerClass.Add(m);



            m = new MinerClass(1, 62, 12, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(3, 91, 12, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 29, 13, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 93, 13, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 30, 14, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 73, 14, 0, 5, 0);
            ListMinerClass.Add(m);



            m = new MinerClass(1, 31, 15, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(3, 92, 15, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 64, 16, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 82, 16, 0, 5, 0);
            ListMinerClass.Add(m);



            m = new MinerClass(1, 32, 17, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 33, 17, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 34, 18, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 81, 18, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 35, 19, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 36, 19, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(2, 74, 20, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 75, 20, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 37, 20, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(3, 90, 21, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 65, 21, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 38, 22, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 39, 22, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 76, 22, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 40, 23, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 84, 23, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 41, 24, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 66, 24, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(3, 94, 24, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 42, 25, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 85, 25, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(2, 43, 26, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 83, 26, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(1, 44, 27, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(2, 77, 27, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(2, 45, 28, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(2, 46, 29, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(2, 47, 30, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(2, 48, 31, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(3, 95, 31, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(1, 67, 32, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(3, 49, 33, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(3, 50, 34, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(4, 86, 34, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(4, 87, 35, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(4, 51, 36, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 68, 37, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(4, 52, 38, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(4, 53, 39, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(4, 88, 40, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 54, 41, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(3, 55, 42, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(3, 96, 43, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 56, 44, 0, 5, 0);
            ListMinerClass.Add(m);

            m = new MinerClass(1, 57, 45, 0, 5, 0);
            ListMinerClass.Add(m);


            m = new MinerClass(-1, 97, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 98, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 99, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 100, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 101, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 102, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 103, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 104, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 105, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 106, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 107, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 108, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 109, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m = new MinerClass(-1, 110, 1, 0, 5, 0);
            ListMinerClass.Add(m);
            m.m_cost = Mathf.Pow(m.m_basProfit, (float)(ListHireCardOwnCount[0] * ListHireCost[0]));


        }
        //1 채굴량 2 채굴스피드 3 드릴파워 4 판매량
        //SupporterClass s = new SupporterClass();
        //ListMinerClass.Add(s);
        SceneManager.LoadScene("Intro");

    }

    public void AddDebug()
    {      
        HoitStoneCount += 10000;
        SIS.DBManager dbManager = GetComponent<SIS.DBManager>();
        SIS.DBManager.IncreaseFunds("blackcoin", 10000);
        Money += 1000;
        PlayerPrefs.SetInt("HoitStoneCount", HoitStoneCount);
        PlayerPrefs.SetFloat("Money", (float)Money);
        PlayerPrefs.Save();
        iAdsDailyCount = 0;
        IceKey = 1;
        DesertKey = 1;
        ForestKey = 1;


        Semiconductor1 += 5000;
        Semiconductor2 += 5000;
        Semiconductor3 += 5000;
        Semiconductor4 += 5000;

        string strUpgradeTotalCount;
        strUpgradeTotalCount = "Semiconductor1";
        PlayerPrefs.SetInt(strUpgradeTotalCount, Semiconductor1);

        strUpgradeTotalCount = "Semiconductor2";
        PlayerPrefs.SetInt(strUpgradeTotalCount, Semiconductor2);

        strUpgradeTotalCount = "Semiconductor4";
        PlayerPrefs.SetInt(strUpgradeTotalCount, Semiconductor3);

        strUpgradeTotalCount = "Semiconductor4";
        PlayerPrefs.SetInt(strUpgradeTotalCount, Semiconductor4);


        strUpgradeTotalCount = "DesertKey";
        PlayerPrefs.SetInt(strUpgradeTotalCount, DesertKey);
        strUpgradeTotalCount = "IceKey";
         PlayerPrefs.SetInt(strUpgradeTotalCount, IceKey);
        strUpgradeTotalCount = "ForestKey";
         PlayerPrefs.SetInt(strUpgradeTotalCount, ForestKey);

        PlayerPrefs.Save();
        for (int i=0; i< ListHireCount.Count; i++)
        {
            int index = i + 1;
            ListHireCount[i] = 1;
            string tempstr = "HireCount" + index;
            PlayerPrefs.SetInt(tempstr, ListHireCount[i]);
            PlayerPrefs.Save();
        }   

    }
    private void Start()
    {
       

    }

    public string GetThousandCommaText(double data)
    {
        return string.Format("{0:#,###}", data);
    }

    private void Init()
    {

        EventDepthNormal.Add(4);
        EventDepthNormal.Add(6);
        EventDepthNormal.Add(8);
        EventDepthNormal.Add(12);
        EventDepthNormal.Add(15);
        EventDepthNormal.Add(25);
        EventDepthNormal.Add(35);

        EventDepthDesert.Add(3);
        EventDepthDesert.Add(5);
        EventDepthDesert.Add(8);
        EventDepthDesert.Add(10);
        EventDepthDesert.Add(15);
        EventDepthDesert.Add(20);
        EventDepthDesert.Add(23);
        EventDepthDesert.Add(25);
        EventDepthDesert.Add(29);

        EventDepthIce.Add(3);
        EventDepthIce.Add(6);
        EventDepthIce.Add(10);
        EventDepthIce.Add(15);
        EventDepthIce.Add(21);
        EventDepthIce.Add(23);
        EventDepthIce.Add(30);

        EventDepthForest.Add(3);
        EventDepthForest.Add(6);
        EventDepthForest.Add(9);
        EventDepthForest.Add(13);
        EventDepthForest.Add(16);
        EventDepthForest.Add(19);
        EventDepthForest.Add(25);


        GhostLegCount = 0;
        LottoCount = 0;
        SpinwheelCount = 0;

        Depth = 1;
        DesertDepth = 1;
        ForestDepth = 1;
        IceDepth = 1;

        BlackCoinCount = 0;
        HoitStoneCount = 0;
        GodStoneCount = 0;
        for (int i=1; i<= 7;i++)
        {
            string strRibbon = "Ribbon" +i;
            string strLvTest = "LvTest" + i;
            string strHome = "ImgHome" + i;
            if(i < 5)
            {
                listMinerHomeIndex.Add(MinerStatusViewObj.transform.Find(strHome).gameObject);
            }
            if(i < 8)
            {
                listMinerStatusRibbon.Add(MinerStatusViewObj.transform.Find(strRibbon).gameObject);                
            }
            if(i < 7)
                listMinerStatusLv.Add(MinerStatusViewObj.transform.Find(strLvTest).gameObject);
            else
            {
                listMinerStatusLv.Add(MinerStatusViewObj.transform.Find(strLvTest).gameObject);
            }
        }
        ExpNow = 0;
        ExpNowDesert = 0;
        ExpNowForest = 0;
        ExpNowIce = 0;

        Color lvColor;
        lvColor.r = 0; lvColor.g = 0; lvColor.b = 0; lvColor.a = 0.58f;
        lvColorList.Add(lvColor);

        lvColor.r = 0.39f; lvColor.g = 0.39f; lvColor.b = 0.39f; lvColor.a = 0.58f;
        lvColorList.Add(lvColor);

        lvColor.r = 0.39f; lvColor.g = 0.78f; lvColor.b = 0.39f; lvColor.a = 0.58f;
        lvColorList.Add(lvColor);

        lvColor.r = 0; lvColor.g = 0.58f; lvColor.b = 1f; lvColor.a = 0.58f;
        lvColorList.Add(lvColor);

        lvColor.r = 0.58f; lvColor.g = 0; lvColor.b = 1f; lvColor.a = 0.58f;
        lvColorList.Add(lvColor);

        lvColor.r = 1; lvColor.g = 0; lvColor.b = 1f; lvColor.a = 0.58f;
        lvColorList.Add(lvColor);

        lvColor.r = 1; lvColor.g = 0; lvColor.b = 0; lvColor.a = 0.58f;
        lvColorList.Add(lvColor);

        ListEnginePower.Add(1) ;
        ListEnginePower.Add(2);
        ListEnginePower.Add(5);
        ListEnginePower.Add(30);
        ListEnginePower.Add(260);
        ListEnginePower.Add(610);
        ListEnginePower.Add(1000);
        ListEnginePower.Add(4000);
        ListEnginePower.Add(6500);
        ListEnginePower.Add(13000);
        ListEnginePower.Add(40000);
        ListEnginePower.Add(245000);
        ListEnginePower.Add(2450000);
        ListEnginePower.Add(24500000);
        ListEnginePower.Add(245000000);
        ListEnginePower.Add(1);
        ListEnginePower.Add(1);
        ListEnginePower.Add(1);

        ListBitPower.Add(2);
        ListBitPower.Add(3);
        ListBitPower.Add(15);
        ListBitPower.Add(50);
        ListBitPower.Add(300);
        ListBitPower.Add(700);
        ListBitPower.Add(1500);
        ListBitPower.Add(5500);
        ListBitPower.Add(9000);
        ListBitPower.Add(20000);
        ListBitPower.Add(40000);
        ListBitPower.Add(100000);
        ListBitPower.Add(1000000);
        ListBitPower.Add(10000000);
        ListBitPower.Add(100000000);
        ListBitPower.Add(1);
        ListBitPower.Add(1);
        ListBitPower.Add(1);


        listMaxCapacity.Add(1500);
        //listMaxCapacity.Add(1000000000);
        listMaxCapacity.Add(3000);
        listMaxCapacity.Add(4500);
        listMaxCapacity.Add(7000);
        listMaxCapacity.Add(20000);
        listMaxCapacity.Add(50000);
        listMaxCapacity.Add(150000);
        listMaxCapacity.Add(300000);
        listMaxCapacity.Add(600000);
        listMaxCapacity.Add(1000000);
        listMaxCapacity.Add(2000000);
        listMaxCapacity.Add(4000000);
        listMaxCapacity.Add(10000000);
        listMaxCapacity.Add(50000000);
        listMaxCapacity.Add(100000000);
        listMaxCapacity.Add(500000000);
        listMaxCapacity.Add(1000000000);
        listMaxCapacity.Add(0);
        listMaxCapacity.Add(0);
        listMaxCapacity.Add(0);
        listMaxCapacity.Add(0);


        for(int i =0; i <20; i++)
        {
            listOwnMinerals.Add(0);

            listOwnNoramlMinerals.Add(0);
            listOwnDesertMinerals.Add(0);
            listOwnIceMinerals.Add(0);
            listOwnForestMinerals.Add(0);

            
        }
        //1
        EquipmentCost.Add(3.0E-15);
        EquipmentCost.Add(5.0E-15);
        EquipmentHoitStoneCost.Add(0);
        EquipmentHoitStoneCost.Add(0);

        //2
        EquipmentCost.Add(4.0E-13);
        EquipmentCost.Add(6.5E-13);
        EquipmentHoitStoneCost.Add(0);
        EquipmentHoitStoneCost.Add(0);
        //3
        EquipmentCost.Add(3.0E-11);
        EquipmentCost.Add(4.0E-11);
        EquipmentHoitStoneCost.Add(5);
        EquipmentHoitStoneCost.Add(5);
        //4
        EquipmentCost.Add(2.0E-10);
        EquipmentCost.Add(4.0E-10);
        EquipmentHoitStoneCost.Add(20);
        EquipmentHoitStoneCost.Add(20);
        //5
        EquipmentCost.Add(2.0E-9);
        EquipmentCost.Add(5.5E-8);
        EquipmentHoitStoneCost.Add(50);
        EquipmentHoitStoneCost.Add(50);

        EquipmentCost.Add(9.5E-7);
        EquipmentCost.Add(7.5E-6);
        EquipmentHoitStoneCost.Add(150);
        EquipmentHoitStoneCost.Add(150);

        EquipmentCost.Add(8.0E-5);
        EquipmentCost.Add(5.0E-4);
        EquipmentHoitStoneCost.Add(300);
        EquipmentHoitStoneCost.Add(300);

        EquipmentCost.Add(0.015f);
        EquipmentCost.Add(0.15f);
        EquipmentHoitStoneCost.Add(400);
        EquipmentHoitStoneCost.Add(400);

        EquipmentCost.Add(3.5f);
        EquipmentCost.Add(13.5f);
        EquipmentHoitStoneCost.Add(700);
        EquipmentHoitStoneCost.Add(700);

        EquipmentCost.Add(115f);
        EquipmentCost.Add(5100f);
        EquipmentHoitStoneCost.Add(1520);
        EquipmentHoitStoneCost.Add(1520);

        EquipmentCost.Add(55000);
        EquipmentCost.Add(150000);
        EquipmentHoitStoneCost.Add(7000);
        EquipmentHoitStoneCost.Add(7000);

        EquipmentCost.Add(3500000);
        EquipmentCost.Add(235000000);
        EquipmentHoitStoneCost.Add(15000);
        EquipmentHoitStoneCost.Add(15000);

        EquipmentCost.Add(2350000000);
        EquipmentCost.Add(1235000000);
        EquipmentHoitStoneCost.Add(45000);
        EquipmentHoitStoneCost.Add(45000);

        EquipmentCost.Add(90000000000);
        EquipmentCost.Add(590000000000);
        EquipmentHoitStoneCost.Add(100000);
        EquipmentHoitStoneCost.Add(100000);



        //1
        DefaulteEquipmentCost.Add(3.0E-15);
        DefaulteEquipmentCost.Add(5.0E-15);
        DefaultEquipmentHoitStoneCost.Add(0);
        DefaultEquipmentHoitStoneCost.Add(0);

        //2
        DefaulteEquipmentCost.Add(4.0E-13);
        DefaulteEquipmentCost.Add(6.5E-13);
        DefaultEquipmentHoitStoneCost.Add(0);
        DefaultEquipmentHoitStoneCost.Add(0);
        //3
        DefaulteEquipmentCost.Add(3.0E-11);
        DefaulteEquipmentCost.Add(4.0E-11);
        DefaultEquipmentHoitStoneCost.Add(5);
        DefaultEquipmentHoitStoneCost.Add(5);
        //4
        DefaulteEquipmentCost.Add(2.0E-10);
        DefaulteEquipmentCost.Add(4.0E-10);
        DefaultEquipmentHoitStoneCost.Add(20);
        DefaultEquipmentHoitStoneCost.Add(20);
        //5
        DefaulteEquipmentCost.Add(2.0E-9);
        DefaulteEquipmentCost.Add(5.5E-8);
        DefaultEquipmentHoitStoneCost.Add(50);
        DefaultEquipmentHoitStoneCost.Add(50);

        DefaulteEquipmentCost.Add(9.5E-7);
        DefaulteEquipmentCost.Add(7.5E-6);
        DefaultEquipmentHoitStoneCost.Add(150);
        DefaultEquipmentHoitStoneCost.Add(150);

        DefaulteEquipmentCost.Add(8.0E-5);
        DefaulteEquipmentCost.Add(5.0E-4);
        DefaultEquipmentHoitStoneCost.Add(300);
        DefaultEquipmentHoitStoneCost.Add(300);

        DefaulteEquipmentCost.Add(0.015f);
        DefaulteEquipmentCost.Add(0.15f);
        DefaultEquipmentHoitStoneCost.Add(400);
        DefaultEquipmentHoitStoneCost.Add(400);

        DefaulteEquipmentCost.Add(3.5f);
        DefaulteEquipmentCost.Add(13.5f);
        DefaultEquipmentHoitStoneCost.Add(700);
        DefaultEquipmentHoitStoneCost.Add(700);

        DefaulteEquipmentCost.Add(115f);
        DefaulteEquipmentCost.Add(5100f);
        DefaultEquipmentHoitStoneCost.Add(1520);
        DefaultEquipmentHoitStoneCost.Add(1520);

        DefaulteEquipmentCost.Add(55000);
        DefaulteEquipmentCost.Add(150000);
        DefaultEquipmentHoitStoneCost.Add(7000);
        DefaultEquipmentHoitStoneCost.Add(7000);

        DefaulteEquipmentCost.Add(3500000);
        DefaulteEquipmentCost.Add(235000000);
        DefaultEquipmentHoitStoneCost.Add(15000);
        DefaultEquipmentHoitStoneCost.Add(15000);

        DefaulteEquipmentCost.Add(2350000000);
        DefaulteEquipmentCost.Add(1235000000);
        DefaultEquipmentHoitStoneCost.Add(45000);
        DefaultEquipmentHoitStoneCost.Add(45000);

        DefaulteEquipmentCost.Add(90000000000);
        DefaulteEquipmentCost.Add(590000000000);
        DefaultEquipmentHoitStoneCost.Add(100000);
        DefaultEquipmentHoitStoneCost.Add(100000);

        for (int i=0; i< 110; i++)
        {
            ListMoney.Add(0);
            //listMaxMinerCapacity.Add(50);
            ListCapacityNow.Add(0);

            eachMiningPower.Add(0);
            eachMiningSpeed.Add(0);
            eachSellPower.Add(0);
        }
        listMaxMinerCapacity.Add(50);
        listMaxMinerCapacity.Add(50);
        listMaxMinerCapacity.Add(75);
        listMaxMinerCapacity.Add(75);
        listMaxMinerCapacity.Add(100);
        listMaxMinerCapacity.Add(100);
        listMaxMinerCapacity.Add(120);
        listMaxMinerCapacity.Add(120);
        listMaxMinerCapacity.Add(120);
        listMaxMinerCapacity.Add(120);
        listMaxMinerCapacity.Add(140);
        listMaxMinerCapacity.Add(140);
        listMaxMinerCapacity.Add(140);
        listMaxMinerCapacity.Add(140);
        listMaxMinerCapacity.Add(160);
        listMaxMinerCapacity.Add(160);
        listMaxMinerCapacity.Add(160);
        listMaxMinerCapacity.Add(160);
        listMaxMinerCapacity.Add(180);
        listMaxMinerCapacity.Add(180);
        listMaxMinerCapacity.Add(200);
        listMaxMinerCapacity.Add(200);
        listMaxMinerCapacity.Add(200);
        listMaxMinerCapacity.Add(200);
        listMaxMinerCapacity.Add(200);
        listMaxMinerCapacity.Add(240);
        listMaxMinerCapacity.Add(240);
        listMaxMinerCapacity.Add(240);
        listMaxMinerCapacity.Add(240);
        listMaxMinerCapacity.Add(260);
        listMaxMinerCapacity.Add(260);
        listMaxMinerCapacity.Add(260);
        listMaxMinerCapacity.Add(380);
        listMaxMinerCapacity.Add(380);
        listMaxMinerCapacity.Add(380);
        listMaxMinerCapacity.Add(580);
        listMaxMinerCapacity.Add(500);
        listMaxMinerCapacity.Add(500);
        listMaxMinerCapacity.Add(700);
        listMaxMinerCapacity.Add(700);
        listMaxMinerCapacity.Add(720);
        listMaxMinerCapacity.Add(720);
        listMaxMinerCapacity.Add(720);
        listMaxMinerCapacity.Add(720);
        listMaxMinerCapacity.Add(720);
        listMaxMinerCapacity.Add(740);
        listMaxMinerCapacity.Add(740);
        listMaxMinerCapacity.Add(740);
        listMaxMinerCapacity.Add(840);
        listMaxMinerCapacity.Add(860);
        listMaxMinerCapacity.Add(860);
        listMaxMinerCapacity.Add(960);
        listMaxMinerCapacity.Add(980);
        listMaxMinerCapacity.Add(980);
        listMaxMinerCapacity.Add(980);
        listMaxMinerCapacity.Add(980);
        listMaxMinerCapacity.Add(1200);
        listMaxMinerCapacity.Add(1200);
        listMaxMinerCapacity.Add(1200);
        listMaxMinerCapacity.Add(1200);
        listMaxMinerCapacity.Add(1200);
        listMaxMinerCapacity.Add(1550);
        listMaxMinerCapacity.Add(1550);
        listMaxMinerCapacity.Add(1550);
        listMaxMinerCapacity.Add(1550);
        listMaxMinerCapacity.Add(1550);
        listMaxMinerCapacity.Add(1550);
        listMaxMinerCapacity.Add(1550);
        listMaxMinerCapacity.Add(1550);
        listMaxMinerCapacity.Add(2050);
        listMaxMinerCapacity.Add(2050);
        listMaxMinerCapacity.Add(2050);
        listMaxMinerCapacity.Add(2050);
        listMaxMinerCapacity.Add(2050);
        listMaxMinerCapacity.Add(2050);
        listMaxMinerCapacity.Add(2050);
        listMaxMinerCapacity.Add(2250);
        listMaxMinerCapacity.Add(2250);
        listMaxMinerCapacity.Add(2250);
        listMaxMinerCapacity.Add(2250);
        listMaxMinerCapacity.Add(2250);
        listMaxMinerCapacity.Add(2250);
        listMaxMinerCapacity.Add(2250);
        listMaxMinerCapacity.Add(2250);
        listMaxMinerCapacity.Add(2450);
        listMaxMinerCapacity.Add(2450);
        listMaxMinerCapacity.Add(2450);
        listMaxMinerCapacity.Add(2450);
        listMaxMinerCapacity.Add(2450);
        listMaxMinerCapacity.Add(2450);
        listMaxMinerCapacity.Add(2650);
        listMaxMinerCapacity.Add(2650);
        listMaxMinerCapacity.Add(2650);
        listMaxMinerCapacity.Add(2650);
        listMaxMinerCapacity.Add(2650);
        listMaxMinerCapacity.Add(2650);
        listMaxMinerCapacity.Add(5000);
        listMaxMinerCapacity.Add(6000);
        listMaxMinerCapacity.Add(6000);
        listMaxMinerCapacity.Add(6000);
        listMaxMinerCapacity.Add(8000);
        listMaxMinerCapacity.Add(2850);
        listMaxMinerCapacity.Add(10000);
        listMaxMinerCapacity.Add(5000);
        listMaxMinerCapacity.Add(5000);
        listMaxMinerCapacity.Add(2850);
        listMaxMinerCapacity.Add(2850);
        listMaxMinerCapacity.Add(2850);
        listMaxMinerCapacity.Add(2850);
        listMaxMinerCapacity.Add(3050);
        listMaxMinerCapacity.Add(3050);
        listMaxMinerCapacity.Add(3050);
        listMaxMinerCapacity.Add(3050);
        listMaxMinerCapacity.Add(3050);
        listMaxMinerCapacity.Add(3050);
        listMaxMinerCapacity.Add(3050);
        listMaxMinerCapacity.Add(2050);
        listMaxMinerCapacity.Add(12050);
        listMaxMinerCapacity.Add(12050);
        listMaxMinerCapacity.Add(12050);

        for(int i=0; i< listMaxMinerCapacity.Count; i++)
        {
            listMaxMinerCapacity[i] = listMaxMinerCapacity[i] * 5;
            listMaxMinerCapacityDefault.Add(listMaxMinerCapacity[i]);
        }

        //ListCostMinerals.Add(1);
        //ListCostMinerals.Add(2);
        //ListCostMinerals.Add(4);
        //ListCostMinerals.Add(20);
        //ListCostMinerals.Add(40);
        //ListCostMinerals.Add(120);
        //ListCostMinerals.Add(500);
        //ListCostMinerals.Add(1000);
        //ListCostMinerals.Add(2000);
        //ListCostMinerals.Add(5000);
        //ListCostMinerals.Add(10000);
        //ListCostMinerals.Add(50000);
        //ListCostMinerals.Add(100000);
        //ListCostMinerals.Add(500000);
        //ListCostMinerals.Add(1000000);
        //ListCostMinerals.Add(5000000);
        //ListCostMinerals.Add(10000000);
        //ListCostMinerals.Add(50000000);
        //ListCostMinerals.Add(100000000);
        //ListCostMinerals.Add(500000000);
        //ListCostMinerals.Add(800000000);
        //ListCostMinerals.Add(1000000000);
        //ListCostMinerals.Add(5000000000);
        //ListCostMinerals.Add(10000000000);
        //ListCostMinerals.Add(50000000000);
        //ListCostMinerals.Add(100000000000);
        //ListCostMinerals.Add(500000000000);
        //ListCostMinerals.Add(1000000000000);
        //ListCostMinerals.Add(5000000000000);
        //ListCostMinerals.Add(10000000000000);
        //ListCostMinerals.Add(50000000000000);
        //ListCostMinerals.Add(100000000000000);
        //ListCostMinerals.Add(500000000000000);
        //ListCostMinerals.Add(1000000000000000);
        //ListCostMinerals.Add(5000000000000000);
        //ListCostMinerals.Add(10000000000000000);
        //ListCostMinerals.Add(50000000000000000);
        //ListCostMinerals.Add(100000000000000000);

        ListCostMinerals.Add(0.000000000000000001f);
        ListCostMinerals.Add(0.000000000000000002f);
        ListCostMinerals.Add(0.000000000000000004f);
        ListCostMinerals.Add(0.00000000000000001f);
        ListCostMinerals.Add(0.00000000000000005f);
        ListCostMinerals.Add(0.0000000000000002f);
        ListCostMinerals.Add(0.0000000000000003f);
        ListCostMinerals.Add(0.0000000000000004f);
        ListCostMinerals.Add(0.0000000000000007f);
        ListCostMinerals.Add(0.000000000000001f);
        ListCostMinerals.Add(0.000000000000005f);
        ListCostMinerals.Add(0.00000000000003f);
        ListCostMinerals.Add(0.00000000000006f);
        ListCostMinerals.Add(0.00000000000009f);
        ListCostMinerals.Add(0.0000000000003f);
        ListCostMinerals.Add(0.0000000000007f);
        ListCostMinerals.Add(0.000000000001f);
        ListCostMinerals.Add(0.000000000005f);
        ListCostMinerals.Add(0.00000000002f);
        ListCostMinerals.Add(0.00000000006f);
        ListCostMinerals.Add(0.0000000001f);
        ListCostMinerals.Add(0.0000000005f);
        ListCostMinerals.Add(0.000000001f);
        ListCostMinerals.Add(0.000000005f);
        ListCostMinerals.Add(0.00000005f);
        ListCostMinerals.Add(0.00000009f);
        ListCostMinerals.Add(0.0000001f);
        ListCostMinerals.Add(0.0000008f);
        ListCostMinerals.Add(0.000001f);
        ListCostMinerals.Add(0.000007f);
        ListCostMinerals.Add(0.00001f);
        ListCostMinerals.Add(0.00006f);
        ListCostMinerals.Add(0.0001f);
        ListCostMinerals.Add(0.0005f);
        ListCostMinerals.Add(0.001f);
        ListCostMinerals.Add(0.005f);
        ListCostMinerals.Add(0.02f);
        ListCostMinerals.Add(0.05f);

        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);

        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);

        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);

        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);

        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);

        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);

        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);

        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);

        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);

        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);
        ListCostMinerals.Add(0.05f);

        iCapacityIndex = 0;
        CapacityNow = 0;

        iCapacityDesertIndex = 0;
        iCapacityIceIndex = 0;
        iCapacityForestIndex = 0;


        Money = 350* scaleFactor;

        DepthExp = new double[] {
            //0 1 2 3 4
            1,
            20, //20
            1000, //30
            5000, //40
            15000, //50
            30000, //60 //40000
            120000, //70
            2200000, //80
            4500000, //90
            5500000, //100
            5500000, //110
            50000000, //120
            16500000, //130
            30000000,//140
            50000000, //150
            500000000, //160
            500000000, //170
            500000000, //180
            500000000, //190
            2000000000, //200
            3000000000, //210
            3500000000, //220
            6000000000, //230
            7000000000, //240
            7000000000, //250
            10000000000, //260
            15000000000, //270
            15000000000, //280
            20000000000, //290
            20000000000, //300
            30000000000, //310
            30000000000, //320
            30000000000, //330
            30000000000, //340
            30000000000, //350
            60000000000, //360
            80000000000, //370
            100000000000, //380
            100000000000, //390
            200000000000, //400
            500000000000, //410
            500000000000, //420
            500000000000, //430
            500000000000, //440
            500000000000, //450
            1000000000000, //460
            1000000000000, //470
            1500000000000, //480
            2000000000000, //490
            2500000000000, //500
            5000000000000, //510
            10000000000000, //520 
            20000000000000, //530
            20000000000000, //540 
            40000000000000, //550
            100000000000000, //560
            200000000000000, //570
            200000000000000, //580
            200000000000000, //590
            400000000000000, //600
            500000000000000, //610
            500000000000000, //620
            600000000000000, //630
            700000000000000, //640
            800000000000000, //650            
            1000000000000000, //660
            2000000000000000,//670 
            4000000000000000,//680
            8000000000000000,//690
            9000000000000000000,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
            9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,9999999999999999999,
        };


        MinerStatusProgass = MinerStatusViewObj.transform.Find("PrograssBack").gameObject.transform.Find("Prograss").gameObject;
        MinerCapacityProgass = MinerStatusViewObj.transform.Find("PrograssCapBack").gameObject.transform.Find("Prograss").gameObject;
        MinerCapacityProgassBack =  MinerStatusViewObj.transform.Find("PrograssCapBack").gameObject;
        MinerCapacityProgassText = MinerStatusViewObj.transform.Find("PrograssCapBack").gameObject.transform.Find("Text").gameObject;
        TextBtnMoney = MinerStatusViewObj.transform.Find("BtnSell").gameObject.transform.Find("TextMoney").gameObject;
        TextMiningPower = TextBtnMoney.transform.Find("Text").gameObject;

        BtnSell = MinerStatusViewObj.transform.Find("BtnSell").gameObject;
        BtnBuff = MinerStatusViewObj.transform.Find("BtnBuff").gameObject;
        BtnBuffType0 = MinerStatusViewObj.transform.Find("BtnBuffType0").gameObject;


        Color _color = new Color();
        Color _colorOutline = new Color();

        _color.a = 1; _color.r = 0; _color.g = 0; _color.b = 0;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.53f; _color.g = 0.3f; _color.b = 0.24f;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.91f; _color.g = 0.91f; _color.b = 0.91f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.588f; _color.g = 0.588f; _color.b = 0.588f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 1; _color.g = 0.968f; _color.b = 0.223f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.458f; _color.g = 0.462f; _color.b = 0.466f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.533f; _color.g = 5 / 255; _color.b = 0.019f;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.549f; _color.g = 0.035f; _color.b = 0.294f;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 1; _color.g = 0.929f; _color.b = 0.168f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.07f; _color.g = 0.78f; _color.b =0.39f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.019f; _color.g = 0.11f; _color.b = 0.843f;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.98f; _color.g = 0.058f; _color.b = 0.058f;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.823f; _color.g = 0.9f; _color.b = 0.9f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.686f; _color.g = 0.647f; _color.b = 0.529f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.9f; _color.g = 0.27f; _color.b = 0;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.7f; _color.g = 0.862f; _color.b = 0.9f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.196f; _color.g = 0.196f; _color.b = 0.196f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        _color.a = 1; _color.r = 0.156f; _color.g = 0.274f; _color.b = 1;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //New Minerals
       // 0.78f 0.62f 0.5f  0
        _color.a = 1; _color.r =0.78f; _color.g = 0.62f; _color.b = 0.5f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.35f 0.47f 0.29f 0
        _color.a = 1; _color.r = 0.35f; _color.g = 0.47f; _color.b = 0.29f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.78f 0.5f 0.5f 0
        _color.a = 1; _color.r = 0.78f; _color.g = 0.5f; _color.b = 0.5f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.06f 0.14f 0.07f 1
        _color.a = 1; _color.r = 0.06f; _color.g = 0.14f; _color.b = 0.07f;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.13f 0.098f 0.098f 1
        _color.a = 1; _color.r = 0.13f; _color.g = 0.098f; _color.b = 0.098f;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.9f 0.9f 0.9f 0
        _color.a = 1; _color.r = 0.9f; _color.g = 0.9f; _color.b = 0;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.9f 0.78f 0.5f 0
        _color.a = 1; _color.r = 0.9f; _color.g = 0.78f; _color.b = 0;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.54f 0.9f 0.27f 0
        _color.a = 1; _color.r = 0.54f; _color.g = 0.9f; _color.b = 0;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.5f 0 0.27f 1
        _color.a = 1; _color.r = 0.5f; _color.g = 0.27f; _color.b = 1;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.98f 190 0.79f  0
        _color.a = 1; _color.r = 0.98f; _color.g = 0.74f; _color.b = 0.79f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.13f 0.13f 0.54f 1
        _color.a = 1; _color.r = 0.13f; _color.g = 0.13f; _color.b = 0.54f;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0 0.9f 0.7f 0
        _color.a = 1; _color.r = 0; _color.g = 0.9f; _color.b = 0.7f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.79f 0.43f 0.79f  0
        _color.a = 1; _color.r = 0.79f; _color.g = 0.43f; _color.b = 0.79f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //1 1 1 0
        _color.a = 1; _color.r = 1; _color.g = 1; _color.b = 1;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0 0.5f 1 0
        _color.a = 1; _color.r = 0; _color.g = 0.5f; _color.b = 1;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.5f 0.88f 0.078f 0
        _color.a = 1; _color.r = 0.5f; _color.g = 0.88f; _color.b = 0.078f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //1 0.49f 0 0
        _color.a = 1; _color.r = 0; _color.g = 0.49f; _color.b = 0;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.23f 0 0.47f 1
        _color.a = 1; _color.r = 0.23f; _color.g = 0; _color.b = 0.47f;
        _colorOutline.a = 1; _colorOutline.r = 1; _colorOutline.g = 1; _colorOutline.b = 1;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //1 0.078f 0.23f 0
        _color.a = 1; _color.r = 1; _color.g = 0.079f; _color.b = 0.23f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        //0.47f 0.66f 0.5f 0
        _color.a = 1; _color.r = 0.47f; _color.g = 0.66f; _color.b = 0.5f;
        _colorOutline.a = 1; _colorOutline.r = 0; _colorOutline.g = 0; _colorOutline.b = 0;
        listTextColor.Add(_color);
        listTextOutlineColor.Add(_colorOutline);

        UniqueMinerList.Clear();
        UniqueMinerList.Add(104);
        UniqueMinerList.Add(96);
        UniqueMinerList.Add(97);
        UniqueMinerList.Add(98);
        UniqueMinerList.Add(99);
        UniqueMinerList.Add(103);
        UniqueMinerList.Add(100);
        UniqueMinerList.Add(102);
        UniqueMinerList.Add(101);
        UniqueMinerList.Add(105);
        UniqueMinerList.Add(106);
        UniqueMinerList.Add(107);
        UniqueMinerList.Add(108);
        UniqueMinerList.Add(109);

        UniqueMinerBuffTypeList.Clear();
        UniqueMinerBuffTypeList.Add("1.5");
        UniqueMinerBuffTypeList.Add("1.8");
        UniqueMinerBuffTypeList.Add("1.9");
        UniqueMinerBuffTypeList.Add("2.6");
        UniqueMinerBuffTypeList.Add("2.9");
        UniqueMinerBuffTypeList.Add("2.12");
        UniqueMinerBuffTypeList.Add("3.4");
        UniqueMinerBuffTypeList.Add("3.8");
        UniqueMinerBuffTypeList.Add("4.4");
        UniqueMinerBuffTypeList.Add("4.8");
        UniqueMinerBuffTypeList.Add("5.6");
        UniqueMinerBuffTypeList.Add("5.8");
        UniqueMinerBuffTypeList.Add("6.5");
        UniqueMinerBuffTypeList.Add("6.8");

        ListHireCostDefault.Add(1.0E-17);
        ListHireCostDefault.Add(5.0E-17);
        ListHireCostDefault.Add(1.0E-16);
        ListHireCostDefault.Add(1.5E-16);
        ListHireCostDefault.Add(4.5E-16);
        ListHireCostDefault.Add(5.5E-16);
        ListHireCostDefault.Add(7.5E-16);
        ListHireCostDefault.Add(1.1E-15);
        ListHireCostDefault.Add(1.2E-15);
        ListHireCostDefault.Add(1.15E-14);
        ListHireCostDefault.Add(1.3E-14);
        ListHireCostDefault.Add(1.8E-14);
        ListHireCostDefault.Add(1.1E-14);
        ListHireCostDefault.Add(1.2E-14);
        ListHireCostDefault.Add(1.5E-14);
        ListHireCostDefault.Add(1.65E-14);
        ListHireCostDefault.Add(1.9E-14);
        ListHireCostDefault.Add(1.12E-13);
        ListHireCostDefault.Add(1.2E-13);
        ListHireCostDefault.Add(1.25E-13);
        ListHireCostDefault.Add(1.5E-13);
        ListHireCostDefault.Add(1.1E-12);
        ListHireCostDefault.Add(1.3E-12);
        ListHireCostDefault.Add(1.5E-12);
        ListHireCostDefault.Add(1.8E-12);
        ListHireCostDefault.Add(1.1E-11);
        ListHireCostDefault.Add(1.3E-11);
        ListHireCostDefault.Add(1.5E-11);
        ListHireCostDefault.Add(1.1E-11);
        ListHireCostDefault.Add(1.5E-11);
        ListHireCostDefault.Add(1.1E-11);
        ListHireCostDefault.Add(1.5E-11);
        ListHireCostDefault.Add(1.5E-10);
        ListHireCostDefault.Add(1.75E-09);
        ListHireCostDefault.Add(1.1E-09);
        ListHireCostDefault.Add(1.35E-09);
        ListHireCostDefault.Add(1.35E-09);
        ListHireCostDefault.Add(1.5E-08);
        ListHireCostDefault.Add(1.75E-08);
        ListHireCostDefault.Add(1.1E-07);
        ListHireCostDefault.Add(1.25E-07);
        ListHireCostDefault.Add(1.5E-07);
        ListHireCostDefault.Add(1.75E-07);
        ListHireCostDefault.Add(1.1E-06);
        ListHireCostDefault.Add(1.15E-06);
        ListHireCostDefault.Add(1.15E-05);
        ListHireCostDefault.Add(1.25E-05);
        ListHireCostDefault.Add(0.000135f);
        ListHireCostDefault.Add(0.001155f);
        ListHireCostDefault.Add(0.001255f);
        ListHireCostDefault.Add(0.001455f);
        ListHireCostDefault.Add(0.011155f);
        ListHireCostDefault.Add(0.012155f);
        ListHireCostDefault.Add(0.015555f);
        ListHireCostDefault.Add(0.11005f);
        ListHireCostDefault.Add(0.11005f);
        ListHireCostDefault.Add(0.51005f);
        ListHireCostDefault.Add(0.61005f);
        ListHireCostDefault.Add(0.71005f);
        ListHireCostDefault.Add(1);
        ListHireCostDefault.Add(1.5f);
        ListHireCostDefault.Add(1.5f);
        ListHireCostDefault.Add(2.5f);
        ListHireCostDefault.Add(2.5f);
        ListHireCostDefault.Add(5f);
        ListHireCostDefault.Add(7f);
        ListHireCostDefault.Add(10f);
        ListHireCostDefault.Add(15);
        ListHireCostDefault.Add(25);
        ListHireCostDefault.Add(40);
        ListHireCostDefault.Add(45);
        ListHireCostDefault.Add(100);
        ListHireCostDefault.Add(300);
        ListHireCostDefault.Add(350);
        ListHireCostDefault.Add(700);
        ListHireCostDefault.Add(750);
        ListHireCostDefault.Add(1000);
        ListHireCostDefault.Add(1500);
        ListHireCostDefault.Add(3000);
        ListHireCostDefault.Add(4500);
        ListHireCostDefault.Add(7000);
        ListHireCostDefault.Add(15000);
        ListHireCostDefault.Add(30000);
        ListHireCostDefault.Add(100000);
        ListHireCostDefault.Add(500000);
        ListHireCostDefault.Add(1500000);
        ListHireCostDefault.Add(3000000);
        ListHireCostDefault.Add(7000000);
        ListHireCostDefault.Add(15000000);
        ListHireCostDefault.Add(30000000);
        ListHireCostDefault.Add(60000000);
        ListHireCostDefault.Add(200000000);
        ListHireCostDefault.Add(500000000);
        ListHireCostDefault.Add(1000000000);
        ListHireCostDefault.Add(10000000000);
        ListHireCostDefault.Add(120);
        ListHireCostDefault.Add(120);
        ListHireCostDefault.Add(140);
        ListHireCostDefault.Add(160);
        ListHireCostDefault.Add(180);
        ListHireCostDefault.Add(140);
        ListHireCostDefault.Add(100);
        ListHireCostDefault.Add(150);
        ListHireCostDefault.Add(120);
        ListHireCostDefault.Add(100);
        ListHireCostDefault.Add(100);
        ListHireCostDefault.Add(100);
        ListHireCostDefault.Add(100);
        ListHireCostDefault.Add(100);
        ListHireCostDefault.Add(100);
        ListHireCostDefault.Add(1000000000000);
        ListHireCostDefault.Add(1000000000000);
        ListHireCostDefault.Add(1000000000000);
        ListHireCostDefault.Add(1000000000000);
        ListHireCostDefault.Add(1000000000000);
        ListHireCostDefault.Add(1000000000000);
        ListHireCostDefault.Add(1000000000000);
        ListHireCostDefault.Add(1000000000000);

        ListHireCost.Add(1.0E-17);
        ListHireCost.Add(5.0E-17);
        ListHireCost.Add(1.0E-16);
        ListHireCost.Add(1.5E-16);
        ListHireCost.Add(4.5E-16);
        ListHireCost.Add(5.5E-16);
        ListHireCost.Add(7.5E-16);
        ListHireCost.Add(1.1E-15);
        ListHireCost.Add(1.2E-15);
        ListHireCost.Add(1.15E-14);
        ListHireCost.Add(1.3E-14);
        ListHireCost.Add(1.8E-14);
        ListHireCost.Add(1.1E-14);
        ListHireCost.Add(1.2E-14);
        ListHireCost.Add(1.5E-14);
        ListHireCost.Add(1.65E-14);
        ListHireCost.Add(1.9E-14);
        ListHireCost.Add(1.12E-13);
        ListHireCost.Add(1.2E-13);
        ListHireCost.Add(1.25E-13);
        ListHireCost.Add(1.5E-13);
        ListHireCost.Add(1.1E-12);
        ListHireCost.Add(1.3E-12);
        ListHireCost.Add(1.5E-12);
        ListHireCost.Add(1.8E-12);
        ListHireCost.Add(1.1E-11);
        ListHireCost.Add(1.3E-11);
        ListHireCost.Add(1.5E-11);
        ListHireCost.Add(1.1E-11);
        ListHireCost.Add(1.5E-11);
        ListHireCost.Add(1.1E-11);
        ListHireCost.Add(1.5E-11);
        ListHireCost.Add(1.5E-10);
        ListHireCost.Add(1.75E-09);
        ListHireCost.Add(1.1E-09);
        ListHireCost.Add(1.35E-09);
        ListHireCost.Add(1.35E-09);
        ListHireCost.Add(1.5E-08);
        ListHireCost.Add(1.75E-08);
        ListHireCost.Add(1.1E-07);
        ListHireCost.Add(1.25E-07);
        ListHireCost.Add(1.5E-07);
        ListHireCost.Add(1.75E-07);
        ListHireCost.Add(1.1E-06);
        ListHireCost.Add(1.15E-06);
        ListHireCost.Add(1.15E-05);
        ListHireCost.Add(1.25E-05);
        ListHireCost.Add(0.000135f);
        ListHireCost.Add(0.001155f);
        ListHireCost.Add(0.001255f);
        ListHireCost.Add(0.001455f);
        ListHireCost.Add(0.011155f);
        ListHireCost.Add(0.012155f);
        ListHireCost.Add(0.015555f);
        ListHireCost.Add(0.11005f);
        ListHireCost.Add(0.11005f);
        ListHireCost.Add(0.51005f);
        ListHireCost.Add(0.61005f);
        ListHireCost.Add(0.71005f);
        ListHireCost.Add(1);
        ListHireCost.Add(1.5f);
        ListHireCost.Add(1.5f);
        ListHireCost.Add(2.5f);
        ListHireCost.Add(2.5f);
        ListHireCost.Add(5f);
        ListHireCost.Add(7f);
        ListHireCost.Add(10f);
        ListHireCost.Add(15);
        ListHireCost.Add(25);
        ListHireCost.Add(40);
        ListHireCost.Add(45);
        ListHireCost.Add(100);
        ListHireCost.Add(300);
        ListHireCost.Add(350);
        ListHireCost.Add(700);
        ListHireCost.Add(750);
        ListHireCost.Add(1000);
        ListHireCost.Add(1500);
        ListHireCost.Add(3000);
        ListHireCost.Add(4500);
        ListHireCost.Add(7000);
        ListHireCost.Add(15000);
        ListHireCost.Add(30000);
        ListHireCost.Add(100000);
        ListHireCost.Add(500000);
        ListHireCost.Add(1500000);
        ListHireCost.Add(3000000);
        ListHireCost.Add(7000000);
        ListHireCost.Add(15000000);
        ListHireCost.Add(30000000);
        ListHireCost.Add(60000000);
        ListHireCost.Add(200000000);
        ListHireCost.Add(500000000);
        ListHireCost.Add(1000000000);
        ListHireCost.Add(10000000000);
        ListHireCost.Add(120);
        ListHireCost.Add(120);
        ListHireCost.Add(140);
        ListHireCost.Add(160);
        ListHireCost.Add(180);
        ListHireCost.Add(140);
        ListHireCost.Add(100);
        ListHireCost.Add(150);
        ListHireCost.Add(120);
        ListHireCost.Add(100);
        ListHireCost.Add(100);
        ListHireCost.Add(100);
        ListHireCost.Add(100);
        ListHireCost.Add(100);
        ListHireCost.Add(100);
        ListHireCost.Add(1000000000000);
        ListHireCost.Add(1000000000000);
        ListHireCost.Add(1000000000000);
        ListHireCost.Add(1000000000000);
        ListHireCost.Add(1000000000000);
        ListHireCost.Add(1000000000000);
        ListHireCost.Add(1000000000000);
        ListHireCost.Add(1000000000000);

        ListMiningMax.Add(4);
        ListMiningMax.Add(4);
        ListMiningMax.Add(6);
        ListMiningMax.Add(6);
        ListMiningMax.Add(8);
        ListMiningMax.Add(10);
        ListMiningMax.Add(11);
        ListMiningMax.Add(12);
        ListMiningMax.Add(15);
        ListMiningMax.Add(16);
        ListMiningMax.Add(18);
        ListMiningMax.Add(20);
        ListMiningMax.Add(20);
        ListMiningMax.Add(22);
        ListMiningMax.Add(22);
        ListMiningMax.Add(24);
        ListMiningMax.Add(24);
        ListMiningMax.Add(24);
        ListMiningMax.Add(26);
        ListMiningMax.Add(26);
        ListMiningMax.Add(28);
        ListMiningMax.Add(30);
        ListMiningMax.Add(30);
        ListMiningMax.Add(32);
        ListMiningMax.Add(32);
        ListMiningMax.Add(35);
        ListMiningMax.Add(35);
        ListMiningMax.Add(45);
        ListMiningMax.Add(45);
        ListMiningMax.Add(50);
        ListMiningMax.Add(55);
        ListMiningMax.Add(55);
        ListMiningMax.Add(60);
        ListMiningMax.Add(60);
        ListMiningMax.Add(65);
        ListMiningMax.Add(65);
        ListMiningMax.Add(70);
        ListMiningMax.Add(75);
        ListMiningMax.Add(75);
        ListMiningMax.Add(80);
        ListMiningMax.Add(80);
        ListMiningMax.Add(120);
        ListMiningMax.Add(120);
        ListMiningMax.Add(140);
        ListMiningMax.Add(140);
        ListMiningMax.Add(150);
        ListMiningMax.Add(150);
        ListMiningMax.Add(170);
        ListMiningMax.Add(170);
        ListMiningMax.Add(180);
        ListMiningMax.Add(180);
        ListMiningMax.Add(200);
        ListMiningMax.Add(210);
        ListMiningMax.Add(210);
        ListMiningMax.Add(230);
        ListMiningMax.Add(230);
        ListMiningMax.Add(260);
        ListMiningMax.Add(4);
        ListMiningMax.Add(10);
        ListMiningMax.Add(4);
        ListMiningMax.Add(8);
        ListMiningMax.Add(35);
        ListMiningMax.Add(35);
        ListMiningMax.Add(40);
        ListMiningMax.Add(150);
        ListMiningMax.Add(160);
        ListMiningMax.Add(150);
        ListMiningMax.Add(250);
        ListMiningMax.Add(4);
        ListMiningMax.Add(6);
        ListMiningMax.Add(8);
        ListMiningMax.Add(15);
        ListMiningMax.Add(35);
        ListMiningMax.Add(35);
        ListMiningMax.Add(40);
        ListMiningMax.Add(85);
        ListMiningMax.Add(110);
        ListMiningMax.Add(8);
        ListMiningMax.Add(10);
        ListMiningMax.Add(15);
        ListMiningMax.Add(35);
        ListMiningMax.Add(8);
        ListMiningMax.Add(130);
        ListMiningMax.Add(135);
        ListMiningMax.Add(135);
        ListMiningMax.Add(185);
        ListMiningMax.Add(5);
        ListMiningMax.Add(185);
        ListMiningMax.Add(8);
        ListMiningMax.Add(65);
        ListMiningMax.Add(65);
        ListMiningMax.Add(26);
        ListMiningMax.Add(26);
        ListMiningMax.Add(90);
        ListMiningMax.Add(110);
        ListMiningMax.Add(100);
        ListMiningMax.Add(300);
        ListMiningMax.Add(300);
        ListMiningMax.Add(400);
        ListMiningMax.Add(500);
        ListMiningMax.Add(200);
        ListMiningMax.Add(6500);
        ListMiningMax.Add(250);
        ListMiningMax.Add(170);
        ListMiningMax.Add(150);
        ListMiningMax.Add(2);
        ListMiningMax.Add(2);
        ListMiningMax.Add(130);
        ListMiningMax.Add(130);
        ListMiningMax.Add(130);
        ListMiningMax.Add(130);
        ListMiningMax.Add(130);
        ListMiningMax.Add(130);


        ListMiningMaxDefault.Add(4);
        ListMiningMaxDefault.Add(4);
        ListMiningMaxDefault.Add(6);
        ListMiningMaxDefault.Add(6);
        ListMiningMaxDefault.Add(8);
        ListMiningMaxDefault.Add(10);
        ListMiningMaxDefault.Add(11);
        ListMiningMaxDefault.Add(12);
        ListMiningMaxDefault.Add(15);
        ListMiningMaxDefault.Add(16);
        ListMiningMaxDefault.Add(18);
        ListMiningMaxDefault.Add(20);
        ListMiningMaxDefault.Add(20);
        ListMiningMaxDefault.Add(22);
        ListMiningMaxDefault.Add(22);
        ListMiningMaxDefault.Add(24);
        ListMiningMaxDefault.Add(24);
        ListMiningMaxDefault.Add(24);
        ListMiningMaxDefault.Add(26);
        ListMiningMaxDefault.Add(26);
        ListMiningMaxDefault.Add(28);
        ListMiningMaxDefault.Add(30);
        ListMiningMaxDefault.Add(30);
        ListMiningMaxDefault.Add(32);
        ListMiningMaxDefault.Add(32);
        ListMiningMaxDefault.Add(35);
        ListMiningMaxDefault.Add(35);
        ListMiningMaxDefault.Add(45);
        ListMiningMaxDefault.Add(45);
        ListMiningMaxDefault.Add(50);
        ListMiningMaxDefault.Add(55);
        ListMiningMaxDefault.Add(55);
        ListMiningMaxDefault.Add(60);
        ListMiningMaxDefault.Add(60);
        ListMiningMaxDefault.Add(65);
        ListMiningMaxDefault.Add(65);
        ListMiningMaxDefault.Add(70);
        ListMiningMaxDefault.Add(75);
        ListMiningMaxDefault.Add(75);
        ListMiningMaxDefault.Add(80);
        ListMiningMaxDefault.Add(80);
        ListMiningMaxDefault.Add(120);
        ListMiningMaxDefault.Add(120);
        ListMiningMaxDefault.Add(140);
        ListMiningMaxDefault.Add(140);
        ListMiningMaxDefault.Add(150);
        ListMiningMaxDefault.Add(150);
        ListMiningMaxDefault.Add(170);
        ListMiningMaxDefault.Add(170);
        ListMiningMaxDefault.Add(180);
        ListMiningMaxDefault.Add(180);
        ListMiningMaxDefault.Add(200);
        ListMiningMaxDefault.Add(210);
        ListMiningMaxDefault.Add(210);
        ListMiningMaxDefault.Add(230);
        ListMiningMaxDefault.Add(230);
        ListMiningMaxDefault.Add(260);
        ListMiningMaxDefault.Add(4);
        ListMiningMaxDefault.Add(10);
        ListMiningMaxDefault.Add(4);
        ListMiningMaxDefault.Add(8);
        ListMiningMaxDefault.Add(35);
        ListMiningMaxDefault.Add(35);
        ListMiningMaxDefault.Add(40);
        ListMiningMaxDefault.Add(150);
        ListMiningMaxDefault.Add(160);
        ListMiningMaxDefault.Add(150);
        ListMiningMaxDefault.Add(250);
        ListMiningMaxDefault.Add(4);
        ListMiningMaxDefault.Add(6);
        ListMiningMaxDefault.Add(8);
        ListMiningMaxDefault.Add(15);
        ListMiningMaxDefault.Add(35);
        ListMiningMaxDefault.Add(35);
        ListMiningMaxDefault.Add(40);
        ListMiningMaxDefault.Add(85);
        ListMiningMaxDefault.Add(110);
        ListMiningMaxDefault.Add(8);
        ListMiningMaxDefault.Add(10);
        ListMiningMaxDefault.Add(15);
        ListMiningMaxDefault.Add(35);
        ListMiningMaxDefault.Add(8);
        ListMiningMaxDefault.Add(130);
        ListMiningMaxDefault.Add(135);
        ListMiningMaxDefault.Add(135);
        ListMiningMaxDefault.Add(185);
        ListMiningMaxDefault.Add(5);
        ListMiningMaxDefault.Add(185);
        ListMiningMaxDefault.Add(8);
        ListMiningMaxDefault.Add(65);
        ListMiningMaxDefault.Add(65);
        ListMiningMaxDefault.Add(26);
        ListMiningMaxDefault.Add(26);
        ListMiningMaxDefault.Add(90);
        ListMiningMaxDefault.Add(110);
        ListMiningMaxDefault.Add(100);
        ListMiningMaxDefault.Add(300);
        ListMiningMaxDefault.Add(300);
        ListMiningMaxDefault.Add(400);
        ListMiningMaxDefault.Add(500);
        ListMiningMaxDefault.Add(200);
        ListMiningMaxDefault.Add(6500);
        ListMiningMaxDefault.Add(250);
        ListMiningMaxDefault.Add(170);
        ListMiningMaxDefault.Add(150);
        ListMiningMaxDefault.Add(2);
        ListMiningMaxDefault.Add(2);
        ListMiningMaxDefault.Add(130);
        ListMiningMaxDefault.Add(130);
        ListMiningMaxDefault.Add(130);
        ListMiningMaxDefault.Add(130);
        ListMiningMaxDefault.Add(130);
        ListMiningMaxDefault.Add(130);


        ListMiningMin.Add(1);
        ListMiningMin.Add(1);
        ListMiningMin.Add(1);
        ListMiningMin.Add(1);
        ListMiningMin.Add(1);
        ListMiningMin.Add(3);
        ListMiningMin.Add(3);
        ListMiningMin.Add(3);
        ListMiningMin.Add(7);
        ListMiningMin.Add(7);
        ListMiningMin.Add(7);
        ListMiningMin.Add(8);
        ListMiningMin.Add(8);
        ListMiningMin.Add(10);
        ListMiningMin.Add(10);
        ListMiningMin.Add(10);
        ListMiningMin.Add(10);
        ListMiningMin.Add(10);
        ListMiningMin.Add(10);
        ListMiningMin.Add(10);
        ListMiningMin.Add(10);
        ListMiningMin.Add(20);
        ListMiningMin.Add(20);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(30);
        ListMiningMin.Add(30);
        ListMiningMin.Add(35);
        ListMiningMin.Add(35);
        ListMiningMin.Add(35);
        ListMiningMin.Add(40);
        ListMiningMin.Add(40);
        ListMiningMin.Add(45);
        ListMiningMin.Add(45);
        ListMiningMin.Add(45);
        ListMiningMin.Add(45);
        ListMiningMin.Add(50);
        ListMiningMin.Add(50);
        ListMiningMin.Add(50);
        ListMiningMin.Add(60);
        ListMiningMin.Add(60);
        ListMiningMin.Add(60);
        ListMiningMin.Add(80);
        ListMiningMin.Add(80);
        ListMiningMin.Add(80);
        ListMiningMin.Add(80);
        ListMiningMin.Add(80);
        ListMiningMin.Add(80);
        ListMiningMin.Add(80);
        ListMiningMin.Add(100);
        ListMiningMin.Add(100);
        ListMiningMin.Add(100);
        ListMiningMin.Add(1);
        ListMiningMin.Add(2);
        ListMiningMin.Add(1);
        ListMiningMin.Add(4);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(85);
        ListMiningMin.Add(65);
        ListMiningMin.Add(85);
        ListMiningMin.Add(100);
        ListMiningMin.Add(1);
        ListMiningMin.Add(2);
        ListMiningMin.Add(4);
        ListMiningMin.Add(5);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(60);
        ListMiningMin.Add(85);
        ListMiningMin.Add(4);
        ListMiningMin.Add(5);
        ListMiningMin.Add(6);
        ListMiningMin.Add(25);
        ListMiningMin.Add(4);
        ListMiningMin.Add(65);
        ListMiningMin.Add(65);
        ListMiningMin.Add(65);
        ListMiningMin.Add(85);
        ListMiningMin.Add(1);
        ListMiningMin.Add(85);
        ListMiningMin.Add(4);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(25);
        ListMiningMin.Add(45);
        ListMiningMin.Add(65);
        ListMiningMin.Add(85);
        ListMiningMin.Add(250);
        ListMiningMin.Add(300);
        ListMiningMin.Add(400);
        ListMiningMin.Add(500);
        ListMiningMin.Add(200);
        ListMiningMin.Add(5500);
        ListMiningMin.Add(250);
        ListMiningMin.Add(170);
        ListMiningMin.Add(150);
        ListMiningMin.Add(1);
        ListMiningMin.Add(1);
        ListMiningMin.Add(120);
        ListMiningMin.Add(120);
        ListMiningMin.Add(120);
        ListMiningMin.Add(130);
        ListMiningMin.Add(130);
        ListMiningMin.Add(130);


        ListMiningTime.Add(25);
        ListMiningTime.Add(24.5f);
        ListMiningTime.Add(24);
        ListMiningTime.Add(24);
        ListMiningTime.Add(24);
        ListMiningTime.Add(24);
        ListMiningTime.Add(24);
        ListMiningTime.Add(24);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(15);
        ListMiningTime.Add(15);
        ListMiningTime.Add(15);
        ListMiningTime.Add(51);
        ListMiningTime.Add(15);
        ListMiningTime.Add(51);
        ListMiningTime.Add(51);
        ListMiningTime.Add(15);
        ListMiningTime.Add(15);
        ListMiningTime.Add(15);
        ListMiningTime.Add(10);
        ListMiningTime.Add(10);
        ListMiningTime.Add(10);
        ListMiningTime.Add(10);
        ListMiningTime.Add(10);
        ListMiningTime.Add(10);
        ListMiningTime.Add(5);
        ListMiningTime.Add(5);
        ListMiningTime.Add(4);
        ListMiningTime.Add(4);
        ListMiningTime.Add(24);
        ListMiningTime.Add(24);
        ListMiningTime.Add(24);
        ListMiningTime.Add(22);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(18);
        ListMiningTime.Add(15);
        ListMiningTime.Add(10);
        ListMiningTime.Add(5);
        ListMiningTime.Add(24);
        ListMiningTime.Add(24);
        ListMiningTime.Add(22);
        ListMiningTime.Add(22);
        ListMiningTime.Add(20);
        ListMiningTime.Add(18);
        ListMiningTime.Add(18);
        ListMiningTime.Add(15);
        ListMiningTime.Add(15);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(20);
        ListMiningTime.Add(24);
        ListMiningTime.Add(10);
        ListMiningTime.Add(10);
        ListMiningTime.Add(10);
        ListMiningTime.Add(24);
        ListMiningTime.Add(10);
        ListMiningTime.Add(5);
        ListMiningTime.Add(24);
        ListMiningTime.Add(18);
        ListMiningTime.Add(18);
        ListMiningTime.Add(18);
        ListMiningTime.Add(18);
        ListMiningTime.Add(15);
        ListMiningTime.Add(5);
        ListMiningTime.Add(5);
        ListMiningTime.Add(6);
        ListMiningTime.Add(4);
        ListMiningTime.Add(5);
        ListMiningTime.Add(5);
        ListMiningTime.Add(8);
        ListMiningTime.Add(50);
        ListMiningTime.Add(7);
        ListMiningTime.Add(8);
        ListMiningTime.Add(7);
        ListMiningTime.Add(5);
        ListMiningTime.Add(5);
        ListMiningTime.Add(5);
        ListMiningTime.Add(5);
        ListMiningTime.Add(5);
        ListMiningTime.Add(8);
        ListMiningTime.Add(8);
        ListMiningTime.Add(8);


        for(int i=0; i< ListMiningMax.Count; i++)
        {
            ListDefaultListMiningMax.Add(ListMiningMax[i]);
        }
        for (int i = 0; i < ListMiningMin.Count; i++)
        {
            ListDefaultListMiningMin.Add(ListMiningMin[i]);
        }
        for (int i = 0; i < ListMiningTime.Count; i++)
        {
            ListDefaultListMiningTime.Add(ListMiningTime[i]);
            ListDefaultListMiningTimeCompose.Add(ListMiningTime[i]);
        }


        listMinerGrade.Add(1);
        listMinerGrade.Add(1);
        listMinerGrade.Add(1);
        listMinerGrade.Add(1);
        listMinerGrade.Add(1);
        listMinerGrade.Add(1);
        listMinerGrade.Add(1);
        listMinerGrade.Add(1);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(4);
        listMinerGrade.Add(4);
        listMinerGrade.Add(4);
        listMinerGrade.Add(4);
        listMinerGrade.Add(4);
        listMinerGrade.Add(4);
        listMinerGrade.Add(4);
        listMinerGrade.Add(4);
        listMinerGrade.Add(4);
        listMinerGrade.Add(4);
        listMinerGrade.Add(5);
        listMinerGrade.Add(5);
        listMinerGrade.Add(5);
        listMinerGrade.Add(5);
        listMinerGrade.Add(5);
        listMinerGrade.Add(5);
        listMinerGrade.Add(5);
        listMinerGrade.Add(6);
        listMinerGrade.Add(6);
        listMinerGrade.Add(6);
        listMinerGrade.Add(1);
        listMinerGrade.Add(1);
        listMinerGrade.Add(1);
        listMinerGrade.Add(2);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(4);
        listMinerGrade.Add(4);
        listMinerGrade.Add(5);
        listMinerGrade.Add(6);
        listMinerGrade.Add(1);
        listMinerGrade.Add(1);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(4);
        listMinerGrade.Add(5);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(2);
        listMinerGrade.Add(3);
        listMinerGrade.Add(2);
        listMinerGrade.Add(4);
        listMinerGrade.Add(4);
        listMinerGrade.Add(4);
        listMinerGrade.Add(5);
        listMinerGrade.Add(5);
        listMinerGrade.Add(6);
        listMinerGrade.Add(2);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(3);
        listMinerGrade.Add(4);
        listMinerGrade.Add(5);
        listMinerGrade.Add(6);

        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
        listMinerGrade.Add(7);
    }

    public string ChangeMoney(double haveGold)
    {
        if (haveGold >= 1000000000000000000)
            return string.Format("{0:#.###} L", (float)haveGold / 1000000000000000000);
        else if (haveGold >= 1000000000000000)
            return string.Format("{0:#.###} K", (float)haveGold / 1000000000000000);
        else if (haveGold >= 1000000000000)
            return string.Format("{0:#.###} J", (float)haveGold / 1000000000000);
        else if (haveGold >= 1000000000)
            return string.Format("{0:#.###} I", (float)haveGold / 1000000000);
        else if (haveGold >= 1000000)
            return string.Format("{0:#.###} H", (float)haveGold / 1000000);
        else if (haveGold >= 1000)
            return string.Format("{0:#.###} G", (float)haveGold / 1000);
        else if (haveGold >= 1)
            return string.Format("{0:#.###} F", (float)haveGold / 1);
        else if (haveGold >= 0.001f)
            return string.Format("{0:#.###} E", (float)haveGold / 0.001f);
        else if (haveGold >= 0.000001f)
            return string.Format("{0:#.###} D", (float)haveGold / 0.000001f);
        else if (haveGold >= 0.000000001f)
            return string.Format("{0:#.###} C", (float)haveGold / 0.000000001f);
        else if (haveGold >= 0.000000000001f)
            return string.Format("{0:#.###} B", (float)haveGold / 0.000000000001f);
        else if (haveGold >= 0.000000000000001f)
            return string.Format("{0:#.###} A", (float)haveGold / 0.000000000000001f);

        else if (haveGold == 0)
            return haveGold.ToString();
        else
        {
            haveGold = haveGold * 1000000000000000000f;
            int a = Mathf.CeilToInt((float)haveGold);
            return string.Format("{0:#.##}", a);
        }
        //return haveGold.ToString();

        //return haveGold.ToString();

    }
    public int GetDepthPos(int pos)
    {
        pos = Mathf.Abs(pos);
        int iPos = Mathf.Abs(pos);
        int depth = 0;
        if (iPos == 1 || iPos == 2)
            depth = 1;
        if (iPos == 3 || iPos == 4)
            depth = 2;
        if (iPos == 5 || iPos == 6)
            depth = 3;
        if (iPos == 7 || iPos == 8)
            depth = 4;
        if (iPos == 9 || iPos == 10)
            depth = 5;
        if (iPos == 11 || iPos == 12)
            depth = 6;
        if (iPos == 13 || iPos == 14)
            depth = 7;
        if (iPos == 15 || iPos == 16)
            depth = 8;
        if (iPos == 17 || iPos == 18)
            depth = 9;
        if (iPos == 19 || iPos == 20)
            depth = 10;
        if (iPos == 21 || iPos == 22)
            depth = 11;
        if (iPos == 23 || iPos == 24)
            depth = 12;
        if (iPos == 25 || iPos == 26)
            depth = 13;
        if (iPos == 27 || iPos == 28)
            depth = 14;

        if (iPos == 29 || iPos == 30)
            depth = 15;
        if (iPos == 31 || iPos == 32)
            depth = 16;
        if (iPos == 33 || iPos == 34)
            depth = 17;
        if (iPos == 35 || iPos == 36)
            depth = 18;
        if (iPos == 37 || iPos == 38)
            depth = 19;
        if (iPos == 39 || iPos == 40)
            depth = 20;
        if (iPos == 41 || iPos == 42)
            depth = 21;
        if (iPos == 43 || iPos == 44)
            depth = 22;
        if (iPos == 45 || iPos == 46)
            depth = 23;
        if (iPos == 47 || iPos == 48)
            depth = 24;
        if (iPos == 49 || iPos == 50)
            depth = 25;
        if (iPos == 51 || iPos == 52)
            depth = 26;
        if (iPos == 53 || iPos == 54)
            depth = 27;
        if (iPos == 55 || iPos == 56)
            depth = 28;

        if (iPos == 57 || iPos == 58)
            depth = 29;
        if (iPos == 59 || iPos == 60)
            depth = 30;
        if (iPos == 61 || iPos == 62)
            depth = 31;
        if (iPos == 63 || iPos == 64)
            depth = 32;
        if (iPos == 65 || iPos == 66)
            depth = 33;
        if (iPos == 67 || iPos == 68)
            depth = 34;
        if (iPos == 69 || iPos == 70)
            depth = 35;
        if (iPos == 71 || iPos == 72)
            depth = 36;
        if (iPos == 73 || iPos == 74)
            depth = 37;
        if (iPos == 75 || iPos == 76)
            depth = 38;
        if (iPos == 77 || iPos == 78)
            depth = 39;

        if (iPos == 79 || iPos == 80)
            depth = 40;
        if (iPos == 81 || iPos == 82)
            depth = 41;
        if (iPos == 83 || iPos == 84)
            depth = 42;
        if (iPos == 85 || iPos == 86)
            depth = 43;
        if (iPos == 87 || iPos == 88)
            depth = 44;
        if (iPos == 89 || iPos == 90)
            depth = 45;
        if (iPos == 91 || iPos == 92)
            depth = 46;
        if (iPos == 93 || iPos == 94)
            depth = 47;
        if (iPos == 95 || iPos == 96)
            depth = 48;
        if (iPos == 97 || iPos == 98)
            depth = 49;
        if (iPos == 99 || iPos == 100)
            depth = 50;

        if (iPos == 101 || iPos == 102)
            depth = 51;
        if (iPos == 103 || iPos == 104)
            depth = 52;
        if (iPos == 105 || iPos == 106)
            depth = 53;
        if (iPos == 107 || iPos == 108)
            depth = 54;
        if (iPos == 109 || iPos == 110)
            depth = 55;
        if (iPos == 111 || iPos == 112)
            depth = 56;
        if (iPos == 113 || iPos == 114)
            depth = 57;
        if (iPos == 115 || iPos == 116)
            depth = 58;
        return depth;
    }
    public float GetMoneyPos()
    {        
        for(int i= 0; i < ListMinerClass.Count; i++)
        {            
            if(ListMinerClass[i].m_depth == Depth+1)
            {                
                return (float)ListHireCost[i];
            }
        }
        return (float)0;
    }

    public float GetAverageMoney()
    {
        rewardMoney = 0;
        List<int> minerList = new List<int>();
        float weight = 1;
        int iMineralIndex = 0;
        if (MapType ==1)
        {
            minerList = ListHireCount;
            iMineralIndex = Depth - 1;
        }
        if (MapType == 2)
        {
            minerList = ListHireDesertCount;
            weight = 5;
            iMineralIndex = DesertDepth - 1;
        }
        if (MapType == 3)
        {
            minerList = ListHireIceCount;
            weight = 10;
            iMineralIndex = IceDepth - 1;
        }
        if (MapType == 4)
        {
            minerList = ListHireForestCount;
            weight = 100;
            iMineralIndex = ForestDepth - 1;
        }
        int totalCount = 0;
        for (int i = 0; i < minerList.Count; i++)
        {
            if (minerList[i] < 0)
            {                
                int Rand = Random.Range(ListMiningMin[i], ListMiningMax[i]);
                rewardMoney += Rand * ListCostMinerals[iMineralIndex] * weight;
                totalCount++;
            }
        }
        if(totalCount >0)
            return (float)(rewardMoney / totalCount);
        else        
            return 0;
        
    }
    public float GetAverageMoneyPerMin(float Inputtime)
    {
        rewardMoney = 0;
        List<int> minerList = new List<int>();
        float weight = 1;
        int iMineralIndex = 0;
        if (MapType == 1)
        {
            minerList = ListHireCount;
            iMineralIndex = Depth - 1;
        }
        if (MapType == 2)
        {
            minerList = ListHireDesertCount;
            weight = 5;
            iMineralIndex = DesertDepth - 1;
        }
        if (MapType == 3)
        {
            minerList = ListHireIceCount;
            weight = 10;
            iMineralIndex = IceDepth - 1;
        }
        if (MapType == 4)
        {
            minerList = ListHireForestCount;
            weight = 100;
            iMineralIndex = ForestDepth - 1;
        }
        int totalCount = 0;
        float time =1;
        for (int i = 0; i < minerList.Count; i++)
        {
            if (minerList[i] < 0)
            {
                int Rand = ListMiningMax[i];
                time =  Inputtime/ListMiningTime[i] ;
                double rewardTimeMonye = time * Rand * ListCostMinerals[iMineralIndex] * weight;
                rewardMoney += rewardTimeMonye;
                totalCount++;
                
            }
        }
        if (totalCount > 0)
            return (float)(rewardMoney );
        else
            return 0;

    }

    public float GetMoneyPos(int _depth)
    {
        for (int i = 0; i < ListMinerClass.Count; i++)
        {
            if (ListMinerClass[i].m_depth == _depth)
            {
                return (float)ListHireCost[i];
            }
        }
        return (float)0;
    }

    public int Choose(List<float> probs)
    {

        float total = 0;
        foreach (float elem in probs)
        {
            total += elem;
        }
        float randomPoint = Random.value * total;
        for (int i = 0; i < probs.Count; i++)
        {
            if (randomPoint < probs[i])
            {
                return i;
            }
            else
            {
                randomPoint -= probs[i];
            }
        }
        return probs.Count - 1;
    }
    public int Choose(List<int> probs)
    {

        float total = 0;
        foreach (float elem in probs)
        {
            total += elem;
        }
        float randomPoint = Random.value * total;
        for (int i = 0; i < probs.Count; i++)
        {
            if (randomPoint < probs[i])
            {
                return i;
            }
            else
            {
                randomPoint -= probs[i];
            }
        }
        return probs.Count - 1;
    }
    public void AddPanel(GameObject obj, string name)
    {
        int count = 0;
        for (int i = 0; i < listPanelDic.Count; i++)
        {
            if (listPanelDic[i].GetName() == name)
            {
                count++;
            }
        }
        if(count ==0)
            listPanelDic.Add(new PanelDic(name, obj));
    }
    public void DeletePanel(string name)
    {
        int iDiccount = -1;
        for(int i=0; i< listPanelDic.Count; i++)
        {
            if(listPanelDic[i].GetName() == name)
            {
                iDiccount = i;
            }
        }
        if(iDiccount >-1)
        {
            listPanelDic.RemoveAt(iDiccount);
        }
    }

    public void AddPanelPopup(GameObject obj, string name)
    {
        int count = 0;
        for(int i=0; i< listPanelPopupDic.Count; i++)
        {
            if (listPanelPopupDic[i].GetName() == name)
            {
                count++;
            }
        }
        if (count == 0)
            listPanelPopupDic.Add(new PanelPopUpDic(name, obj));
    }
    public void DeletePanelAll()
    {
        for (int i = 0; i < listPanelDic.Count; i++)
        {
            if (listPanelDic[i].GetName() == "HireShopCanvas")
            {
                GameObject.Find("MainCanvas").GetComponent<MainBtnSrc>().PressHireShop(0);
            }
            else
            {
                listPanelDic[i].GetObj().SetActive(false);
            }
        }
        listPanelDic.Clear();
    }
    public void DeletePanelPopupAll()
    {
        for(int i=0; i < listPanelPopupDic.Count; i++)
        {
            listPanelPopupDic[i].GetObj().SetActive(false);
        }
        listPanelPopupDic.Clear();
    }
    public void DeletePanelPopup(string name,int type =0)
    {
        
        int iDiccount = -1;
        for (int i = 0; i < listPanelPopupDic.Count; i++)
        {          
            if (listPanelPopupDic[i].GetName() == name)
            {
                iDiccount = i;
            }
        }
        if (iDiccount > -1)
        {
            listPanelPopupDic.RemoveAt(iDiccount);
        }
    }

    public float GetMinerWeight(int i)
    {
        float weight =0;
        if (listMinerGrade[i] == 1)
        {
            weight = 0.2f;
        }
        if (listMinerGrade[i] == 2)
        {
            weight = 0.3f;
        }
        if (listMinerGrade[i] == 3)
        {
            weight = 0.6f;
        }
        if (listMinerGrade[i] == 4)
        {
            weight = 1f;
        }
        if (listMinerGrade[i] == 5)
        {
            weight = 1.5f;
        }
        if (listMinerGrade[i] == 6)
        {
            weight = 2.2f;
        }
        if (listMinerGrade[i] == 7)
        {
            weight = 3f;
        }

        return weight;
    }
    public void AddRobotBuff(int i)
    {
    }
    public void AddUniqueBuff(int i)
    {
        if (i > 95)
        {
            string strBuff = string.Empty;
            for (int k = 0; k < UniqueMinerList.Count; k++)
            {
                if (UniqueMinerList[k] == i)
                {
                    switch (UniqueMinerBuffTypeList[k])
                    {
                        case "1.5":
                            strBuff = "드릴파워 증가 x5";
                            DrillBuffPower += 5;
                            break;
                        case "1.8":
                            strBuff = "드릴파워 증가 x8";
                            DrillBuffPower += 8;
                            break;
                        case "1.9":
                            strBuff = "드릴파워 증가 x9";
                            DrillBuffPower += 9;
                            break;
                        case "2.6":
                            strBuff = "전체판매량 증가 x6";
                            SaleBuffPower += 6;
                            break;
                        case "2.9":
                            strBuff = "전체판매량 증가 x9";
                            SaleBuffPower += 9;
                            break;
                        case "2.12":
                            strBuff = "전체판매량 증가 x12";
                            SaleBuffPower += 6;
                            break;
                        case "3.4":
                            strBuff = "전체 호잇스톤 채굴량 x4";
                            HoitStoneBuffPower += 4;
                            break;
                        case "3.8":
                            strBuff = "전체 호잇스톤 채굴량 x8";
                            HoitStoneBuffPower += 8;
                            break;
                        case "4.4":
                            strBuff = "드릴파워 증가 x4\n전체판매량 증가 x4";
                            DrillBuffPower += 4;
                            SaleBuffPower += 4;
                            break;
                        case "4.8":
                            strBuff = "드릴파워 증가 x8\n전체판매량 증가 x8";
                            DrillBuffPower += 8;
                            SaleBuffPower += 8;
                            break;
                        case "5.6":
                            strBuff = "드릴파워 증가 x6\n전체 호잇스톤 채굴량 x6";
                            DrillBuffPower += 6;
                            HoitStoneBuffPower += 6;
                            break;
                        case "5.8":
                            strBuff = "드릴파워 증가 x8\n전체 호잇스톤 채굴량 x8";
                            DrillBuffPower += 8;
                            HoitStoneBuffPower += 8;
                            break;
                        case "6.5":
                            strBuff = "전체판매량 증가 x5\n전체 호잇스톤 채굴량 x5";
                            SaleBuffPower += 5;
                            HoitStoneBuffPower += 5;
                            break;
                        case "6.8":
                            strBuff = "전체판매량 증가 x8\n전체 호잇스톤 채굴량 x8";
                            SaleBuffPower += 8;
                            HoitStoneBuffPower += 8;
                            break;
                    }
                    Debug.Log(strBuff + "++");
                }
            }
        }
    }
    public void DeleteQniqueBuff(int i)
    {
        if (i > 95)
        {
            string strBuff = string.Empty;
            for (int k = 0; k < UniqueMinerList.Count; k++)
            {
                if (UniqueMinerList[k] == i)
                {
                    switch (UniqueMinerBuffTypeList[k])
                    {
                        case "1.5":
                            strBuff = "드릴파워 증가 x5";
                            DrillBuffPower -= 5;
                            break;
                        case "1.8":
                            strBuff = "드릴파워 증가 x8";
                            DrillBuffPower -= 8;
                            break;
                        case "1.9":
                            strBuff = "드릴파워 증가 x9";
                            DrillBuffPower -= 9;
                            break;
                        case "2.6":
                            strBuff = "전체판매량 증가 x6";
                            SaleBuffPower -= 6;
                            break;
                        case "2.9":
                            strBuff = "전체판매량 증가 x9";
                            SaleBuffPower -= 9;
                            break;
                        case "2.12":
                            strBuff = "전체판매량 증가 x6";
                            SaleBuffPower -= 6;
                            break;
                        case "3.4":
                            strBuff = "전체 호잇스톤 채굴량 x4";
                            HoitStoneBuffPower -= 4;
                            break;
                        case "3.8":
                            strBuff = "전체 호잇스톤 채굴량 x8";
                            HoitStoneBuffPower -= 8;
                            break;
                        case "4.4":
                            strBuff = "드릴파워 증가 x4\n전체판매량 증가 x4";
                            DrillBuffPower -= 4;
                            SaleBuffPower -= 4;
                            break;
                        case "4.8":
                            strBuff = "드릴파워 증가 x8\n전체판매량 증가 x8";
                            DrillBuffPower -= 8;
                            SaleBuffPower -= 8;
                            break;
                        case "5.6":
                            strBuff = "드릴파워 증가 x6\n전체 호잇스톤 채굴량 x6";
                            DrillBuffPower -= 6;
                            HoitStoneBuffPower -= 6;
                            break;
                        case "5.8":
                            strBuff = "드릴파워 증가 x8\n전체 호잇스톤 채굴량 x8";
                            DrillBuffPower -= 8;
                            HoitStoneBuffPower -= 8;
                            break;
                        case "6.5":
                            strBuff = "전체판매량 증가 x5\n전체 호잇스톤 채굴량 x5";
                            SaleBuffPower -= 5;
                            HoitStoneBuffPower -= 5;
                            break;
                        case "6.8":
                            strBuff = "전체판매량 증가 x8\n전체 호잇스톤 채굴량 x8";
                            SaleBuffPower -= 8;
                            HoitStoneBuffPower -= 8;
                            break;
                    }
                    Debug.Log(strBuff + "--");
                }
            }
        }
    }
}

