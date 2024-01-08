using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DrillManager : MonoBehaviour {

    // Use this for initialization

    public Image ProgassImg;
    public Text TextPecent;
    public Text TextPecent2;

    public Text BuffText;
    public Text SaleText;
    GlobalVariable gv;
    MapContorller mapController;
    bool bStartDrillBuff = false;
    bool bStartSaleBuff = false;
    public List<GameObject> DrillParticle;
    private void Awake()
    {
        gv = GlobalVariable.Instance;
    }
    void Start () {
        mapController = GameObject.Find("MainCanvas").GetComponent<MapContorller>();
        StartCoroutine("Diging");
        StartCoroutine("CheckBuff");
        CheckBuffAds();
    }
    public void CheckBuffAds()
    {
        bStartDrillBuff = false;
        bStartSaleBuff = false;
        if (gv.MapType == 1)
        {
            if (gv.SaleBuffCount > 0)
            {
                int Saletime = (gv.SaleBuffCount - 1) * gv.iAdSaleBuffTime;                
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTime", gv.iAdSaleBuffTime + Saletime) == -1)                
                {
                    gv.SaleBuffCount = 0;
                    PlayerPrefs.SetInt("SaleBuffCount", 0);
                    PlayerPrefs.Save();
                    if(bStartSaleBuff ==true)
                    {
                        gv.SaleBuffPower -= 2;
                        bStartSaleBuff = false;
                    }
                }
                else if(GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTime", gv.iAdSaleBuffTime + Saletime) == 1)                
                {
                    if(bStartSaleBuff ==false)
                    {
                        gv.SaleBuffPower += 2;
                        bStartSaleBuff = true;
                    }                    
                }    
            }
            if (gv.DrillBuffCount > 0)
            {
                int drilltime = (gv.DrillBuffCount - 1) * gv.iAdDrillBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTime", gv.iAdDrillBuffTime + drilltime) == -1)
                {
                    gv.DrillBuffCount = 0;
                    PlayerPrefs.SetInt("DrillBuffCount", 0);
                    PlayerPrefs.Save();
                    if (bStartDrillBuff == true)
                    {
                        gv.DrillBuffPower -= 2;
                        bStartDrillBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTime", gv.iAdDrillBuffTime + drilltime) == 1)
                {
                    if (bStartDrillBuff == false)
                    {
                        gv.DrillBuffPower += 2;
                        bStartDrillBuff = true;
                    }
                }
            }
        }

        if (gv.MapType == 2)
        {
            if (gv.SaleBuffCountDesert > 0)
            {
                int Saletime = (gv.SaleBuffCountDesert - 1) * gv.iAdSaleBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTimeDesert", gv.iAdSaleBuffTime + Saletime) == -1)
                {
                    gv.SaleBuffCountDesert = 0;
                    PlayerPrefs.SetInt("SaleBuffCountDesert", 0);
                    PlayerPrefs.Save();
                    if (bStartSaleBuff == true)
                    {
                        gv.SaleBuffPower -= 2;
                        bStartSaleBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTimeDesert", gv.iAdSaleBuffTime + Saletime) == 1)
                {
                    if (bStartSaleBuff == false)
                    {
                        gv.SaleBuffPower += 2;
                        bStartSaleBuff = true;
                    }
                }
            }

            if (gv.DrillBuffCountDesert > 0)
            {
                int drilltime = (gv.DrillBuffCountDesert - 1) * gv.iAdDrillBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTimeDesert", gv.iAdDrillBuffTime + drilltime) == -1)
                {
                    gv.DrillBuffCountDesert = 0;
                    PlayerPrefs.SetInt("DrillBuffCountDesert", 0);
                    PlayerPrefs.Save();
                    if (bStartDrillBuff == true)
                    {
                        gv.DrillBuffPower -= 2;
                        bStartDrillBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTimeDesert", gv.iAdDrillBuffTime + drilltime) == 1)
                {
                    if (bStartDrillBuff == false)
                    {
                        gv.DrillBuffPower += 2;
                        bStartDrillBuff = true;
                    }
                }
            }
        }

        if (gv.MapType == 3)
        {
            if (gv.SaleBuffCountIce > 0)
            {
                int Saletime = (gv.SaleBuffCountIce - 1) * gv.iAdSaleBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTimeIce", gv.iAdSaleBuffTime + Saletime) == -1)
                {
                    gv.SaleBuffCountIce = 0;
                    PlayerPrefs.SetInt("SaleBuffCountIce", 0);
                    PlayerPrefs.Save();
                    if (bStartSaleBuff == true)
                    {
                        gv.SaleBuffPower -= 2;
                        bStartSaleBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTimeIce", gv.iAdSaleBuffTime + Saletime) == 1)
                {
                    if (bStartSaleBuff == false)
                    {
                        gv.SaleBuffPower += 2;
                        bStartSaleBuff = true;
                    }
                }
            }

            if (gv.DrillBuffCountIce > 0)
            {
                int drilltime = (gv.DrillBuffCountIce - 1) * gv.iAdDrillBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTimeIce", gv.iAdDrillBuffTime + drilltime) == -1)
                {
                    gv.DrillBuffCountIce = 0;
                    PlayerPrefs.SetInt("DrillBuffCountIce", 0);
                    PlayerPrefs.Save();
                    if (bStartDrillBuff == true)
                    {
                        gv.DrillBuffPower -= 2;
                        bStartDrillBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTimeIce", gv.iAdDrillBuffTime + drilltime) == 1)
                {
                    if (bStartDrillBuff == false)
                    {
                        gv.DrillBuffPower += 2;
                        bStartDrillBuff = true;
                    }
                }
            }
        }

        if (gv.MapType == 4)
        {
            if (gv.SaleBuffCountForest > 0)
            {
                int Saletime = (gv.SaleBuffCountForest - 1) * gv.iAdSaleBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTimeForest", gv.iAdSaleBuffTime + Saletime) == -1)
                {
                    gv.SaleBuffCountForest = 0;
                    PlayerPrefs.SetInt("SaleBuffCountForest", 0);
                    PlayerPrefs.Save();
                    if (bStartSaleBuff == true)
                    {
                        gv.SaleBuffPower -= 2;
                        bStartSaleBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTimeForest", gv.iAdSaleBuffTime + Saletime) == 1)
                {
                    if (bStartSaleBuff == false)
                    {
                        gv.SaleBuffPower += 2;
                        bStartSaleBuff = true;
                    }
                }
            }

            if (gv.DrillBuffCountForest > 0)
            {
                int drilltime = (gv.DrillBuffCountForest - 1) * gv.iAdDrillBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTimeForest", gv.iAdDrillBuffTime + drilltime) == -1)
                {
                    gv.DrillBuffCountForest = 0;
                    PlayerPrefs.SetInt("DrillBuffCountForest", 0);
                    PlayerPrefs.Save();
                    if (bStartDrillBuff == true)
                    {
                        gv.DrillBuffPower -= 2;
                        bStartDrillBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTimeForest", gv.iAdDrillBuffTime + drilltime) == 1)
                {
                    if (bStartDrillBuff == false)
                    {
                        gv.DrillBuffPower += 2;
                        bStartDrillBuff = true;
                    }
                }
            }
        }

        if(gv.DrillBuffPower ==0)
        {
            BuffText.text = "x 1";
        }
        else
        {
            BuffText.text = "x " + gv.DrillBuffPower;
        }

        if(gv.SaleBuffPower ==0)
        {
            SaleText.text = "1"; 
        }
        else
        {
            SaleText.text =gv.SaleBuffPower.ToString("N1");
        }
        

    }
    IEnumerator Diging()
    {
        yield return new WaitForSeconds(0.5f);
        if(gv.DepthExp.Length >0)
        {
            int deptIndex = 0;
            if (gv.MapType == 1)
            {
                deptIndex = gv.Depth;
            }
            if (gv.MapType == 2)
            {
                deptIndex = gv.DesertDepth;
            }
            if (gv.MapType == 3)
            {
                deptIndex = gv.IceDepth;
            }
            if (gv.MapType == 4)
            {
                deptIndex = gv.ForestDepth;
            }
            if(gv.MapType==1)
            {
                if(gv.isStartCraftEngineNormal ==0 && gv.isStartCraftBitNormal ==0)
                {
                    if (gv.ExpNow <= gv.DepthExp[deptIndex])
                    {
                        float buffDrill;
                        if (gv.DrillBuffPower <= 0)
                        {
                            buffDrill = 1;
                        }
                        else
                        {
                            buffDrill = gv.DrillBuffPower;
                        }
                        gv.ExpNow += (gv.ListBitPower[gv.BitLv] * buffDrill);
                        gv.ExpNow += (gv.ListEnginePower[gv.EngineLv] * buffDrill);
                        //Depth 경험치 저장
                        PlayerPrefs.SetFloat("ExpNow", (float)gv.ExpNow);
                        PlayerPrefs.Save();


                        ProgassImg.fillAmount = (float)gv.ExpNow / (float)gv.DepthExp[deptIndex];
                        if (((float)gv.ExpNow / (float)gv.DepthExp[deptIndex]) < 1)
                        {
                            TextPecent.text = ((float)gv.ExpNow / (float)gv.DepthExp[deptIndex] * 100).ToString("N2") + " %";
                            TextPecent2.text = ((float)gv.ExpNow / (float)gv.DepthExp[deptIndex] * 100).ToString("N2") + " %";
                        }
                        else
                        {
                            TextPecent.text = 100 + " %";
                            TextPecent2.text = 100 + " %";
                            ProgassImg.fillAmount = 1;
                        }
                    }
                    else
                    {
                        TextPecent.text = 100 + " %";
                        TextPecent2.text = 100 + " %";
                        ProgassImg.fillAmount = 1;
                    }
                    mapController.SetFill((float)gv.ExpNow / (float)gv.DepthExp[deptIndex]);
                }               
                StartCoroutine("Diging");
            }
            if (gv.MapType == 2)
            {
                if (gv.isStartCraftEngineDesert == 0 && gv.isStartCraftBitDesert== 0)
                {
                    if (gv.ExpNowDesert <= gv.DepthExp[deptIndex]*3)
                    {
                        float buffDrill;
                        if (gv.DrillBuffPower <= 0)
                        {
                            buffDrill = 1;
                        }
                        else
                        {
                            buffDrill = gv.DrillBuffPower;
                        }
                        gv.ExpNowDesert += (gv.ListBitPower[gv.BitLv] * buffDrill);
                        gv.ExpNowDesert += (gv.ListEnginePower[gv.EngineLv] * buffDrill);


                        //Depth 경험치 저장
                        PlayerPrefs.SetFloat("ExpNowDesert", (float)gv.ExpNowDesert);
                        PlayerPrefs.Save();


                        ProgassImg.fillAmount = (float)gv.ExpNowDesert / ((float)gv.DepthExp[deptIndex]*3);
                        if (((float)gv.ExpNowDesert / ((float)gv.DepthExp[deptIndex] *3)) < 1)
                        {
                            float lv = (float)gv.ExpNowDesert / ((float)gv.DepthExp[deptIndex] * 3);
                            TextPecent.text = (lv * 100).ToString("N2") + " %";
                            TextPecent2.text = (lv * 100).ToString("N2") + " %";
                        }
                        else
                        {
                            TextPecent.text = 100 + " %";
                            TextPecent2.text = 100 + " %";
                            ProgassImg.fillAmount = 1;
                        }
                    }
                    else
                    {
                        TextPecent.text = 100 + " %";
                        TextPecent2.text = 100 + " %";
                        ProgassImg.fillAmount = 1;
                    }
                    mapController.SetFill((float)gv.ExpNowDesert / ((float)gv.DepthExp[deptIndex] * 3));
                }
                StartCoroutine("Diging");
            }
            if (gv.MapType == 3)
            {
                if (gv.isStartCraftEngineIce == 0 && gv.isStartCraftBitIce == 0)
                {
                    if (gv.ExpNowIce <= gv.DepthExp[deptIndex] * 6)
                    {
                        float buffDrill;
                        if (gv.DrillBuffPower <= 0)
                        {
                            buffDrill = 1;
                        }
                        else
                        {
                            buffDrill = gv.DrillBuffPower;
                        }
                        gv.ExpNowIce += (gv.ListBitPower[gv.BitLv] * buffDrill);
                        gv.ExpNowIce += (gv.ListEnginePower[gv.EngineLv] * buffDrill);

                        //Depth 경험치 저장
                        PlayerPrefs.SetFloat("ExpNowIce", (float)gv.ExpNowIce);
                        PlayerPrefs.Save();


                        ProgassImg.fillAmount = (float)gv.ExpNowIce / ((float)gv.DepthExp[deptIndex ] * 6);
                        if (((float)gv.ExpNowIce / ((float)gv.DepthExp[deptIndex] * 6)) < 1)
                        {
                            float lv = (float)gv.ExpNowIce / ((float)gv.DepthExp[deptIndex] * 6);
                            TextPecent.text = (lv * 100).ToString("N2") + " %";
                            TextPecent2.text = (lv * 100).ToString("N2") + " %";
                        }
                        else
                        {
                            TextPecent.text = 100 + " %";
                            TextPecent2.text = 100 + " %";
                            ProgassImg.fillAmount = 1;
                        }
                    }
                    else
                    {
                        TextPecent.text = 100 + " %";
                        TextPecent2.text = 100 + " %";
                        ProgassImg.fillAmount = 1;
                    }
                    mapController.SetFill((float)gv.ExpNowIce / ((float)gv.DepthExp[deptIndex ] * 6));
                }
                StartCoroutine("Diging");
            }
            if (gv.MapType == 4)
            {
                if (gv.isStartCraftEngineForest == 0 && gv.isStartCraftBitForest == 0)
                {
                    if (gv.ExpNowForest <= gv.DepthExp[deptIndex] * 10)
                    {
                        float buffDrill;
                        if (gv.DrillBuffPower <= 0)
                        {
                            buffDrill = 1;
                        }
                        else
                        {
                            buffDrill = gv.DrillBuffPower;
                        }
                        gv.ExpNowForest += (gv.ListBitPower[gv.BitLv] * buffDrill);
                        gv.ExpNowForest += (gv.ListEnginePower[gv.EngineLv] * buffDrill);


                        //Depth 경험치 저장
                        PlayerPrefs.SetFloat("ExpNowForest", (float)gv.ExpNowForest);
                        PlayerPrefs.Save();


                        ProgassImg.fillAmount = (float)gv.ExpNowForest / ((float)gv.DepthExp[deptIndex ] * 10);
                        if (((float)gv.ExpNowForest / ((float)gv.DepthExp[deptIndex] * 10)) < 1)
                        {
                            float lv = (float)gv.ExpNowForest / ((float)gv.DepthExp[deptIndex] * 10);
                            TextPecent.text = (lv * 100).ToString("N2") + " %";
                            TextPecent2.text = (lv * 100).ToString("N2") + " %";
                        }
                        else
                        {
                            TextPecent.text = 100 + " %";
                            TextPecent2.text = 100 + " %";
                            ProgassImg.fillAmount = 1;
                        }
                    }
                    else
                    {
                        TextPecent.text = 100 + " %";
                        TextPecent2.text = 100 + " %";
                        ProgassImg.fillAmount = 1;
                    }
                    mapController.SetFill((float)gv.ExpNowForest / ((float)gv.DepthExp[deptIndex] * 10));
                }
                StartCoroutine("Diging");
            }

        }
    
    }

    IEnumerator CheckBuff()
    {
        yield return new WaitForSeconds(1);
        if (gv.MapType == 1)
        {
            if (gv.SaleBuffCount > 0)
            {
                int Saletime = (gv.SaleBuffCount - 1) * gv.iAdSaleBuffTime;                
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTime", gv.iAdSaleBuffTime + Saletime) == -1)                
                {
                    gv.SaleBuffCount = 0;
                    PlayerPrefs.SetInt("SaleBuffCount", 0);
                    PlayerPrefs.Save();
                    if (bStartSaleBuff == true)
                    {
                        gv.SaleBuffPower -= 2;
                        bStartSaleBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTime", gv.iAdSaleBuffTime + Saletime) == 1)                
                {
                    if (bStartSaleBuff == false)
                    {
                        gv.SaleBuffPower += 2;
                        bStartSaleBuff = true;
                    }
                }

            }
            if (gv.DrillBuffCount > 0)
            {
                int drilltime = (gv.DrillBuffCount - 1) * gv.iAdDrillBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTime", gv.iAdDrillBuffTime + drilltime) == -1)
                {
                    gv.DrillBuffCount = 0;
                    PlayerPrefs.SetInt("DrillBuffCount", 0);
                    PlayerPrefs.Save();
                    if (bStartDrillBuff == true)
                    {
                        gv.DrillBuffPower -= 2;
                        bStartDrillBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTime", gv.iAdDrillBuffTime + drilltime) == 1)
                {
                    if (bStartDrillBuff == false)
                    {
                        gv.DrillBuffPower += 2;
                        bStartDrillBuff = true;
                    }
                }
            }
        }

        if (gv.MapType == 2)
        {
            if (gv.SaleBuffCountDesert > 0)
            {
                int Saletime = (gv.SaleBuffCountDesert - 1) * gv.iAdSaleBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTimeDesert", gv.iAdSaleBuffTime + Saletime) == -1)
                {
                    gv.SaleBuffCountDesert = 0;
                    PlayerPrefs.SetInt("SaleBuffCountDesert", 0);
                    PlayerPrefs.Save();
                    if (bStartSaleBuff == true)
                    {
                        gv.SaleBuffPower -= 2;
                        bStartSaleBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTimeDesert", gv.iAdSaleBuffTime + Saletime) == 1)
                {
                    if (bStartSaleBuff == false)
                    {
                        gv.SaleBuffPower += 2;
                        bStartSaleBuff = true;
                    }
                }
            }

            if (gv.DrillBuffCountDesert > 0)
            {
                int drilltime = (gv.DrillBuffCountDesert - 1) * gv.iAdDrillBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTimeDesert", gv.iAdDrillBuffTime + drilltime) == -1)
                {
                    gv.DrillBuffCountDesert = 0;
                    PlayerPrefs.SetInt("DrillBuffCountDesert", 0);
                    PlayerPrefs.Save();
                    if (bStartDrillBuff == true)
                    {
                        gv.DrillBuffPower -= 2;
                        bStartDrillBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTimeDesert", gv.iAdDrillBuffTime + drilltime) == 1)
                {
                    if (bStartDrillBuff == false)
                    {
                        gv.DrillBuffPower += 2;
                        bStartDrillBuff = true;
                    }
                }
            }
        }

        if (gv.MapType == 3)
        {
            if (gv.SaleBuffCountIce > 0)
            {
                int Saletime = (gv.SaleBuffCountIce - 1) * gv.iAdSaleBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTimeIce", gv.iAdSaleBuffTime + Saletime) == -1)
                {
                    gv.SaleBuffCountIce = 0;
                    PlayerPrefs.SetInt("SaleBuffCountIce", 0);
                    PlayerPrefs.Save();
                    if (bStartSaleBuff == true)
                    {
                        gv.SaleBuffPower -= 2;
                        bStartSaleBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTimeIce", gv.iAdSaleBuffTime + Saletime) == 1)
                {
                    if (bStartSaleBuff == false)
                    {
                        gv.SaleBuffPower += 2;
                        bStartSaleBuff = true;
                    }
                }
            }

            if (gv.DrillBuffCountIce > 0)
            {
                int drilltime = (gv.DrillBuffCountIce - 1) * gv.iAdDrillBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTimeIce", gv.iAdDrillBuffTime + drilltime) == -1)
                {
                    gv.DrillBuffCountIce = 0;
                    PlayerPrefs.SetInt("DrillBuffCountIce", 0);
                    PlayerPrefs.Save();
                    if (bStartDrillBuff == true)
                    {
                        gv.DrillBuffPower -= 2;
                        bStartDrillBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTimeIce", gv.iAdDrillBuffTime + drilltime) == 1)
                {
                    if (bStartDrillBuff == false)
                    {
                        gv.DrillBuffPower += 2;
                        bStartDrillBuff = true;
                    }
                }
            }
        }

        if (gv.MapType == 4)
        {
            if (gv.SaleBuffCountForest > 0)
            {
                int Saletime = (gv.SaleBuffCountForest - 1) * gv.iAdSaleBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTimeForest", gv.iAdSaleBuffTime + Saletime) == -1)
                {
                    gv.SaleBuffCountForest = 0;
                    PlayerPrefs.SetInt("SaleBuffCountForest", 0);
                    PlayerPrefs.Save();
                    if (bStartSaleBuff == true)
                    {
                        gv.SaleBuffPower -= 2;
                        bStartSaleBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("SaleBuffTimeForest", gv.iAdSaleBuffTime + Saletime) == 1)
                {
                    if (bStartSaleBuff == false)
                    {
                        gv.SaleBuffPower += 2;
                        bStartSaleBuff = true;
                    }
                }
            }

            if (gv.DrillBuffCountForest > 0)
            {
                int drilltime = (gv.DrillBuffCountForest - 1) * gv.iAdDrillBuffTime;
                if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTimeForest", gv.iAdDrillBuffTime + drilltime) == -1)
                {
                    gv.DrillBuffCountForest = 0;
                    PlayerPrefs.SetInt("DrillBuffCountForest", 0);
                    PlayerPrefs.Save();
                    if (bStartDrillBuff == true)
                    {
                        gv.DrillBuffPower -= 2;
                        bStartDrillBuff = false;
                    }
                }
                else if (GameObject.Find("MainCanvas").GetComponent<TimerManager>().SetTimerText("DrillBuffTimeForest", gv.iAdDrillBuffTime + drilltime) == 1)
                {
                    if (bStartDrillBuff == false)
                    {
                        gv.DrillBuffPower += 2;
                        bStartDrillBuff = true;
                    }
                }
            }
        }
        if (gv.DrillBuffPower == 0)
        {
            BuffText.text = "x 1";
        }
        else
        {
            BuffText.text = "x " + gv.DrillBuffPower.ToString("N1");
        }

        if (gv.SaleBuffPower == 0)
        {
            SaleText.text = "1";
        }
        else
        {
            SaleText.text = gv.SaleBuffPower.ToString("N1");
        }
        StartCoroutine("CheckBuff");
        if(gv.DrillBuffPower >= 2)
        {
            DrillParticle[0].SetActive(true);
        }
        if (gv.DrillBuffPower >= 4)
        {
            DrillParticle[1].SetActive(true);
        }
        if (gv.DrillBuffPower >= 6)
        {
            DrillParticle[2].SetActive(true);
        }
        if (gv.DrillBuffPower >= 8)
        {
            DrillParticle[3].SetActive(true);
        }
        if (gv.DrillBuffPower >= 10)
        {
            DrillParticle[4].SetActive(true);
        }
        if (gv.DrillBuffPower >= 12)
        {
            DrillParticle[5].SetActive(true);
        }
        if (gv.DrillBuffPower >= 14)
        {
            DrillParticle[6].SetActive(true);
        }
        if (gv.DrillBuffPower >= 16)
        {
            DrillParticle[7].SetActive(true);
        }
    }
}
