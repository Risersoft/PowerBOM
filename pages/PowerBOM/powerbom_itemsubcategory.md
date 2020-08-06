---
title: Item Sub Category
keywords: Item Sub Category
sidebar: powerbomwin_sidebar
permalink: powerbom-win/item-sub-category.html
folder: PowerBOM
hide_sidebar: false
comments: false
---

# Item Sub Category



Sub Category is the second level in the item coding definition hierarchy.

![](/images/item-sub-category.png)

Unit of material is selected at this level. Generally, this can be kept as 5-digit long. Exact length depends upon how many subcategories you will need to define. Since 2 digits of the sub category are in fact the schedule code, you will need 5 digits if no of subcategories in even one schedule can exceed 99.


## Coding System Definition

![](/images/code-definition.png)

In this screen, we define what the rest of the digits in the item code will mean. We first define the no. of groups and then the name of each group and no. of characters in that group.

Optionally we can define a table of values and texts where we can enter meaning of “digit codes”. Sometimes the digits denote just a dimension which is in the item name (for example 6 mm thk = 60) and in that case this translation table is not needed.

PowerBOM interprets the item coding system defined by you and generates a picture which can be seen in the picture tab.

![](/images/code-definition-picture.png)

This picture along with the Remark can be printed from “Generate format Sub Category Definitions” to produce a nicely formatted coding system manual.

Please note that definition and use of coding system Is entirely optional and the generation of other PowerBOM reports does not depend on it.


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


## Drawing BOM Parameters – Part 2

![](/images/drawing-part2.png)

There are two other sections to be filled on this page.

In the first section, the values of parameters specified in item schedule are given.

In the second section, dimensional parameters are specified for item codes. These parameters are used by PowerBOM to find the appropriate item code in case variables have been given in standard parametric drawings. These have two requirements:

1.  The names of these dimensional parameters should match with the field names on the document BOM screen.

2.  The parameters should be able to uniquely identify item codes in the sub category.



For hardware main element, thread and length are specified. For nut element, only thread is specified.


## Parameter Definition Screen

![](/images/parameter-definition-screen.png)

These parameters are used to facilitate easy item selection on the document BOM forms. In the item selection grid, the items are displayed along with the parameter values specified here. These can be used to sort and filter the item code grid to facilitate easy identification and selection.