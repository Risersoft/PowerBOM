---
title: Filtering System
keywords: Filtering System
sidebar: powerbomwin_sidebar
permalink: powerbom-win/filtering-system.html
folder: PowerBOM
hide_sidebar: false
comments: false
---

# Filtering System

PowerBOM includes an easy and powerful filtering system for viewing of records.

A filter is basically a criteria acting upon a particular field which limits the results being returned in the display area. These criteria can be added, altered or deleted by the user to obtain the listing of their choice.

For example, the “Work Orders” view has two applicable filters – “Completed” and “Dated”. If the “Completed” filter is set to “No”, only those jobs are returned which have not been completed. If the “Dated” filter is set, only those jobs are returned which satisfy the dates set in the filter.

Filters can be common across views – when this happens, the view automatically picks up criteria from the filter. It does not matter in which view the filter was originally set. If a view does not have a particular filter as applicable, it will list the filter in the “filter display” area but render it as strikethrough which means that filter was not considered. For example, the Item Schedule filter is common to both item and item subcategories.

## Add Filter Menu


![](/images/filter-menu.jpg)

Add filter lists all filters applicable in the current view.

If a date type filter is selected, a screen such as the following is shown

![](/images/select-dated.png)

If a lookup type filter is selected, a screen such as the following is shown:

![](/images/select-completed.png)

## Filters Menu


![](/images/filters-menu.jpg)

Edit filter value allows to edit the selected filter in the filter display area.

Clear Value clears the value in the currently selected row of the filter display area.

Clear Filter clears all values of the filter in the currently selected row of the filter display area.

Clear All clears all filters listed in the filter display area.

## Selecting Views from the List Menu

When a view is selected from the list menu, it may have some pre-defined filters attached to it. For example, the “Work orders” menu command has a “Completed=No” filter attached to it. So every time this command is clicked, the Completed filter is set to No.

![](/images/select-view-list-menu.png)

Whenever a new view is requested, it adjusts the height of the filter display area to include all filters that are applicable to the running view.
