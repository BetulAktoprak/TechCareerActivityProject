using Microsoft.AspNetCore.Mvc;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.UI.Controllers
{
    public class StageController : Controller
    {
        public IActionResult Index()
        {
            var stageList = new List<Stage>()
            {
                new Stage
                {
                    StageName = "CİMRİ",
                    StageDescription = "Tiyatro",
                    StageTime = "14 Şubat Çarşamba",
                    StageLocation = "Maximum UNIQ Hall",
                    StageImage = "0000190_cimri.jpg"
                },
                new Stage
                {
                    StageName = "AYDINLIKEVLER",
                    StageDescription = "Tiyatro",
                    StageTime = "15 Şubat Perşembe",
                    StageLocation = "Bostancı Gösteri Merkezi",
                    StageImage = "aydinlikevler-yatay.jpg"
                },
                new Stage
                {
                    StageName = "ZENGİN MUTFAĞI",
                    StageDescription = "Tiyatro",
                    StageTime = "16 Şubat Cuma",
                    StageLocation = "Maximum UNIQ Hall",
                    StageImage = "zengin-mutfagi-04.jpg"
                },
                new Stage
                {
                    StageName = "MONTAİGNE",
                    StageDescription = "Tiyatro",
                    StageTime = "17 Şubat Cumartesi",
                    StageLocation = "Oda Tiyatrosu",
                    StageImage = "396024018_18391995217028468_7905172375322033882_n-2-1024x574.jpg"
                },
                new Stage
                {
                    StageName = "İBRAHİM SELİM İLE BU GECE",
                    StageDescription = "Talk Show",
                    StageTime = "18 Şubat Pazar",
                    StageLocation = "Zorlu PSM",
                    StageImage = "indir (6).jpg"
                },
                new Stage
                {
                    StageName = "SAATLERİ AYARLAMA ENSTİTÜSÜ",
                    StageDescription = "Tiyatro",
                    StageTime = "19 Şubat Pazartesi",
                    StageLocation = "Maximum UNIQ Hall",
                    StageImage = "9a1f44e4140943a69876550fa02a5c39.jpg"
                },
                new Stage
                {
                    StageName = "HÜCRELER",
                    StageDescription = "Tiyatro",
                    StageTime = "21 Şubat Çarşamba",
                    StageLocation = "Maximum UNIQ Hall",
                    StageImage = "hucreler.jpg"
                },
                new Stage
                {
                    StageName = "TİMSAH ATEŞİ",
                    StageDescription = "Tiyatro",
                    StageTime = "22 Şubat Perşembe",
                    StageLocation = "Zorlu PSM",
                    StageImage = "indir (7).jpg"
                },
                new Stage
                {
                    StageName = "KÜHEYLAN",
                    StageDescription = "Tiyatro",
                    StageTime = "24 Şubat Cumartesi",
                    StageLocation = "Maximum UNIQ Hall",
                    StageImage = "indir (8).jpg"
                },

            };
            return View(stageList);
        }
    }
}
