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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.imsglobal.org/xsd/ims_qtiasiv1p2", TypeName="resprocessingType")]
[System.Xml.Serialization.XmlRootAttribute("resprocessingType")]
public partial class ResprocessingType
{
    
    #region Private fields
    private OutcomesType _outcomes;
    
    private List<RespconditionType> _items;
    #endregion
    
    public ResprocessingType()
    {
        this._items = new List<RespconditionType>();
        this._outcomes = new OutcomesType();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("outcomes")]
    public OutcomesType Outcomes
    {
        get
        {
            return this._outcomes;
        }
        set
        {
            this._outcomes = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("respcondition")]
    public List<RespconditionType> Items
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
}
}
#pragma warning restore
