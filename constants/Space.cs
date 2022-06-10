using System;

namespace ApolloRoboto.Constants
{
	/// data from https://nssdc.gsfc.nasa.gov/planetary/factsheet/
	/// distances are in km
	/// masses when present are in kg
	public struct Space
	{
		public struct Mercury
		{
			public const double DIAMETER = 4879;
			public const double RADIUS = 2439.5;
			public const double MASS = 0.330e24;
		}
		public struct Venus
		{
			public const double DIAMETER = 12104;
			public const double RADIUS = 6052;
			public const double MASS = 4.87e24;
		}
		public struct Earth
		{
			public const double DIAMETER = 12756;
			public const double RADIUS = 6378;
			public const double MASS = 5.97e24;
		}
		public struct Mars
		{
			public const double DIAMETER = 6792;
			public const double RADIUS = 3396;
			public const double MASS = 0.642e24;
		}
		public struct Jupiter
		{
			public const double DIAMETER = 142984;
			public const double RADIUS = 71492;
			public const double MASS = 1898e24;
		}
		public struct Saturn
		{
			public const double DIAMETER = 120536;
			public const double RADIUS = 60268;
			public const double MASS = 568e24;
		}
		public struct Uranus
		{
			public const double DIAMETER = 51118;
			public const double RADIUS = 25559;
			public const double MASS = 86.8e24;
		}
		public struct Neptune
		{
			public const double DIAMETER = 49528;
			public const double RADIUS = 24764;
			public const double MASS = 102e24;
		}
		public struct Moon
		{
			public const double RADIUS = 1738;
			public const double DIAMETER = 3476;
		}
		public struct Phobos
		{
			public const double RADIUS = 11.267;
			public const double DIAMETER = 22.534;
		}
		public struct Deimos
		{
			public const double RADIUS = 6.2;
			public const double DIAMETER = 12.4;
		}
		public struct Io
		{
			public const double RADIUS = 1821.6;
			public const double DIAMETER = 3643.2;
		}
		public struct Europa
		{
			public const double RADIUS = 1560.8;
			public const double DIAMETER = 3121.6;
		}
		public struct Ganymede
		{
			public const double RADIUS = 2634.1;
			public const double DIAMETER = 5268.2;
		}
		public struct Callisto
		{
			public const double RADIUS = 2410.3;
			public const double DIAMETER = 4820.6;
		}
		public struct Amalthea
		{
			public const double RADIUS = 83.5;
			public const double DIAMETER = 167;
		}
		public struct Himalia
		{
			public const double RADIUS = 69.8;
			public const double DIAMETER = 139.6;
		}
		public struct Elara
		{
			public const double RADIUS = 43;
			public const double DIAMETER = 86;
		}
		public struct Pasiphae
		{
			public const double RADIUS = 30;
			public const double DIAMETER = 60;
		}
		public struct Sinope
		{
			public const double RADIUS = 19;
			public const double DIAMETER = 38;
		}
		public struct Lysithea
		{
			public const double RADIUS = 18;
			public const double DIAMETER = 36;
		}
		public struct Carme
		{
			public const double RADIUS = 23;
			public const double DIAMETER = 46;
		}
		public struct Ananke
		{
			public const double RADIUS = 14;
			public const double DIAMETER = 28;
		}
		public struct Leda
		{
			public const double RADIUS = 10;
			public const double DIAMETER = 20;
		}
		public struct Thebe
		{
			public const double RADIUS = 49.3;
			public const double DIAMETER = 98.6;
		}
		public struct Adrastea
		{
			public const double RADIUS = 8.2;
			public const double DIAMETER = 16.4;
		}
		public struct Metis
		{
			public const double RADIUS = 21.5;
			public const double DIAMETER = 43;
		}
		public struct Callirrhoe
		{
			public const double RADIUS = 4.5;
			public const double DIAMETER = 9;
		}
		public struct Themisto
		{
			public const double RADIUS = 4;
			public const double DIAMETER = 8;
		}
		public struct Megaclite
		{
			public const double RADIUS = 2.7;
			public const double DIAMETER = 5.4;
		}
		public struct Taygete
		{
			public const double RADIUS = 2.5;
			public const double DIAMETER = 5;
		}
		public struct Chaldene
		{
			public const double RADIUS = 1.9;
			public const double DIAMETER = 3.8;
		}
		public struct Harpalyke
		{
			public const double RADIUS = 2.2;
			public const double DIAMETER = 4.4;
		}
		public struct Kalyke
		{
			public const double RADIUS = 2.6;
			public const double DIAMETER = 5.2;
		}
		public struct Iocaste
		{
			public const double RADIUS = 2.6;
			public const double DIAMETER = 5.2;
		}
		public struct Erinome
		{
			public const double RADIUS = 1.6;
			public const double DIAMETER = 3.2;
		}
		public struct Isonoe
		{
			public const double RADIUS = 2;
			public const double DIAMETER = 4;
		}
		public struct Praxidike
		{
			public const double RADIUS = 3.5;
			public const double DIAMETER = 7;
		}
		public struct Autonoe
		{
			public const double RADIUS = 2;
			public const double DIAMETER = 4;
		}
		public struct Thyone
		{
			public const double RADIUS = 2;
			public const double DIAMETER = 4;
		}
		public struct Hermippe
		{
			public const double RADIUS = 2;
			public const double DIAMETER = 4;
		}
		public struct Aitne
		{
			public const double RADIUS = 1.5;
			public const double DIAMETER = 3;
		}
		public struct Eurydome
		{
			public const double RADIUS = 1.5;
			public const double DIAMETER = 3;
		}
		public struct Euanthe
		{
			public const double RADIUS = 1.5;
			public const double DIAMETER = 3;
		}
		public struct Euporie
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Orthosie
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Sponde
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Kale
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Pasithee
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Hegemone
		{
			public const double RADIUS = 1.5;
			public const double DIAMETER = 3;
		}
		public struct Mneme
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Aoede
		{
			public const double RADIUS = 2;
			public const double DIAMETER = 4;
		}
		public struct Thelxinoe
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Arche
		{
			public const double RADIUS = 1.5;
			public const double DIAMETER = 3;
		}
		public struct Kallichore
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Helike
		{
			public const double RADIUS = 2;
			public const double DIAMETER = 4;
		}
		public struct Carpo
		{
			public const double RADIUS = 1.5;
			public const double DIAMETER = 3;
		}
		public struct Eukelade
		{
			public const double RADIUS = 2;
			public const double DIAMETER = 4;
		}
		public struct Cyllene
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Kore
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Herse
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Dia
		{
			public const double RADIUS = 2;
			public const double DIAMETER = 4;
		}
		public struct Eirene
		{
			public const double RADIUS = 2;
			public const double DIAMETER = 4;
		}
		public struct Philophrosyne
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Eupheme
		{
			public const double RADIUS = 1;
			public const double DIAMETER = 2;
		}
		public struct Valetudo
		{
			public const double RADIUS = 0.5;
			public const double DIAMETER = 1;
		}
		public struct Pandia
		{
			public const double RADIUS = 1.5;
			public const double DIAMETER = 3;
		}
		public struct Ersa
		{
			public const double RADIUS = 1.5;
			public const double DIAMETER = 3;
		}
		public struct Mimas
		{
			public const double RADIUS = 198.2;
			public const double DIAMETER = 396.4;
		}
		public struct Enceladus
		{
			public const double RADIUS = 252.1;
			public const double DIAMETER = 504.2;
		}
		public struct Tethys
		{
			public const double RADIUS = 533.1;
			public const double DIAMETER = 1066.2;
		}
		public struct Dione
		{
			public const double RADIUS = 561.4;
			public const double DIAMETER = 1122.8;
		}
		public struct Rhea
		{
			public const double RADIUS = 763.8;
			public const double DIAMETER = 1527.6;
		}
		public struct Titan
		{
			public const double RADIUS = 2574.73;
			public const double DIAMETER = 5149.46;
		}
		public struct Hyperion
		{
			public const double RADIUS = 135;
			public const double DIAMETER = 270;
		}
		public struct Iapetus
		{
			public const double RADIUS = 735.6;
			public const double DIAMETER = 1471.2;
		}
		public struct Phoebe
		{
			public const double RADIUS = 106.5;
			public const double DIAMETER = 213;
		}
		public struct Janus
		{
			public const double RADIUS = 89.5;
			public const double DIAMETER = 179;
		}
		public struct Epimetheus
		{
			public const double RADIUS = 58.1;
			public const double DIAMETER = 116.2;
		}
		public struct Helene
		{
			public const double RADIUS = 17.6;
			public const double DIAMETER = 35.2;
		}
		public struct Telesto
		{
			public const double RADIUS = 12.4;
			public const double DIAMETER = 24.8;
		}
		public struct Calypso
		{
			public const double RADIUS = 10.7;
			public const double DIAMETER = 21.4;
		}
		public struct Atlas
		{
			public const double RADIUS = 15.1;
			public const double DIAMETER = 30.2;
		}
		public struct Prometheus
		{
			public const double RADIUS = 43.1;
			public const double DIAMETER = 86.2;
		}
		public struct Pandora
		{
			public const double RADIUS = 40.7;
			public const double DIAMETER = 81.4;
		}
		public struct Pan
		{
			public const double RADIUS = 14.1;
			public const double DIAMETER = 28.2;
		}
		public struct Ymir
		{
			public const double RADIUS = 9;
			public const double DIAMETER = 18;
		}
		public struct Paaliaq
		{
			public const double RADIUS = 11;
			public const double DIAMETER = 22;
		}
		public struct Tarvos
		{
			public const double RADIUS = 7.5;
			public const double DIAMETER = 15;
		}
		public struct Ijiraq
		{
			public const double RADIUS = 6;
			public const double DIAMETER = 12;
		}
		public struct Suttungr
		{
			public const double RADIUS = 3.5;
			public const double DIAMETER = 7;
		}
		public struct Kiviuq
		{
			public const double RADIUS = 8;
			public const double DIAMETER = 16;
		}
		public struct Mundilfari
		{
			public const double RADIUS = 3.5;
			public const double DIAMETER = 7;
		}
		public struct Albiorix
		{
			public const double RADIUS = 16;
			public const double DIAMETER = 32;
		}
		public struct Skathi
		{
			public const double RADIUS = 4;
			public const double DIAMETER = 8;
		}
		public struct Erriapus
		{
			public const double RADIUS = 5;
			public const double DIAMETER = 10;
		}
		public struct Siarnaq
		{
			public const double RADIUS = 20;
			public const double DIAMETER = 40;
		}
		public struct Thrymr
		{
			public const double RADIUS = 3.5;
			public const double DIAMETER = 7;
		}
		public struct Narvi
		{
			public const double RADIUS = 3.5;
			public const double DIAMETER = 7;
		}
		public struct Methone
		{
			public const double RADIUS = 1.45;
			public const double DIAMETER = 2.9;
		}
		public struct Pallene
		{
			public const double RADIUS = 2.22;
			public const double DIAMETER = 4.44;
		}
		public struct Polydeuces
		{
			public const double RADIUS = 1.3;
			public const double DIAMETER = 2.6;
		}
		public struct Daphnis
		{
			public const double RADIUS = 3.8;
			public const double DIAMETER = 7.6;
		}
		public struct Aegir
		{
			public const double RADIUS = 3;
			public const double DIAMETER = 6;
		}
		public struct Bebhionn
		{
			public const double RADIUS = 3;
			public const double DIAMETER = 6;
		}
		public struct Bergelmir
		{
			public const double RADIUS = 3;
			public const double DIAMETER = 6;
		}
		public struct Bestla
		{
			public const double RADIUS = 3.5;
			public const double DIAMETER = 7;
		}
		public struct Farbauti
		{
			public const double RADIUS = 2.5;
			public const double DIAMETER = 5;
		}
		public struct Fenrir
		{
			public const double RADIUS = 2;
			public const double DIAMETER = 4;
		}
		public struct Fornjot
		{
			public const double RADIUS = 3;
			public const double DIAMETER = 6;
		}
		public struct Hati
		{
			public const double RADIUS = 3;
			public const double DIAMETER = 6;
		}
		public struct Hyrrokkin
		{
			public const double RADIUS = 4;
			public const double DIAMETER = 8;
		}
		public struct Kari
		{
			public const double RADIUS = 3.5;
			public const double DIAMETER = 7;
		}
		public struct Loge
		{
			public const double RADIUS = 3;
			public const double DIAMETER = 6;
		}
		public struct Skoll
		{
			public const double RADIUS = 3;
			public const double DIAMETER = 6;
		}
		public struct Surtur
		{
			public const double RADIUS = 3;
			public const double DIAMETER = 6;
		}
		public struct Anthe
		{
			public const double RADIUS = 0.9;
			public const double DIAMETER = 1.8;
		}
		public struct Jarnsaxa
		{
			public const double RADIUS = 3;
			public const double DIAMETER = 6;
		}
		public struct Greip
		{
			public const double RADIUS = 3;
			public const double DIAMETER = 6;
		}
		public struct Tarqeq
		{
			public const double RADIUS = 3.5;
			public const double DIAMETER = 7;
		}
		public struct Aegaeon
		{
			public const double RADIUS = 0.33;
			public const double DIAMETER = 0.66;
		}
		public struct Ariel
		{
			public const double RADIUS = 578.9;
			public const double DIAMETER = 1157.8;
		}
		public struct Umbriel
		{
			public const double RADIUS = 584.7;
			public const double DIAMETER = 1169.4;
		}
		public struct Titania
		{
			public const double RADIUS = 788.9;
			public const double DIAMETER = 1577.8;
		}
		public struct Oberon
		{
			public const double RADIUS = 761.4;
			public const double DIAMETER = 1522.8;
		}
		public struct Miranda
		{
			public const double RADIUS = 235.8;
			public const double DIAMETER = 471.6;
		}
		public struct Cordelia
		{
			public const double RADIUS = 20.1;
			public const double DIAMETER = 40.2;
		}
		public struct Ophelia
		{
			public const double RADIUS = 21.4;
			public const double DIAMETER = 42.8;
		}
		public struct Bianca
		{
			public const double RADIUS = 25.7;
			public const double DIAMETER = 51.4;
		}
		public struct Cressida
		{
			public const double RADIUS = 39.8;
			public const double DIAMETER = 79.6;
		}
		public struct Desdemona
		{
			public const double RADIUS = 32;
			public const double DIAMETER = 64;
		}
		public struct Juliet
		{
			public const double RADIUS = 46.8;
			public const double DIAMETER = 93.6;
		}
		public struct Portia
		{
			public const double RADIUS = 67.6;
			public const double DIAMETER = 135.2;
		}
		public struct Rosalind
		{
			public const double RADIUS = 36;
			public const double DIAMETER = 72;
		}
		public struct Belinda
		{
			public const double RADIUS = 40.3;
			public const double DIAMETER = 80.6;
		}
		public struct Puck
		{
			public const double RADIUS = 81;
			public const double DIAMETER = 162;
		}
		public struct Caliban
		{
			public const double RADIUS = 36.4;
			public const double DIAMETER = 72.8;
		}
		public struct Sycorax
		{
			public const double RADIUS = 93;
			public const double DIAMETER = 186;
		}
		public struct Prospero
		{
			public const double RADIUS = 25;
			public const double DIAMETER = 50;
		}
		public struct Setebos
		{
			public const double RADIUS = 24;
			public const double DIAMETER = 48;
		}
		public struct Stephano
		{
			public const double RADIUS = 16;
			public const double DIAMETER = 32;
		}
		public struct Trinculo
		{
			public const double RADIUS = 9.5;
			public const double DIAMETER = 19;
		}
		public struct Francisco
		{
			public const double RADIUS = 11;
			public const double DIAMETER = 22;
		}
		public struct Margaret
		{
			public const double RADIUS = 10;
			public const double DIAMETER = 20;
		}
		public struct Ferdinand
		{
			public const double RADIUS = 10;
			public const double DIAMETER = 20;
		}
		public struct Perdita
		{
			public const double RADIUS = 15;
			public const double DIAMETER = 30;
		}
		public struct Mab
		{
			public const double RADIUS = 12;
			public const double DIAMETER = 24;
		}
		public struct Cupid
		{
			public const double RADIUS = 9;
			public const double DIAMETER = 18;
		}
		public struct Triton
		{
			public const double RADIUS = 1353.4;
			public const double DIAMETER = 2706.8;
		}
		public struct Nereid
		{
			public const double RADIUS = 170;
			public const double DIAMETER = 340;
		}
		public struct Naiad
		{
			public const double RADIUS = 33;
			public const double DIAMETER = 66;
		}
		public struct Thalassa
		{
			public const double RADIUS = 41;
			public const double DIAMETER = 82;
		}
		public struct Despina
		{
			public const double RADIUS = 78;
			public const double DIAMETER = 156;
		}
		public struct Galatea
		{
			public const double RADIUS = 88;
			public const double DIAMETER = 176;
		}
		public struct Larissa
		{
			public const double RADIUS = 97;
			public const double DIAMETER = 194;
		}
		public struct Proteus
		{
			public const double RADIUS = 210;
			public const double DIAMETER = 420;
		}
		public struct Halimede
		{
			public const double RADIUS = 31;
			public const double DIAMETER = 62;
		}
		public struct Psamathe
		{
			public const double RADIUS = 20;
			public const double DIAMETER = 40;
		}
		public struct Sao
		{
			public const double RADIUS = 22;
			public const double DIAMETER = 44;
		}
		public struct Laomedeia
		{
			public const double RADIUS = 21;
			public const double DIAMETER = 42;
		}
		public struct Neso
		{
			public const double RADIUS = 30;
			public const double DIAMETER = 60;
		}
		public struct Hippocamp
		{
			public const double RADIUS = 17.4;
			public const double DIAMETER = 34.8;
		}
		public struct Vanth
		{
			public const double RADIUS = 221;
			public const double DIAMETER = 442;
		}
		public struct Charon
		{
			public const double RADIUS = 606;
			public const double DIAMETER = 1212;
		}
		public struct Nix
		{
			public const double RADIUS = 22.5;
			public const double DIAMETER = 45;
		}
		public struct Hydra
		{
			public const double RADIUS = 27.5;
			public const double DIAMETER = 55;
		}
		public struct Kerberos
		{
			public const double RADIUS = 7;
			public const double DIAMETER = 14;
		}
		public struct Styx
		{
			public const double RADIUS = 5.5;
			public const double DIAMETER = 11;
		}
		public struct Actaea
		{
			public const double RADIUS = 142;
			public const double DIAMETER = 284;
		}
		public struct Hi_iaka
		{
			public const double RADIUS = 160;
			public const double DIAMETER = 320;
		}
		public struct Namaka
		{
			public const double RADIUS = 85;
			public const double DIAMETER = 170;
		}
		public struct Weywot
		{
			public const double RADIUS = 37;
			public const double DIAMETER = 74;
		}
		public struct Ilmare
		{
			public const double RADIUS = 163;
			public const double DIAMETER = 326;
		}
		public struct Xiangliu
		{
			public const double RADIUS = 150;
			public const double DIAMETER = 300;
		}
		public struct Dysnomia
		{
			public const double RADIUS = 350;
			public const double DIAMETER = 700;
		}
	}
}
