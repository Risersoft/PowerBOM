---
title: Drawing Item Collection
keywords: Drawing Item Collection
sidebar: powerbomwin_sidebar
permalink: powerbom-win/drawing-item-collection.html
folder: PowerBOM
hide_sidebar: false
comments: false
---

# Drawing Item Collection

![](/images/drawing-collection.png)

A collection can be simply a collection of drawing items or represent an assembly. In manufacturing drawings, very often it happens that two assemblies of very similar nature are to be made – they have basically same parts but differ in quantity of some minor parts. In this case, instead of making two documents, we can make a single document and then create “collections” of drawing items. Each collection defines the quantity of parts that make it. You can even opt to not include a part altogether.

Whenever a collection is made in a work order document, the BOM tree tab will show how PowerBOM is traversing the tree of materials.

![](/images/drawing-collection-item-tree.png)

The collection may consist of part items or references but not another collection. The Quantity field of the collection represents the total quantity for the collection. In finding out the total material called in the BOM, quantity of items in the collection will be multiplied by this field to arrive at the final figure.

In the case of standard drawing, collections are frequently used to group all parts together and then they are referenced in a single drawing item.
