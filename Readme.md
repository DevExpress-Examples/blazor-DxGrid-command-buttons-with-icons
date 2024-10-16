<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/202762813/23.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T807225)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Blazor Grid - Use icons instead of default command buttons

Use templates to modify command button appearance within the DevExpress Blazor Grid.

![Grid with Custom Icons](images/datagrid-command-icons.png)

For example, you can add content to the command column's [CellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.CellDisplayTemplate) or [HeaderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.HeaderTemplate) (HTML elements).

You'll need to handle the corresponding event and use [StartEditNewRowAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.StartEditNewRowAsync), [StartEditDataItemAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.StartEditDataItemAsync(System.Object)) and [ShowDataItemDeleteConfirmation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowDataItemDeleteConfirmation(System.Object)) methods to implement appropriate functionality. Remember to send the following input parameters:

* A *null* object if you want to create a new record
* The existing object if you edit or delete a record

Use the *context* object to obtain the current row object in the column's [CellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.CellDisplayTemplate):

```razor
<CellDisplayTemplate>
    <a class="oi oi-pencil" @onclick="@(() => MyGrid.StartEditRowAsync(context.VisibleIndex))" style="text-decoration: none;" href="javascript:void(0);"></a>
    <a class="oi oi-x" @onclick="@(() => MyGrid.ShowDataItemDeleteConfirmation(context.DataItem))" style="text-decoration: none;" href="javascript:void(0);"></a>
</CellDisplayTemplate>
```

<!-- default file list -->
## Files to Review

* [Index.razor](./CS/CommandButtonsWithIcons/Pages/Index.razor)
<!-- default file list end -->

## Documentation

[Grid - Appearance](https://docs.devexpress.com/Blazor/403143/grid?v=22.1#appearance)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-DxGrid-command-buttons-with-icons&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-DxGrid-command-buttons-with-icons&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
