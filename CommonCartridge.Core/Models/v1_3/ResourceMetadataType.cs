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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="ResourceMetadata.Type", Namespace="http://www.imsglobal.org/xsd/imsccv1p3/imscp_v1p1")]
[System.Xml.Serialization.XmlRootAttribute("ResourceMetadataType")]
public partial class ResourceMetadataType
{
    
    #region Private fields
    private string _schema;
    
    private string _schemaversion;
    
    private LOMType1 _lom;
    
    private List<CurriculumStandardsMetadataSetType> _curriculumStandardsMetadataSet;
    #endregion
    
    public ResourceMetadataType()
    {
        this._curriculumStandardsMetadataSet = new List<CurriculumStandardsMetadataSetType>();
        this._lom = new LOMType1();
    }
    
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", ElementName="schema")]
    public string Schema
    {
        get
        {
            return this._schema;
        }
        set
        {
            this._schema = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", ElementName="schemaversion")]
    public string Schemaversion
    {
        get
        {
            return this._schemaversion;
        }
        set
        {
            this._schemaversion = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ltsc.ieee.org/xsd/imsccv1p3/LOM/resource", ElementName="lom")]
    public LOMType1 Lom
    {
        get
        {
            return this._lom;
        }
        set
        {
            this._lom = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("curriculumStandardsMetadataSet", Namespace="http://www.imsglobal.org/xsd/imsccv1p3/imscsmd_v1p0", ElementName="curriculumStandardsMetadataSet")]
    public List<CurriculumStandardsMetadataSetType> CurriculumStandardsMetadataSet
    {
        get
        {
            return this._curriculumStandardsMetadataSet;
        }
        set
        {
            this._curriculumStandardsMetadataSet = value;
        }
    }
}
}
#pragma warning restore
