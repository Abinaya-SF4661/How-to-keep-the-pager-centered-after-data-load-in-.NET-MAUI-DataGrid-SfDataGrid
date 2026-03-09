# How to keep the pager centered after data load in .NET MAUI DataGrid?
This sample demonstrates how to keep the SfPager centered in a [.NET MAUI SfDataGrid](https://help.syncfusion.com/maui/datagrid/overview). It shows that the pager remains centered by using layout settings that keep it fixed in the middle. This ensures that the pager doesn’t move or shift when the data loads or when the grid changes size. As a result, the UI stays clean, and the pager always remains centered.

## XAML

```xml
<ContentPage.Content>
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="Auto" />
        </Grid.RowDefinitions>
        
        <pager:SfDataPager x:Name ="dataPager" 
                           Grid.Row="1"
                           PageSize="15" 
                           NumericButtonCount="10"
                           Source="{Binding OrderInfoCollection}"
                           WidthRequest="500"
                           HorizontalOptions="Center"
                           Margin="0,5">
        </pager:SfDataPager>
        
        <syncfusion:SfDataGrid x:Name="dataGrid"
                               Grid.Row="0"
                               ColumnWidthMode="Fill"
                               ItemsSource="{Binding Source={x:Reference dataPager}, Path=PagedSource}">
        </syncfusion:SfDataGrid>
        
    </Grid>
</ContentPage.Content>
```

Download the complete sample from [GitHub](https://github.com/SyncfusionExamples/How-to-keep-the-pager-centered-after-data-load-in-.NET-MAUI-DataGrid-SfDataGrid)