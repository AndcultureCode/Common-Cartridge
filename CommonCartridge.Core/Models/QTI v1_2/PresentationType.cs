// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.QTIv1_2
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.imsglobal.org/xsd/ims_qtiasiv1p2", TypeName="presentationType")]
[System.Xml.Serialization.XmlRootAttribute("presentationType")]
public partial class PresentationType
{
    
    #region Private fields
    private List<object> _items;
    
    private string _label;
    
    private string _lang;
    
    private string _x0;
    
    private string _y0;
    
    private string _width;
    
    private string _height;
    #endregion
    
    public PresentationType()
    {
        this._items = new List<object>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("flow", typeof(FlowType))]
    [System.Xml.Serialization.XmlElementAttribute("material", typeof(MaterialType))]
    [System.Xml.Serialization.XmlElementAttribute("response_lid", typeof(Response_lidType))]
    [System.Xml.Serialization.XmlElementAttribute("response_str", typeof(Response_strType))]
    public List<object> Items
    {
        get
        {
            return this._items;
        }
        set
        {
            this._items = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="label")]
    public string Label
    {
        get
        {
            return this._label;
        }
        set
        {
            this._label = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace", AttributeName="lang")]
    public string Lang
    {
        get
        {
            return this._lang;
        }
        set
        {
            this._lang = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="x0")]
    public string X0
    {
        get
        {
            return this._x0;
        }
        set
        {
            this._x0 = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="y0")]
    public string Y0
    {
        get
        {
            return this._y0;
        }
        set
        {
            this._y0 = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="width")]
    public string Width
    {
        get
        {
            return this._width;
        }
        set
        {
            this._width = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="height")]
    public string Height
    {
        get
        {
            return this._height;
        }
        set
        {
            this._height = value;
        }
    }
}
}
#pragma warning restore
