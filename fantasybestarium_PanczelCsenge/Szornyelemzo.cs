using System;
using System.Collections.Generic;
using System.Text;

namespace fantasybestarium_PanczelCsenge
{
    internal class Szornyelemzo
    {
        private List<Szorny> szornyek;
        public Szornyelemzo()
        {
            var szornykezelo = new SzornyAdatbazis();
            this.szornyek = szornykezelo.Feltolt("server=localhost; " +
                "database=fantasybestariumdb; uid=root; password=");



        }

        public int OsszesSzornyszama()
        {
            return szornyek.Count;
        }

        public IEnumerable<string> Veszelyesszornyeknevei()
        {
            return szornyek.Where(sz=>sz.VeszelyessegSzint>5)
                .Select(sz=>sz.Nev).ToList();
        }
        public IEnumerable<string> EgyediElohelyek()
        {
            return szornyek.OrderBy(sz => sz.Elohely)
                .Select(sz => sz.Elohely)
                .Distinct().ToList();   
        }

        public double AtlagosVeszelyesseg()
        {
            return Convert.ToDouble( szornyek.Average(sz => sz.VeszelyessegSzint));
        }

        public IEnumerable<Szorny> LegveszelyesebbSzorny()
        {
            return szornyek.OrderByDescending(sz=>sz.VeszelyessegSzint).Take(3);
        }

        public IEnumerable<Szorny> MocsariVeszelyesSzornyek()
        {
            return szornyek.OrderByDescending(sz => sz.VeszelyessegSzint)
                .Where(sz=>sz.Elohely=="Fekete Mocsár" && sz.VeszelyessegSzint>=5);
        }

        public bool vanEextremtuzgyengeszorny()
        {
            return Convert.ToBoolean( szornyek.Where(sz=>sz.FoGyengeseg.StartsWith("Tűz ") && sz.VeszelyessegSzint>=9));
        }


        //public IEnumerable<string> Szonyekszamaelohelyenkent()
        //{
        //    return szornyek.GroupBy(sz => sz.Elohely)
        //        .Select(sz => new {Elohely = sz.Key, Count=sz.Count()})
        //        .ToList() ;
                
        //}


    }
}
