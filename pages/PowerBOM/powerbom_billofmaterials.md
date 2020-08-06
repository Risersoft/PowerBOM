---
title: Bill of Materials
keywords: Bill of Materials
sidebar: powerbomwin_sidebar
permalink: powerbom-win/bill-of-materials.html
folder: PowerBOM
hide_sidebar: false
comments: false
---

# Bill of Materials

Both standard drawing document and work order document contain bill of materials. The editing screens of both provide a tab for bill of materials. This tab contains a list of currently defined drawing items and an array of buttons to add and edit these drawing items.

Here’s a screenshot of standard drawing bill of material

![](/images/bill-of-materials.png)

Here’s a screenshot of work order document bill of material tab.

![](/images/bill-of-materials-work-order.png)

The work order document bill of material contains “Add File Reference” in addition to the ones contained by the standard drawing document bill of material. Standard drawings can only refer to other standard drawings, whereas work order documents can refer to other work order documents as well as standard drawing.

Other buttons found only on work order document are as follows:

|Term|Description|
|:---|:----------|
|Copy|Copy current bill of material to PowerBOM clipboard|
|Paste|Paste bill of material from PowerBOM clipboard to current document. This is used to copy from reference documents. Collections are not pasted.|
|Process|After a copy/paste operation or a major change operation, this button can be pressed to process all BOM items. Normally PowerBOM keeps processing upon add/edit. Processing is required to generate material reports.|



In the succeeding subsections, we will see each one of the options given in the bill of material tab. When you add a drawing item, you need to decide which type of drawing item you need. When you edit, PowerBOM already knows the drawing item type, and opens the corresponding screen automatically.


