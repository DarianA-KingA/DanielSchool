using DanielSchool.Core.Application.Dtos.Qualification;
using DanielSchool.Core.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Helpers
{
    public class QualificationFilter
    {
        //int x = ListMonth.Where(M => M.RealId == ActualMonth).FirstOrDefault().OwnId;
        public static bool[] QualificacionFiilterMehtod()
        {
            List<DescriptionMonth> ListMonth = new List<DescriptionMonth>(){
                    new DescriptionMonth(){
                        Name = "Enero",
                        OwnId = (int)EnumMonth.Enero,
                        RealId = 1
                    },
                    new DescriptionMonth(){
                        Name = "Frebero",
                        OwnId = (int)EnumMonth.Frebrero,
                        RealId = 2
                    },
                    new DescriptionMonth(){
                        Name = "Marzo",
                        OwnId = (int)EnumMonth.Marzo,
                        RealId = 3
                    },
                    new DescriptionMonth(){
                        Name = "Abril",
                        OwnId = (int)EnumMonth.Abril,
                        RealId = 4
                    },
                    new DescriptionMonth(){
                        Name = "Mayo",
                        OwnId = (int)EnumMonth.Mayo,
                        RealId = 5
                    },
                    new DescriptionMonth(){
                        Name = "Junio",
                        OwnId = (int)EnumMonth.Junio,
                        RealId = 6
                    },
                    new DescriptionMonth(){
                        Name = "Julio",
                        OwnId = (int)EnumMonth.Julio,
                        RealId = 7
                    },
                    new DescriptionMonth(){
                        Name = "Agosto",
                        OwnId = (int)EnumMonth.Agosto,
                        RealId = 8
                    },
                    new DescriptionMonth(){
                        Name = "Septiembre",
                        OwnId = (int)EnumMonth.Septiembre,
                        RealId = 9
                    },
                    new DescriptionMonth(){
                        Name = "Octubre",
                        OwnId = (int)EnumMonth.Octubre,
                        RealId = 10
                    },
                    new DescriptionMonth(){
                        Name = "Noviembre",
                        OwnId = (int)EnumMonth.Noviembre,
                        RealId = 11
                    },
                    new DescriptionMonth(){
                        Name = "Diciembre",
                        OwnId = (int)EnumMonth.Diciembre,
                        RealId = 12
                    },
                };
            int ActualMonth = DateTime.UtcNow.Month;
            bool[] Limite = new bool[]{
                    ListMonth.Where(M=>M.OwnId ==1).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId,
                    ListMonth.Where(M=>M.OwnId ==2).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId,
                    ListMonth.Where(M=>M.OwnId ==3).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId,
                    ListMonth.Where(M=>M.OwnId ==4).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId,
                    ListMonth.Where(M=>M.OwnId ==5).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId,
                    ListMonth.Where(M=>M.OwnId ==6).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId,
                    ListMonth.Where(M=>M.OwnId ==6).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId,
                    ListMonth.Where(M=>M.OwnId ==7).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId,
                    ListMonth.Where(M=>M.OwnId ==8).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId,
                    ListMonth.Where(M=>M.OwnId ==9).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId,
                    ListMonth.Where(M=>M.OwnId ==10).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId,
                    ListMonth.Where(M=>M.OwnId ==11).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId,
                    ListMonth.Where(M=>M.OwnId ==12).FirstOrDefault().OwnId<= ListMonth.Where(M=>M.RealId == ActualMonth).FirstOrDefault().OwnId

                };
            return Limite;
        }

        
    }
}
