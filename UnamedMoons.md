
This file is listing all unnamed moons to add to the Space constants.

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
		"	public const double RADIUS = " + radius + ";\n" +
		"	public const double DIAMETER = " + (radius * 2) + ";\n" +
		"}\n";

	finalString += s;
});

console.log(finalString);
```

```c#
public struct S_2010 J 1
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2010 J 2
{
	public const double RADIUS = 0.5;
	public const double DIAMETER = 1;
}
public struct S_2016 J 1
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2003 J 18
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2011 J 2
{
	public const double RADIUS = 0.5;
	public const double DIAMETER = 1;
}
public struct S_2017 J 1
{
	public const double RADIUS = 2;
	public const double DIAMETER = 4;
}
public struct S_2003 J 19
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2017 J 2
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2017 J 3
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2017 J 5
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2017 J 6
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2017 J 7
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2017 J 8
{
	public const double RADIUS = 0.5;
	public const double DIAMETER = 1;
}
public struct S_2017 J 9
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2011 J 1
{
	public const double RADIUS = 0.5;
	public const double DIAMETER = 1;
}
public struct S_2003 J 2
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2003 J 4
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2003 J 9
{
	public const double RADIUS = 0.5;
	public const double DIAMETER = 1;
}
public struct S_2003 J 10
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2003 J 12
{
	public const double RADIUS = 0.5;
	public const double DIAMETER = 1;
}
public struct S_2003 J 16
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2003 J 23
{
	public const double RADIUS = 1;
	public const double DIAMETER = 2;
}
public struct S_2003 J 24
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2004_S_20
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2004_S_22
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2004_S_23
{
	public const double RADIUS = 4;
	public const double DIAMETER = 8;
}
public struct S_2004_S_25
{
	public const double RADIUS = 4;
	public const double DIAMETER = 8;
}
public struct S_2004_S_26
{
	public const double RADIUS = 4;
	public const double DIAMETER = 8;
}
public struct S_2004_S_27
{
	public const double RADIUS = 6;
	public const double DIAMETER = 12;
}
public struct S_2004_S_29
{
	public const double RADIUS = 4;
	public const double DIAMETER = 8;
}
public struct S_2004_S_30
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2004_S_32
{
	public const double RADIUS = 4;
	public const double DIAMETER = 8;
}
public struct S_2004_S_33
{
	public const double RADIUS = 4;
	public const double DIAMETER = 8;
}
public struct S_2004_S_34
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2004_S_35
{
	public const double RADIUS = 6;
	public const double DIAMETER = 12;
}
public struct S_2004_S_38
{
	public const double RADIUS = 4;
	public const double DIAMETER = 8;
}
public struct S_2004_S_7
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2004_S_12
{
	public const double RADIUS = 2.5;
	public const double DIAMETER = 5;
}
public struct S_2004_S_13
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2004_S_17
{
	public const double RADIUS = 2;
	public const double DIAMETER = 4;
}
public struct S_2004_S_21
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2004_S_24
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2004_S_28
{
	public const double RADIUS = 4;
	public const double DIAMETER = 8;
}
public struct S_2004_S_31
{
	public const double RADIUS = 4;
	public const double DIAMETER = 8;
}
public struct S_2004_S_36
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2004_S_37
{
	public const double RADIUS = 4;
	public const double DIAMETER = 8;
}
public struct S_2004_S_39
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2006_S_1
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2006_S_3
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2007_S_2
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2007_S_3
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct S_2009_S_1
{
	public const double RADIUS = 0.15;
	public const double DIAMETER = 0.3;
}
public struct S_2019_S_1
{
	public const double RADIUS = 3;
	public const double DIAMETER = 6;
}
public struct (unnamed)
{
	public const double RADIUS = 72;
	public const double DIAMETER = 144;
}
public struct S_2015_136472_1
{
	public const double RADIUS = 87.5;
	public const double DIAMETER = 175;
}
```