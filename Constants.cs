using System;

namespace AR.Constants
{
	public struct Math
	{
		public const byte ONE = 1;
		public const byte TWO = 2;
		public const float ONE_HALF = 0.5f;
		public const double PI = 3.14159265358979323846;
		public const double ROOT_2 = 1.41421356237309504880;
		public const double ROOT_3 = 1.73205080756887729352;
		public const double ROOT_5 = 2.23606797749978969640;
		public const double GOLDEN_RATIO = 1.61803398874989484820;
		public const double SIVER_RATIO = 2.41421356237309504880;
		public const byte ZERO = 0;
		public const int NEGATIVE_ONE = -1;
		public const double CUBE_ROOT_2 = 1.25992104989487316476;
		public const double CUBE_ROOT_3 = 1.44224957030740838232;
		public const double TWELFTH_ROOT_2 = 1.05946309435929526456;
		public const double SUPER_GOLDEN_RATIO = 1.46557123187676802665;

		// https://en.wikipedia.org/wiki/Connective_constant
		public const double CONNECTIVE_HEXAGONAL = 1.84775906502257351225;
		// CONNECTIVE_TRIANGLE
		// CONNECTIVE_SQUARE
		// CONNECTIVE_KAGOME

		public const double KEPLER_BOUWKAMP = 0.11494204485329620070;
		public const double WALLIS = 2.09455148154232659148;
		public const double EULER_NUMBER = 2.71828182845904523536;
		public const double LN_2 = 0.69314718055994530941;
		public const double LEMNISCATE = 2.62205755429211981046;
		public const double EULER = 0.57721566490153286060;
		public const double ERDOS_BORWEIN = 1.60669515241529176378;
		public const double OMEGA = 0.56714329040978387299;
		public const double APERY = 1.20205690315959428539;
		public const double LAPLACE_LIMIT = 0.66274341934918158097;
		public const double RAMANUJAN_SOLDNER = 1.45136923488338105028;
		public const double GAUSS = 0.83462684167407318628;
		public const double SECOND_HERMITE = 1.15470053837925152901;
		public const double LIOUVILLE = 0.110001000000000000000001;
		public const double FIRST_CONTINUED_FRACTION = 0.69777465796400798201;
		public const double RAMANUJAN = 262537412640768743.999999999999250073;
		public const double GLAISHER_KINKELIN = 1.28242712910062263687;
		public const double CATALAN = 0.91596559417721901505;
		public const double DOTTIE = 0.73908513321516064165;
		public const double MEISSEL_MERTENS = 0.26149721284764278375;
		public const double UNIVERSAL_PARABOLIC = 2.29558714939263807403;
		public const double CAHEN = 0.64341054628833802618;
		public const double GELFOND = 23.1406926327792690057;
		public const double GELFOND_SCHNEIDER = 2.66514414269022518865;
		public const double SECOND_FAVARD = 1.23370055013616982735;
		public const double GOLDEN_ANGLE = 2.39996322972865332223;
		public const double SIERPINSKI = 2.58498175957925321706;
		public const double LANDAU_RAMANUJAN = 0.76422365358922066299;
		public const double FIRST_NIELSEN_RAMANUJAN = 0.82246703342411321823;
		public const double GIESEKING = 1.01494160640965362502;
		public const double BERNSTEIN = 0.28016949902386913303;
		public const double TRIBONACCI = 1.83928675521416113255;
		public const double BRUN = 1.902160583104;
		public const double TWIN_PRIMES = 0.66016181584686957392;
		public const double PLASTIC = 1.32471795724474602596;
		// bloch = 
		public const double Z_SCORE_FOR_THE_975_PERCENTILE_POINT = 1.95996398454005423552;
		// Landau =
		// Landau_third =
		public const double PROUHET_THUE_MORSE = 0.41245403364010759778;
		public const double GOLOMB_DICKMAN = 0.62432998854355087099;
		// Constant related to the asymptotic behavior of Lebesgue constants =
		public const double FELLER_TORNIER = 0.66131704946962233528;
		public const double BASE_10_CHAMPERNOWNE = 0.12345678910111213141;
		public const double SALEM = 1.17628081825991750654;
		public const double KHINCHIN = 2.68545200106530644530;
		public const double LEVY_1 = 1.18656911041562545282;
		public const double LEVY_2 = 3.27582291872181115978;
		public const double COPELAND_ERDOS = 0.23571113171923293137;
		public const double MILLS = 1.30637788386308069046;
		public const double GOMPERTZ = 0.59634736232319407434;
		// de_Bruijn_Newman = 
		public const double VAN_DER_PAUW = 4.53236014182719380962;
		public const double MAGIC_ANGLE = 0.955316618124509278163;
		public const double ARTIN = 0.37395581361920228805;
		public const double PORTER = 1.46707807943397547289;
		public const double LOCHS = 0.97027011439203392574;
		public const double DEVICCI_TESSERACT = 1.00743475688427937609;
	}

	public struct Physics
	{
		
	}

	/// data from https://nssdc.gsfc.nasa.gov/planetary/factsheet/
	/// distances are in km
	/// masses are in kg
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
	}
}
