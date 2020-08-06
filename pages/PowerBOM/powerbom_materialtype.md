---
title: Material Type
keywords: Material Type
sidebar: powerbomwin_sidebar
permalink: powerbom-win/material-type.html
folder: PowerBOM
hide_sidebar: false
comments: false
---

# Material Type

![](/images/material-type.png)

Material type offers a way to group materials outside of coding system. Generally, this can be used to group materials such as MS Channel and MS Plate which otherwise would have different sub categories but which are both relevant to a shop, say a fabrication shop.

Also, special materials such as gasket and hardware can be indicated. This information is used by PowerBOM to decide which materials will be included in charts like “List of Gaskets” and “List of Hardware”.

If you want to split hardware into “SS Hardware” and “MS Hardware”, you can define two material types with both of them marked as “Material is Hardware. Then assign sub categories the appropriate type. Reports will be segregated accordingly.

QC Report title field is used to print title for QC Check lists. You can use this to print “Fabrication Shop” in the title for “MS” Material Type.

Welded Hardware generally becomes part of MS / Fabrication shop. You can choose to do this by selecting the “MS” material type in the “On Welding, move material to type” field. If you mark hardware as welded in document BOM, PowerBOM will move the material to “MS” material type.
