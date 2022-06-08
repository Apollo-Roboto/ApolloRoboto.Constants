
This file is listing all moons to add to the Space section.

https://en.wikipedia.org/wiki/List_of_natural_satellites

The following javascript code is made to get some data from the table on the wikipedia page. not perfect but was able to write a lot.
```javascript
let tr = Array.from(document.querySelector("html.client-js.ve-available body.mediawiki.ltr.sitedir-ltr.mw-hide-empty-elt.ns-0.ns-subject.mw-editable.page-List_of_natural_satellites.rootpage-List_of_natural_satellites.skin-vector.action-view.skin-vector-legacy div#content.mw-body div#bodyContent.vector-body div#mw-content-text.mw-body-content.mw-content-ltr div.mw-parser-output table.wikitable.sortable.jquery-tablesorter tbody").getElementsByTagName("tr"));

let finalString = "";

tr.forEach(x => {
	let name = x.getElementsByTagName("td")[3].textContent;
	let radius = x.getElementsByTagName("td")[4].textContent.replaceAll(",|\n", "");

	let s = "public struct " + name + "\n" +
		"{\n" +
		"	public const double RADIUS " + radius + ";\n" +
		"}\n";

	finalString += s;
});

console.log(finalString);
```

```c#
public struct Moon
{
	public const double RADIUS 1738;
}
public struct Phobos
{
	public const double RADIUS 11.267;
}
public struct Deimos
{
	public const double RADIUS 6.2;
}
public struct Io
{
	public const double RADIUS 1821.6;
}
public struct Europa
{
	public const double RADIUS 1560.8;
}
public struct Ganymede
{
	public const double RADIUS 2634.1;
}
public struct Callisto
{
	public const double RADIUS 2410.3;
}
public struct Amalthea
{
	public const double RADIUS 83.5;
}
public struct Himalia
{
	public const double RADIUS 69.8;
}
public struct Elara
{
	public const double RADIUS 43;
}
public struct Pasiphae
{
	public const double RADIUS 30;
}
public struct Sinope
{
	public const double RADIUS 19;
}
public struct Lysithea
{
	public const double RADIUS 18;
}
public struct Carme
{
	public const double RADIUS 23;
}
public struct Ananke
{
	public const double RADIUS 14;
}
public struct Leda
{
	public const double RADIUS 10;
}
public struct Thebe
{
	public const double RADIUS 49.3;
}
public struct Adrastea
{
	public const double RADIUS 8.2;
}
public struct Metis
{
	public const double RADIUS 21.5;
}
public struct Callirrhoe
{
	public const double RADIUS 4.5;
}
public struct Themisto
{
	public const double RADIUS 4;
}
public struct Megaclite
{
	public const double RADIUS 2.7;
}
public struct Taygete
{
	public const double RADIUS 2.5;
}
public struct Chaldene
{
	public const double RADIUS 1.9;
}
public struct Harpalyke
{
	public const double RADIUS 2.2;
}
public struct Kalyke
{
	public const double RADIUS 2.6;
}
public struct Iocaste
{
	public const double RADIUS 2.6;
}
public struct Erinome
{
	public const double RADIUS 1.6;
}
public struct Isonoe
{
	public const double RADIUS 2;
}
public struct Praxidike
{
	public const double RADIUS 3.5;
}
public struct Autonoe
{
	public const double RADIUS 2;
}
public struct Thyone
{
	public const double RADIUS 2;
}
public struct Hermippe
{
	public const double RADIUS 2;
}
public struct Aitne
{
	public const double RADIUS 1.5;
}
public struct Eurydome
{
	public const double RADIUS 1.5;
}
public struct Euanthe
{
	public const double RADIUS 1.5;
}
public struct Euporie
{
	public const double RADIUS 1;
}
public struct Orthosie
{
	public const double RADIUS 1;
}
public struct Sponde
{
	public const double RADIUS 1;
}
public struct Kale
{
	public const double RADIUS 1;
}
public struct Pasithee
{
	public const double RADIUS 1;
}
public struct Hegemone
{
	public const double RADIUS 1.5;
}
public struct Mneme
{
	public const double RADIUS 1;
}
public struct Aoede
{
	public const double RADIUS 2;
}
public struct Thelxinoe
{
	public const double RADIUS 1;
}
public struct Arche
{
	public const double RADIUS 1.5;
}
public struct Kallichore
{
	public const double RADIUS 1;
}
public struct Helike
{
	public const double RADIUS 2;
}
public struct Carpo
{
	public const double RADIUS 1.5;
}
public struct Eukelade
{
	public const double RADIUS 2;
}
public struct Cyllene
{
	public const double RADIUS 1;
}
public struct Kore
{
	public const double RADIUS 1;
}
public struct Herse
{
	public const double RADIUS 1;
}
public struct S_2010 J 1
{
	public const double RADIUS 1;
}
public struct S_2010 J 2
{
	public const double RADIUS 0.5;
}
public struct Dia
{
	public const double RADIUS 2;
}
public struct S_2016 J 1
{
	public const double RADIUS 3;
}
public struct S_2003 J 18
{
	public const double RADIUS 1;
}
public struct S_2011 J 2
{
	public const double RADIUS 0.5;
}
public struct Eirene
{
	public const double RADIUS 2;
}
public struct Philophrosyne
{
	public const double RADIUS 1;
}
public struct S_2017 J 1
{
	public const double RADIUS 2;
}
public struct Eupheme
{
	public const double RADIUS 1;
}
public struct S_2003 J 19
{
	public const double RADIUS 1;
}
public struct Valetudo
{
	public const double RADIUS 0.5;
}
public struct S_2017 J 2
{
	public const double RADIUS 1;
}
public struct S_2017 J 3
{
	public const double RADIUS 1;
}
public struct Pandia
{
	public const double RADIUS 1.5;
}
public struct S_2017 J 5
{
	public const double RADIUS 1;
}
public struct S_2017 J 6
{
	public const double RADIUS 1;
}
public struct S_2017 J 7
{
	public const double RADIUS 1;
}
public struct S_2017 J 8
{
	public const double RADIUS 0.5;
}
public struct S_2017 J 9
{
	public const double RADIUS 1;
}
public struct Ersa
{
	public const double RADIUS 1.5;
}
public struct S_2011 J 1
{
	public const double RADIUS 0.5;
}
public struct S_2003 J 2
{
	public const double RADIUS 1;
}
public struct S_2003 J 4
{
	public const double RADIUS 1;
}
public struct S_2003 J 9
{
	public const double RADIUS 0.5;
}
public struct S_2003 J 10
{
	public const double RADIUS 1;
}
public struct S_2003 J 12
{
	public const double RADIUS 0.5;
}
public struct S_2003 J 16
{
	public const double RADIUS 1;
}
public struct S_2003 J 23
{
	public const double RADIUS 1;
}
public struct S_2003 J 24
{
	public const double RADIUS 3;
}
public struct Mimas
{
	public const double RADIUS 198.2;
}
public struct Enceladus
{
	public const double RADIUS 252.1;
}
public struct Tethys
{
	public const double RADIUS 533.1;
}
public struct Dione
{
	public const double RADIUS 561.4;
}
public struct Rhea
{
	public const double RADIUS 763.8;
}
public struct Titan
{
	public const double RADIUS 2574.73;
}
public struct Hyperion
{
	public const double RADIUS 135;
}
public struct Iapetus
{
	public const double RADIUS 735.6;
}
public struct Phoebe
{
	public const double RADIUS 106.5;
}
public struct Janus
{
	public const double RADIUS 89.5;
}
public struct Epimetheus
{
	public const double RADIUS 58.1;
}
public struct Helene
{
	public const double RADIUS 17.6;
}
public struct Telesto
{
	public const double RADIUS 12.4;
}
public struct Calypso
{
	public const double RADIUS 10.7;
}
public struct Atlas
{
	public const double RADIUS 15.1;
}
public struct Prometheus
{
	public const double RADIUS 43.1;
}
public struct Pandora
{
	public const double RADIUS 40.7;
}
public struct Pan
{
	public const double RADIUS 14.1;
}
public struct Ymir
{
	public const double RADIUS 9;
}
public struct Paaliaq
{
	public const double RADIUS 11;
}
public struct Tarvos
{
	public const double RADIUS 7.5;
}
public struct Ijiraq
{
	public const double RADIUS 6;
}
public struct Suttungr
{
	public const double RADIUS 3.5;
}
public struct Kiviuq
{
	public const double RADIUS 8;
}
public struct Mundilfari
{
	public const double RADIUS 3.5;
}
public struct Albiorix
{
	public const double RADIUS 16;
}
public struct Skathi
{
	public const double RADIUS 4;
}
public struct Erriapus
{
	public const double RADIUS 5;
}
public struct Siarnaq
{
	public const double RADIUS 20;
}
public struct Thrymr
{
	public const double RADIUS 3.5;
}
public struct Narvi
{
	public const double RADIUS 3.5;
}
public struct Methone
{
	public const double RADIUS 1.45;
}
public struct Pallene
{
	public const double RADIUS 2.22;
}
public struct Polydeuces
{
	public const double RADIUS 1.3;
}
public struct Daphnis
{
	public const double RADIUS 3.8;
}
public struct Aegir
{
	public const double RADIUS 3;
}
public struct Bebhionn
{
	public const double RADIUS 3;
}
public struct Bergelmir
{
	public const double RADIUS 3;
}
public struct Bestla
{
	public const double RADIUS 3.5;
}
public struct Farbauti
{
	public const double RADIUS 2.5;
}
public struct Fenrir
{
	public const double RADIUS 2;
}
public struct Fornjot
{
	public const double RADIUS 3;
}
public struct Hati
{
	public const double RADIUS 3;
}
public struct Hyrrokkin
{
	public const double RADIUS 4;
}
public struct Kari
{
	public const double RADIUS 3.5;
}
public struct Loge
{
	public const double RADIUS 3;
}
public struct Skoll
{
	public const double RADIUS 3;
}
public struct Surtur
{
	public const double RADIUS 3;
}
public struct Anthe
{
	public const double RADIUS 0.9;
}
public struct Jarnsaxa
{
	public const double RADIUS 3;
}
public struct Greip
{
	public const double RADIUS 3;
}
public struct Tarqeq
{
	public const double RADIUS 3.5;
}
public struct Aegaeon
{
	public const double RADIUS 0.33;
}
public struct S_2004_S_20
{
	public const double RADIUS 3;
}
public struct S_2004_S_22
{
	public const double RADIUS 3;
}
public struct S_2004_S_23
{
	public const double RADIUS 4;
}
public struct S_2004_S_25
{
	public const double RADIUS 4;
}
public struct S_2004_S_26
{
	public const double RADIUS 4;
}
public struct S_2004_S_27
{
	public const double RADIUS 6;
}
public struct S_2004_S_29
{
	public const double RADIUS 4;
}
public struct S_2004_S_30
{
	public const double RADIUS 3;
}
public struct S_2004_S_32
{
	public const double RADIUS 4;
}
public struct S_2004_S_33
{
	public const double RADIUS 4;
}
public struct S_2004_S_34
{
	public const double RADIUS 3;
}
public struct S_2004_S_35
{
	public const double RADIUS 6;
}
public struct S_2004_S_38
{
	public const double RADIUS 4;
}
public struct S_2004_S_7
{
	public const double RADIUS 3;
}
public struct S_2004_S_12
{
	public const double RADIUS 2.5;
}
public struct S_2004_S_13
{
	public const double RADIUS 3;
}
public struct S_2004_S_17
{
	public const double RADIUS 2;
}
public struct S_2004_S_21
{
	public const double RADIUS 3;
}
public struct S_2004_S_24
{
	public const double RADIUS 3;
}
public struct S_2004_S_28
{
	public const double RADIUS 4;
}
public struct S_2004_S_31
{
	public const double RADIUS 4;
}
public struct S_2004_S_36
{
	public const double RADIUS 3;
}
public struct S_2004_S_37
{
	public const double RADIUS 4;
}
public struct S_2004_S_39
{
	public const double RADIUS 3;
}
public struct S_2006_S_1
{
	public const double RADIUS 3;
}
public struct S_2006_S_3
{
	public const double RADIUS 3;
}
public struct S_2007_S_2
{
	public const double RADIUS 3;
}
public struct S_2007_S_3
{
	public const double RADIUS 3;
}
public struct S_2009_S_1
{
	public const double RADIUS 0.15;
}
public struct S_2019_S_1
{
	public const double RADIUS 3;
}
public struct Ariel
{
	public const double RADIUS 578.9;
}
public struct Umbriel
{
	public const double RADIUS 584.7;
}
public struct Titania
{
	public const double RADIUS 788.9;
}
public struct Oberon
{
	public const double RADIUS 761.4;
}
public struct Miranda
{
	public const double RADIUS 235.8;
}
public struct Cordelia
{
	public const double RADIUS 20.1;
}
public struct Ophelia
{
	public const double RADIUS 21.4;
}
public struct Bianca
{
	public const double RADIUS 25.7;
}
public struct Cressida
{
	public const double RADIUS 39.8;
}
public struct Desdemona
{
	public const double RADIUS 32;
}
public struct Juliet
{
	public const double RADIUS 46.8;
}
public struct Portia
{
	public const double RADIUS 67.6;
}
public struct Rosalind
{
	public const double RADIUS 36;
}
public struct Belinda
{
	public const double RADIUS 40.3;
}
public struct Puck
{
	public const double RADIUS 81;
}
public struct Caliban
{
	public const double RADIUS 36.4;
}
public struct Sycorax
{
	public const double RADIUS 93;
}
public struct Prospero
{
	public const double RADIUS 25;
}
public struct Setebos
{
	public const double RADIUS 24;
}
public struct Stephano
{
	public const double RADIUS 16;
}
public struct Trinculo
{
	public const double RADIUS 9.5;
}
public struct Francisco
{
	public const double RADIUS 11;
}
public struct Margaret
{
	public const double RADIUS 10;
}
public struct Ferdinand
{
	public const double RADIUS 10;
}
public struct Perdita
{
	public const double RADIUS 15;
}
public struct Mab
{
	public const double RADIUS 12;
}
public struct Cupid
{
	public const double RADIUS 9;
}
public struct Triton
{
	public const double RADIUS 1353.4;
}
public struct Nereid
{
	public const double RADIUS 170;
}
public struct Naiad
{
	public const double RADIUS 33;
}
public struct Thalassa
{
	public const double RADIUS 41;
}
public struct Despina
{
	public const double RADIUS 78;
}
public struct Galatea
{
	public const double RADIUS 88;
}
public struct Larissa
{
	public const double RADIUS 97;
}
public struct Proteus
{
	public const double RADIUS 210;
}
public struct Halimede
{
	public const double RADIUS 31;
}
public struct Psamathe
{
	public const double RADIUS 20;
}
public struct Sao
{
	public const double RADIUS 22;
}
public struct Laomedeia
{
	public const double RADIUS 21;
}
public struct Neso
{
	public const double RADIUS 30;
}
public struct Hippocamp
{
	public const double RADIUS 17.4;
}
public struct Vanth
{
	public const double RADIUS 221;
}
public struct (unnamed)
{
	public const double RADIUS 72;
}
public struct Charon
{
	public const double RADIUS 606;
}
public struct Nix
{
	public const double RADIUS 22.5;
}
public struct Hydra
{
	public const double RADIUS 27.5;
}
public struct Kerberos
{
	public const double RADIUS 7;
}
public struct Styx
{
	public const double RADIUS 5.5;
}
public struct Actaea
{
	public const double RADIUS 142;
}
public struct Hi_iaka
{
	public const double RADIUS 160;
}
public struct Namaka
{
	public const double RADIUS 85;
}
public struct Weywot
{
	public const double RADIUS 37;
}
public struct S_2015_136472_1
{
	public const double RADIUS 87.5;
}
public struct Ilmare
{
	public const double RADIUS 163;
}
public struct Xiangliu
{
	public const double RADIUS 150;
}
public struct Dysnomia
{
	public const double RADIUS 350;
}
```