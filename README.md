# Manastiri---web-app

# NemanjiciWebApp

NemanjiciWebApp je edukativna web aplikacija o dinastiji Nemanjića, urađena u ASP.NET Core MVC. Projekat prikazuje vladare, porodično stablo, manastire i osnovnu strukturu demo web shopa, sa fokusom na prijatan dizajn i čitljiv raspored sadržaja.

## Opis projekta

Aplikacija obuhvata:

- pregled vladara dinastije Nemanjića,
- porodično stablo (lozu) vladara,
- pregled manastira i njihove kulturne uloge,
- osnovu za demo web shop sa suvenirima.

Cilj projekta je učenje i demonstracija rada u ASP.NET Core MVC, organizacije koda u MVC arhitekturi i stilizacije frontenda (HTML/CSS/Bootstrap) kroz jedan zaokružen primer.

## Tehnologije

- **Backend**: ASP.NET Core MVC (C#)  
- **Frontend**: Razor views, HTML5, CSS3, Bootstrap  
- **Arhitektura**: MVC sa jednostavnim repozitorijumima (in-memory kolekcije)  
- **Razvoj/Build**: .NET SDK

## Funkcionalnosti

### Početna stranica

- Moderni “landing page” sa hero sekcijom i kratkim opisom projekta.  
- Istaknute veze ka: vladarima, manastirima, porodičnom stablu i web shopu.

### Dinastija / Vladari

- Lista glavnih vladara dinastije Nemanjića (ime, period vladavine, kratak opis, slika).  
- Horizontalna vremenska linija (timeline) sa vladarima poređanim hronološki.  
- Detaljna stranica za svakog vladara.

### Porodično stablo (loza)

- Porodično stablo dinastije prikazano čistim HTML+CSS (ugneždene liste + linije između čvorova).  
- Glavne grane od Stefana Nemanje do Stefana Uroša V, uz Vukana i Svetog Savu.  
- Klik na vladara iz stabla otvara njegov detaljan prikaz.

### Manastiri

- Manastiri predstavljeni kao “ruta” / hodočasnička staza (vertikalna lista sa markerima).  
- Svaka stanica sadrži naziv, kratak opis, ktitora, period i lokaciju.  
- Pretraga manastira po nazivu, ktitoru ili lokaciji.  
- Sortiranje po nazivu i periodu.  
- Detaljna stranica manastira (slika + osnovne informacije).

### Web shop (osnovna struktura)

- Stranica za demo web shop sa fiktivnim proizvodima (knjige, posteri, suveniri).  
- Pripremljene stranice i routing za kasnije proširenje (korpa, detalji proizvoda).

## Struktura aplikacije

- `Controllers/` – MVC kontroleri (Home, Vladari, Manastiri, Dinastija, Shop, …).  
- `Models/` – modeli domena (`Vladar`, `Manastir`, `ClanDinastije`, `Proizvod`, …).  
- `Data/` – jednostavni repozitorijumi sa in-memory listama (`VladarRepozitorijum`, `ManastirRepozitorijum`, …).  
- `Views/` – Razor view‑ovi po kontrolerima (početna, vladari, manastiri, stablo, shop, …).  
- `wwwroot/css/site.css` – glavni stilovi (paleta boja: `#F2DDB6`, `#734E20`, `#D9C8B4`, `#8C7D70`, `#40110D`).  
- `wwwroot/slike/` – slike vladara, manastira i proizvoda.

## Ćirilica/latinica tekst
## Dodavanje linkova ka videima ya manastire/ktitore
## Dodavanje ostalih funkcionalnosti - kviy, mapa, računanje datuma Vaskrsa, kalendar postova...

