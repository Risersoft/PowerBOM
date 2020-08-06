---
title: Part Item
keywords: Part Item
sidebar: powerbomwin_sidebar
permalink: powerbom-win/part-item.html
folder: PowerBOM
hide_sidebar: false
comments: false
---

# Part Item

This is the fundamental screen for association of drawing items with inventory item codes.

We select a subcategory and the screen adapts automatically to the type of material selected.

## Thickness


![](/images/thickness-drawing.png)

In this case, when we select an item from the details grid, density and thickness are automatically displayed. We need to enter Length / Width or ID/OD on the dimension’s side. PowerBOM calculates area from the information available and then multiplied by thickness and density to get the weight.

### Weight Reduction

Often times, in this type of material, there is a profiling in external boundary or internal portions. In such cases we can choose the type of area reductions (rectangular, round, triangle, radius) and then enter those dimensions. PowerBOM computes the total area removed and takes it into account during calculation of weight

## CNC File

![](/images/cnc-file-drawing.png)

For each part item, upto 4 dxf file can be associated. More than 1 files are required when you need to split a part due to sheet limitations, for example. You click on Browse to select a file and then you can view it using the view button via the built-in DXF viewer. You can use “Clear “button to remove the reference.

CNC files are required for nesting.


## Section and Wt / Mtr

![](/images/section-drawing-part.png)

Notice how the item selection grid contains the parameters as defined in sub category and items. Also notice that the screen asks only for the length and calculates weight / piece and the total weight as per quantity entered.

## Section and Wt / Piece

![](/images/section-drwaing-wt-piece.png)

In this case, only material selection is required. Weight is calculated from the material information and total quantity entered.