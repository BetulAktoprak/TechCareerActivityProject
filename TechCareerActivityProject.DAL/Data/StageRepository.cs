using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechCareerActivityProject.DAL.Models;

namespace TechCareerActivityProject.DAL.Data
{
    public class StageRepository
    {
        private static readonly List<Stage> _stages = null;

        static StageRepository()
        {
            _stages = new List<Stage>()
            {
                new Stage
                {
                    Id = 1,
                    StageName = "CİMRİ",
                    StageDescription = "Tiyatro",
                    StageTime = "14 Şubat Çarşamba",
                    StageLocation = "Maximum UNIQ Hall",
                    StageImage = "0000190_cimri.jpg"
                },
                new Stage
                {
                    Id = 2,
                    StageName = "AYDINLIKEVLER",
                    StageDescription = "Tiyatro",
                    StageTime = "15 Şubat Perşembe",
                    StageLocation = "Bostancı Gösteri Merkezi",
                    StageImage = "aydinlikevler-yatay.jpg"
                },
                new Stage
                {
                    Id = 3,
                    StageName = "ZENGİN MUTFAĞI",
                    StageDescription = "Tiyatro",
                    StageTime = "16 Şubat Cuma",
                    StageLocation = "Maximum UNIQ Hall",
                    StageImage = "zengin-mutfagi-04.jpg"
                },
                new Stage
                {
                    Id = 4,
                    StageName = "MONTAİGNE",
                    StageDescription = "Tiyatro",
                    StageTime = "17 Şubat Cumartesi",
                    StageLocation = "Oda Tiyatrosu",
                    StageImage = "396024018_18391995217028468_7905172375322033882_n-2-1024x574.jpg"
                },
                new Stage
                {
                    Id = 5,
                    StageName = "İBRAHİM SELİM İLE BU GECE",
                    StageDescription = "Talk Show",
                    StageTime = "18 Şubat Pazar",
                    StageLocation = "Zorlu PSM",
                    StageImage = "indir (6).jpg"
                },
                new Stage
                {
                    Id = 6,
                    StageName = "SAATLERİ AYARLAMA ENSTİTÜSÜ",
                    StageDescription = "Tiyatro",
                    StageTime = "19 Şubat Pazartesi",
                    StageLocation = "Maximum UNIQ Hall",
                    StageImage = "9a1f44e4140943a69876550fa02a5c39.jpg"
                },
                new Stage
                {
                    Id = 7,
                    StageName = "HÜCRELER",
                    StageDescription = "Tiyatro",
                    StageTime = "21 Şubat Çarşamba",
                    StageLocation = "Maximum UNIQ Hall",
                    StageImage = "hucreler.jpg"
                },
                new Stage
                {
                    Id = 8,
                    StageName = "TİMSAH ATEŞİ",
                    StageDescription = "Tiyatro",
                    StageTime = "22 Şubat Perşembe",
                    StageLocation = "Zorlu PSM",
                    StageImage = "indir (7).jpg"
                },
                new Stage
                {
                    Id = 9,
                    StageName = "KÜHEYLAN",
                    StageDescription = "Tiyatro",
                    StageTime = "24 Şubat Cumartesi",
                    StageLocation = "Maximum UNIQ Hall",
                    StageImage = "indir (8).jpg"
                },

            };
        }

        public static List<Stage> Stages
        {
            get
            {
                return _stages;
            }
        }

        public static Stage GetById(int id)
        {
            return _stages.FirstOrDefault(c => c.Id == id);
        }
    }
}
