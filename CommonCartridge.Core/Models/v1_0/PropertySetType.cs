// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.72
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v1_0
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;

[System.Xml.Serialization.XmlIncludeAttribute(typeof(PlatformPropertySetType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="PropertySet.Type", Namespace="http://www.imsglobal.org/xsd/imslticm_v1p0")]
[System.Xml.Serialization.XmlRootAttribute("PropertySetType")]
public partial class PropertySetType
{
    
    #region Private fields
    private List<PropertyType> _property;
    #endregion
    
    public PropertySetType()
    {
        this._property = new List<PropertyType>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("property", ElementName="property")]
    public List<PropertyType> Property
    {
        get
        {
            return this._property;
        }
        set
        {
            this._property = value;
        }
    }
}
}
#pragma warning restore
