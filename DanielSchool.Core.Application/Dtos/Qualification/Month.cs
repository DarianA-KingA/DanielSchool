using DanielSchool.Core.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Dtos.Qualification
{
    public class Month
    {
        public static DescriptionMonth[] ListMonth { get; set; } = new DescriptionMonth[] { 
            new DescriptionMonth(){ 
                Name = "Enero",
                OwnId = int.Parse(EnumMonth.Enero.ToString()),
                RealId = 1
            },
            new DescriptionMonth(){
                Name = "Frebero",
                OwnId = int.Parse(EnumMonth.Frebrero.ToString()),
                RealId = 2
            },
            new DescriptionMonth(){
                Name = "Marzo",
                OwnId = int.Parse(EnumMonth.Marzo.ToString()),
                RealId = 3
            },
            new DescriptionMonth(){
                Name = "Abril",
                OwnId = int.Parse(EnumMonth.Abril.ToString()),
                RealId = 4
            },
            new DescriptionMonth(){
                Name = "Mayo",
                OwnId = int.Parse(EnumMonth.Mayo.ToString()),
                RealId = 5
            },
            new DescriptionMonth(){
                Name = "Junio",
                OwnId = int.Parse(EnumMonth.Junio.ToString()),
                RealId = 6
            },
            new DescriptionMonth(){
                Name = "Julio",
                OwnId = int.Parse(EnumMonth.Julio.ToString()),
                RealId = 7
            },
            new DescriptionMonth(){
                Name = "Agosto",
                OwnId = int.Parse(EnumMonth.Agosto.ToString()),
                RealId = 8
            },
            new DescriptionMonth(){
                Name = "Septiembre",
                OwnId = int.Parse(EnumMonth.Septiembre.ToString()),
                RealId = 9
            },
            new DescriptionMonth(){
                Name = "Octubre",
                OwnId = int.Parse(EnumMonth.Octubre.ToString()),
                RealId = 10
            },
            new DescriptionMonth(){
                Name = "Noviembre",
                OwnId = int.Parse(EnumMonth.Noviembre.ToString()),
                RealId = 11
            },
            new DescriptionMonth(){
                Name = "Diciembre",
                OwnId = int.Parse(EnumMonth.Diciembre.ToString()),
                RealId = 12
            },
        };
        static int ActualMonth { get; } = DateTime.UtcNow.Month;
        public bool[] Limite { get; set; } = new bool[]{ 
            ListMonth.Where(M=>M.OwnId ==1).FirstOrDefault().RealId<= ActualMonth,
            ListMonth.Where(M=>M.OwnId ==2).FirstOrDefault().RealId<= ActualMonth,
            ListMonth.Where(M=>M.OwnId ==3).FirstOrDefault().RealId<= ActualMonth,
            ListMonth.Where(M=>M.OwnId ==4).FirstOrDefault().RealId<= ActualMonth,
            ListMonth.Where(M=>M.OwnId ==5).FirstOrDefault().RealId<= ActualMonth,
            ListMonth.Where(M=>M.OwnId ==6).FirstOrDefault().RealId<= ActualMonth,
            ListMonth.Where(M=>M.OwnId ==6).FirstOrDefault().RealId<= ActualMonth,
            ListMonth.Where(M=>M.OwnId ==7).FirstOrDefault().RealId<= ActualMonth,
            ListMonth.Where(M=>M.OwnId ==8).FirstOrDefault().RealId<= ActualMonth,
            ListMonth.Where(M=>M.OwnId ==9).FirstOrDefault().RealId<= ActualMonth,
            ListMonth.Where(M=>M.OwnId ==10).FirstOrDefault().RealId<= ActualMonth,
            ListMonth.Where(M=>M.OwnId ==11).FirstOrDefault().RealId<= ActualMonth,
            ListMonth.Where(M=>M.OwnId ==12).FirstOrDefault().RealId<= ActualMonth

        };

    }
}
