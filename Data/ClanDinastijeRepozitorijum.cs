using System.Collections.Generic;
using System.Linq;
using NemanjiciWebApp.Models;

namespace NemanjiciWebApp.Data
{
    public static class ClanDinastijeRepozitorijum
    {
        private static readonly List<ClanDinastije> _clanovi = new List<ClanDinastije>
{
    new ClanDinastije
    {
        Id = 1,
        Ime = "Stefan Nemanja",
        Uloga = "vladar",
        RoditeljId = null,
        Period = "oko 1166–1196",
        Napomena = "Osnivač dinastije Nemanjića i veliki župan koji je ujedinio srpske zemlje."
    },
    new ClanDinastije
    {
        Id = 2,
        Ime = "Stefan Prvovenčani",
        Uloga = "vladar",
        RoditeljId = 1,
        Period = "1196–1228",
        Napomena = "Prvi krunisani kralj Srbije, sin Stefana Nemanje."
    },
    new ClanDinastije
    {
        Id = 3,
        Ime = "Stefan Radoslav",
        Uloga = "vladar",
        RoditeljId = 2,
        Period = "1228–1234",
        Napomena = "Kralj Srbije, sin Stefana Prvovenčanog."
    },
    new ClanDinastije
    {
        Id = 4,
        Ime = "Stefan Vladislav",
        Uloga = "vladar",
        RoditeljId = 2,
        Period = "1234–1243",
        Napomena = "Kralj Srbije, brat Stefana Radoslava."
    },
    new ClanDinastije
    {
        Id = 5,
        Ime = "Stefan Uroš I",
        Uloga = "vladar",
        RoditeljId = 2,
        Period = "1243–1276",
        Napomena = "Kralj Srbije, sin Stefana Prvovenčanog."
    },
    new ClanDinastije
    {
        Id = 6,
        Ime = "Stefan Dragutin",
        Uloga = "vladar",
        RoditeljId = 5,
        Period = "1276–1282",
        Napomena = "Kralj Srbije, sin Stefana Uroša I."
    },
    new ClanDinastije
    {
        Id = 7,
        Ime = "Stefan Milutin",
        Uloga = "vladar",
        RoditeljId = 5,
        Period = "1282–1321",
        Napomena = "Kralj Srbije poznat po brojnim zadužbinama."
    },
    new ClanDinastije
    {
        Id = 8,
        Ime = "Stefan Uroš III Dečanski",
        Uloga = "vladar",
        RoditeljId = 7,
        Period = "1321–1331",
        Napomena = "Kralj Srbije, otac cara Dušana."
    },
    new ClanDinastije
    {
        Id = 9,
        Ime = "Stefan Dušan",
        Uloga = "vladar",
        RoditeljId = 8,
        Period = "1331–1355",
        Napomena = "Car Dušan Silni, pod kojim Srbija dostiže najveće teritorijalno proširenje."
    },
    new ClanDinastije
    {
        Id = 10,
        Ime = "Stefan Uroš V",
        Uloga = "vladar",
        RoditeljId = 9,
        Period = "1355–1371",
        Napomena = "Poslednji vladar dinastije Nemanjića, poznat kao Uroš Nejak."
    },
    new ClanDinastije
    {
        Id = 11,
        Ime = "Sava Nemanjić",
        Uloga = "član porodice",
        RoditeljId = 1,
        Period = null,
        Napomena = "Sveti Sava, prvi srpski arhiepiskop."
    }
};


        public static List<ClanDinastije> VratiSve()
        {
            return _clanovi;
        }

        public static ClanDinastije? VratiPoId(int id)
        {
            return _clanovi.FirstOrDefault(c => c.Id == id);
        }

        public static List<ClanDinastije> VratiDecu(int roditeljId)
        {
            return _clanovi.Where(c => c.RoditeljId == roditeljId).ToList();
        }

        public static List<ClanDinastije> VratiKorenove()
        {
            return _clanovi.Where(c => c.RoditeljId == null).ToList();
        }
    }
}
