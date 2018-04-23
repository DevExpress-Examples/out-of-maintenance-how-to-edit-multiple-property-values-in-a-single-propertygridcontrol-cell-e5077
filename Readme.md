# How to: Edit Multiple Property Values in a Single PropertyGridControl Cell


<p>We provide a mechanism to display and edit properties different from the property specified in the property definition’s <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinitionBase_Pathtopic">Path</a>. This can be done using a custom <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinitionBase_ContentTemplatetopic">ContentTemplate</a>.</p>
<p> </p>
<p>Assume that you have an Item class with the complex Address property.</p>


```cs
public class Person {
    //...
    public Address Address { get; set; }
    //...
}
public class Address {
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
}
```


<br>
<p>The task is to display and edit the Address.AddressLine1 and Address.AddressLine2 property values in the Address row. This can be done using the template below.</p>


```xaml
<dxprg:PropertyDefinition Path="Address">
    <dxprg:PropertyDefinition.ContentTemplate>
        <DataTemplate>
            <StackPanel>
                <dxprg:CellEditorPresenter Path="AddressLine1"/>
                <dxprg:CellEditorPresenter Path="AddressLine2"/>
            </StackPanel>
        </DataTemplate>
    </dxprg:PropertyDefinition.ContentTemplate>
</dxprg:PropertyDefinition>
```


<br>
<p><strong>CellEditorPresenter.Path</strong> works similar to <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinitionBase_Pathtopic">PropertyDefinitionBase.Path</a> - it specifies a path to the data source field that will be displayed within the cell editor. To learn more on how to build paths, refer to the <a href="https://documentation.devexpress.com/#WPF/CustomDocument15521">Property Definitions</a> topic.</p>
<p>Note that the Path may work in two modes: <strong>Relative </strong>and <strong>Absolute</strong> (to switch between these modes, set the <strong>PathMode</strong> property). In Relative mode, the specified path is applied to the object originally displayed in the row. In Absolute mode, the path is applied to the entire SelectedObject.<br><br>To configure a cell editor generated in CellEditorPresenter, set required properties for the PropertyDefinition object that is mapped to the same property. For example:</p>


```xaml
<dxprg:PropertyDefinition Path="Address" Header="Contact" IsReadOnly="False">
    <dxprg:PropertyDefinition.ContentTemplate>
        <DataTemplate>
            <StackPanel>
                <dxprg:CellEditorPresenter Path="Phone" PathMode="Absolute"/>
            </StackPanel>
        </DataTemplate>
    </dxprg:PropertyDefinition.ContentTemplate>
</dxprg:PropertyDefinition>
<dxprg:PropertyDefinition Path="Phone" IsReadOnly="True" Visibility="Collapsed"/>
```



<br/>


