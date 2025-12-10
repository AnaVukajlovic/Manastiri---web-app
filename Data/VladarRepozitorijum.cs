using System.Collections.Generic;
using NemanjiciWebApp.Models;

namespace NemanjiciWebApp.Data
{
    public static class VladarRepozitorijum
    {
        public static List<Vladar> VratiSve()
        {
            return new List<Vladar>
            {
                new Vladar
                {
                    Id = 1,
                    Ime = "Stefan Nemanja",
                    PeriodVladavine = "1166–1196",
                    KratakOpis = "Osnivač dinastije Nemanjića, veliki župan koji je ujedinio srpske zemlje i postavio temelje države.",
                    PutanjaSlike = "/slike/vladari/stefan-nemanja.jpg"
                },
                new Vladar
                {
                    Id = 2,
                    Ime = "Stefan Prvovenčani",
                    PeriodVladavine = "1196–1228",
                    KratakOpis = "Prvi krunisani kralj Srbije, učvrstio državu i nastavio politiku svog oca Stefana Nemanje.",
                    PutanjaSlike = "/slike/vladari/stefan-prvovencani.jpg"
                },
                new Vladar
                {
                    Id = 3,
                    Ime = "Stefan Radoslav",
                    PeriodVladavine = "1228–1234",
                    KratakOpis = "Sin Stefana Prvovenčanog; njegova vladavina obeležena je jakim grčkim uticajem preko braka sa vizantijskom princezom.",
                    PutanjaSlike = "/slike/vladari/stefan-radoslav.jpg"
                },
                new Vladar
                {
                    Id = 4,
                    Ime = "Stefan Vladislav",
                    PeriodVladavine = "1234–1243",
                    KratakOpis = "Brat Stefana Radoslava; nastavio je da učvršćuje državu i naslonjen je na bugarsku političku sferu.",
                    PutanjaSlike = "/slike/vladari/stefan-vladislav.jpg"
                },
                new Vladar
                {
                    Id = 5,
                    Ime = "Stefan Uroš I",
                    PeriodVladavine = "1243–1276",
                    KratakOpis = "Poznat po razvoju rudnika i trgovine; za vreme njegove vladavine jača ekonomska moć Srbije.",
                    PutanjaSlike = "/slike/vladari/stefan-uros-prvi.jpg"
                },
                new Vladar
                {
                    Id = 6,
                    Ime = "Stefan Dragutin",
                    PeriodVladavine = "1276–1282",
                    KratakOpis = "Zbačen sa prestola u sukobu sa bratom Milutinom; kasnije vlada severnim oblastima kao ugarski vazal.",
                    PutanjaSlike = "/slike/vladari/stefan-dragutin.jpg"
                },
                new Vladar
                {
                    Id = 7,
                    Ime = "Stefan Milutin",
                    PeriodVladavine = "1282–1321",
                    KratakOpis = "Jedan od najznačajnijih Nemanjića; poznat kao veliki ktitor (Gračanica, Bogorodica Ljeviška) i vešt državnik.",
                    PutanjaSlike = "/slike/vladari/stefan-milutin.jpg"
                },
                new Vladar
                {
                    Id = 8,
                    Ime = "Stefan Uroš III Dečanski",
                    PeriodVladavine = "1321–1331",
                    KratakOpis = "Osnivač manastira Visoki Dečani; pobedio Bugare u bici kod Velbužda 1330. godine.",
                    PutanjaSlike = "/slike/vladari/stefan-uros-treci-decanski.jpg"
                },
                new Vladar
                {
                    Id = 9,
                    Ime = "Stefan Dušan",
                    PeriodVladavine = "1331–1355",
                    KratakOpis = "Car Dušan Silni; pod njim Srbija dostiže najveće teritorijalno proširenje, a donosi se i Dušanov zakonik.",
                    PutanjaSlike = "/slike/vladari/stefan-dusan.jpg"
                },
                new Vladar
                {
                    Id = 10,
                    Ime = "Stefan Uroš V",
                    PeriodVladavine = "1355–1371",
                    KratakOpis = "Poznat kao Uroš Nejaki; tokom njegove vladavine carstvo se raspada usled jačanja velikaša.",
                    PutanjaSlike = "/slike/vladari/stefan-uros-peti-nejaki.jpg"
                }
            };
        }

        public static Vladar? VratiPoId(int id)
        {
            return VratiSve().Find(v => v.Id == id);
        }
    }
}
