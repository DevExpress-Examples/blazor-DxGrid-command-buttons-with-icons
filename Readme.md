<!-- default file list -->
*Files to look at*:

* [Index.razor](./CS/CommandButtonsWithIcons/Pages/Index.razor)
<!-- default file list end -->

### Blazor Data Grid - How to use icons instead of default command buttons

At the moment, our DataGrid for Blazor doesn't support any API to customize command button appearance.

It's possible to place any content into the command column's [CellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataGridCommandColumnBase.CellTemplate) or [HeaderCellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataGridCommandColumnBase.HeaderCellTemplate) template, for example, <button> or <a> HTML elements.
Then, you can handle the corresponding event and use the [StartRowEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataGridBase-1.StartRowEdit(System.Object)) method to implement the necessary functionality. Send the *null* object if you want to create a new record or send the existing object that should be edited.
Use the *context* object to obtain the current row object in the column's [CellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataGridCommandColumnBase.CellTemplate) template:

```razor
<CellTemplate>
    <a class="oi oi-pencil" @onclick="@(() => MyGrid.StartRowEdit(context))" href="javascript:void(0);"></a>
    ...
</CellTemplate>
```

