---
title: Drawing BOM Parameters – Part 1
keywords: Drawing BOM Parameters – Part 1
sidebar: powerbomwin_sidebar
permalink: powerbom-win/drawing-bom-parameters-part1.html
folder: PowerBOM
hide_sidebar: false
comments: false
---

## Drawing BOM Parameters – Part 1

Information entered in this screen is used by PowerBOM in various reports and material selection.

![](/images/drawing-part1.png)

|Field Name|Description|
|:---------|:----------|
|Friendly Name for Drawing BOM Selection|This is used in the material column of the document BOM|
|BOM Section Type|Can be of following three types: **1.  Thickness** In this case, thickness, length and width are asked in document BOM and weight is obtained by getting volume and multiplying by specified density.**2.  Section, Wt/Mtr and Area/Mtr** In this case, length is asked in document BOM and weight is obtained by multiplying Wt/Mtr defined in Item Code with Length.**3.  Section and Wt/Piece** In this case, weight is obtained by multiplying weight/piece specified in item code with qty in document BOM.|
|Make Available for Tank Drawing BOM selection|If this is unchecked, PowerBOM would not show the subcategory in document BOM|
|Density|Used in weight calculation for Thickness BOM Section Type|
|% Offcut|Final material weight is increased by this figure|
|Material Type|Each Sub category is assigned a material type which defines whether any special treatment (example gasket,hardware etc) is to be given.|
