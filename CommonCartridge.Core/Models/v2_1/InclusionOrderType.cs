// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v2_1
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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="InclusionOrder.Type", Namespace="http://www.imsglobal.org/xsd/apip/apipv1p0/imsapip_qtiv1p0")]
[System.Xml.Serialization.XmlRootAttribute("InclusionOrderType")]
public partial class InclusionOrderType
{
    
    #region Private fields
    private object[] _items;
    
    private ItemsChoiceType27[] _itemsElementName;
    #endregion
    
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("aslDefaultOrder", typeof(ElementOrderListType))]
    [System.Xml.Serialization.XmlElementAttribute("aslOnDemandOrder", typeof(ElementOrderListType))]
    [System.Xml.Serialization.XmlElementAttribute("brailleDefaultOrder", typeof(ElementOrderListType))]
    [System.Xml.Serialization.XmlElementAttribute("graphicsOnlyOnDemandOrder", typeof(ElementOrderListType))]
    [System.Xml.Serialization.XmlElementAttribute("nonVisualDefaultOrder", typeof(ElementOrderListType))]
    [System.Xml.Serialization.XmlElementAttribute("signedEnglishDefaultOrder", typeof(ElementOrderListType))]
    [System.Xml.Serialization.XmlElementAttribute("signedEnglishOnDemandOrder", typeof(ElementOrderListType))]
    [System.Xml.Serialization.XmlElementAttribute("textGraphicsDefaultOrder", typeof(ElementOrderListType))]
    [System.Xml.Serialization.XmlElementAttribute("textGraphicsOnDemandOrder", typeof(ElementOrderListType))]
    [System.Xml.Serialization.XmlElementAttribute("textOnlyDefaultOrder", typeof(ElementOrderListType))]
    [System.Xml.Serialization.XmlElementAttribute("textOnlyOnDemandOrder", typeof(ElementOrderListType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
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
    
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType27[] ItemsElementName
    {
        get
        {
            return this._itemsElementName;
        }
        set
        {
            this._itemsElementName = value;
        }
    }
}
}
#pragma warning restore