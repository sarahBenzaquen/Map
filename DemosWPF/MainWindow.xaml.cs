using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemosWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		public MainWindow()
		{
			InitializeComponent();
			Map.AccessToken = "pk.eyJ1Ijoic2FyaXRhNTUiLCJhIjoiY2t2cXBwbGZzYWwzbTJ1czdmeXpzNDhtOSJ9.uryPfZDyocf_Ih4D2YeNdg";
            //put my own style with this
           // Map.MapStyle = "mapbox://styles/sarita55/cl06fm4lf000z14sz18b71tps";
            //or with JSON 
            var style = new Dictionary<string, object>
			{
				["version"] = 8,
				["name"] = "Monochrome",
				["metadata"] = new Dictionary<string, object>
				{
					["mapbox:type"] = "default",
					["mapbox:origin"] = "monochrome-dark-v1",
					["mapbox:sdk-support"] = new Dictionary<string, object>
					{
						["android"] = "10.0.0",
						["ios"] = "10.0.0",
						["js"] = "2.6.0",
					},
					["mapbox:autocomposite"] = true,
					["mapbox:groups"] = new Dictionary<string, object>
					{
						["Land, water, & sky, land"] = new Dictionary<string, object>
						{
							["name"] = "Land, water, & sky, land",
							["collapsed"] = true,
						},
						["Land, water, & sky, water"] = new Dictionary<string, object>
						{
							["name"] = "Land, water, & sky, water",
							["collapsed"] = true,
						},
						["Land, water, & sky, built"] = new Dictionary<string, object>
						{
							["name"] = "Land, water, & sky, built",
							["collapsed"] = true,
						},
						["Transit, built"] = new Dictionary<string, object>
						{
							["name"] = "Transit, built",
							["collapsed"] = true,
						},
						["Buildings, built"] = new Dictionary<string, object>
						{
							["name"] = "Buildings, built",
							["collapsed"] = true,
						},
						["Road network, tunnels-case"] = new Dictionary<string, object>
						{
							["name"] = "Road network, tunnels-case",
							["collapsed"] = true,
						},
						["Road network, tunnels"] = new Dictionary<string, object>
						{
							["name"] = "Road network, tunnels",
							["collapsed"] = true,
						},
						["Road network, surface"] = new Dictionary<string, object>
						{
							["name"] = "Road network, surface",
							["collapsed"] = true,
						},
						["Transit, surface"] = new Dictionary<string, object>
						{
							["name"] = "Transit, surface",
							["collapsed"] = true,
						},
						["Road network, surface-icons"] = new Dictionary<string, object>
						{
							["name"] = "Road network, surface-icons",
							["collapsed"] = true,
						},
						["Road network, bridges"] = new Dictionary<string, object>
						{
							["name"] = "Road network, bridges",
							["collapsed"] = true,
						},
						["Transit, bridges"] = new Dictionary<string, object>
						{
							["name"] = "Transit, bridges",
							["collapsed"] = true,
						},
						["Administrative boundaries, admin"] = new Dictionary<string, object>
						{
							["name"] = "Administrative boundaries, admin",
							["collapsed"] = true,
						},
						["Road network, road-labels"] = new Dictionary<string, object>
						{
							["name"] = "Road network, road-labels",
							["collapsed"] = true,
						},
						["Natural features, natural-labels"] = new Dictionary<string, object>
						{
							["name"] = "Natural features, natural-labels",
							["collapsed"] = true,
						},
						["Point of interest labels, poi-labels"] = new Dictionary<string, object>
						{
							["name"] = "Point of interest labels, poi-labels",
							["collapsed"] = true,
						},
						["Transit, transit-labels"] = new Dictionary<string, object>
						{
							["name"] = "Transit, transit-labels",
							["collapsed"] = true,
						},
						["Place labels, place-labels"] = new Dictionary<string, object>
						{
							["name"] = "Place labels, place-labels",
							["collapsed"] = true,
						},
					},
					["mapbox:decompiler"] = new Dictionary<string, object>
					{
						["id"] = "monochrome-dark-v1",
						["componentVersion"] = "11.2.0",
						["strata"] = new object[] {
				new Dictionary<string, object> {
					["id"] = "monochrome-dark-v1",
					["order"] = new object[] {
						new object[] {
							"land-and-water",
							"land",
						},
						new object[] {
							"land-and-water",
							"water",
						},
						new object[] {
							"land-and-water",
							"built",
						},
						new object[] {
							"transit",
							"built",
						},
						new object[] {
							"buildings",
							"built",
						},
						new object[] {
							"road-network",
							"tunnels-case",
						},
						new object[] {
							"road-network",
							"tunnels",
						},
						new object[] {
							"transit",
							"ferries",
						},
						new object[] {
							"road-network",
							"surface",
						},
						new object[] {
							"transit",
							"surface",
						},
						new object[] {
							"road-network",
							"surface-icons",
						},
						new object[] {
							"road-network",
							"bridges",
						},
						new object[] {
							"transit",
							"bridges",
						},
						new object[] {
							"road-network",
							"traffic-and-closures",
						},
						new object[] {
							"buildings",
							"extruded",
						},
						new object[] {
							"transit",
							"elevated",
						},
						new object[] {
							"admin-boundaries",
							"admin",
						},
						new object[] {
							"buildings",
							"building-labels",
						},
						new object[] {
							"road-network",
							"road-labels",
						},
						new object[] {
							"transit",
							"ferry-aerialway-labels",
						},
						new object[] {
							"natural-features",
							"natural-labels",
						},
						new object[] {
							"point-of-interest-labels",
							"poi-labels",
						},
						new object[] {
							"transit",
							"transit-labels",
						},
						new object[] {
							"place-labels",
							"place-labels",
						},
						new object[] {
							"land-and-water",
							"sky",
						},
					},
				},
			},
						["components"] = new Dictionary<string, object>
						{
							["land-and-water"] = "11.2.0",
							["buildings"] = "11.1.1",
							["road-network"] = "11.2.0",
							["admin-boundaries"] = "11.1.1",
							["natural-features"] = "11.1.1",
							["point-of-interest-labels"] = "11.1.1",
							["transit"] = "11.1.1",
							["place-labels"] = "11.1.1",
						},
						["propConfig"] = new Dictionary<string, object>
						{
							["land-and-water"] = new Dictionary<string, object>
							{
								["colorBase"] = "hsl(185, 0%, 23%)",
								["landType"] = "Landuse only",
								["transitionLandOnZoom"] = false,
							},
							["buildings"] = new Dictionary<string, object>
							{
								["colorBase"] = "hsl(185, 0%, 23%)",
								["houseNumbers"] = false,
							},
							["road-network"] = new Dictionary<string, object>
							{
								["colorBase"] = "hsl(185, 0%, 23%)",
								["exits"] = false,
								["railwayCrossings"] = false,
								["oneWayArrows"] = false,
								["polygonFeatures"] = false,
								["shields"] = false,
								["iconColorScheme"] = "Monochrome",
							},
							["admin-boundaries"] = new Dictionary<string, object>
							{
								["colorBase"] = "hsl(185, 0%, 23%)",
							},
							["natural-features"] = new Dictionary<string, object>
							{
								["colorBase"] = "hsl(185, 0%, 23%)",
								["labelStyle"] = "Text only",
								["density"] = 1,
							},
							["point-of-interest-labels"] = new Dictionary<string, object>
							{
								["colorBase"] = "hsl(185, 0%, 23%)",
								["labelStyle"] = "Text only",
								["density"] = 1,
							},
							["transit"] = new Dictionary<string, object>
							{
								["colorBase"] = "hsl(185, 0%, 23%)",
								["aerialways"] = false,
								["ferries"] = false,
								["transitLabels"] = false,
								["railwayStyle"] = false,
								["iconColorScheme"] = "Monochrome",
							},
							["place-labels"] = new Dictionary<string, object>
							{
								["colorBase"] = "hsl(185, 0%, 23%)",
							},
						},
					},
				},
				["center"] = new object[] {
		-122.4241,
		37.78,
	},
				["zoom"] = 9,
				["sources"] = new Dictionary<string, object>
				{
					["mapbox://mapbox.mapbox-traffic-v1"] = new Dictionary<string, object>
					{
						["url"] = "mapbox://mapbox.mapbox-traffic-v1",
						["type"] = "vector",
					},
					["composite"] = new Dictionary<string, object>
					{
						["url"] = "mapbox://mapbox.mapbox-streets-v8,mapbox.mapbox-terrain-v2",
						["type"] = "vector",
					},
				},
				["sprite"] = "mapbox://sprites/sarita55/cl06fm4lf000z14sz18b71tps/ck2u8j60r58fu0sgyxrigm3cu",
				["glyphs"] = "mapbox://fonts/mapbox/{fontstack}/{range}.pbf",
				["layers"] = new object[] {
		new Dictionary<string, object> {
			["id"] = "land",
			["type"] = "background",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "land-and-water",
				["mapbox:group"] = "Land, water, & sky, land",
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["background-color"] = "hsl(185, 0%, 18%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "national-park",
			["type"] = "fill",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "land-and-water",
				["mapbox:group"] = "Land, water, & sky, land",
			},
			["source"] = "composite",
			["source-layer"] = "landuse_overlay",
			["minzoom"] = 5,
			["filter"] = new object[] {
				"==",
				new object[] {
					"get",
					"class",
				},
				"national_park",
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["fill-color"] = "hsl(185, 2%, 17%)",
				["fill-opacity"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					5,
					0,
					6,
					0.5,
					10,
					0.5,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "landuse",
			["type"] = "fill",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "land-and-water",
				["mapbox:group"] = "Land, water, & sky, land",
			},
			["source"] = "composite",
			["source-layer"] = "landuse",
			["minzoom"] = 5,
			["filter"] = new object[] {
				"match",
				new object[] {
					"get",
					"class",
				},
				new object[] {
					"park",
					"airport",
					"glacier",
					"pitch",
					"sand",
					"facility",
				},
				true,
				false,
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["fill-color"] = "hsl(185, 2%, 17%)",
				["fill-opacity"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					5,
					0,
					6,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"glacier",
						0.5,
						1,
					},
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "waterway-shadow",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "land-and-water",
				["mapbox:group"] = "Land, water, & sky, water",
			},
			["source"] = "composite",
			["source-layer"] = "waterway",
			["minzoom"] = 8,
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					11,
					"round",
				},
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-color"] = "hsl(185, 0%, 4%)",
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.3,
					},
					new object[] {
						"zoom",
					},
					9,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"canal",
							"river",
						},
						0.1,
						0,
					},
					20,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"canal",
							"river",
						},
						8,
						3,
					},
				},
				["line-translate"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.2,
					},
					new object[] {
						"zoom",
					},
					7,
					new object[] {
						"literal",
						new object[] {
							0,
							0,
						},
					},
					16,
					new object[] {
						"literal",
						new object[] {
							-1,
							-1,
						},
					},
				},
				["line-translate-anchor"] = "viewport",
				["line-opacity"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					8,
					0,
					8.5,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "water-shadow",
			["type"] = "fill",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "land-and-water",
				["mapbox:group"] = "Land, water, & sky, water",
			},
			["source"] = "composite",
			["source-layer"] = "water",
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["fill-color"] = "hsl(185, 0%, 4%)",
				["fill-translate"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.2,
					},
					new object[] {
						"zoom",
					},
					7,
					new object[] {
						"literal",
						new object[] {
							0,
							0,
						},
					},
					16,
					new object[] {
						"literal",
						new object[] {
							-1,
							-1,
						},
					},
				},
				["fill-translate-anchor"] = "viewport",
			},
		},
		new Dictionary<string, object> {
			["id"] = "waterway",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "land-and-water",
				["mapbox:group"] = "Land, water, & sky, water",
			},
			["source"] = "composite",
			["source-layer"] = "waterway",
			["minzoom"] = 8,
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					11,
					"round",
				},
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-color"] = "hsl(185, 0%, 14%)",
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.3,
					},
					new object[] {
						"zoom",
					},
					9,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"canal",
							"river",
						},
						0.1,
						0,
					},
					20,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"canal",
							"river",
						},
						8,
						3,
					},
				},
				["line-opacity"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					8,
					0,
					8.5,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "water",
			["type"] = "fill",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "land-and-water",
				["mapbox:group"] = "Land, water, & sky, water",
			},
			["source"] = "composite",
			["source-layer"] = "water",
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["fill-color"] = "hsl(185, 0%, 14%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "land-structure-polygon",
			["type"] = "fill",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "land-and-water",
				["mapbox:group"] = "Land, water, & sky, built",
			},
			["source"] = "composite",
			["source-layer"] = "structure",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"Polygon",
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"class",
					},
					"land",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["fill-color"] = "hsl(185, 0%, 18%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "land-structure-line",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "land-and-water",
				["mapbox:group"] = "Land, water, & sky, built",
			},
			["source"] = "composite",
			["source-layer"] = "structure",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"class",
					},
					"land",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.99,
					},
					new object[] {
						"zoom",
					},
					14,
					0.75,
					20,
					40,
				},
				["line-color"] = "hsl(185, 0%, 18%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "aeroway-polygon",
			["type"] = "fill",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "transit",
				["mapbox:group"] = "Transit, built",
			},
			["source"] = "composite",
			["source-layer"] = "aeroway",
			["minzoom"] = 11,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"Polygon",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"type",
					},
					new object[] {
						"runway",
						"taxiway",
						"helipad",
					},
					true,
					false,
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["fill-color"] = "hsl(185, 0%, 27%)",
				["fill-opacity"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					11,
					0,
					11.5,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "aeroway-line",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "transit",
				["mapbox:group"] = "Transit, built",
			},
			["source"] = "composite",
			["source-layer"] = "aeroway",
			["minzoom"] = 9,
			["filter"] = new object[] {
				"==",
				new object[] {
					"geometry-type",
				},
				"LineString",
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-color"] = "hsl(185, 0%, 27%)",
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					9,
					new object[] {
						"match",
						new object[] {
							"get",
							"type",
						},
						"runway",
						1,
						0.5,
					},
					18,
					new object[] {
						"match",
						new object[] {
							"get",
							"type",
						},
						"runway",
						80,
						20,
					},
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "building-outline",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "buildings",
				["mapbox:group"] = "Buildings, built",
			},
			["source"] = "composite",
			["source-layer"] = "building",
			["minzoom"] = 15,
			["filter"] = new object[] {
				"all",
				new object[] {
					"!=",
					new object[] {
						"get",
						"type",
					},
					"building:part",
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"underground",
					},
					"false",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-color"] = "hsl(185, 0%, 14%)",
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					15,
					0.75,
					20,
					3,
				},
				["line-opacity"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					15,
					0,
					16,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "building",
			["type"] = "fill",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "buildings",
				["mapbox:group"] = "Buildings, built",
			},
			["source"] = "composite",
			["source-layer"] = "building",
			["minzoom"] = 15,
			["filter"] = new object[] {
				"all",
				new object[] {
					"!=",
					new object[] {
						"get",
						"type",
					},
					"building:part",
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"underground",
					},
					"false",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["fill-color"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					15,
					"hsl(185, 0%, 19%)",
					16,
					"hsl(185, 0%, 16%)",
				},
				["fill-opacity"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					15,
					0,
					16,
					1,
				},
				["fill-outline-color"] = "hsl(185, 0%, 14%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "tunnel-street-minor-low",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, tunnels-case",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["maxzoom"] = 14,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"tunnel",
				},
				new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
							"track",
						},
						true,
						false,
					},
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"track",
							"primary_link",
							"secondary_link",
							"tertiary_link",
							"service",
						},
						true,
						false,
					},
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
						},
						2,
						"track",
						1,
						0.5,
					},
					18,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
						},
						18,
						12,
					},
				},
				["line-color"] = "hsl(185, 0%, 16%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "tunnel-street-minor-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, tunnels-case",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"tunnel",
				},
				new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
							"track",
						},
						true,
						false,
					},
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"track",
							"primary_link",
							"secondary_link",
							"tertiary_link",
							"service",
						},
						true,
						false,
					},
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.75,
					20,
					2,
				},
				["line-color"] = "hsl(185, 0%, 29%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
						},
						2,
						"track",
						1,
						0.5,
					},
					18,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
						},
						18,
						12,
					},
				},
				["line-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					0,
					14,
					1,
				},
				["line-dasharray"] = new object[] {
					3,
					3,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "tunnel-primary-secondary-tertiary-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, tunnels-case",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"tunnel",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"primary",
						"secondary",
						"tertiary",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					10,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"primary",
						1,
						0.75,
					},
					18,
					2,
				},
				["line-color"] = "hsl(185, 0%, 29%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"primary",
						0.75,
						0.1,
					},
					18,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"primary",
						32,
						26,
					},
				},
				["line-dasharray"] = new object[] {
					3,
					3,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "tunnel-major-link-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, tunnels-case",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"tunnel",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway_link",
						"trunk_link",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.75,
					20,
					2,
				},
				["line-color"] = "hsl(185, 0%, 29%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					2,
					18,
					18,
				},
				["line-dasharray"] = new object[] {
					3,
					3,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "tunnel-motorway-trunk-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, tunnels-case",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"tunnel",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway",
						"trunk",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					10,
					1,
					18,
					2,
				},
				["line-color"] = "hsl(185, 0%, 29%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					0.75,
					18,
					32,
				},
				["line-dasharray"] = new object[] {
					3,
					3,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "tunnel-construction",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, tunnels-case",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 14,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"tunnel",
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"class",
					},
					"construction",
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					14,
					2,
					18,
					18,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-dasharray"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"literal",
						new object[] {
							0.4,
							0.8,
						},
					},
					15,
					new object[] {
						"literal",
						new object[] {
							0.3,
							0.6,
						},
					},
					16,
					new object[] {
						"literal",
						new object[] {
							0.2,
							0.3,
						},
					},
					17,
					new object[] {
						"literal",
						new object[] {
							0.2,
							0.25,
						},
					},
					18,
					new object[] {
						"literal",
						new object[] {
							0.15,
							0.15,
						},
					},
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "tunnel-major-link",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, tunnels",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"tunnel",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway_link",
						"trunk_link",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					2,
					18,
					18,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "tunnel-street-minor",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, tunnels",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"tunnel",
				},
				new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
							"track",
						},
						true,
						false,
					},
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"track",
							"primary_link",
							"secondary_link",
							"tertiary_link",
							"service",
						},
						true,
						false,
					},
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
						},
						2,
						"track",
						1,
						0.5,
					},
					18,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
						},
						18,
						12,
					},
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					0,
					14,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "tunnel-primary-secondary-tertiary",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, tunnels",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"tunnel",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"primary",
						"secondary",
						"tertiary",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"primary",
						0.75,
						0.1,
					},
					18,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"primary",
						32,
						26,
					},
				},
				["line-color"] = "hsl(185, 0%, 16%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "tunnel-motorway-trunk",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, tunnels",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"tunnel",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway",
						"trunk",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					0.75,
					18,
					32,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "turning-feature-outline",
			["type"] = "circle",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 15,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"Point",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"turning_circle",
						"turning_loop",
					},
					true,
					false,
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["circle-radius"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					15,
					4.5,
					16,
					8,
					18,
					20,
				},
				["circle-color"] = "hsl(185, 0%, 27%)",
				["circle-stroke-width"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					15,
					0.8,
					16,
					1.2,
					18,
					2,
				},
				["circle-stroke-color"] = "hsl(185, 0%, 16%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-minor-low",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["maxzoom"] = 14,
			["filter"] = new object[] {
				"all",
				new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"==",
						new object[] {
							"get",
							"class",
						},
						"track",
					},
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"track",
							"secondary_link",
							"tertiary_link",
							"service",
						},
						true,
						false,
					},
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"track",
						1,
						0.5,
					},
					18,
					12,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-minor-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"==",
						new object[] {
							"get",
							"class",
						},
						"track",
					},
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"track",
							"secondary_link",
							"tertiary_link",
							"service",
						},
						true,
						false,
					},
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.75,
					20,
					2,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"track",
						1,
						0.5,
					},
					18,
					12,
				},
				["line-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					0,
					14,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-street-low",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 11,
			["maxzoom"] = 14,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"street",
						"street_limited",
						"primary_link",
					},
					true,
					false,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					2,
					18,
					18,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-street-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"street",
						"street_limited",
						"primary_link",
					},
					true,
					false,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.75,
					20,
					2,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					2,
					18,
					18,
				},
				["line-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					0,
					14,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-secondary-tertiary-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 10,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"secondary",
						"tertiary",
					},
					true,
					false,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					10,
					0.75,
					18,
					2,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					0.1,
					18,
					26,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-primary-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 10,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"class",
					},
					"primary",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					10,
					1,
					18,
					2,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					0.75,
					18,
					32,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-major-link-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 10,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway_link",
						"trunk_link",
					},
					true,
					false,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.75,
					20,
					2,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					2,
					18,
					18,
				},
				["line-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					0,
					11,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-motorway-trunk-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 5,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway",
						"trunk",
					},
					true,
					false,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					10,
					1,
					18,
					2,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					0.75,
					18,
					32,
				},
				["line-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"motorway",
						1,
						0,
					},
					6,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-construction",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 14,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"class",
					},
					"construction",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					14,
					2,
					18,
					18,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
				["line-dasharray"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"literal",
						new object[] {
							0.4,
							0.8,
						},
					},
					15,
					new object[] {
						"literal",
						new object[] {
							0.3,
							0.6,
						},
					},
					16,
					new object[] {
						"literal",
						new object[] {
							0.2,
							0.3,
						},
					},
					17,
					new object[] {
						"literal",
						new object[] {
							0.2,
							0.25,
						},
					},
					18,
					new object[] {
						"literal",
						new object[] {
							0.15,
							0.15,
						},
					},
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-major-link",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 10,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway_link",
						"trunk_link",
					},
					true,
					false,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					13,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					13,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					2,
					18,
					18,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-minor",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"==",
						new object[] {
							"get",
							"class",
						},
						"track",
					},
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"track",
							"secondary_link",
							"tertiary_link",
							"service",
						},
						true,
						false,
					},
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"track",
						1,
						0.5,
					},
					18,
					12,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
				["line-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					0,
					14,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-street",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"street",
						"street_limited",
						"primary_link",
					},
					true,
					false,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					2,
					18,
					18,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
				["line-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					0,
					14,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-secondary-tertiary",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 8,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"secondary",
						"tertiary",
					},
					true,
					false,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					0.1,
					18,
					26,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-primary",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 6,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"class",
					},
					"primary",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					0.75,
					18,
					32,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-motorway-trunk",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway",
						"trunk",
					},
					true,
					false,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					13,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					13,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					0.75,
					18,
					32,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-rail",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "transit",
				["mapbox:group"] = "Transit, surface",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"major_rail",
						"minor_rail",
					},
					true,
					false,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"structure",
					},
					new object[] {
						"none",
						"ford",
					},
					true,
					false,
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-color"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					13,
					"hsl(185, 0%, 16%)",
					17,
					"hsl(185, 0%, 14%)",
				},
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					14,
					0.5,
					20,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "turning-feature",
			["type"] = "circle",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, surface-icons",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 15,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"Point",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"turning_circle",
						"turning_loop",
					},
					true,
					false,
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["circle-radius"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					15,
					4.5,
					16,
					8,
					18,
					20,
				},
				["circle-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-street-minor-low",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["maxzoom"] = 14,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
							"track",
						},
						true,
						false,
					},
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"track",
							"primary_link",
							"secondary_link",
							"tertiary_link",
							"service",
						},
						true,
						false,
					},
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
						},
						2,
						"track",
						1,
						0.5,
					},
					18,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
						},
						18,
						12,
					},
				},
				["line-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-street-minor-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
							"track",
						},
						true,
						false,
					},
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"track",
							"primary_link",
							"secondary_link",
							"tertiary_link",
							"service",
						},
						true,
						false,
					},
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.75,
					20,
					2,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
						},
						2,
						"track",
						1,
						0.5,
					},
					18,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
						},
						18,
						12,
					},
				},
				["line-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					0,
					14,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-primary-secondary-tertiary-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"primary",
						"secondary",
						"tertiary",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					10,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"primary",
						1,
						0.75,
					},
					18,
					2,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"primary",
						0.75,
						0.1,
					},
					18,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"primary",
						32,
						26,
					},
				},
				["line-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					0,
					10,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-major-link-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway_link",
						"trunk_link",
					},
					true,
					false,
				},
				new object[] {
					"<=",
					new object[] {
						"get",
						"layer",
					},
					1,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.75,
					20,
					2,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					2,
					18,
					18,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-motorway-trunk-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway",
						"trunk",
					},
					true,
					false,
				},
				new object[] {
					"<=",
					new object[] {
						"get",
						"layer",
					},
					1,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					10,
					1,
					18,
					2,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					0.75,
					18,
					32,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-construction",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 14,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"class",
					},
					"construction",
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					14,
					2,
					18,
					18,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
				["line-dasharray"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"literal",
						new object[] {
							0.4,
							0.8,
						},
					},
					15,
					new object[] {
						"literal",
						new object[] {
							0.3,
							0.6,
						},
					},
					16,
					new object[] {
						"literal",
						new object[] {
							0.2,
							0.3,
						},
					},
					17,
					new object[] {
						"literal",
						new object[] {
							0.2,
							0.25,
						},
					},
					18,
					new object[] {
						"literal",
						new object[] {
							0.15,
							0.15,
						},
					},
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-major-link",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway_link",
						"trunk_link",
					},
					true,
					false,
				},
				new object[] {
					"<=",
					new object[] {
						"get",
						"layer",
					},
					1,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = "round",
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					2,
					18,
					18,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-street-minor",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
							"track",
						},
						true,
						false,
					},
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"track",
							"primary_link",
							"secondary_link",
							"tertiary_link",
							"service",
						},
						true,
						false,
					},
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
						},
						2,
						"track",
						1,
						0.5,
					},
					18,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"street",
							"street_limited",
							"primary_link",
						},
						18,
						12,
					},
				},
				["line-color"] = "hsl(185, 0%, 27%)",
				["line-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					0,
					14,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-primary-secondary-tertiary",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"primary",
						"secondary",
						"tertiary",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"primary",
						0.75,
						0.1,
					},
					18,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						"primary",
						32,
						26,
					},
				},
				["line-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-motorway-trunk",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway",
						"trunk",
					},
					true,
					false,
				},
				new object[] {
					"<=",
					new object[] {
						"get",
						"layer",
					},
					1,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = "round",
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					0.75,
					18,
					32,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-major-link-2-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					">=",
					new object[] {
						"get",
						"layer",
					},
					2,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway_link",
						"trunk_link",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.75,
					20,
					2,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					2,
					18,
					18,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-motorway-trunk-2-case",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					">=",
					new object[] {
						"get",
						"layer",
					},
					2,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway",
						"trunk",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					10,
					1,
					18,
					2,
				},
				["line-color"] = "hsl(185, 0%, 16%)",
				["line-gap-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					0.75,
					18,
					32,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-major-link-2",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					">=",
					new object[] {
						"get",
						"layer",
					},
					2,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway_link",
						"trunk_link",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = "round",
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					12,
					0.5,
					14,
					2,
					18,
					18,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-motorway-trunk-2",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					">=",
					new object[] {
						"get",
						"layer",
					},
					2,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway",
						"trunk",
					},
					true,
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-cap"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"butt",
					14,
					"round",
				},
				["line-join"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					"miter",
					14,
					"round",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					5,
					0.75,
					18,
					32,
				},
				["line-color"] = "hsl(185, 0%, 27%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "bridge-rail",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "transit",
				["mapbox:group"] = "Transit, bridges",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"structure",
					},
					"bridge",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"major_rail",
						"minor_rail",
					},
					true,
					false,
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-color"] = "hsl(185, 0%, 14%)",
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.5,
					},
					new object[] {
						"zoom",
					},
					14,
					0.5,
					20,
					1,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "admin-1-boundary-bg",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "admin-boundaries",
				["mapbox:group"] = "Administrative boundaries, admin",
			},
			["source"] = "composite",
			["source-layer"] = "admin",
			["minzoom"] = 7,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"admin_level",
					},
					1,
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"maritime",
					},
					"false",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"worldview",
					},
					new object[] {
						"all",
						"US",
					},
					true,
					false,
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-join"] = "bevel",
			},
			["paint"] = new Dictionary<string, object> {
				["line-color"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					8,
					"hsl(185, 0%, 14%)",
					16,
					"hsl(185, 0%, 14%)",
				},
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					7,
					3.75,
					12,
					5.5,
				},
				["line-opacity"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					7,
					0,
					8,
					0.75,
				},
				["line-dasharray"] = new object[] {
					1,
					0,
				},
				["line-blur"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					3,
					0,
					8,
					3,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "admin-0-boundary-bg",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "admin-boundaries",
				["mapbox:group"] = "Administrative boundaries, admin",
			},
			["source"] = "composite",
			["source-layer"] = "admin",
			["minzoom"] = 1,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"admin_level",
					},
					0,
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"maritime",
					},
					"false",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"worldview",
					},
					new object[] {
						"all",
						"US",
					},
					true,
					false,
				},
			},
			["layout"] = new Dictionary<string, object> {
			},
			["paint"] = new Dictionary<string, object> {
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					3,
					3.5,
					10,
					8,
				},
				["line-color"] = "hsl(185, 0%, 14%)",
				["line-opacity"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					3,
					0,
					4,
					0.5,
				},
				["line-blur"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					3,
					0,
					10,
					2,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "admin-1-boundary",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "admin-boundaries",
				["mapbox:group"] = "Administrative boundaries, admin",
			},
			["source"] = "composite",
			["source-layer"] = "admin",
			["minzoom"] = 2,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"admin_level",
					},
					1,
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"maritime",
					},
					"false",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"worldview",
					},
					new object[] {
						"all",
						"US",
					},
					true,
					false,
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-join"] = "round",
				["line-cap"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-dasharray"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"literal",
						new object[] {
							2,
							0,
						},
					},
					7,
					new object[] {
						"literal",
						new object[] {
							2,
							2,
							6,
							2,
						},
					},
				},
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					7,
					0.75,
					12,
					1.5,
				},
				["line-opacity"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					2,
					0,
					3,
					1,
				},
				["line-color"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					3,
					"hsl(185, 0%, 27%)",
					7,
					"hsl(185, 0%, 41%)",
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "admin-0-boundary",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "admin-boundaries",
				["mapbox:group"] = "Administrative boundaries, admin",
			},
			["source"] = "composite",
			["source-layer"] = "admin",
			["minzoom"] = 1,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"admin_level",
					},
					0,
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"disputed",
					},
					"false",
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"maritime",
					},
					"false",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"worldview",
					},
					new object[] {
						"all",
						"US",
					},
					true,
					false,
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-join"] = "round",
				["line-cap"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-color"] = "hsl(185, 0%, 43%)",
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					3,
					0.5,
					10,
					2,
				},
				["line-dasharray"] = new object[] {
					10,
					0,
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "admin-0-boundary-disputed",
			["type"] = "line",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "admin-boundaries",
				["mapbox:group"] = "Administrative boundaries, admin",
			},
			["source"] = "composite",
			["source-layer"] = "admin",
			["minzoom"] = 1,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"disputed",
					},
					"true",
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"admin_level",
					},
					0,
				},
				new object[] {
					"==",
					new object[] {
						"get",
						"maritime",
					},
					"false",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"worldview",
					},
					new object[] {
						"all",
						"US",
					},
					true,
					false,
				},
			},
			["layout"] = new Dictionary<string, object> {
				["line-join"] = "round",
			},
			["paint"] = new Dictionary<string, object> {
				["line-color"] = "hsl(185, 0%, 43%)",
				["line-width"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					3,
					0.5,
					10,
					2,
				},
				["line-dasharray"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"literal",
						new object[] {
							3.25,
							3.25,
						},
					},
					6,
					new object[] {
						"literal",
						new object[] {
							2.5,
							2.5,
						},
					},
					7,
					new object[] {
						"literal",
						new object[] {
							2,
							2.25,
						},
					},
					8,
					new object[] {
						"literal",
						new object[] {
							1.75,
							2,
						},
					},
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, road-labels",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 10,
			["filter"] = new object[] {
				"step",
				new object[] {
					"zoom",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway",
						"trunk",
						"primary",
						"secondary",
						"tertiary",
					},
					true,
					false,
				},
				12,
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"motorway",
						"trunk",
						"primary",
						"secondary",
						"tertiary",
						"street",
						"street_limited",
					},
					true,
					false,
				},
				15,
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"path",
						"pedestrian",
						"golf",
						"ferry",
						"aerialway",
					},
					false,
					true,
				},
			},
			["layout"] = new Dictionary<string, object> {
				["text-size"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					10,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"motorway",
							"trunk",
							"primary",
							"secondary",
							"tertiary",
						},
						10,
						new object[] {
							"motorway_link",
							"trunk_link",
							"primary_link",
							"secondary_link",
							"tertiary_link",
							"street",
							"street_limited",
						},
						9,
						6.5,
					},
					18,
					new object[] {
						"match",
						new object[] {
							"get",
							"class",
						},
						new object[] {
							"motorway",
							"trunk",
							"primary",
							"secondary",
							"tertiary",
						},
						16,
						new object[] {
							"motorway_link",
							"trunk_link",
							"primary_link",
							"secondary_link",
							"tertiary_link",
							"street",
							"street_limited",
						},
						14,
						13,
					},
				},
				["text-max-angle"] = 30,
				["text-font"] = new object[] {
					"DIN Pro Regular",
					"Arial Unicode MS Regular",
				},
				["symbol-placement"] = "line",
				["text-padding"] = 1,
				["text-rotation-alignment"] = "map",
				["text-pitch-alignment"] = "viewport",
				["text-field"] = new object[] {
					"coalesce",
					new object[] {
						"get",
						"name_en",
					},
					new object[] {
						"get",
						"name",
					},
				},
				["text-letter-spacing"] = 0.01,
			},
			["paint"] = new Dictionary<string, object> {
				["text-color"] = "hsl(185, 0%, 69%)",
				["text-halo-color"] = "hsl(185, 0%, 5%)",
				["text-halo-width"] = 1,
				["text-halo-blur"] = 1,
			},
		},
		new Dictionary<string, object> {
			["id"] = "road-intersection",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "road-network",
				["mapbox:group"] = "Road network, road-labels",
			},
			["source"] = "composite",
			["source-layer"] = "road",
			["minzoom"] = 15,
			["filter"] = new object[] {
				"all",
				new object[] {
					"==",
					new object[] {
						"get",
						"class",
					},
					"intersection",
				},
				new object[] {
					"has",
					"name",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["text-field"] = new object[] {
					"coalesce",
					new object[] {
						"get",
						"name_en",
					},
					new object[] {
						"get",
						"name",
					},
				},
				["icon-image"] = "intersection",
				["icon-text-fit"] = "both",
				["icon-text-fit-padding"] = new object[] {
					1,
					2,
					1,
					2,
				},
				["text-size"] = new object[] {
					"interpolate",
					new object[] {
						"exponential",
						1.2,
					},
					new object[] {
						"zoom",
					},
					15,
					9,
					18,
					12,
				},
				["text-font"] = new object[] {
					"DIN Pro Bold",
					"Arial Unicode MS Bold",
				},
			},
			["paint"] = new Dictionary<string, object> {
				["text-color"] = "hsl(185, 0%, 9%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "waterway-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "natural-features",
				["mapbox:group"] = "Natural features, natural-labels",
			},
			["source"] = "composite",
			["source-layer"] = "natural_label",
			["minzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"canal",
						"river",
						"stream",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"worldview",
						},
						new object[] {
							"all",
							"US",
						},
						true,
						false,
					},
					new object[] {
						"disputed_canal",
						"disputed_river",
						"disputed_stream",
					},
					new object[] {
						"all",
						new object[] {
							"==",
							new object[] {
								"get",
								"disputed",
							},
							"true",
						},
						new object[] {
							"match",
							new object[] {
								"get",
								"worldview",
							},
							new object[] {
								"all",
								"US",
							},
							true,
							false,
						},
					},
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["text-font"] = new object[] {
					"DIN Pro Italic",
					"Arial Unicode MS Regular",
				},
				["text-max-angle"] = 30,
				["symbol-spacing"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
						1,
					},
					new object[] {
						"zoom",
					},
					15,
					250,
					17,
					400,
				},
				["text-size"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					13,
					12,
					18,
					16,
				},
				["symbol-placement"] = "line",
				["text-pitch-alignment"] = "viewport",
				["text-field"] = new object[] {
					"coalesce",
					new object[] {
						"get",
						"name_en",
					},
					new object[] {
						"get",
						"name",
					},
				},
			},
			["paint"] = new Dictionary<string, object> {
				["text-color"] = "hsl(185, 0%, 38%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "natural-line-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "natural-features",
				["mapbox:group"] = "Natural features, natural-labels",
			},
			["source"] = "composite",
			["source-layer"] = "natural_label",
			["minzoom"] = 4,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"glacier",
						"landform",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"worldview",
						},
						new object[] {
							"all",
							"US",
						},
						true,
						false,
					},
					new object[] {
						"disputed_glacier",
						"disputed_landform",
					},
					new object[] {
						"all",
						new object[] {
							"==",
							new object[] {
								"get",
								"disputed",
							},
							"true",
						},
						new object[] {
							"match",
							new object[] {
								"get",
								"worldview",
							},
							new object[] {
								"all",
								"US",
							},
							true,
							false,
						},
					},
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
				new object[] {
					"<=",
					new object[] {
						"get",
						"filterrank",
					},
					1,
				},
			},
			["layout"] = new Dictionary<string, object> {
				["text-size"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						18,
						5,
						12,
					},
					17,
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						18,
						13,
						12,
					},
				},
				["text-max-angle"] = 30,
				["text-field"] = new object[] {
					"coalesce",
					new object[] {
						"get",
						"name_en",
					},
					new object[] {
						"get",
						"name",
					},
				},
				["text-font"] = new object[] {
					"DIN Pro Medium",
					"Arial Unicode MS Regular",
				},
				["symbol-placement"] = "line-center",
				["text-pitch-alignment"] = "viewport",
			},
			["paint"] = new Dictionary<string, object> {
				["text-halo-width"] = 0.5,
				["text-halo-color"] = "hsl(185, 0%, 5%)",
				["text-halo-blur"] = 0.5,
				["text-color"] = "hsl(185, 0%, 69%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "natural-point-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "natural-features",
				["mapbox:group"] = "Natural features, natural-labels",
			},
			["source"] = "composite",
			["source-layer"] = "natural_label",
			["minzoom"] = 4,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"dock",
						"glacier",
						"landform",
						"water_feature",
						"wetland",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"worldview",
						},
						new object[] {
							"all",
							"US",
						},
						true,
						false,
					},
					new object[] {
						"disputed_dock",
						"disputed_glacier",
						"disputed_landform",
						"disputed_water_feature",
						"disputed_wetland",
					},
					new object[] {
						"all",
						new object[] {
							"==",
							new object[] {
								"get",
								"disputed",
							},
							"true",
						},
						new object[] {
							"match",
							new object[] {
								"get",
								"worldview",
							},
							new object[] {
								"all",
								"US",
							},
							true,
							false,
						},
					},
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"Point",
				},
				new object[] {
					"<=",
					new object[] {
						"get",
						"filterrank",
					},
					1,
				},
			},
			["layout"] = new Dictionary<string, object> {
				["text-size"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						18,
						5,
						12,
					},
					17,
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						18,
						13,
						12,
					},
				},
				["icon-image"] = "",
				["text-font"] = new object[] {
					"DIN Pro Medium",
					"Arial Unicode MS Regular",
				},
				["text-offset"] = new object[] {
					"literal",
					new object[] {
						0,
						0,
					},
				},
				["text-field"] = new object[] {
					"coalesce",
					new object[] {
						"get",
						"name_en",
					},
					new object[] {
						"get",
						"name",
					},
				},
			},
			["paint"] = new Dictionary<string, object> {
				["icon-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						0,
						5,
						1,
					},
					17,
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						0,
						13,
						1,
					},
				},
				["text-halo-color"] = "hsl(185, 0%, 5%)",
				["text-halo-width"] = 0.5,
				["text-halo-blur"] = 0.5,
				["text-color"] = "hsl(185, 0%, 69%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "water-line-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "natural-features",
				["mapbox:group"] = "Natural features, natural-labels",
			},
			["source"] = "composite",
			["source-layer"] = "natural_label",
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"bay",
						"ocean",
						"reservoir",
						"sea",
						"water",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"worldview",
						},
						new object[] {
							"all",
							"US",
						},
						true,
						false,
					},
					new object[] {
						"disputed_bay",
						"disputed_ocean",
						"disputed_reservoir",
						"disputed_sea",
						"disputed_water",
					},
					new object[] {
						"all",
						new object[] {
							"==",
							new object[] {
								"get",
								"disputed",
							},
							"true",
						},
						new object[] {
							"match",
							new object[] {
								"get",
								"worldview",
							},
							new object[] {
								"all",
								"US",
							},
							true,
							false,
						},
					},
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"LineString",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["text-size"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					7,
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						20,
						6,
						18,
						12,
						12,
					},
					10,
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						15,
						9,
						12,
					},
					18,
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						15,
						9,
						14,
					},
				},
				["text-max-angle"] = 30,
				["text-letter-spacing"] = new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					"ocean",
					0.25,
					new object[] {
						"sea",
						"bay",
					},
					0.15,
					0,
				},
				["text-font"] = new object[] {
					"DIN Pro Italic",
					"Arial Unicode MS Regular",
				},
				["symbol-placement"] = "line-center",
				["text-pitch-alignment"] = "viewport",
				["text-field"] = new object[] {
					"coalesce",
					new object[] {
						"get",
						"name_en",
					},
					new object[] {
						"get",
						"name",
					},
				},
			},
			["paint"] = new Dictionary<string, object> {
				["text-color"] = "hsl(185, 0%, 38%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "water-point-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "natural-features",
				["mapbox:group"] = "Natural features, natural-labels",
			},
			["source"] = "composite",
			["source-layer"] = "natural_label",
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					new object[] {
						"bay",
						"ocean",
						"reservoir",
						"sea",
						"water",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"worldview",
						},
						new object[] {
							"all",
							"US",
						},
						true,
						false,
					},
					new object[] {
						"disputed_bay",
						"disputed_ocean",
						"disputed_reservoir",
						"disputed_sea",
						"disputed_water",
					},
					new object[] {
						"all",
						new object[] {
							"==",
							new object[] {
								"get",
								"disputed",
							},
							"true",
						},
						new object[] {
							"match",
							new object[] {
								"get",
								"worldview",
							},
							new object[] {
								"all",
								"US",
							},
							true,
							false,
						},
					},
					false,
				},
				new object[] {
					"==",
					new object[] {
						"geometry-type",
					},
					"Point",
				},
			},
			["layout"] = new Dictionary<string, object> {
				["text-line-height"] = 1.3,
				["text-size"] = new object[] {
					"interpolate",
					new object[] {
						"linear",
					},
					new object[] {
						"zoom",
					},
					7,
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						20,
						6,
						15,
						12,
						12,
					},
					10,
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						15,
						9,
						12,
					},
				},
				["text-font"] = new object[] {
					"DIN Pro Italic",
					"Arial Unicode MS Regular",
				},
				["text-field"] = new object[] {
					"coalesce",
					new object[] {
						"get",
						"name_en",
					},
					new object[] {
						"get",
						"name",
					},
				},
				["text-letter-spacing"] = new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					"ocean",
					0.25,
					new object[] {
						"bay",
						"sea",
					},
					0.15,
					0.01,
				},
				["text-max-width"] = new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					"ocean",
					4,
					"sea",
					5,
					new object[] {
						"bay",
						"water",
					},
					7,
					10,
				},
			},
			["paint"] = new Dictionary<string, object> {
				["text-color"] = "hsl(185, 0%, 38%)",
			},
		},
		new Dictionary<string, object> {
			["id"] = "poi-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "point-of-interest-labels",
				["mapbox:group"] = "Point of interest labels, poi-labels",
			},
			["source"] = "composite",
			["source-layer"] = "poi_label",
			["minzoom"] = 6,
			["filter"] = new object[] {
				"<=",
				new object[] {
					"get",
					"filterrank",
				},
				new object[] {
					"+",
					new object[] {
						"step",
						new object[] {
							"zoom",
						},
						0,
						16,
						1,
						17,
						2,
					},
					1,
				},
			},
			["layout"] = new Dictionary<string, object> {
				["text-size"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						18,
						5,
						12,
					},
					17,
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						18,
						13,
						12,
					},
				},
				["icon-image"] = "",
				["text-font"] = new object[] {
					"DIN Pro Medium",
					"Arial Unicode MS Regular",
				},
				["text-offset"] = new object[] {
					0,
					0,
				},
				["text-anchor"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						"center",
						5,
						"top",
					},
					17,
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						"center",
						13,
						"top",
					},
				},
				["text-field"] = new object[] {
					"coalesce",
					new object[] {
						"get",
						"name_en",
					},
					new object[] {
						"get",
						"name",
					},
				},
			},
			["paint"] = new Dictionary<string, object> {
				["text-halo-color"] = "hsl(185, 0%, 5%)",
				["text-halo-width"] = 0.5,
				["text-halo-blur"] = 0.5,
				["text-color"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						"hsl(185, 0%, 41%)",
						5,
						"hsl(185, 0%, 56%)",
					},
					17,
					new object[] {
						"step",
						new object[] {
							"get",
							"sizerank",
						},
						"hsl(185, 0%, 41%)",
						13,
						"hsl(185, 0%, 56%)",
					},
				},
			},
		},
		new Dictionary<string, object> {
			["id"] = "airport-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "transit",
				["mapbox:group"] = "Transit, transit-labels",
			},
			["source"] = "composite",
			["source-layer"] = "airport_label",
			["minzoom"] = 8,
			["filter"] = new object[] {
				"match",
				new object[] {
					"get",
					"class",
				},
				new object[] {
					"military",
					"civil",
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"worldview",
					},
					new object[] {
						"all",
						"US",
					},
					true,
					false,
				},
				new object[] {
					"disputed_military",
					"disputed_civil",
				},
				new object[] {
					"all",
					new object[] {
						"==",
						new object[] {
							"get",
							"disputed",
						},
						"true",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"worldview",
						},
						new object[] {
							"all",
							"US",
						},
						true,
						false,
					},
				},
				false,
			},
			["layout"] = new Dictionary<string, object> {
				["text-line-height"] = 1.1,
				["text-size"] = new object[] {
					"step",
					new object[] {
						"get",
						"sizerank",
					},
					18,
					9,
					12,
				},
				["icon-image"] = new object[] {
					"get",
					"maki",
				},
				["text-font"] = new object[] {
					"DIN Pro Medium",
					"Arial Unicode MS Regular",
				},
				["text-offset"] = new object[] {
					0,
					0.75,
				},
				["text-rotation-alignment"] = "viewport",
				["text-anchor"] = "top",
				["text-field"] = new object[] {
					"step",
					new object[] {
						"get",
						"sizerank",
					},
					new object[] {
						"coalesce",
						new object[] {
							"get",
							"name_en",
						},
						new object[] {
							"get",
							"name",
						},
					},
					15,
					new object[] {
						"get",
						"ref",
					},
				},
				["text-letter-spacing"] = 0.01,
				["text-max-width"] = 9,
			},
			["paint"] = new Dictionary<string, object> {
				["text-color"] = "hsl(185, 0%, 69%)",
				["text-halo-color"] = "hsl(185, 0%, 5%)",
				["text-halo-width"] = 1,
			},
		},
		new Dictionary<string, object> {
			["id"] = "settlement-subdivision-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "place-labels",
				["mapbox:group"] = "Place labels, place-labels",
			},
			["source"] = "composite",
			["source-layer"] = "place_label",
			["minzoom"] = 10,
			["maxzoom"] = 15,
			["filter"] = new object[] {
				"all",
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					"settlement_subdivision",
					new object[] {
						"match",
						new object[] {
							"get",
							"worldview",
						},
						new object[] {
							"all",
							"US",
						},
						true,
						false,
					},
					"disputed_settlement_subdivision",
					new object[] {
						"all",
						new object[] {
							"==",
							new object[] {
								"get",
								"disputed",
							},
							"true",
						},
						new object[] {
							"match",
							new object[] {
								"get",
								"worldview",
							},
							new object[] {
								"all",
								"US",
							},
							true,
							false,
						},
					},
					false,
				},
				new object[] {
					"<=",
					new object[] {
						"get",
						"filterrank",
					},
					4,
				},
			},
			["layout"] = new Dictionary<string, object> {
				["text-field"] = new object[] {
					"coalesce",
					new object[] {
						"get",
						"name_en",
					},
					new object[] {
						"get",
						"name",
					},
				},
				["text-transform"] = "uppercase",
				["text-font"] = new object[] {
					"DIN Pro Regular",
					"Arial Unicode MS Regular",
				},
				["text-letter-spacing"] = new object[] {
					"match",
					new object[] {
						"get",
						"type",
					},
					"suburb",
					0.15,
					0.1,
				},
				["text-max-width"] = 7,
				["text-padding"] = 3,
				["text-size"] = new object[] {
					"interpolate",
					new object[] {
						"cubic-bezier",
						0.5,
						0,
						1,
						1,
					},
					new object[] {
						"zoom",
					},
					11,
					new object[] {
						"match",
						new object[] {
							"get",
							"type",
						},
						"suburb",
						11,
						10.5,
					},
					15,
					new object[] {
						"match",
						new object[] {
							"get",
							"type",
						},
						"suburb",
						15,
						14,
					},
				},
			},
			["paint"] = new Dictionary<string, object> {
				["text-halo-color"] = "hsl(185, 0%, 5%)",
				["text-halo-width"] = 1,
				["text-color"] = "hsl(185, 0%, 57%)",
				["text-halo-blur"] = 0.5,
			},
		},
		new Dictionary<string, object> {
			["id"] = "settlement-minor-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "place-labels",
				["mapbox:group"] = "Place labels, place-labels",
			},
			["source"] = "composite",
			["source-layer"] = "place_label",
			["minzoom"] = 3,
			["maxzoom"] = 13,
			["filter"] = new object[] {
				"all",
				new object[] {
					"<=",
					new object[] {
						"get",
						"filterrank",
					},
					3,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					"settlement",
					new object[] {
						"match",
						new object[] {
							"get",
							"worldview",
						},
						new object[] {
							"all",
							"US",
						},
						true,
						false,
					},
					"disputed_settlement",
					new object[] {
						"all",
						new object[] {
							"==",
							new object[] {
								"get",
								"disputed",
							},
							"true",
						},
						new object[] {
							"match",
							new object[] {
								"get",
								"worldview",
							},
							new object[] {
								"all",
								"US",
							},
							true,
							false,
						},
					},
					false,
				},
				new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						">",
						new object[] {
							"get",
							"symbolrank",
						},
						6,
					},
					4,
					new object[] {
						">=",
						new object[] {
							"get",
							"symbolrank",
						},
						7,
					},
					6,
					new object[] {
						">=",
						new object[] {
							"get",
							"symbolrank",
						},
						8,
					},
					7,
					new object[] {
						">=",
						new object[] {
							"get",
							"symbolrank",
						},
						10,
					},
					10,
					new object[] {
						">=",
						new object[] {
							"get",
							"symbolrank",
						},
						11,
					},
					11,
					new object[] {
						">=",
						new object[] {
							"get",
							"symbolrank",
						},
						13,
					},
					12,
					new object[] {
						">=",
						new object[] {
							"get",
							"symbolrank",
						},
						15,
					},
				},
			},
			["layout"] = new Dictionary<string, object> {
				["text-line-height"] = 1.1,
				["text-size"] = new object[] {
					"interpolate",
					new object[] {
						"cubic-bezier",
						0.2,
						0,
						0.9,
						1,
					},
					new object[] {
						"zoom",
					},
					3,
					new object[] {
						"step",
						new object[] {
							"get",
							"symbolrank",
						},
						12,
						9,
						11,
						10,
						10.5,
						12,
						9.5,
						14,
						8.5,
						16,
						6.5,
						17,
						4,
					},
					13,
					new object[] {
						"step",
						new object[] {
							"get",
							"symbolrank",
						},
						23,
						9,
						21,
						10,
						19,
						11,
						17,
						12,
						16,
						13,
						15,
						15,
						13,
					},
				},
				["text-radial-offset"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"capital",
						},
						2,
						0.6,
						0.55,
					},
					8,
					0,
				},
				["icon-image"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"case",
						new object[] {
							"==",
							new object[] {
								"get",
								"capital",
							},
							2,
						},
						"border-dot-13",
						new object[] {
							"step",
							new object[] {
								"get",
								"symbolrank",
							},
							"dot-11",
							9,
							"dot-10",
							11,
							"dot-9",
						},
					},
					8,
					"",
				},
				["text-font"] = new object[] {
					"DIN Pro Regular",
					"Arial Unicode MS Regular",
				},
				["text-justify"] = "auto",
				["text-anchor"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"get",
						"text_anchor",
					},
					8,
					"center",
				},
				["text-field"] = new object[] {
					"coalesce",
					new object[] {
						"get",
						"name_en",
					},
					new object[] {
						"get",
						"name",
					},
				},
				["text-max-width"] = 7,
			},
			["paint"] = new Dictionary<string, object> {
				["text-color"] = new object[] {
					"step",
					new object[] {
						"get",
						"symbolrank",
					},
					"hsl(185, 0%, 69%)",
					11,
					"hsl(185, 0%, 56%)",
					16,
					"hsl(185, 0%, 50%)",
				},
				["text-halo-color"] = "hsl(185, 0%, 5%)",
				["text-halo-width"] = 1,
				["text-halo-blur"] = 1,
			},
		},
		new Dictionary<string, object> {
			["id"] = "settlement-major-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "place-labels",
				["mapbox:group"] = "Place labels, place-labels",
			},
			["source"] = "composite",
			["source-layer"] = "place_label",
			["minzoom"] = 3,
			["maxzoom"] = 15,
			["filter"] = new object[] {
				"all",
				new object[] {
					"<=",
					new object[] {
						"get",
						"filterrank",
					},
					3,
				},
				new object[] {
					"match",
					new object[] {
						"get",
						"class",
					},
					"settlement",
					new object[] {
						"match",
						new object[] {
							"get",
							"worldview",
						},
						new object[] {
							"all",
							"US",
						},
						true,
						false,
					},
					"disputed_settlement",
					new object[] {
						"all",
						new object[] {
							"==",
							new object[] {
								"get",
								"disputed",
							},
							"true",
						},
						new object[] {
							"match",
							new object[] {
								"get",
								"worldview",
							},
							new object[] {
								"all",
								"US",
							},
							true,
							false,
						},
					},
					false,
				},
				new object[] {
					"step",
					new object[] {
						"zoom",
					},
					false,
					3,
					new object[] {
						"<=",
						new object[] {
							"get",
							"symbolrank",
						},
						6,
					},
					4,
					new object[] {
						"<",
						new object[] {
							"get",
							"symbolrank",
						},
						7,
					},
					6,
					new object[] {
						"<",
						new object[] {
							"get",
							"symbolrank",
						},
						8,
					},
					7,
					new object[] {
						"<",
						new object[] {
							"get",
							"symbolrank",
						},
						10,
					},
					10,
					new object[] {
						"<",
						new object[] {
							"get",
							"symbolrank",
						},
						11,
					},
					11,
					new object[] {
						"<",
						new object[] {
							"get",
							"symbolrank",
						},
						13,
					},
					12,
					new object[] {
						"<",
						new object[] {
							"get",
							"symbolrank",
						},
						15,
					},
					13,
					new object[] {
						">=",
						new object[] {
							"get",
							"symbolrank",
						},
						11,
					},
					14,
					new object[] {
						">=",
						new object[] {
							"get",
							"symbolrank",
						},
						15,
					},
				},
			},
			["layout"] = new Dictionary<string, object> {
				["text-line-height"] = 1.1,
				["text-size"] = new object[] {
					"interpolate",
					new object[] {
						"cubic-bezier",
						0.2,
						0,
						0.9,
						1,
					},
					new object[] {
						"zoom",
					},
					3,
					new object[] {
						"step",
						new object[] {
							"get",
							"symbolrank",
						},
						13,
						6,
						12,
					},
					6,
					new object[] {
						"step",
						new object[] {
							"get",
							"symbolrank",
						},
						16,
						6,
						15,
						7,
						14,
					},
					8,
					new object[] {
						"step",
						new object[] {
							"get",
							"symbolrank",
						},
						18,
						9,
						17,
						10,
						15,
					},
					15,
					new object[] {
						"step",
						new object[] {
							"get",
							"symbolrank",
						},
						23,
						9,
						22,
						10,
						20,
						11,
						18,
						12,
						16,
						13,
						15,
						15,
						13,
					},
				},
				["text-radial-offset"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"capital",
						},
						2,
						0.6,
						0.55,
					},
					8,
					0,
				},
				["icon-image"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"case",
						new object[] {
							"==",
							new object[] {
								"get",
								"capital",
							},
							2,
						},
						"border-dot-13",
						new object[] {
							"step",
							new object[] {
								"get",
								"symbolrank",
							},
							"dot-11",
							9,
							"dot-10",
							11,
							"dot-9",
						},
					},
					8,
					"",
				},
				["text-font"] = new object[] {
					"DIN Pro Medium",
					"Arial Unicode MS Regular",
				},
				["text-justify"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"text_anchor",
						},
						new object[] {
							"left",
							"bottom-left",
							"top-left",
						},
						"left",
						new object[] {
							"right",
							"bottom-right",
							"top-right",
						},
						"right",
						"center",
					},
					8,
					"center",
				},
				["text-anchor"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"get",
						"text_anchor",
					},
					8,
					"center",
				},
				["text-field"] = new object[] {
					"coalesce",
					new object[] {
						"get",
						"name_en",
					},
					new object[] {
						"get",
						"name",
					},
				},
				["text-max-width"] = 7,
			},
			["paint"] = new Dictionary<string, object> {
				["text-color"] = new object[] {
					"step",
					new object[] {
						"get",
						"symbolrank",
					},
					"hsl(185, 0%, 69%)",
					11,
					"hsl(185, 0%, 56%)",
					16,
					"hsl(185, 0%, 50%)",
				},
				["text-halo-color"] = "hsl(185, 0%, 5%)",
				["text-halo-width"] = 1,
				["text-halo-blur"] = 1,
			},
		},
		new Dictionary<string, object> {
			["id"] = "state-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "place-labels",
				["mapbox:group"] = "Place labels, place-labels",
			},
			["source"] = "composite",
			["source-layer"] = "place_label",
			["minzoom"] = 3,
			["maxzoom"] = 9,
			["filter"] = new object[] {
				"match",
				new object[] {
					"get",
					"class",
				},
				"state",
				new object[] {
					"match",
					new object[] {
						"get",
						"worldview",
					},
					new object[] {
						"all",
						"US",
					},
					true,
					false,
				},
				"disputed_state",
				new object[] {
					"all",
					new object[] {
						"==",
						new object[] {
							"get",
							"disputed",
						},
						"true",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"worldview",
						},
						new object[] {
							"all",
							"US",
						},
						true,
						false,
					},
				},
				false,
			},
			["layout"] = new Dictionary<string, object> {
				["text-size"] = new object[] {
					"interpolate",
					new object[] {
						"cubic-bezier",
						0.85,
						0.7,
						0.65,
						1,
					},
					new object[] {
						"zoom",
					},
					4,
					new object[] {
						"step",
						new object[] {
							"get",
							"symbolrank",
						},
						10,
						6,
						9.5,
						7,
						9,
					},
					9,
					new object[] {
						"step",
						new object[] {
							"get",
							"symbolrank",
						},
						21,
						6,
						16,
						7,
						13,
					},
				},
				["text-transform"] = "uppercase",
				["text-font"] = new object[] {
					"DIN Pro Bold",
					"Arial Unicode MS Bold",
				},
				["text-field"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"step",
						new object[] {
							"get",
							"symbolrank",
						},
						new object[] {
							"coalesce",
							new object[] {
								"get",
								"name_en",
							},
							new object[] {
								"get",
								"name",
							},
						},
						5,
						new object[] {
							"coalesce",
							new object[] {
								"get",
								"abbr",
							},
							new object[] {
								"get",
								"name_en",
							},
							new object[] {
								"get",
								"name",
							},
						},
					},
					5,
					new object[] {
						"coalesce",
						new object[] {
							"get",
							"name_en",
						},
						new object[] {
							"get",
							"name",
						},
					},
				},
				["text-letter-spacing"] = 0.15,
				["text-max-width"] = 6,
			},
			["paint"] = new Dictionary<string, object> {
				["text-color"] = "hsl(185, 0%, 41%)",
				["text-halo-color"] = "hsl(185, 0%, 5%)",
				["text-halo-width"] = 1,
			},
		},
		new Dictionary<string, object> {
			["id"] = "country-label",
			["type"] = "symbol",
			["metadata"] = new Dictionary<string, object> {
				["mapbox:featureComponent"] = "place-labels",
				["mapbox:group"] = "Place labels, place-labels",
			},
			["source"] = "composite",
			["source-layer"] = "place_label",
			["minzoom"] = 1,
			["maxzoom"] = 10,
			["filter"] = new object[] {
				"match",
				new object[] {
					"get",
					"class",
				},
				"country",
				new object[] {
					"match",
					new object[] {
						"get",
						"worldview",
					},
					new object[] {
						"all",
						"US",
					},
					true,
					false,
				},
				"disputed_country",
				new object[] {
					"all",
					new object[] {
						"==",
						new object[] {
							"get",
							"disputed",
						},
						"true",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"worldview",
						},
						new object[] {
							"all",
							"US",
						},
						true,
						false,
					},
				},
				false,
			},
			["layout"] = new Dictionary<string, object> {
				["text-line-height"] = 1.1,
				["text-size"] = new object[] {
					"interpolate",
					new object[] {
						"cubic-bezier",
						0.2,
						0,
						0.7,
						1,
					},
					new object[] {
						"zoom",
					},
					1,
					new object[] {
						"step",
						new object[] {
							"get",
							"symbolrank",
						},
						11,
						4,
						9,
						5,
						8,
					},
					9,
					new object[] {
						"step",
						new object[] {
							"get",
							"symbolrank",
						},
						22,
						4,
						19,
						5,
						17,
					},
				},
				["text-radial-offset"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					0.6,
					8,
					0,
				},
				["icon-image"] = "",
				["text-font"] = new object[] {
					"DIN Pro Medium",
					"Arial Unicode MS Regular",
				},
				["text-justify"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"match",
						new object[] {
							"get",
							"text_anchor",
						},
						new object[] {
							"left",
							"bottom-left",
							"top-left",
						},
						"left",
						new object[] {
							"right",
							"bottom-right",
							"top-right",
						},
						"right",
						"center",
					},
					7,
					"auto",
				},
				["text-field"] = new object[] {
					"coalesce",
					new object[] {
						"get",
						"name_en",
					},
					new object[] {
						"get",
						"name",
					},
				},
				["text-max-width"] = 6,
			},
			["paint"] = new Dictionary<string, object> {
				["icon-opacity"] = new object[] {
					"step",
					new object[] {
						"zoom",
					},
					new object[] {
						"case",
						new object[] {
							"has",
							"text_anchor",
						},
						1,
						0,
					},
					7,
					0,
				},
				["text-color"] = "hsl(185, 0%, 42%)",
				["text-halo-color"] = "hsl(185, 0%, 5%)",
				["text-halo-width"] = 1.25,
			},
		},
	},
				["created"] = "2022-02-28T08:21:09.721Z",
				["modified"] = "2022-02-28T08:21:09.721Z",
				["id"] = "cl06fm4lf000z14sz18b71tps",
				["owner"] = "sarita55",
				["visibility"] = "private",
				["protected"] = false,
				["draft"] = false,
			}
;

			//Map.MapStyle = style;

        }
    }
    }

