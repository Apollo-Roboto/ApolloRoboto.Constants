using System;

namespace ApolloRoboto.Constants
{
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
