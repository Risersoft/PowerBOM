---
title: Terminology
keywords: Terminology
sidebar: powerbomwin_sidebar
permalink: powerbom-win/terminology.html
folder: PowerBOM
hide_sidebar: false
comments: false
---

# Terminology

**•** Item Coding System

PowerBOM provides a comprehensive item coding system maintenance facility. The item coding system is divided into three levels.

 o Item Schedule

This is the topmost level in the item coding system.  Generally, it can be of two digits.

o Item Sub Category

This is the second level in the item coding system. Many Material Properties are defined at this level.  Coding system definition – assignment of meaning to digits of code takes at this level.

o Item Code

This is the actual item – corresponding to inventory item code.

**•** Standard Drawing

This is a pre-defined list of parts or an assembly of parts. It can be called in a work order document. Bill of material is defined for each standard drawing.

**•** Work Order

Each new job is known as a work order. You can have multiple drawings / documents in one work order.

**•** Work Order Document

Each work order has several documents and bill of material is defined inside each document.


**•** Bill of Materials

o Part Item

A drawing item associated with one inventory item code. Example MS Sheet 6 mm.

o Drawing Item Collection

A drawing item which defines a collection of drawing items, generally representing an assembly of items. This drawing item can be called in other documents.

o Standard Reference

A drawing item which references another drawing item defined in a standard drawing.

o File Reference

A drawing item which references another drawing item defined in a work order document.

o Item Collection

A drawing item which defines a collection of inventory item codes. Example Labels.

o Hardware

A drawing item which defines a set of hardware. Generally, hardware is defined in a set such as Screw, Nut, Plain washer, spring washer etc.



**•** Parametric Standard Drawing

A standard drawing which defines parameters and then defines bill of materials in terms of these parameters. This allows definition of variable parts or variable assembly of parts.



**•** Nesting Requirement

This is used to define nesting requirement which can be used to club parts of different work orders for the same material and thickness.



**•** Nest

This is used to nest selected nesting requirements for given thickness and material.

o Nesting Provider

PowerBOM can be integrated with different nesting software for automatic nesting.
