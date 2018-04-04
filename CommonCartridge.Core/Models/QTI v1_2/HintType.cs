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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.imsglobal.org/xsd/ims_qtiasiv1p2", TypeName="hintType")]
[System.Xml.Serialization.XmlRootAttribute("hintType")]
public partial class HintType
{
    
    #region Private fields
    private List<HintmaterialType> _hintmaterial;
    
    private HintTypeFeedbackstyle _feedbackstyle;
    #endregion
    
    public HintType()
    {
        this._hintmaterial = new List<HintmaterialType>();
        this._feedbackstyle = HintTypeFeedbackstyle.Complete;
    }
    
    [System.Xml.Serialization.XmlElementAttribute("hintmaterial", ElementName="hintmaterial")]
    public List<HintmaterialType> Hintmaterial
    {
        get
        {
            return this._hintmaterial;
        }
        set
        {
            this._hintmaterial = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="feedbackstyle")]
    [System.ComponentModel.DefaultValueAttribute(HintTypeFeedbackstyle.Complete)]
    public HintTypeFeedbackstyle Feedbackstyle
    {
        get
        {
            return this._feedbackstyle;
        }
        set
        {
            this._feedbackstyle = value;
        }
    }
}
}
#pragma warning restore
