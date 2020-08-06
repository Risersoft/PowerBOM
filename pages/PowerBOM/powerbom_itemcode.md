---
title: Item Code
keywords: Item Code
sidebar: powerbomwin_sidebar
permalink: powerbom-win/item-code.html
folder: PowerBOM
hide_sidebar: false
comments: false
---

# Item Code

![](/images/item-code.png)

Item code is the actual inventory item code and represents actual material. Each drawing item which is linked with inventory is ultimately associated with an item code.

Item code and name are defined according to the coding system. Unit is automatically determined from the sub category selected.

## Parameters

In this page, we specify the values of the parameters which were defined in the sub category.

![](/images/parameters-item.png)

For the above parameter screen, following are the entries made in the sub category.


![](/images/parameters-item-sub-category.png)

## Drawing BOM

In this screen, we specify information relevant for PowerBOM as defined in the sub category Drawing BOM section.

![](/images/drawing-bom-item.png)

Material Section field is used by PowerBOM to generated specification for document BOM material. For example, for above item code, PowerBOM will generate “DIA 32 x 1000 Lg.” instead of “MS Bright Rod Cold Drawn Dia 32 mm x 1000 Lg.”

Following are the entries made in sub category for the above item.

![](/images/drawing-bom-item-sub-category.png)

“Item is Non-Standard in BOM” can be selected to ensure that PowerBOM does not display the item in the selection list by default. This is to avoid drafting errors.

A checkbox is available in the document BOM material selection box to allow to bring such materials into view.

