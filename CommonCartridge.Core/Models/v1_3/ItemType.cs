// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.72
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v1_3
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Item.Type", Namespace="http://www.imsglobal.org/xsd/imsccv1p3/imscp_v1p1")]
[System.Xml.Serialization.XmlRootAttribute("ItemType")]
public partial class ItemType
{
    
    #region Private fields
    private string _title;
    
    private List<ItemType> _item;
    
    private MetadataType _metadata;
    
    private string _identifier;
    
    private string _identifierref;
    #endregion
    
    public ItemType()
    {
        this._metadata = new MetadataType();
        this._item = new List<ItemType>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("title")]
    public string Title
    {
        get
        {
            return this._title;
        }
        set
        {
            this._title = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("item", ElementName="item")]
    public List<ItemType> Item
    {
        get
        {
            return this._item;
        }
        set
        {
            this._item = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("metadata")]
    public MetadataType Metadata
    {
        get
        {
            return this._metadata;
        }
        set
        {
            this._metadata = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID", AttributeName="identifier")]
    public string Identifier
    {
        get
        {
            return this._identifier;
        }
        set
        {
            this._identifier = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="identifierref")]
    public string Identifierref
    {
        get
        {
            return this._identifierref;
        }
        set
        {
            this._identifierref = value;
        }
    }
}
}
#pragma warning restore
