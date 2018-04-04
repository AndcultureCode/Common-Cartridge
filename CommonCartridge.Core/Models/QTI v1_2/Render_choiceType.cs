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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.imsglobal.org/xsd/ims_qtiasiv1p2", TypeName="render_choiceType")]
[System.Xml.Serialization.XmlRootAttribute("render_choiceType")]
public partial class Render_choiceType
{
    
    #region Private fields
    private List<object> _items;
    
    private Render_choiceTypeShuffle _shuffle;
    
    private string _minnumber;
    
    private string _maxnumber;
    #endregion
    
    public Render_choiceType()
    {
        this._items = new List<object>();
        this._shuffle = Render_choiceTypeShuffle.No;
    }
    
    [System.Xml.Serialization.XmlElementAttribute("flow_label", typeof(Flow_labelType))]
    [System.Xml.Serialization.XmlElementAttribute("material", typeof(MaterialType))]
    [System.Xml.Serialization.XmlElementAttribute("material_ref", typeof(Material_refType))]
    [System.Xml.Serialization.XmlElementAttribute("response_label", typeof(Response_labelType))]
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="shuffle")]
    [System.ComponentModel.DefaultValueAttribute(Render_choiceTypeShuffle.No)]
    public Render_choiceTypeShuffle Shuffle
    {
        get
        {
            return this._shuffle;
        }
        set
        {
            this._shuffle = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="minnumber")]
    public string Minnumber
    {
        get
        {
            return this._minnumber;
        }
        set
        {
            this._minnumber = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="maxnumber")]
    public string Maxnumber
    {
        get
        {
            return this._maxnumber;
        }
        set
        {
            this._maxnumber = value;
        }
    }
}
}
#pragma warning restore
