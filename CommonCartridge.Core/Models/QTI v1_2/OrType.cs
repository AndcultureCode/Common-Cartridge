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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.imsglobal.org/xsd/ims_qtiasiv1p2", TypeName="orType")]
[System.Xml.Serialization.XmlRootAttribute("orType")]
public partial class OrType
{
    
    #region Private fields
    private List<object> _items;
    #endregion
    
    public OrType()
    {
        this._items = new List<object>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("not", typeof(NotType))]
    [System.Xml.Serialization.XmlElementAttribute("varequal", typeof(VarequalType))]
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
}
}
#pragma warning restore
