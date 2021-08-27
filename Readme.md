<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/202762813/20.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T807225)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Index.razor](./CS/CommandButtonsWithIcons/Pages/Index.razor)
<!-- default file list end -->

### Blazor Data Grid - How to use icons instead of default command buttons

At the moment, our DataGrid for Blazor doesn't support any API to customize command button appearance.

It's possible to place any content into the command column's [CellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridCommandColumn.CellTemplate) or [HeaderCellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridCommandColumn.HeaderCellTemplate) template, for example, <button> or <a> HTML elements.
Then, you can handle the corresponding event and use the [StartRowEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.StartRowEdit(System.Object)) method to implement the necessary functionality. Send the *null* object if you want to create a new record or send the existing object that should be edited.
Use the *context* object to obtain the current row object in the column's [CellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridCommandColumn.CellTemplate) template:

```razor
<CellTemplate>
    <a class="oi oi-pencil" @onclick="@(() => MyGrid.StartRowEdit(context))" href="javascript:void(0);"></a>
    ...
</CellTemplate>
```

